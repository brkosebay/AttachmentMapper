namespace AttachmentMapper
{
    partial class AttachmentMapperForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openCsvButton = new MaterialSkin.Controls.MaterialButton();
            this.colNameToReadFromComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.colNameToWriteToComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.csvPathTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.filesPathTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.browseFilesButton = new MaterialSkin.Controls.MaterialButton();
            this.noOfCsvText = new MaterialSkin.Controls.MaterialLabel();
            this.noOfPdfText = new MaterialSkin.Controls.MaterialLabel();
            this.runButton = new MaterialSkin.Controls.MaterialButton();
            this.readColumnLabel = new MaterialSkin.Controls.MaterialLabel();
            this.writeColumnLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // openCsvButton
            // 
            this.openCsvButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openCsvButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.openCsvButton.Depth = 0;
            this.openCsvButton.HighEmphasis = true;
            this.openCsvButton.Icon = null;
            this.openCsvButton.Location = new System.Drawing.Point(482, 100);
            this.openCsvButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openCsvButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.openCsvButton.Name = "openCsvButton";
            this.openCsvButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.openCsvButton.Size = new System.Drawing.Size(112, 36);
            this.openCsvButton.TabIndex = 0;
            this.openCsvButton.Text = "Browse CSV";
            this.openCsvButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.openCsvButton.UseAccentColor = false;
            this.openCsvButton.UseVisualStyleBackColor = true;
            this.openCsvButton.Click += new System.EventHandler(this.openCsvButton_Click);
            // 
            // colNameToReadFromComboBox
            // 
            this.colNameToReadFromComboBox.AutoResize = false;
            this.colNameToReadFromComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colNameToReadFromComboBox.Depth = 0;
            this.colNameToReadFromComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.colNameToReadFromComboBox.DropDownHeight = 174;
            this.colNameToReadFromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colNameToReadFromComboBox.DropDownWidth = 121;
            this.colNameToReadFromComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.colNameToReadFromComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colNameToReadFromComboBox.FormattingEnabled = true;
            this.colNameToReadFromComboBox.IntegralHeight = false;
            this.colNameToReadFromComboBox.ItemHeight = 43;
            this.colNameToReadFromComboBox.Location = new System.Drawing.Point(96, 330);
            this.colNameToReadFromComboBox.MaxDropDownItems = 4;
            this.colNameToReadFromComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.colNameToReadFromComboBox.Name = "colNameToReadFromComboBox";
            this.colNameToReadFromComboBox.Size = new System.Drawing.Size(323, 49);
            this.colNameToReadFromComboBox.StartIndex = 0;
            this.colNameToReadFromComboBox.TabIndex = 1;
            this.colNameToReadFromComboBox.SelectedIndexChanged += new System.EventHandler(this.colNameToReadFromComboBox_SelectedIndexChanged);
            // 
            // colNameToWriteToComboBox
            // 
            this.colNameToWriteToComboBox.AutoResize = false;
            this.colNameToWriteToComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colNameToWriteToComboBox.Depth = 0;
            this.colNameToWriteToComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.colNameToWriteToComboBox.DropDownHeight = 174;
            this.colNameToWriteToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colNameToWriteToComboBox.DropDownWidth = 121;
            this.colNameToWriteToComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.colNameToWriteToComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colNameToWriteToComboBox.FormattingEnabled = true;
            this.colNameToWriteToComboBox.IntegralHeight = false;
            this.colNameToWriteToComboBox.ItemHeight = 43;
            this.colNameToWriteToComboBox.Location = new System.Drawing.Point(96, 427);
            this.colNameToWriteToComboBox.MaxDropDownItems = 4;
            this.colNameToWriteToComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.colNameToWriteToComboBox.Name = "colNameToWriteToComboBox";
            this.colNameToWriteToComboBox.Size = new System.Drawing.Size(323, 49);
            this.colNameToWriteToComboBox.StartIndex = 0;
            this.colNameToWriteToComboBox.TabIndex = 2;
            this.colNameToWriteToComboBox.SelectedIndexChanged += new System.EventHandler(this.colNameToWriteToComboBox_SelectedIndexChanged);
            // 
            // csvPathTextBox
            // 
            this.csvPathTextBox.AnimateReadOnly = false;
            this.csvPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.csvPathTextBox.Depth = 0;
            this.csvPathTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.csvPathTextBox.LeadingIcon = null;
            this.csvPathTextBox.Location = new System.Drawing.Point(96, 100);
            this.csvPathTextBox.MaxLength = 50;
            this.csvPathTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.csvPathTextBox.Multiline = false;
            this.csvPathTextBox.Name = "csvPathTextBox";
            this.csvPathTextBox.Size = new System.Drawing.Size(323, 50);
            this.csvPathTextBox.TabIndex = 3;
            this.csvPathTextBox.Text = "";
            this.csvPathTextBox.TrailingIcon = null;
            this.csvPathTextBox.TextChanged += new System.EventHandler(this.csvPathTextBox_TextChanged);
            // 
            // filesPathTextBox
            // 
            this.filesPathTextBox.AnimateReadOnly = false;
            this.filesPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filesPathTextBox.Depth = 0;
            this.filesPathTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.filesPathTextBox.LeadingIcon = null;
            this.filesPathTextBox.Location = new System.Drawing.Point(96, 199);
            this.filesPathTextBox.MaxLength = 50;
            this.filesPathTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.filesPathTextBox.Multiline = false;
            this.filesPathTextBox.Name = "filesPathTextBox";
            this.filesPathTextBox.Size = new System.Drawing.Size(323, 50);
            this.filesPathTextBox.TabIndex = 4;
            this.filesPathTextBox.Text = "";
            this.filesPathTextBox.TrailingIcon = null;
            this.filesPathTextBox.TextChanged += new System.EventHandler(this.filesPathTextBox_TextChanged);
            // 
            // browseFilesButton
            // 
            this.browseFilesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseFilesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.browseFilesButton.Depth = 0;
            this.browseFilesButton.HighEmphasis = true;
            this.browseFilesButton.Icon = null;
            this.browseFilesButton.Location = new System.Drawing.Point(482, 199);
            this.browseFilesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.browseFilesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.browseFilesButton.Name = "browseFilesButton";
            this.browseFilesButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.browseFilesButton.Size = new System.Drawing.Size(122, 36);
            this.browseFilesButton.TabIndex = 5;
            this.browseFilesButton.Text = "Browse Files";
            this.browseFilesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.browseFilesButton.UseAccentColor = false;
            this.browseFilesButton.UseVisualStyleBackColor = true;
            this.browseFilesButton.Click += new System.EventHandler(this.browseFilesButton_Click);
            // 
            // noOfCsvText
            // 
            this.noOfCsvText.AutoSize = true;
            this.noOfCsvText.Depth = 0;
            this.noOfCsvText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.noOfCsvText.Location = new System.Drawing.Point(93, 153);
            this.noOfCsvText.MouseState = MaterialSkin.MouseState.HOVER;
            this.noOfCsvText.Name = "noOfCsvText";
            this.noOfCsvText.Size = new System.Drawing.Size(233, 19);
            this.noOfCsvText.TabIndex = 6;
            this.noOfCsvText.Text = "Number of records found in CSV:";
            // 
            // noOfPdfText
            // 
            this.noOfPdfText.AutoSize = true;
            this.noOfPdfText.Depth = 0;
            this.noOfPdfText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.noOfPdfText.Location = new System.Drawing.Point(93, 252);
            this.noOfPdfText.MouseState = MaterialSkin.MouseState.HOVER;
            this.noOfPdfText.Name = "noOfPdfText";
            this.noOfPdfText.Size = new System.Drawing.Size(230, 19);
            this.noOfPdfText.TabIndex = 7;
            this.noOfPdfText.Text = "Number of PDFs found in folder:";
            // 
            // runButton
            // 
            this.runButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.runButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.runButton.Depth = 0;
            this.runButton.HighEmphasis = true;
            this.runButton.Icon = null;
            this.runButton.Location = new System.Drawing.Point(96, 515);
            this.runButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.runButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.runButton.Name = "runButton";
            this.runButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.runButton.Size = new System.Drawing.Size(64, 36);
            this.runButton.TabIndex = 8;
            this.runButton.Text = "Run";
            this.runButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.runButton.UseAccentColor = false;
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // readColumnLabel
            // 
            this.readColumnLabel.AutoSize = true;
            this.readColumnLabel.Depth = 0;
            this.readColumnLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.readColumnLabel.Location = new System.Drawing.Point(93, 308);
            this.readColumnLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.readColumnLabel.Name = "readColumnLabel";
            this.readColumnLabel.Size = new System.Drawing.Size(318, 19);
            this.readColumnLabel.TabIndex = 9;
            this.readColumnLabel.Text = "Select the column name to read names from:";
            // 
            // writeColumnLabel
            // 
            this.writeColumnLabel.AutoSize = true;
            this.writeColumnLabel.Depth = 0;
            this.writeColumnLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.writeColumnLabel.Location = new System.Drawing.Point(93, 405);
            this.writeColumnLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.writeColumnLabel.Name = "writeColumnLabel";
            this.writeColumnLabel.Size = new System.Drawing.Size(326, 19);
            this.writeColumnLabel.TabIndex = 10;
            this.writeColumnLabel.Text = "Select the column to write attachment path to:";
            // 
            // AttachmentMapperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.writeColumnLabel);
            this.Controls.Add(this.readColumnLabel);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.noOfPdfText);
            this.Controls.Add(this.noOfCsvText);
            this.Controls.Add(this.browseFilesButton);
            this.Controls.Add(this.filesPathTextBox);
            this.Controls.Add(this.csvPathTextBox);
            this.Controls.Add(this.colNameToWriteToComboBox);
            this.Controls.Add(this.colNameToReadFromComboBox);
            this.Controls.Add(this.openCsvButton);
            this.Name = "AttachmentMapperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttachmentMapper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton openCsvButton;
        private MaterialSkin.Controls.MaterialComboBox colNameToReadFromComboBox;
        private MaterialSkin.Controls.MaterialComboBox colNameToWriteToComboBox;
        private MaterialSkin.Controls.MaterialTextBox csvPathTextBox;
        private MaterialSkin.Controls.MaterialTextBox filesPathTextBox;
        private MaterialSkin.Controls.MaterialButton browseFilesButton;
        private MaterialSkin.Controls.MaterialLabel noOfCsvText;
        private MaterialSkin.Controls.MaterialLabel noOfPdfText;
        private MaterialSkin.Controls.MaterialButton runButton;
        private MaterialSkin.Controls.MaterialLabel readColumnLabel;
        private MaterialSkin.Controls.MaterialLabel writeColumnLabel;
    }
}

