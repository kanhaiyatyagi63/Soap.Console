using Soap.Console.Models.Base;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Soap.Console.Helpers;

public static class ParseHelpers
{
    public static T FromXml<T>(string xml)
    {
        T returnedXmlClass = default(T);

        try
        {
            using (TextReader reader = new StringReader(xml))
            {
                try
                {
                    returnedXmlClass = (T)new XmlSerializer(typeof(T)).Deserialize(reader);
                }
                catch (InvalidOperationException)
                {
                    // String passed is not XML, simply return defaultXmlClass
                }
            }
        }
        catch (Exception)
        {
            System.Console.WriteLine("Unable to parse string to xml");
        }

        return returnedXmlClass;
    }

    public static string AddBodyInXmlToString<T>(Envelope<T> data) where T : class
    {
        var serializer = new XmlSerializer(typeof(Envelope<T>));
        var settings = new XmlWriterSettings
        {
            Encoding = Encoding.UTF8,
            Indent = true,
            OmitXmlDeclaration = true,
        };
        var builder = new StringBuilder();
        using (var writer = XmlWriter.Create(builder, settings))
        {
            serializer.Serialize(writer, data, data.xmlns);
        }

        return builder.ToString();
    }
}
