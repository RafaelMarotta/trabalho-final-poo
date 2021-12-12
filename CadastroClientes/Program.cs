using System;
using System.Windows.Forms;
using CadastroClientes.view;

namespace CadastroClientes
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ListagemClientesView());
        }
    }
}
