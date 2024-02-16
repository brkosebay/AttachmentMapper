using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttachmentMapper
{
    public class ClassMapSchema : ClassMap<Dictionary<string, object>>
    {
        public ClassMapSchema(IEnumerable<string> headers)
        {
            foreach (var header in headers)
            {
                Map().Name(header).Convert(args =>
                {
                    // Assuming that the dictionary has a string type for the key and the value.
                    var dictionary = args.Row.GetRecord<Dictionary<string, string>>();
                    return dictionary.TryGetValue(header, out var value) ? value : null;
                });
            }
        }
    }
}
