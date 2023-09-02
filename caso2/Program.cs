using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caso2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ti;
            int ta, kilos;
            float preciofi, ganancia;
            preciofi = 0;
            
            Console.WriteLine("Que tipo de uva desea seleccionar A/B: ");
            ti = Console.ReadLine();
            Console.WriteLine("Que tamaño desea 1/2: ");
            ta = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantos kilos de uva desea llevar: ");
            kilos = int.Parse(Console.ReadLine());
            if (ti == "a")
            {
                if (ta == 1)
                {
                    preciofi = +0.20f;
                }
                else if (ta == 2)
                {
                    preciofi = +0.30f;
                }
            }
            else if (ti == "b")
            {
                if (ta == 1)
                {
                    preciofi = -0.30f;
                }
                else if (ta == 2)
                {
                    preciofi = -0.50f;
                }
            }
            else
            {
                Console.WriteLine("Tipo de uva no valido");
                return;
            }
            
            ganancia = preciofi * kilos; 
            Console.WriteLine("El precio final será: S/" +ganancia.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
