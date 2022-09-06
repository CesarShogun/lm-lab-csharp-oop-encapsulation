using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        private readonly string _location;
        private readonly double _temperature;
        private const int HOT_THRESHHOLD = 30;
        private const int COLD_THRESHHOLD = 10;

        public WeatherReporter(string location, double temperature)
        {
            _location = location;
            _temperature = temperature;
        }

        public void Report()
        {
            Console.Out.WriteLine($"I am in {_location} and it is {DisplayLocationIcon()}. {DisplayTempReaction()}. The temperature in Fahrenheit is {(9.0 / 5.0) * _temperature + 32}.");
        }

        private String DisplayLocationIcon()
        {
            switch (_location)
            {
                case "London":
                    return "🌦";
                case "California":
                    return "🌅";
                case "Cape Town":
                    return "🌤";
            }

            return "🔆";
        }

        private string DisplayTempReaction()
        {
            if (_temperature > HOT_THRESHHOLD)
            {

                return "It's too hot 🥵!";

            }
            else if (_temperature < COLD_THRESHHOLD)
            {

                return "It's too cold 🥶!";

            }
            return "Ahhh...it's just right 😊!";
        }

    }
}

