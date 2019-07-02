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
    public partial class TurmaPG : ContentPage
    {
        public TurmaPG()
        {
            InitializeComponent();
        }
            private async void Novaturma(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Novaturmapg());
        }
        public void Turmaedt(object sender, EventArgs e)
        {

        }
               private async void ASCprofessor(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new associarprof());

        }

    }
}