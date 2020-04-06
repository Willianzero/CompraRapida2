using System;
using System.Collections.Generic;
using System.Text;
using CompraRapida.Dominio.ObjetoValor;

namespace CompraRapida.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DatàPrevisaoEntrega { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FomaPagamento FomaPagamento { get; set; }

        //pedido deve ter pelo menos um  item pedido 
        //ou muitos itens pedidos
        public ICollection<ItemPedido> ItemPedido { get; set; }
    }
}
