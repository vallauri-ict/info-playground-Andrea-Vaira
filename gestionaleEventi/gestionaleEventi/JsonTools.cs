using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace gestionaleEventi
{
    public class JsonTools
    {
        static JsonSerializerSettings jsonSettings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

        /*public static string SerializeToJson(BindingList<Veicolo> veicoli, string filePath = null)
        {
            string serializedData = JsonConvert.SerializeObject(veicoli, jsonSettings);

            if (filePath != null)
            {
                File.WriteAllText(filePath, serializedData);
            }
            return serializedData;
        }

        public static BindingList<Veicolo> DeserializeFromJson(string json)
        {
            return JsonConvert.DeserializeObject<BindingList<Veicolo>>(json, jsonSettings);
        }

        public static BindingList<Veicolo> DeserializeFromFile(string filePath)
        {
            string dataFromFile = File.ReadAllText(filePath);
            return DeserializeFromJson(dataFromFile);
        }*/
    }
}
