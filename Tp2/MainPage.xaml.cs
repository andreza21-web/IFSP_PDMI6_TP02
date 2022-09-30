using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnEstiloPadrao(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EstiloPadraoPage());
        }

        private async void btnEstiloDinamico(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EstiloDinamicoPage());
        }

        private async void btnEstiloTriggers(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EstiloTriggersViewPage());
        }

        private async void btnViewSimples(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new ViewSimplesPage());
        }
        private async void btnHomePage(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new HomePage());
        }

        private async void btnProdutoForm(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new ProdutoFormPage());
        }
    }
}
