using CompraRapida.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompraRapida.Dominio.ObjetoValor

{
    public class FomaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhCartaoCredito
        {
            get { return Id == (int)TipoFormadePagmentoEnum.Boleto; }
        }

        public bool EhCartaCredito
        {
            get { return Id == (int)TipoFormadePagmentoEnum.CartoCredito; }
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
