using System;

namespace CadastroClientes.exceptions
{
    internal class ClienteNaoSelecionadoException : Exception
    {
        public string Mensagem { get; }
        public ClienteNaoSelecionadoException(string mensagem)
        {
            this.Mensagem = mensagem;
        }
    }
}
