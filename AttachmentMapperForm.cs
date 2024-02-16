using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AttachmentMapper
{
    public partial class AttachmentMapperForm : MaterialForm
    {
        private CsvDataService _csvDataService;
        private RegexService _regexService;
        private string colNameToReadFrom;
        private string colNameToWriteTo;
        private string pdfFilePath;
        private string csvFilePath;
        private string[] listOfFiles;
        private List<Dictionary<string, string>> records;

        public AttachmentMapperForm()
        {
            InitializeComponent();
            _csvDataService = new CsvDataService();
            _regexService = new RegexService();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void BrowseCsvFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                openFileDialog.Filter = "CSV files (*.csv)|*.csv";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    csvFilePath = openFileDialog.FileName;

                    csvPathTextBox.Text = csvFilePath;

                    try
                    {
                        List<string> csvHeaders = _csvDataService.ReadCsvHeaders(csvFilePath);

                        addHeadersToComboBox(csvHeaders);

                        records = _csvDataService.ReadCsvWithDynamicHeaders(csvFilePath);

                        int recordsCount = records.Count;

                        noOfCsvText.Text = String.Format("Number of records found in CSV: {0}", recordsCount);
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        private void BrowseFolder()
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
                folderBrowserDialog.Description = "Select the folder containing the CSV files";
                folderBrowserDialog.ShowNewFolderButton = true;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of the selected folder
                    pdfFilePath = folderBrowserDialog.SelectedPath;
                    filesPathTextBox.Text = pdfFilePath;
                    listOfFiles = Directory.GetFiles(pdfFilePath, "*.pdf").Concat(Directory.GetFiles(pdfFilePath, "*.png")).ToArray();
                    int fileCount = listOfFiles.Length;
                    noOfPdfText.Text = String.Format("Number of PDFs found in folder: {0}", fileCount);
                }
            }
        }

        private void addHeadersToComboBox(List<String> headers)
        {
            colNameToReadFromComboBox.Items.Clear();
            colNameToWriteToComboBox.Items.Clear();
            if(headers != null)
            {
                foreach (String header in headers)
                {
                    colNameToReadFromComboBox.Items.Add(header);
                    colNameToWriteToComboBox.Items.Add(header);

                }
            } 
        }

        private void runMatching()
        {
            if(!string.IsNullOrEmpty(pdfFilePath) && !string.IsNullOrEmpty(csvFilePath) && !string.IsNullOrEmpty(colNameToReadFrom) && !string.IsNullOrEmpty(colNameToWriteTo))
            {
                if (records.Any())
                {
                    int result = _regexService.RegexHandler(records, listOfFiles, pdfFilePath, csvFilePath, colNameToReadFrom, colNameToWriteTo, _csvDataService);
                    if (result != -1)
                    {
                        try
                        {
                            MessageBox.Show("The operation has been completed successfully.\nThe program will now exit.");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No data rows were found to process.");
                }
            }
            else
            {
                MessageBox.Show("Please select the column names and/or the folder attachments are located in.");
            }
        }

        private void openCsvButton_Click(object sender, EventArgs e)
        {
            BrowseCsvFile();
        }
        private void browseFilesButton_Click(object sender, EventArgs e)
        {
            BrowseFolder();
        }

        private void colNameToReadFromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox cmb = (System.Windows.Forms.ComboBox)sender;
            colNameToReadFrom = cmb.SelectedItem.ToString();
        }

        private void colNameToWriteToComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox cmb = (System.Windows.Forms.ComboBox)sender;
            colNameToWriteTo = cmb.SelectedItem.ToString();
        }

        private void csvPathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            runMatching();
        }

        private void filesPathTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
