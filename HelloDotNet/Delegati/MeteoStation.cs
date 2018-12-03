using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace it.Finsa.HelloDotNetCore.Delegati
{
    public class MeteoStation
    {
        double temperature;
        double pressure;
        double humidity;
        Random dice;
        List<Display> displays;


        public MeteoStation()
        {
            displays = new List<Display>();
            dice = new Random();

        }

        public void AddDisplay(Display newDisplay)
        {
            displays.Add(newDisplay);
        }

        public void RemoveDisplay(Display oldDisplay)
        {
            displays.Remove(oldDisplay);
        }

        public void Start()
        {
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(dice.Next(1, 6)*1000);
                temperature = dice.NextDouble() * 50;
                pressure = dice.NextDouble() * 50;
                humidity = dice.NextDouble() * 50;
                Console.WriteLine($"T: {temperature}, P: {pressure}, H: {humidity}");
                foreach (var display in displays)
                {
                    display.Update(temperature, pressure, humidity);
                }
            }
        }
    }
}
