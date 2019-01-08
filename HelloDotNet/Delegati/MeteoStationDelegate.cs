using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace it.Finsa.HelloDotNetCore.Delegati
{
    public delegate void Update(double t, double p, double h);



    public class MeteoStationDelegate
    {
        private double temperature;
        private double pressure;
        private double humidity;
        private Random dice;
        public event Update ConditionsChanged;

     

        public MeteoStationDelegate()
        {
 
            dice = new Random();
            

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
                ConditionsChanged?.Invoke(temperature, pressure, humidity);
                //update(temperature, pressure, humidity);
            }
        }
    }
}
