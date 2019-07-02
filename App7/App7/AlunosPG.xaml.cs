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
    public partial class AlunosPG : ContentPage
    {
        public AlunosPG()
        {
            InitializeComponent();
        }
        private async void NovoAluno(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NovoAluno());
        }

        public void EDTAluno(object sender, EventArgs e)
        {

        }
        public void MTRCURSO(object sender, EventArgs e)
        {

        }
    }
}