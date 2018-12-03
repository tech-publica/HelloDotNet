using System;
using System.Collections.Generic;
using System.Text;

namespace it.Finsa.HelloDotNetCore.Delegati
{
    class AverageConditionsDisplay : Display
    {

        Dictionary<string, AverageData> averages = new Dictionary<string, AverageData>(); 

        public AverageConditionsDisplay()
        {
            averages.Add("T", new AverageData());
            averages.Add("P", new AverageData());
            averages.Add("H", new AverageData());
        }

        public void Update(double temperature, double pressure, double humidity)
        {
            averages["T"] = averages["T"].NextAverage(temperature);
            averages["P"] = averages["P"].NextAverage(pressure);
            averages["H"] = averages["H"].NextAverage(humidity);

            Console.WriteLine($"Avg T: {averages["T"].Average},Avg P: {averages["P"].Average},Avg H: {averages["H"].Average}");
        }


        private class AverageData
        {
            double average;
            int measures;

            public double Average => average;

            public AverageData NextAverage(double measurament)
            {
                var avg = new AverageData();
                avg.measures = this.measures + 1;
                double newAverage = (this.average*this.measures + measurament) / avg.measures;
                avg.average = newAverage;
                return avg;
            }
        }
    }


}
