using System;
using System.ComponentModel.DataAnnotations;
using CadastroClientes.exceptions;
using CadastroClientes.model;

namespace CadastroClientes.controller
{
    internal class CadastroClienteController
    {
        private EmailAddressAttribute emailValidator = new EmailAddressAttribute();
        public void Salvar(string cpf, string nome, string email, string dataNascimento, string telefone, bool edicao)
        {
            ValidaCliente(cpf, nome, email, dataNascimento, telefone);
            Cliente cliente = new Cliente();
            cliente.nome = nome;
            cliente.email = email;
            cliente.dataNascimento = DateTime.Parse(dataNascimento);
            cliente.telefone = telefone;
            cliente.cpf = cpf;
            Clientes.SalvarCliente(cliente, edicao);
        }

        public void Remover(String cpf)
        {
            Clientes.RemoverCliente(cpf);
        }

        private void ValidaCliente(string cpf, string nome, string email, string dataNascimento, string telefone)
        {
            if (cpf.Length != 14)
            {
                throw new ClienteInvalidoException("Favor informar um CPF válido!");
            }
            if (nome.Length < 2)
            {
                throw new ClienteInvalidoException("Favor informar um nome válido!");
            }
            if (!emailValidator.IsValid(email))
            {
                throw new ClienteInvalidoException("Favor informar um e-mail válido!");
            }
            DateTime date;
            if (!DateTime.TryParse(dataNascimento, out date))
            {
                throw new ClienteInvalidoException("Favor informar uma data no formato dd/MM/yyyy:");
            }
            if(telefone.Length < 15)
            {
                throw new ClienteInvalidoException("Favor informar um número de telefone válido:)");
            }
        }
    }
}
