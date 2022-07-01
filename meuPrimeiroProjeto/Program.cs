// See https://aka.ms/new-console-template for more information
using System;

namespace meuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente ("Anna", 12345, 678, 10);
            ContaCorrente conta2 = new ContaCorrente ("Carolina", 12345, 453, 100);
            ContaCorrente conta3 = new ContaCorrente ("Clara", 12345, 978, 1000);
        

            Console.WriteLine("A conta é do (a): " + conta.Titular + ", a agência é: " + conta.Agencia + " e o número é: " + conta.Numero + "."); 
            Console.WriteLine("A conta é do (a): " + conta2.Titular + ", a agência é: " + conta2.Agencia + " e o número é: " + conta2.Numero + ".");
            Console.WriteLine("A conta é do (a): " + conta3.Titular + ", a agência é: " + conta3.Agencia + " e o número é: " + conta3.Numero + ".");

        }
}

}


