using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using CadastroClientes.exceptions;
using CadastroClientes.model;
using CadastroClientes.view;

namespace CadastroClientes.controller
{
    internal class CadastroClienteController
    {
        private EmailAddressAttribute EmailValidator;
        private Form View;
        private Form LastView;
        private bool Edicao;
        public CadastroClienteController(Form view, Form lastView, bool edicao)
        {
            EmailValidator = new EmailAddressAttribute();
            View = view;
            LastView = lastView;
            Edicao = edicao;
        }
        public void Salvar(string cpf, string nome, string email, string dataNascimento, string telefone)
        {
            ValidaCliente(cpf, nome, email, dataNascimento, telefone);
            Cliente cliente = new Cliente();
            cliente.Nome = nome;
            cliente.Email = email;
            cliente.DataNascimento = DateTime.Parse(dataNascimento);
            cliente.Telefone = telefone;
            cliente.Cpf = cpf;
            Clientes.SalvarCliente(cliente, Edicao);
            if (!Edicao)
            {
                new CadastroClienteView(LastView, cliente).Show();
                View.Close();
            }
        }
        public void Remover(String cpf)
        {
            Clientes.RemoverCliente(cpf);
            MessageBox.Show("Cliente removido com sucesso!");
            Voltar();
        }
        public void Voltar()
        {
            LastView.Show();
            View.Close();
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
            if (!EmailValidator.IsValid(email))
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
