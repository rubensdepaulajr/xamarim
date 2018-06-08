using ListViewApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Total_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TotalPage());
        }

        private async void Pessoa_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PessoaPage());
        }
    }
}
