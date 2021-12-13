using System;
using System.Windows.Forms;
using CadastroClientes.controller;
using CadastroClientes.exceptions;
using CadastroClientes.model;

namespace CadastroClientes.view
{
    public partial class CadastroClienteView : Form
    {
        private CadastroClienteController Controller;
        public CadastroClienteView(Form lastView)
        {
            InitializeComponent();
            this.Controller = new CadastroClienteController(this, lastView, false);
        }
        public CadastroClienteView(Form lastView, Cliente cliente)
        {
            InitializeComponent();
            Controller = new CadastroClienteController(this, lastView, true);
            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            txtCpf.Text = cliente.Cpf;
            txtCpf.Enabled = false;
            txtDataNascimento.Text = cliente.DataNascimento.ToString("dd/MM/yyyy");
            txtTelefone.Text = cliente.Telefone;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.Salvar(txtCpf.Text, txtNome.Text, txtEmail.Text, txtDataNascimento.Text, txtTelefone.Text);
                MessageBox.Show("Cliente salvo com sucesso!");
            } 
            catch (ClienteInvalidoException ex)
            {
                MessageBox.Show(ex.Mensagem);
            }
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            Controller.Remover(txtCpf.Text);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Controller.Voltar();
        }
    }
}
