using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleFeature
{
    class Circle
    {    
        public void calculateArea()
        {
            Console.WriteLine("Please enter the radius: ");
            float radius = float.Parse(Console.ReadLine());
            Console.WriteLine("The Area of a Circle with radius {0} is {1}", radius, (radius * radius) * (float)Math.PI);
        }
    }
}
