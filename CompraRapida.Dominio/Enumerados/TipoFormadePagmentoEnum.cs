using System;
using System.Collections.Generic;
using System.Text;

namespace CompraRapida.Dominio.Enumerados
{
    public enum TipoFormadePagmentoEnum
    {
        NaoDefinido = 0,
        Boleto      = 1,
        CartaoCredito= 2,
        Deposito    = 3
    }
}
