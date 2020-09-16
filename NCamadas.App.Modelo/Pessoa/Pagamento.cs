namespace NCamadas.App.Modelo.Pessoa
{
    public class Pagamento
    {
        public Cliente Cliente { get; set; }

        public enum TipoDePagamento
        {
            Boleto,
            Debito,
            Credito
        }
    }
    
}
