using System;
using System.Collections.Generic;
using System.Dynamic;

namespace InfnetBanking
{
    class Program
    {
        static void Main(string[] args)
        {
            Aula20200813();
        }

        static void Aula20200813()
        {
            Pessoa titular = new PessoaFisica
            {
                CadastroPessoa = "00000000000",
                Nome = "Fulano",
                Sobrenome = "Beltrano",
                DataNascimento = new DateTime(1970, 1, 1),
                Enderecos = new List<Endereco>() // criando uma lista (sem o new, dará erro) 
            };

            titular.Enderecos.Add(new Endereco { TipoLogradouro="Rua", Logradouro="São José", Numero="90" });
            titular.Enderecos.Add(new Endereco { TipoLogradouro = "Rua", Logradouro = "do Rosário", Numero = "134" });

            ContaBancaria contaBancaria = new ContaBancaria(3652, 20839, titular);
            Console.WriteLine(contaBancaria.ToString());
        }

        /* static void Aula20200811()
        {
            // 1. Instanciar objeto do tipo ContaBancaria
            ContaBancaria contaBancaria = new ContaBancaria(); // Construtor padrão da classe

            // 2. Acessar (ler e/ou escrever) propriedades:
            contaBancaria.Agencia = 3652;
            contaBancaria.Numero = 30680;

            contaBancaria.Titular = new PessoaJuridica
            {
                RazaoSocial = "Infnet Educação LTDA.",
                NomeFantasia = "Instituto Infnet",
                CadastroPessoa = "00.673.757/0001-46",
                DataNascimento = new DateTime(1994, 10, 25),
                Endereco = "Rua São José, 90, 2º andar\nCentro, Rio de Janeiro, RJ\nCEP 20010-020"
            };

            Console.WriteLine("=== Dados da Conta ===");
            Console.WriteLine(contaBancaria.ToString());
        } */
        /*static void Aula20200804()
        {
            // 1. Instanciar objeto do tipo ContaBancaria
            ContaBancaria contaBancaria = new ContaBancaria(); // Construtor padrão da classe
            
            // 2. Acessar (ler e/ou escrever) propriedades:
            contaBancaria.Agencia = 3652;
            contaBancaria.Numero = 30680;
            contaBancaria.Titular = new PessoaFisica { Cpf = "00000000000", Nome = "Agenor", Sobrenome = "Leopoldo" };
            Console.WriteLine(contaBancaria.ToString());

        }*/

        /*static void Aula20200729()
        {
            // 1. Instanciar objeto do tipo ContaBancaria
            ContaBancaria contaBancaria = new ContaBancaria(); // Construtor padrão da classe
            // O construtor é uma estrutura presente em todas as classes e que sabe instanciar objetos da classe.
            // O construtor chamado "padrão" não recebe parâmetro e pode ficar "invisível" na classe. 

            // 2. Acessar (ler e/ou escrever) propriedades:
            contaBancaria.Agencia = 3652;
            contaBancaria.Numero = 30680;
            //contaBancaria.Titular = "Agenor Leopoldo Fagundes"; --> Troca do tipo da propriedade Titular
            //Console.WriteLine($"Titular: {contaBancaria.Titular}."); --> Troca do tipo da propriedade Titular
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
        }*/
    }
}