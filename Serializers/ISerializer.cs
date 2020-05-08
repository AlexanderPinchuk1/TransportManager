using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Serializers
{
    public interface ISerializer
    {
        void Serialize(object[] transport, string filePath);
        object[] Deserialize(string filePath);
        string FileExtension { get; } 
    }
}
