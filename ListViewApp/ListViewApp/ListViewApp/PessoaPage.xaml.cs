using ListViewApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PessoaPage : ContentPage
    {
        public PessoaPage()
        {
            InitializeComponent();
            BindingContext = new ContatoListViewModel();
        }
    }
}