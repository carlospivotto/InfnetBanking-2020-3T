namespace InfnetBanking
{
    public class ContaSalario : ContaBancaria  // ContaSalario HERDA de ContaBancaria
    {
        public override void Transferir(double valor, ContaBancaria conta)
        {
            // Regra: Só é possível transferir todo o saldo para a conta destino.
            if(valor == Saldo)
            {
                base.Transferir(valor, conta);
            } else
            {
                throw new System.Exception("Só é possível transferir todo o valor do saldo.");
            }
        }
    }
}
