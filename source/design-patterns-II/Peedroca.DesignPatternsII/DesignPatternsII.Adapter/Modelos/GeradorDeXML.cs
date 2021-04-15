using System.IO;
using System.Xml.Serialization;

namespace DesignPatternsII.Adapter.Modelos
{
    public static class GeradorDeXML
    {
        public static string Gerar(object obj)
        {
            var serializer = new XmlSerializer(obj.GetType());
            var stringWriter = new StringWriter();
            
            serializer.Serialize(stringWriter, obj);

            return stringWriter.ToString();
        }
    }
}
