using Soap.Console.Constants;
using System.Xml.Serialization;

namespace Soap.Console.Models.Temperature
{
    public class WeatherForecastBody
    {
        [XmlElement(ElementName = "weather", Namespace = SoapConstants.t)]
        public List<WeatherForecastModel> WeatherForecasts { get; set; }
    }
}
