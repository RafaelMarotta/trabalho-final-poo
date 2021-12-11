using System;
using CadastroClientes.model;

namespace CadastroClientes.controller
{
    internal class CadastroClienteController
    {
        public void Salvar(string cpf, string nome, string email, string dataNascimento, string telefone)
        {
            Cliente cliente = new Cliente();
            cliente.nome = nome;
            cliente.email = email;
            cliente.dataNascimento = DateTime.Parse(dataNascimento);
            cliente.telefone = telefone;
            cliente.cpf = cpf;
            Clientes.SalvarCliente(cliente);
        }

        public void Remover(String cpf)
        {
            Clientes.RemoverCliente(cpf);
        }
    }
}
