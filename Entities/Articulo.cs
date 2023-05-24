using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPoo.Entities
{
    public class Articulo
    {
        public double Precio;

        public double Compra()
        {
            double total = 0, art;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("PRECIO DEL ARTICULO " + (i + 1));
                art = double.Parse(Console.ReadLine());
                total = total + art;
            }
            Console.Clear();
            return total;
        }
    }
}
