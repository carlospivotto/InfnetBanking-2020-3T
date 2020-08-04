using System;
using System.Dynamic;

namespace InfnetBanking_2020_3T
{
    class Program
    {
        static void Main(string[] args)
        {
            Aula20200729();
        }

        static void Aula20200729()
        {
            // 1. Instanciar objeto do tipo ContaBancaria
            ContaBancaria contaBancaria = new ContaBancaria(); // Construtor padrão da classe
            // O construtor é uma estrutura presente em todas as classes e que sabe instanciar objetos da classe.
            // O construtor chamado "padrão" não recebe parâmetro e pode ficar "invisível" na classe. 

            // 2. Acessar (ler e/ou escrever) propriedades:
            contaBancaria.Agencia = 3652;
            contaBancaria.Numero = 30680;
            contaBancaria.Titular = "Agenor Leopoldo Fagundes";
            Console.WriteLine($"Titular: {contaBancaria.Titular}.");
            Console.WriteLine($"Agência: {contaBancaria.Agencia}.");
            Console.WriteLine($"Conta: {contaBancaria.Numero}.");
            Console.WriteLine($"Saldo inicial: {contaBancaria.Saldo}.");

            Console.Write("Informe o valor de depósito inicial: R$ ");
            double valor = Double.Parse(Console.ReadLine());
            contaBancaria.Depositar(valor);

            Console.WriteLine($"Saldo atual: {contaBancaria.Saldo}.");

            // Não pode:
            // contaBancaria.Saldo = 1000; // <- Porque Saldo é uma propriedade somente leitura
            // Para "escrever" o saldo, usaremos métodos Sacar() e Depositar().

            Console.Write($"Informe o valor de saque: R$ ");
            valor = Double.Parse(Console.ReadLine());
            contaBancaria.Sacar(valor);

            ContaBancaria contaBancaria2 = new ContaBancaria();
            contaBancaria2.Depositar(100);

            contaBancaria.Transferir(100, contaBancaria2);
            Console.WriteLine($"Saldo da primeira conta: {contaBancaria.Saldo}");
            Console.WriteLine($"Saldo da segunda conta: {contaBancaria2.Saldo}");
        }
    }
}