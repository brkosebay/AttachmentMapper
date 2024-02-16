using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttachmentMapper
{
    public class RegexService
    {
        public string BuildPattern(string name)
        {
            // Building regex pattern
            name = name.ToUpper(new CultureInfo("tr-TR"));
            String[] firstNameLastName = Regex.Split(name, @"(?: |@|-)");
            string pattern = @"";
            switch (firstNameLastName.Length)
            {
                case 0:
                    MessageBox.Show("Error!");
                    break;
                case 1:
                    pattern = @".*(?i)" + firstNameLastName[0] + @".*\.(pdf|png)$";
                    break;
                case 2:
                    pattern = @".*(?i)" + firstNameLastName[0] + @"[\s_.-]*" + firstNameLastName[1] + @".*\.(pdf|png)$";
                    break;
                case 3:
                   pattern = @".*(?i)" + firstNameLastName[0] + @"[\s_.-]*" + firstNameLastName[1] + @"[\s_.-]*" + firstNameLastName[2] + @".*\.(pdf|png)$";
                    break;
                case 4:
                    pattern = @".*(?i)" + firstNameLastName[0] + @"[\s_.-]*" + firstNameLastName[1] + @"[\s_.-]*" + firstNameLastName[2] + @".*\.(pdf|png)$";
                    break;
                case 5:
                    pattern = @".*(?i)" + firstNameLastName[0] + @"[\s_.-]*" + firstNameLastName[1] + @"[\s_.-]*" + firstNameLastName[2] + @".*\.(pdf|png)$";
                    break;
                case 6:
                    pattern = @".*(?i)" + firstNameLastName[0] + @"[\s_.-]*" + firstNameLastName[1] + @"[\s_.-]*" + firstNameLastName[2] + @".*\.(pdf|png)$";
                    break;
                case 7:
                    pattern = @".*(?i)" + firstNameLastName[0] + @"[\s_.-]*" + firstNameLastName[1] + @"[\s_.-]*" + firstNameLastName[2] + @".*\.(pdf|png)$";
                    break;
                case 8:
                    pattern = @".*(?i)" + firstNameLastName[0] + @"[\s_.-]*" + firstNameLastName[1] + @"[\s_.-]*" + firstNameLastName[2] + @".*\.(pdf|png)$";
                    break;
                default:
                    break;
            }
            return pattern;
        }

        public int RegexHandler(List<Dictionary<string, string>> rows, String[] listOfFiles, string pdfFilePath, string csvFilePath, string colNameToReadFrom, string colNameToWriteTo, CsvDataService _csvDataService)
        {
            // Create a concurrent bag to keep track of rows with errors
            ConcurrentBag<string> errorMessages = new ConcurrentBag<string>();

            // Use Parallel.ForEach for multithreading
            Parallel.ForEach(rows, row =>
            {
                try
                {
                    string pattern = BuildPattern(row[colNameToReadFrom]);
                    Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
                    List<string> justFileNames = listOfFiles.Select(file => file.Split('\\').Last()).ToList();
                    List<string> result = justFileNames.Where(f => regex.IsMatch(f.ToUpper(new CultureInfo("tr-TR")))).ToList();
                    Console.WriteLine(row[colNameToReadFrom]);
                    Console.WriteLine(result.Count);
                    Console.WriteLine(pattern);

                    if (result.Count == 1)
                    {
                        string attachmentPath = Path.Combine(pdfFilePath, result[0]);
                        row[colNameToWriteTo] = attachmentPath;
                    }
                    else if (result.Count == 0)
                    {
                        errorMessages.Add("Error: No file matches with the name " + row[colNameToReadFrom] + "!");
                    }
                    else
                    {
                        errorMessages.Add("Error: More than one file matches with the name " + row[colNameToReadFrom] + "!");
                    }
                }
                catch (Exception ex)
                {
                    errorMessages.Add("Error processing row for name " + row[colNameToReadFrom] + ": " + ex.Message);
                    row[colNameToWriteTo] = "Error";
                }
            });

            _csvDataService.WriteCsvWithDynamicHeaders(csvFilePath, rows);

            // Handle the error messages
            if (errorMessages.Any())
            {
                string message = errorMessages.Count > 10
                    ? "More than 10 rows encountered errors:\n"
                    : "Some rows encountered errors:\n" + string.Join("\n", errorMessages);

                MessageBox.Show(message);
            }

            return errorMessages.Any() ? -1 : 1;
        }
    }
}
