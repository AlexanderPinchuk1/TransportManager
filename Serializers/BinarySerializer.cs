using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Serializers
{
    public class BinarySerializer: ISerializer
    {
        public string FileExtension { get; } = ".dat|*.dat";
        public void Serialize(object[] transport , string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, transport);
            }
        }

        public object[] Deserialize(string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            object[] transport;
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                transport = (object[])formatter.Deserialize(fs);
            }
            return transport;
        }

    }
}
