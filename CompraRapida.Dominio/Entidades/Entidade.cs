using System.Collections.Generic;
using System.Linq;

namespace CompraRapida.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }
        private List<string> mensgaemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>());}
        }

        protected void LimparMensagemValidacao()
        {
            mensgaemValidacao.Clear();
        }
        protected void AdicionarCritica(string mensagem)
        {
            mensgaemValidacao.Add(mensagem);
        }

        public string ObterMensagemValidacao()
        {
            return string.Join(".", mensgaemValidacao);
        }
        public abstract void Validate();
        public bool EhValido
        {
            get { return !mensgaemValidacao.Any(); }
        }
    }
}
