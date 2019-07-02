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
    public partial class ContatosPG : ContentPage
    {
        public ContatosPG()
        {
            InitializeComponent();
        }
        private async void ASCFamilia(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new associar_familia());
        }
        public void ASCednereco(object sender, EventArgs e)
        {

        }
        public void ASCInternet(object sender, EventArgs e)
        {

        }
        public void AscTelefone(object sender, EventArgs e)
        {

        }
        public void ExcContato(object sender, EventArgs e)
        {

        }
        public void EXcPessoa(object sender, EventArgs e)
        {

        }
    }
}