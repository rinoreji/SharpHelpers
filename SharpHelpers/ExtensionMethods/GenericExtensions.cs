using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SharpHelpers.ExtensionMethods
{
    public static class GenericExtensions
    {
        public static string SerializeObjectToXML<T>(this T item)
        {
            var xs = new XmlSerializer(typeof(T));
            using (var stringWriter = new StringWriter())
            {
                xs.Serialize(stringWriter, item);
                return stringWriter.ToString();
            }
        }

        public static T DeserializeFromXml<T>(this string xml)
        {
            T result;
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (TextReader tr = new StringReader(xml))
            {
                result = (T)ser.Deserialize(tr);
            }
            return result;
        }

        public static T Clone<T>(this object item)
        {
            //credits and thanks to the Author @ http://extensionmethod.net/csharp/object/clone-t
            if (item != null)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                MemoryStream stream = new MemoryStream();
                formatter.Serialize(stream, item);
                stream.Seek(0, SeekOrigin.Begin);
                T result = (T)formatter.Deserialize(stream);
                stream.Close();
                return result;
            }
            else
                return default(T);
        }
    }
}
