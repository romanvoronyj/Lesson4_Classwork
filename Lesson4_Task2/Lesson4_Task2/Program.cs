using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Досвід роботи програміста: ");
            Console.WriteLine("Введіть клькість років: ");
            string exp = Console.ReadLine();
            double expYears = Convert.ToDouble(exp);

            if (expYears <= 0.25)
            {
                Console.WriteLine("Trainee");
            }
            else if (expYears > 0.25 && expYears <= 0.5)
            {
                Console.WriteLine("Ви працюєте {0} року. З цим досвідом Ви вважаєтесь Low Junior!", expYears);
            }

            else if (expYears >0.5 && expYears <= 1)
            {
                Console.WriteLine("Ви працюєте {0} рік.З цим досвідом Ви вважаєтесь Junior!", expYears);
            }

            else if (expYears > 1 && expYears <= 1.5)
            {
                Console.WriteLine("Ви працюєте {0} роки.З цим досвідом Ви вважаєтесь Strong Junior!", expYears);
            }
            else if (expYears > 1.5 && expYears <= 2)
            {
                Console.WriteLine("Ви працюєте {0} роки. З цим досвідом Ви вважаєтесь Low Middle!", expYears);
            }
            else if (expYears > 2 && expYears <= 3)
            {
                Console.WriteLine("Ви працюєте {0} років.З цим досвідом Ви вважаєтесь Middle!", expYears);
            }
            else if (expYears > 3 && expYears <= 4)
            {
                Console.WriteLine("Ви працюєте {0} років.З цим досвідом Ви вважаєтесь Strong Middle!", expYears);
            }

            else if (expYears > 4 && expYears <= 5)
            {
                Console.WriteLine("Ви працюєте {0} років.З цим досвідом Ви вважаєтесь Low Senior!", expYears);
            }
            else if (expYears > 5 && expYears <= 6)
            {
                Console.WriteLine("Ви працюєте {0} років.З цим досвідом Ви вважаєтесь Senior!", expYears);
            }

            else if (expYears > 6 && expYears <= 8)
            {
                Console.WriteLine("Ви працюєте {0} років.З цим досвідом Ви вважаєтесь Strong Senior!", expYears);
            }
            else if (expYears > 8 )
            {
                Console.WriteLine("Ви працюєте {0} років.З цим досвідом Ви вважаєтесь Professional!", expYears);
            }



            Console.ReadKey();
        }
    }
}
