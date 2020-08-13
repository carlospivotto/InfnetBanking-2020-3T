namespace InfnetBanking
{
    public class Endereco
    {
        public string TipoLogradouro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string Pais { get; set; }

        public override string ToString()
        {
            string resultado = $"{TipoLogradouro} {Logradouro}, {Numero}";
            if(Complemento != null)
            {
                resultado += $", {Complemento}";
            }
            //TODO: Adicionar Bairro, Município, UF, CEP, País.
            return resultado;
        }
    }
}