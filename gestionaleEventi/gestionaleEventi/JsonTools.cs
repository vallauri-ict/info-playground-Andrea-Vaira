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

        #region Iscritti
        public static string SerializeToJsonIscritti(BindingList<iscritto> iscritti)
        {
            string filePath = Directory.GetCurrentDirectory() + "\\iscritti.json";
            string serializedData = JsonConvert.SerializeObject(iscritti, jsonSettings);

            if (filePath != null)
            {
                File.WriteAllText(filePath, serializedData);
            }
            return serializedData;
        }

        public static BindingList<iscritto> DeserializeFromJsonIscritti(string json)
        {
            return JsonConvert.DeserializeObject<BindingList<iscritto>>(json, jsonSettings);
        }

        public static BindingList<iscritto> DeserializeFromFileIscritti()
        {
            string dataFromFile = File.ReadAllText(Directory.GetCurrentDirectory() + "\\iscritti.json");
            return DeserializeFromJsonIscritti(dataFromFile);
        }
        #endregion

        #region Eventi
        public static string SerializeToJsonEventi(BindingList<evento> eventi)
        {
            string filePath = Directory.GetCurrentDirectory() + "\\eventi.json";
            string serializedData = JsonConvert.SerializeObject(eventi, jsonSettings);

            if (filePath != null)
            {
                File.WriteAllText(filePath, serializedData);
            }
            return serializedData;
        }

        public static BindingList<evento> DeserializeFromJsonEventi(string json)
        {
            return JsonConvert.DeserializeObject<BindingList<evento>>(json, jsonSettings);
        }

        public static BindingList<evento> DeserializeFromFileEventi()
        {
            //string dataFromFile = File.ReadAllText(filePath);
            string dataFromFile = File.ReadAllText(Directory.GetCurrentDirectory() + "\\eventi.json");
            return DeserializeFromJsonEventi(dataFromFile);
        }
        #endregion
    }
}
 