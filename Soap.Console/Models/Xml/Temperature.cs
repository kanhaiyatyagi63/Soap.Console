namespace Soap.Console.Models.Xml
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class ArrayOfWeatherForecast
    {

        private ArrayOfWeatherForecastWeatherForecast[] weatherForecastField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("WeatherForecast")]
        public ArrayOfWeatherForecastWeatherForecast[] WeatherForecast
        {
            get
            {
                return weatherForecastField;
            }
            set
            {
                weatherForecastField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class ArrayOfWeatherForecastWeatherForecast
    {

        private DateTime dateField;

        private byte temperatureCField;

        private string summaryField;

        /// <remarks/>
        public DateTime Date
        {
            get
            {
                return dateField;
            }
            set
            {
                dateField = value;
            }
        }

        /// <remarks/>
        public byte TemperatureC
        {
            get
            {
                return temperatureCField;
            }
            set
            {
                temperatureCField = value;
            }
        }

        /// <remarks/>
        public string Summary
        {
            get
            {
                return summaryField;
            }
            set
            {
                summaryField = value;
            }
        }
    }


}
