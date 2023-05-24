using PracticaPoo.Entities;
using PracticaPoo.Services;
using System;

namespace PracticaPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente persona = new Cliente();
            Promocion compra = new Promocion();
            persona.PedirDatos();
            compra.Descuento();
            persona.ImprimirDatos();
        }
    }
}
