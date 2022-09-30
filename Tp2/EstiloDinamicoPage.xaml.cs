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
    public partial class EstiloDinamicoPage : ContentPage
    {
        public EstiloDinamicoPage()
        {
            InitializeComponent();
             Device.StartTimer(TimeSpan.FromSeconds(1), timeLocal);
        }

         bool timeLocal()
        {
            lblTime.Text = DateTime.Now.ToString("dd / MM / yyyy HH : mm : ss");
            return true;
        }
    }
}