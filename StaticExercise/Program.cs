namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var tempFahrenheit = TempConverter.FahrenheitToCelsius(40);
            Console.WriteLine($"{tempFahrenheit} degrees celsius.");

            var tempCelsius = TempConverter.CelsiusToFahrenheit(30);
            Console.WriteLine($"{tempCelsius} degrees fahrenheit.");
        }
    }
}
