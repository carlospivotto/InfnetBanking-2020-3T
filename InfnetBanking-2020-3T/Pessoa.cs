using System;
using System.Collections.Generic;

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

        // Ref. programadores Python: listas de Python
        // Ref. programadores Java: java.util.ArrayList<>
        public List<Endereco> Enderecos { get; set; }

        public DateTime DataNascimento { get; set; }

        public abstract bool ValidarCadastroPessoa(string value);

    }
}