using CadastroClientes.exceptions;
using CadastroClientes.model;
using CadastroClientes.view;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CadastroClientes.controller
{
    internal class ListagemClientesController
    {
        public List<Cliente> ObterClientes()
        {
            return Clientes.ObterClientes().Itens;
        }

        public void AdicionarNovoCliente(ListagemClientesView view)
        {
            view.Hide();
            new CadastroClienteView(view).Show();
        }

        public void EditarCliente(ListagemClientesView view, DataGridView dataGridView)
        {
            ValidateSelectionDataGridView(dataGridView);
            view.Hide();
            Cliente cliente = (Cliente)dataGridView.SelectedRows[0].DataBoundItem;
            new CadastroClienteView(view, cliente).Show();
        }

        public int DeletaClientes(ListagemClientesView view, DataGridView dataGridView)
        {
            int quantidadeClientes = dataGridView.SelectedRows.Count;
            ValidateSelectionDataGridView(dataGridView);
            for(int i = 0; i < quantidadeClientes; i++)
            {
                Cliente cliente = (Cliente)dataGridView.SelectedRows[i].DataBoundItem;
                Clientes.RemoverCliente(cliente.Cpf);
            }
            view.ReloadDataGridView();
            return quantidadeClientes;
        }

        private void ValidateSelectionDataGridView(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                throw new ClienteNaoSelecionadoException("Selecione um cliente na listagem!");
            }
        }
    }
}
