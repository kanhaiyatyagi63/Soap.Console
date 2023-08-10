using Soap.Console.Constants;
using System.Xml.Serialization;

namespace Soap.Console.Models.Temperature;

[XmlType(Namespace = SoapConstants.t, IncludeInSchema = true)]
public class WeatherForecastModel
{
    [XmlElement(ElementName = "date")]
    public DateTime Date { get; set; }
    [XmlElement(ElementName = "temp_c")]
    public int TemperatureC { get; set; }

    [XmlElement(ElementName = "summary")]
    public string? Summary { get; set; }
}
