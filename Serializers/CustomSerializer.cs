using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.Vehicle;

namespace CRUD.Serializers
{
    class CustomSerializer : ISerializer
    {
        public string FileExtension { get; } = ".txt|*.txt";

        private string ObjectSerializer(object obj)
        {
            string result = "";
            PropertyInfo[] properties = obj.GetType().GetProperties();

            for (int i = 0; i < properties.Length; i++)
            {
                Type propertyValueType = properties[i].GetValue(obj).GetType();
                if ((propertyValueType.IsClass) && (propertyValueType.Namespace != "System"))
                    result += ObjectSerializer(properties[i].GetValue(obj));
                else
                    result += Convert.ToString(properties[i].GetValue(obj)) + '*';
            }
            return result;
        }
        public void Serialize(object[] transport, string filePath)
        {
            using (StreamWriter fileStream = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                for (int j = 0; j < transport.Length; j++)
                {
                    string result = transport[j].GetType().FullName + "*";
                    result += ObjectSerializer(transport[j]);
                    fileStream.WriteLine(result);
                }
            }
        }
        private string GetWord(string line, ref int posInLine)
        {
            string result = "";
            while ((line[posInLine] != '*') && (posInLine < line.Length))
            {
                result += line[posInLine];
                posInLine++;
            }
            posInLine++;
            return result;
        }
        private object ObjectDeserializer(Type valueType,string line,ref int posInLine )
        {
            object obj = Activator.CreateInstance(valueType);
            PropertyInfo[] properties;
            properties = obj.GetType().GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                Type propertyValueType = properties[i].GetValue(obj).GetType();
                if ((propertyValueType.IsClass) && (propertyValueType.Namespace != "System"))
                    properties[i].SetValue(obj, ObjectDeserializer(propertyValueType,line, ref posInLine));
                else
                    SetValueInObject(obj, properties[i], GetWord(line, ref posInLine));
            }
            return obj;
        }

        private int GetNumObj(string filePath)
        {
            int result = 0;
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                    result++;
            }
            return result;
        }
        public void SetValueInObject(Object transport,PropertyInfo propertyInfo, string value)
        {
            object obj;
            Type valueType = propertyInfo.GetValue(transport).GetType();
            if (valueType.IsEnum)
                obj = Enum.Parse(valueType, value);
            else
                obj = Convert.ChangeType(value, valueType);
            propertyInfo.SetValue(transport, obj);
        }

        public object[] Deserialize(string filePath)
        {
            int posInLine = 0;
            string line;
            object[] transport = new Transport[GetNumObj(filePath)];
            using (StreamReader fileStream = new StreamReader(filePath, Encoding.UTF8))
            {
                for (int i = 0; i < transport.Length; i++)
                {
                    line = fileStream.ReadLine();
                    Type objType = Type.GetType(GetWord(line, ref posInLine));
                    transport[i] =  ObjectDeserializer(objType, line, ref posInLine); 
                    posInLine = 0;
                }   
            }
            return transport;
        }
    }
}
