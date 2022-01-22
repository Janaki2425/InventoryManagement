using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace InventoryManagement
{
    internal class FetchJsonForRice
    {
        public Rice? ReadTheJsonFile(string Path)
        {
            using(StreamReader file=new StreamReader(Path))
            { 
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Rice>(json);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null; 
                }
               }
        }
    }
}
