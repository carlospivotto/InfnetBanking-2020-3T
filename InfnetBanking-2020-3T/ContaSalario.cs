using System;

namespace InfnetBanking
{
    public class ContaSalario : ContaBancaria  // ContaSalario HERDA de ContaBancaria
    {
        public ContaSalario(int agencia, int numero, Pessoa titular) : base(agencia, numero, titular)
        {
            // Este construtor chama o construtor com 3 parâmetros da classe base. 
        }

        public ContaSalario(int agencia, int numero, double saldo, Pessoa titular): base(agencia, numero, saldo, titular) 
        {
            
        }

        public override void Transferir(double valor, ContaBancaria conta)
        {
            // Regra: Só é possível transferir todo o saldo para a conta destino.
            if (valor == Saldo)
            {
                base.Transferir(valor, conta);
            }
            else
            {
                throw new System.Exception("Só é possível transferir todo o valor do saldo.");
            }
        }
    }
}
