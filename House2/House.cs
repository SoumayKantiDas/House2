using System;
using System.Collections.Generic;
using System.Text;

namespace House2
{
    public class House
    {
        private double Area { get; set; }
        private string Color { get; set; }
        private string Color2 { get; set; }
        private string Color3 { get; set; }

        public House(double area)
        {
            Area = area;
        }
        public House()
        {
            Color = "Brown";
            Color2 = "Green";
            Color3 = "Yellow";
        }
        public void  showdata()
        {
            Console.WriteLine($"I am a house. My area is {Area} m2");
            Console.WriteLine($"I have 3 door one is {Color} one is {Color2} And the other is {Color3}");
        }
            
            

    }
}
