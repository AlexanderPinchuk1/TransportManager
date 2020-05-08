using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Serializers
{
    public class JsonSerializer: ISerializer
    {
        public string FileExtension { get; } = ".json|*.json";
        public void Serialize(object[] transport, string filePath)
        {
            using (StreamWriter fileStream = new StreamWriter(filePath,false))
            {
                string jsonTransport = JsonConvert.SerializeObject(transport, Formatting.Indented, new JsonSerializerSettings
                { TypeNameHandling = TypeNameHandling.All, PreserveReferencesHandling = PreserveReferencesHandling.Objects });
                fileStream.Write(jsonTransport);
            }
        }

        public object[] Deserialize(string filePath)
        {
            object[] transport;
            using (StreamReader fileStream = new StreamReader(filePath))
            {
                string jsonTransport = fileStream.ReadToEnd();
                transport = (object[])JsonConvert.DeserializeObject<object[]>(jsonTransport,new JsonSerializerSettings
                { TypeNameHandling = TypeNameHandling.All, PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            }
            return transport;
        }
    }
}
