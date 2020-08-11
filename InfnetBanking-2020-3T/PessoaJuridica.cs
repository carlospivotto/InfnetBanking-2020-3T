using System;
using System.Collections.Generic;
using System.Text;

namespace InfnetBanking
{
    public class PessoaJuridica : Pessoa
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }

        public override bool ValidarCadastroPessoa(string value)
        {
            return true;
        }

        public override string ToString()
        {
            return $"RAZÃO SOCIAL: {RazaoSocial}\nNOME FANTASIA: {NomeFantasia}";
        }
    }
}
