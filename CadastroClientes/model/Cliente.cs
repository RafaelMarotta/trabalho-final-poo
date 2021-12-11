using System;

namespace CadastroClientes.model
{
    public class Cliente
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public DateTime dataNascimento { get; set; }
    }
}
