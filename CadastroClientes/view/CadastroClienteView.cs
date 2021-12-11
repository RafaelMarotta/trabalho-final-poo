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

namespace CadastroClientes.view
{
    public partial class CadastroClienteView : Form
    {
        private CadastroClienteController controller;
        public CadastroClienteView()
        {
            InitializeComponent();
            this.controller = new CadastroClienteController();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            controller.Salvar(txtCpf.Text, txtNome.Text, txtEmail.Text, txtDataNascimento.Text, txtTelefone.Text);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            controller.Remover(txtCpf.Text);
        }
    }
}
