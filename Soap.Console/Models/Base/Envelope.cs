using Soap.Console.Constants;
using System.Xml.Serialization;

namespace Soap.Console.Models.Base;

[XmlRoot(Namespace = SoapConstants.v)]
public class Envelope<T> where T : class
{
    public Header Header { get; set; }
    public T Body { get; set; }

    static Envelope()
    {
        staticxmlns = new XmlSerializerNamespaces();
        staticxmlns.Add("i", SoapConstants.i);
        staticxmlns.Add("d", SoapConstants.d);
        staticxmlns.Add("c", SoapConstants.c);
        staticxmlns.Add("soapenv", SoapConstants.v);
    }

    private static XmlSerializerNamespaces staticxmlns;

    [XmlNamespaceDeclarations]
    public XmlSerializerNamespaces xmlns { get { return staticxmlns; } }
}