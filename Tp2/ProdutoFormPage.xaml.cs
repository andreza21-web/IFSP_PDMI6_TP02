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
    public partial class ProdutoFormPage : ContentPage
    {
        public ProdutoFormPage()
        {
            InitializeComponent();
        }

        async void btnVoltar_Clicked(object sender, EventArgs e)
        {
            var produto = new Produto
            {
                Id = Id.Text,
                Descricao = Descricao.Text,
                Categoria = Categoria.Text,
                Quantidade = int.Parse(Quantidade.Text),
                Preco = decimal.Parse(Preco.Text),
            };
            var produtoPage = new ProdutosPage();
            produtoPage.BindingContext = produto;
            await Navigation.PushAsync(produtoPage);
        }
    }
}