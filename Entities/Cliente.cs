using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPoo.Entities
{
    public class Cliente
    {
        public string Nombre;
        public string Telefono;
        public string Correo;

        public void PedirDatos()
        {
            Console.Clear();
            Console.WriteLine("INGRESA TU NOMBRE: ");
            this.Nombre = Console.ReadLine();
            Console.WriteLine("INGRESA TU NUMERO DE TELEFONO: ");
            this.Telefono = Console.ReadLine();
            Console.WriteLine("INGRESA TU CORREO ELECTRONICO: ");
            this.Correo = Console.ReadLine();
        }
        public void ImprimirDatos()
        {
            Console.WriteLine("NOMBRE: " + Nombre);
            Console.WriteLine("TELEFONO: " + Telefono);
            Console.WriteLine("CORREO: " + Correo);
        }

    }
}
