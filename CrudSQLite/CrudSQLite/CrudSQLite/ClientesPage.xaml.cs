using CrudSQLite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrudSQLite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientesPage : ContentPage
    {
        public ClientesPage()
        {
            InitializeComponent();
            using (var dados = new AcessoDb())
            {
                this.ListaCliente.ItemsSource = dados.GetClientes();
            }
        }

        private void SalvarClicked(object sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                Nome = this.NomeCliente.Text,
                Email = this.EmailCliente.Text,
            };

            using (var dados = new AcessoDb())
            {
                dados.InserirCliente(cliente);
                this.ListaCliente.ItemsSource = dados.GetClientes();
            }
        }
    }

}