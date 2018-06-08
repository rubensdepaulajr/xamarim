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
    public partial class TotalPage : ContentPage
    {
        public TotalPage()
        {
            InitializeComponent();
            BindingContext = new ContatoListViewModel();
        }
    }
}