using System;
using System.Collections.Generic;
using System.Text;

namespace CompraRapida.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string NomeArquivo { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O nome do produto não foi informado!");

            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("A descrição do prodduto não foi informada!")
        }
    }
}
