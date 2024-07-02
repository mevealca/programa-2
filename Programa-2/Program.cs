using Programa_2.Entities;


namespace Programa_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();
            banco.Depositar();
            banco.obtenerDepositosTotales();
        }
    }
}
