using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tp2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheViewPage : ContentPage
    {
        public DetalheViewPage()
        {
            InitializeComponent();
        }
        private async void btnVoltar_Clicked(object sender, EventArgs e)
        {
            var contato = new Contato
            {
                Nome = "Flavio Mariotti",
                Idade = 32,
                Profissao = "Developer",
                Pais = "Brasil"
            };

            var detalhePage = new DetalheViewPage();
            detalhePage.BindingContext = contato;
            await Navigation.PushAsync(detalhePage);
        }
    }
}