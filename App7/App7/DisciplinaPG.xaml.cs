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
    public partial class DisciplinaPG : ContentPage
    {
        public DisciplinaPG()
        {
            InitializeComponent();
            
        }
        private async void NovaDp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Novadp());
        }
        public void EDTDiscplina(object sende, EventArgs e)
        {

        }
        private async void ASCcurso(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ASCcurso());
        }
    }
}