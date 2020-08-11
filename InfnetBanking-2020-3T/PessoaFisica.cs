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
            return $"{Nome} {Sobrenome}";
        }

        public override bool ValidarCadastroPessoa(string value)
        {
            return true;
        }
    }
}
