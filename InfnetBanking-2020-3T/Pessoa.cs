using System;

namespace InfnetBanking
{
    public abstract class Pessoa
    {
        private string cadastroPessoa;

        public string CadastroPessoa 
        {
            get => cadastroPessoa; 
            set
            {
                if (ValidarCadastroPessoa(value))
                {
                    cadastroPessoa = value;
                }
            }
        }

        public string Endereco { get; set; }

        public DateTime DataNascimento { get; set; }

        public abstract bool ValidarCadastroPessoa(string value);

    }
}