using APIService.Model;
using APIService.Service.interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace APIService.Service
{
    public class DataService : IdataService
    {
        public bool AddData(FormData formData)
        {
            TextWriter writer;
            try
            {
                using (writer = new StreamWriter(@"..\APIService\data\data.json", append: true))
                {

                    writer.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(formData));
                }
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
    
        }
        public List<FormData> Read()
        {
            var result = new List<FormData>();
            using (var reader = new StreamReader(@"..\APIService\data\data.json"))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        result.Add(Newtonsoft.Json.JsonConvert.DeserializeObject<FormData>(line));
                    }
                }
            }
            return result;
        }
    }
}
