
using ByteBank.Modelos;

namespace ByteBank.SistemaInterno //Utilizando a .dll de ByteBank.Modelos, através de dependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(555, 56335); //botão direito ir para definição para ver o código da classe
            Console.WriteLine(conta.Saldo);
        }
    }
}