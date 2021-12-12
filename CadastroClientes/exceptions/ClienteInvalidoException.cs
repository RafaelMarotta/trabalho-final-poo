using System;

namespace CadastroClientes.exceptions
{
    internal class ClienteInvalidoException : Exception
    {
        public string Mensagem { get; }
        public ClienteInvalidoException(string mensagem)
        {
            this.Mensagem = mensagem;
        }
    }
}
