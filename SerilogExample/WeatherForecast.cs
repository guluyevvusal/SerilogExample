public class WeatherForecast
{
    public DateTime Date { get; set; }
    public int TemperatureC { get; set; }
    public string Summary { get; set; }

    // İstəyə görə Fahrenheit dəyərini əlavə edə bilərik
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
