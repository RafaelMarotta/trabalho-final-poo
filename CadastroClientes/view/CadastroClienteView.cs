using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroClientes.controller;
using CadastroClientes.exceptions;
using CadastroClientes.model;

namespace CadastroClientes.view
{
    public partial class CadastroClienteView : Form
    {
        private CadastroClienteController controller;
        private Form lastView;
        private bool edicao = false;
        public CadastroClienteView(Form lastView)
        {
            InitializeComponent();
            this.lastView = lastView;
            this.controller = new CadastroClienteController();
        }

        public CadastroClienteView(Form lastView, Cliente cliente)
        {
            InitializeComponent();
            this.lastView = lastView;
            controller = new CadastroClienteController();
            edicao = true;
            txtNome.Text = cliente.nome;
            txtEmail.Text = cliente.email;
            txtCpf.Text = cliente.cpf;
            txtCpf.Enabled = false;
            txtDataNascimento.Text = cliente.dataNascimento.ToString("dd/MM/yyyy");
            txtTelefone.Text = cliente.telefone;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                controller.Salvar(txtCpf.Text, txtNome.Text, txtEmail.Text, txtDataNascimento.Text, txtTelefone.Text, edicao);
                MessageBox.Show("Cliente salvo com sucesso!");
            } 
            catch (ClienteInvalidoException ex)
            {
                MessageBox.Show(ex.Mensagem);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            controller.Remover(txtCpf.Text);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            lastView.Show();
            Close();
        }
    }
}
