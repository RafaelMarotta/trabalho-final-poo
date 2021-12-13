using CadastroClientes.controller;
using CadastroClientes.exceptions;
using System;
using System.Windows.Forms;

namespace CadastroClientes.view
{
    public partial class ListagemClientesView : Form
    {
        private ListagemClientesController Controller = new ListagemClientesController();
        public ListagemClientesView()
        {
            InitializeComponent();
        }

        public void ReloadDataGridView()
        {
            dgvClientes.DataSource = Controller.ObterClientes();
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
            Controller.AdicionarNovoCliente(this);
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.EditarCliente(this, dgvClientes);
            } catch (ClienteNaoSelecionadoException ex)
            {
                MessageBox.Show(ex.Mensagem);
            }
        }

        private void btnRemoverCliente_Click(object sender, EventArgs e)
        { 
            try
            {
                Controller.DeletaClientes(this, dgvClientes);
            }
            catch (ClienteNaoSelecionadoException ex)
            {
                MessageBox.Show(ex.Mensagem);
            }
        }
    }
}
