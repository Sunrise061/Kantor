using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Kantor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double PLN;

            Console.WriteLine("Podaj kwote(PLN)");
            PLN = Double.Parse(Console.ReadLine());

          

            var EUR = 1.0814;
            var CHF = 1.1394; 
            var GBP = 1.2574; 
            var USD = 3.9901; 
            int wybor;
            do
            {
                   
                Console.WriteLine("Wybierz Walute:");
                Console.WriteLine("1.EUR");
                Console.WriteLine("2.CHF");
                Console.WriteLine("3.GBP");
                
                
                while (!int.TryParse(Console.ReadLine(), out wybor) ||
                    (wybor < 0 || wybor > 3))
                {
                    Console.WriteLine("Niepoprawna wartość!!! Wprowadź numer z przedziału od 0 do 5");
                }

                switch (wybor)
                {                  
                    case 1:
                      var wynik1 = (PLN/USD)/EUR;
                       Console.WriteLine(wynik1);
                       Console.ReadKey();
                        break;
                    case 2:
                        var wynik2 = (PLN / USD) / CHF;
                        Console.WriteLine(wynik2);
                        Console.ReadKey();
                        break;
                    case 3:
                        var wynik3 = (PLN / USD) / GBP;
                        Console.WriteLine(wynik3);
                        Console.ReadKey();
                        break;                    
                    default:
                        Console.WriteLine("Dokonano niewłaściwego wyboru!");
                        break;
                }

                Console.WriteLine("Wybrano {0}. Naciśnij enter aby kontynuować.", wybor);
                Console.ReadLine();
                Console.Clear();

            } while (wybor != 0);



        }
    }
}
