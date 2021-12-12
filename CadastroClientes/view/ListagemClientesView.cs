using CadastroClientes.controller;
using CadastroClientes.exceptions;
using CadastroClientes.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes.view
{
    public partial class ListagemClientesView : Form
    {
        private ListagemClientesController controller = new ListagemClientesController();
        public ListagemClientesView()
        {
            InitializeComponent();
        }

        public void ReloadDataGridView()
        {
            dgvClientes.DataSource = controller.ObterClientes();
        }

        private void ListagemClientesView_Load(object sender, EventArgs e)
        {
            ReloadDataGridView();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                ReloadDataGridView();
            }
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            controller.AdicionarNovoCliente(this);
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                controller.EditarCliente(this, dgvClientes);
            } catch (ClienteNaoSelecionadoException ex)
            {
                MessageBox.Show(ex.Mensagem);
            }
        }

        private void btnRemoverCliente_Click(object sender, EventArgs e)
        { 
            try
            {
                controller.DeletaClientes(this, dgvClientes);
            }
            catch (ClienteNaoSelecionadoException ex)
            {
                MessageBox.Show(ex.Mensagem);
            }
        }
    }
}
