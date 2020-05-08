using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Attributes
{
    class TransportTypeAttribute : Attribute
    {
        public string TypeName { get; set; }

        public TransportTypeAttribute(string typeName)
        {
            TypeName = typeName;
        }
    }
}
