using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSVHelperImplementataion
{
    public class CSVHandlerImplementation
    {
        public void ImplementCSVHandler()
        {
            string importfilepath = @"D:\Bridgelabz Statement\Operator\CSVHelperImplementataion\CSVHelperImplementataion\Import.csv";
            string exportfilepath = @"D:\Bridgelabz Statement\Operator\CSVHelperImplementataion\CSVHelperImplementataion\Export.csv";
            using (var reader = new StreamReader(importfilepath))
            {
                using (var CSV = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = CSV.GetRecords<AddressData>().ToList();
                    Console.WriteLine("Read Data From CSV");
                    foreach (var data in records)
                    {
                        Console.WriteLine(data.Name + "---" + data.Email+"---"+data.Phone+"---"+data.Country);
                    }
                    using(var writer = new StreamWriter(exportfilepath))
                    {
                        using(var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                        {
                            csvExport.WriteRecords(records);
                        }
                    }
                }
            }
            
        }
        public void ImplementCSVHandlerToJson()
        {
            string importFilePath = @"D:\Bridgelabz Statement\Operator\CSVHelperImplementataion\CSVHelperImplementataion\Import.csv";
            string exportFilePath = @"D:\Bridgelabz Statement\Operator\CSVHelperImplementataion\CSVHelperImplementataion\exportjson.json";
            using (var reader = new StreamReader(importFilePath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<AddressData>().ToList();
                    Console.WriteLine("Read Data From CSV");
                    foreach (var data in records)
                    {
                        Console.WriteLine(data.Name + "---" + data.Email + "---" + data.Phone + "---" + data.Country);
                    }
                    Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                    using (var sw = new StreamWriter(exportFilePath))
                    {
                        using (var writer = new JsonTextWriter(sw))
                        {
                            serializer.Serialize(writer, records);
                        }
                    }
                }
            }
        }
        public void ImplementJsonToCsv()
        {
            string importFilePath = @"D:\Bridgelabz Statement\Operator\CSVHelperImplementataion\CSVHelperImplementataion\exportjson.json";
            string exportFilePath = @"D:\Bridgelabz Statement\Operator\CSVHelperImplementataion\CSVHelperImplementataion\Export.csv";
            List<AddressData> list = JsonConvert.DeserializeObject<List<AddressData>>(File.ReadAllText(importFilePath));
            using (var writer = new StreamWriter(exportFilePath))
            {
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(list);
                }
            }
        }
    }
}