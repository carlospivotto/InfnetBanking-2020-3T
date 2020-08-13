using System;

namespace InfnetBanking
{
    public class PessoaFisica : Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        private bool ValidarCpf(string cpf)
        {
            //TODO: Programar regra de validação de CPF;
            return true;
        }

        public override string ToString()
        {
            string resultado = $"{Nome} {Sobrenome}\n\nEndereços cadastrados:\n";
            foreach (var e in Enderecos)
            {
                resultado += $"• {e.ToString()} \n";
            }
            return resultado;
        }

        public override bool ValidarCadastroPessoa(string value)
        {
            return true;
        }
    }
}
