using System;

namespace Programa_2.Entities
{
    internal class Cliente
    {
        public Cliente(string nombre)
        {
            Nombre = nombre;
            Ahorros = 0;
            Extraccion = 0;
        }
        public string? Nombre { get; set; }
        public double Ahorros { get; set; }
        public double Extraccion { get; set; }

        public void depositar(double valor)
        {
            Ahorros += valor;
        }
        public void Extraer(double valor)
        {
            Ahorros -= valor;
            Extraccion = valor;

        }
        public double obtenerAhorros()
        {
            return Ahorros;
        }

        public void imprimirAhorros()
        {
            Console.WriteLine("El usuario " + Nombre + " tiene $" + Ahorros + " ahorrados actualmente.");
        }

        public void ExtrerAhorros()
        {
            Console.WriteLine("El usuario " + Nombre + " extrajo $" + Extraccion + " de sus ahorros.");
        }
    }
}
