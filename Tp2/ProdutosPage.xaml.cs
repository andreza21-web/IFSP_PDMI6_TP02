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
    public partial class ProdutosPage : ContentPage
    {
        public ProdutosPage()
        {
            InitializeComponent();
        }
        async void btnVoltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}