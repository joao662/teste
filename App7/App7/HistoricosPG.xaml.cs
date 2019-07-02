using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoricosPG : ContentPage
    {
        public HistoricosPG()
        {
            InitializeComponent();
        }
            private async void Lançarotas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new lancarnotas());
        }
        public void RemoverNotas(object sender, EventArgs e)
        {

        }
        public void Lançarfaltas(object sender, EventArgs e)
        {

        }
    }
}