using CompraRapida.Dominio.Enumerados;

namespace CompraRapida.Dominio.ObjetoValor

{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto
        {
            get { return Id == (int)TipoFormadePagmentoEnum.Boleto; }
        }

        public bool EhCartaoCredito
        {
            get { return Id == (int)TipoFormadePagmentoEnum.CartaoCredito; }
        }

        public bool EhDeposito
        {
            get { return Id == (int)TipoFormadePagmentoEnum.Deposito; }
        }
        public bool EhNaoFoiDefinido
        {
            get { return Id == (int)TipoFormadePagmentoEnum.NaoDefinido; }
        }
    }
}
