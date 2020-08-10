using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Досвід роботи програміста.");
            Console.Write("Введіть число: ");
            string exp= Console.ReadLine();
            double expDouble = Convert.ToDouble(exp);

            if (expDouble <= 0.25)
            {
                Console.WriteLine("Trainee");
            }
            else if (expDouble > 0.25 && expDouble <= 0.5)
            {
                Console.WriteLine("Low Junior");
            }

            else if (expDouble > 0.5 && expDouble <= 1) 
            {
                Console.WriteLine("Junior");
            }

            else if (expDouble > 1 && expDouble <= 1.5) 
            {
                Console.WriteLine("Strong Junior");
            }
            else if (expDouble > 1.5 && expDouble <=2) 
            {
                Console.WriteLine("Low Middle");
            }
            else if (expDouble > 2 && expDouble <= 3)
            {
                Console.WriteLine("Middle");
            }
            else if (expDouble > 3 && expDouble <= 4)
            {
                Console.WriteLine("Strong Middle");
            }
            else if (expDouble > 4 && expDouble <= 5)
            {
                Console.WriteLine("Low Senior");
            }
            else if (expDouble > 5 && expDouble <= 6)
            {
                Console.WriteLine("Senior");
            }
            else if (expDouble > 6 && expDouble <= 8)
            {
                Console.WriteLine("Strong Senior");
            }
            else if (expDouble > 8 )
            {
                Console.WriteLine("Professional");
            }
            Console.ReadKey();

            
        }
    }
}
