using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeLibrary;

namespace task3
{
    public class Program
    {
        
        public static double Area(double x, double y)
        {
            if (x * x + (y - 1) * (y - 1) <= 1 && y <= 1 - x * x) return x - y;
            else return x * y + 7;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №3. (60в). Нахождение u по описанным правилам.");
            double x = Inputs.Double("Введите координату x: ");
            double y = Inputs.Double("Введите координату y: ");
            Console.WriteLine($"u = {Area(x, y)}");
            Console.ReadKey();

        }

        
    }
}
