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
        
            Console.WriteLine("A conta é do (a): " + conta.Titular + ", a agência é: " + conta.Agencia + ", o número é: " + conta.Numero + " e o saldo é: " + conta.Saldo + "."); 
            Console.WriteLine("A conta é do (a): " + conta2.Titular + ", a agência é: " + conta2.Agencia + ", o número é: " + conta2.Numero + " e o saldo é: " + conta2.Saldo + ".");
            Console.WriteLine("A conta é do (a): " + conta3.Titular + ", a agência é: " + conta3.Agencia + ", o número é: " + conta3.Numero + " e o saldo é: " + conta3.Saldo + ".");

            bool sacar_conta = conta.Sacar(100);
            bool sacar_conta2 = conta2.Sacar(100);
            bool sacar_conta3 = conta3.Sacar(100);

            Console.WriteLine("A conta é do (a): " + conta.Titular + ", a agência é: " + conta.Agencia + ", o número é: " + conta.Numero + " e o saldo é: " + conta.Saldo + "."); 
            Console.WriteLine("A conta é do (a): " + conta2.Titular + ", a agência é: " + conta2.Agencia + ", o número é: " + conta2.Numero + " e o saldo é: " + conta2.Saldo + ".");
            Console.WriteLine("A conta é do (a): " + conta3.Titular + ", a agência é: " + conta3.Agencia + ", o número é: " + conta3.Numero + " e o saldo é: " + conta3.Saldo + ".");


        }


}

}


