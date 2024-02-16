using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttachmentMapper
{
    public class CsvDataService
    {
        // This function reads the headers from a CSV file and returns them as a list of strings.
        public List<string> ReadCsvHeaders(string filePath)
        {
            try
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ";", // Or whatever delimiter your CSV uses
                    Comment = '#',  // If you have comments
                    AllowComments = true,
                }))
                {
                    csv.Read();
                    csv.ReadHeader();
                    return csv.HeaderRecord.ToList();
                }
            }
            catch (IOException ex)
            {
                // Handle the exception according to your needs
                // For now, we'll just rethrow it
                MessageBox.Show("Error: " + ex);
                return null;
                //TO-DO: Add error pop-up for another program is already using the file.
            }
        }

        public List<Dictionary<string, string>> ReadCsvWithDynamicHeaders(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";", // Or whatever delimiter your CSV uses
                Comment = '#',  // If you have comments
                AllowComments = true,
            }))
            {
                csv.Read();
                csv.ReadHeader();
                var headers = csv.HeaderRecord;

                // Register the dynamic class map based on the headers
                csv.Context.RegisterClassMap(new ClassMapSchema(headers));

                // Read the records into a list of dictionaries
                var records = new List<Dictionary<string, string>>();
                while (csv.Read())
                {
                    var record = new Dictionary<string, string>();
                    foreach (var header in headers)
                    {
                        record[header] = csv.GetField(header);
                    }
                    records.Add(record);
                }
                return records;
            }
        }

        public void WriteCsvWithDynamicHeaders(string filePath, List<Dictionary<string, string>> records)
        {
            // Determine the headers from the first record assuming all records have the same structure
            var headers = records.FirstOrDefault()?.Keys.ToList();

            if (headers == null || !headers.Any())
            {
                throw new InvalidOperationException("No headers found in records.");
            }

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
                HasHeaderRecord = true,
                // Specify the encoding if necessary, for example Encoding.UTF8
            };

            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8)) // Use 'false' to overwrite the file
            using (var csv = new CsvWriter(writer, config))
            {
                // Write the headers
                foreach (var header in headers)
                {
                    csv.WriteField(header);
                }
                csv.NextRecord();

                // Write the record values
                foreach (var record in records)
                {
                    foreach (var header in headers)
                    {
                        csv.WriteField(record.TryGetValue(header, out var value) ? value : string.Empty);
                    }
                    csv.NextRecord();
                }
            }

        }
    }
}
