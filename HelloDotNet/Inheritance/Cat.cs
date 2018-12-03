using System;
using System.Collections.Generic;
using System.Text;

namespace it.Finsa.HelloDotNetCore.Inheritance
{
    public class Cat
    {
        private AnimalQualities anim = new AnimalQualities();

        public string Color
        {
            get { return anim.Color; }
            set { anim.Color = value; }
        }

        public void Show()
        {
            anim.Show();
        }
    }
}
