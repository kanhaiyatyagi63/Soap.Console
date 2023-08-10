using Soap.Console.Helpers;
using Soap.Console.Models.Base;
using Soap.Console.Models.Temperature;
using Soap.Console.Models.Xml;

public class Program
{
    /// <summary>
    /// you can create xml to csharp classes with the help of visual studio
    /// You need to create a class first and copy the xml into the clipboard
    ///  Edit => Paste Special => paste xml as classes
    /// </summary>
    /// <returns></returns>
    static string GetXml()
    {
        var output =
      @"<ArrayOfWeatherForecast xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
    <WeatherForecast>
        <Date>2023-08-11T11:19:07.2683817+05:30</Date>
        <TemperatureC>28</TemperatureC>
        <Summary>Freezing</Summary>
    </WeatherForecast>
    <WeatherForecast>
        <Date>2023-08-12T11:19:07.268389+05:30</Date>
        <TemperatureC>53</TemperatureC>
        <Summary>Bracing</Summary>
    </WeatherForecast>
    <WeatherForecast>
        <Date>2023-08-13T11:19:07.2683897+05:30</Date>
        <TemperatureC>8</TemperatureC>
        <Summary>Cool</Summary>
    </WeatherForecast>
    <WeatherForecast>
        <Date>2023-08-14T11:19:07.2683903+05:30</Date>
        <TemperatureC>42</TemperatureC>
        <Summary>Chilly</Summary>
    </WeatherForecast>
    <WeatherForecast>
        <Date>2023-08-15T11:19:07.2683909+05:30</Date>
        <TemperatureC>16</TemperatureC>
        <Summary>Warm</Summary>
    </WeatherForecast>
   </ArrayOfWeatherForecast>";
        return output;
    }

    public static void Main()
    {
        var items = ParseHelpers.FromXml<ArrayOfWeatherForecast>(GetXml());

        var body = items.WeatherForecast.Select(x => new WeatherForecastModel()
        {
            Date = x.Date,
            Summary = x.Summary,
            TemperatureC = x.TemperatureC
        }).ToList();

        var env = new Envelope<WeatherForecastBody>
        {
            Header = new Header(),
            Body = new WeatherForecastBody()
            {
                WeatherForecasts = body
            }
        };

        var output = ParseHelpers.AddBodyInXmlToString(env);

        Console.WriteLine(output);
    }
}

