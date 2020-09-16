using System;

namespace NCamadas.App.Modelo.Pessoa
{
    public class Cliente
    {
        public int Id { get; set; }
        public string CPF { get; internal set; }

        public Pagamento Pagamento { get; set; }
        public DateTime Nascimento { get; internal set; }
        public Usuario Usuario { get; set; }
        public Endereco Endereco { get; set; }
        public Telefone Telefone { get; set; }

        //public IList<Pagamento> Pagamento { get; }

    }
}
