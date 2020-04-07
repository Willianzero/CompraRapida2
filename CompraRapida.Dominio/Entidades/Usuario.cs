using System.Collections.Generic;

namespace CompraRapida.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public bool EhAdmnistrador { get; set; }
        //um usuário pode ter nenhum ou muitos pedidos
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("O e-mail não foi preenchido!");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("A senha não foi informada!");
        }
    }
}
