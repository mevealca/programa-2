
using System;

namespace Programa_2.Entities
{
    internal class Banco
    {
        Cliente cliente1 = new Cliente("Pedro");
        Cliente cliente2 = new Cliente("Antonio");
        Cliente cliente3 = new Cliente("Juana");



        public void Depositar()
        {
            cliente1.depositar(2500);
            cliente2.depositar(15000);
            cliente3.depositar(6500);

            cliente2.Extraer(1000);
        }

        public void obtenerDepositosTotales()
        {
            Console.WriteLine("El valor total depositado: " + (cliente1.Ahorros + cliente2.Ahorros + cliente3.Ahorros));
        }
    }
}
