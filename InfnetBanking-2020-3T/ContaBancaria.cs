using System;

namespace InfnetBanking
{
    public class ContaBancaria
    {
        // Classes possuem membros
        // Membros podem ser campos/propriedades ou métodos.
        private double saldo; // campo privado: apenas a própria classe consegue acessar.

        // Propriedade (C#) - https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/properties
        // Propriedades serão, em geral, públicas. 
        public double Saldo 
        {
            get
            {
                return saldo;
            }
        }

        // Poderíamos ter criado Saldo como uma autopropriedade apenas com get.
        // public double Saldo { get; } // <- Sem um set.

        //Autopropriedade (C# 3.0 ou superior)
        //Padrão da linguagem: nomes de campos com minúscula; nomes de propriedades com maiúsculas.
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public Pessoa Titular { get; set; }

        // E para escrever o saldo?
        // Vamos utilizar métodos que contenham as regras de negócio para manipular o saldo.

        // Os métodos, em geral, serão públicos (Haverá exceções)
        public void Depositar(double valor)
        {
            if (valor >= 0)
            {
                saldo += valor;
            }
            else
            {
                Console.WriteLine("Não é possível depositar valores negativos.");
            }

        }

        public void Sacar(double valor)
        {
            if (saldo >= valor && valor >= 0)
            {
                saldo -= valor;
                Console.WriteLine($"Saque finalizado. O novo saldo é de R$ {saldo}.");
            }
            else
            {
                Console.WriteLine("Não foi possível efetuar o saque. Seu saldo é insuficiente.");
            }
        }

        public virtual void Transferir(double valor, ContaBancaria conta)
        {
            if (valor >= 0 && valor <= saldo)
            {
                Sacar(valor);
                conta.Depositar(valor);
            }
        }

        public override string ToString()
        {
            return $"Agência: {Agencia}\nConta: {Numero}\nTitular: {Titular.ToString()}\nSaldo: R$ {Saldo}";

            /*             
            Agência: 3652
            Conta: 30850
            Titular: Agenor Leopoldo
            Saldo: R$ 1000             
             */
        }
    }
}
