using System;
using System.Threading;

namespace LineComparsn
{
    class Program
    {
        
        static void Main(string[] args)
        {


            double[] length = new double[2];
            Random radom = new Random();
            int count = 0;
            
            while(count<2)
            {
                int x1, x2, y1, y2;
                x1 = radom.Next(-100, 100);
                x2 = radom.Next(-100, 100);
                y1 = radom.Next(-100, 100);
                y2 = radom.Next(-100, 100);
                Console.WriteLine("The coordinates are : (" + x1 + " " + y1 + ") (" + x2 + " " + y2+")");
                length[count] = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                Console.WriteLine("Length of the line : " + Math.Round(length[count], 2));
                count++;
            }
            if (length[0]==length[1]) {
                Console.WriteLine("Lines are equal.");
            }

            else
            {
                Console.WriteLine("Lines are not equal.");
            }
        }
    }
}
