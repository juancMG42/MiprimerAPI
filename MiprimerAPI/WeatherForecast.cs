namespace MiprimerAPI
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public string city { get; set; }

        public WeatherForecast(DateOnly date, int temperatureC, string? summary, string city)
        {
            Date = date;
            TemperatureC = temperatureC;
            Summary = summary;
            this.city = city;
        }

        
    }
}
