using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Rectangle
    {
        public int width;
        public int height;
        public double aspectRatio;
        public int x;
        public int y;
        bool containsPoint;

        
        public Rectangle(int width, int height, int x, int y)
        {
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;     
        }

        public void CalculateArea(int width, int height)
        {
            int area = width * height;
            Console.WriteLine(area);
        }

        public void CalculateAspectRatio(int width, int height) 
        {
            double aspectRatio = width*1.0 / height;
            Console.WriteLine(aspectRatio);
            if (aspectRatio == 1) Console.WriteLine("je to ctverec");
            else if (aspectRatio < 1) Console.WriteLine("je vysoky");
            else Console.WriteLine("je siroky");   
        }

        public void ContainsPoint(int width, int height, int x, int y)
        {
            bool containsPoint = false;
            if (x<=width && y <=height)
            {
                containsPoint = true;
            }
            Console.WriteLine($"bod lezi v obdelniku - {containsPoint}");

        }
    }
}
