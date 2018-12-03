using System;
using System.Collections.Generic;
using System.Text;

namespace it.Finsa.HelloDotNetCore.Inheritance
{
    public class AnimalQualities
    {
        public string Color { get; set; }
        public void Show()
        {
            Console.WriteLine($"Io sono un animale di colore {Color}");
            // Console.WriteLine("Io sono un animale di colore " + color);
        }
    }
}
