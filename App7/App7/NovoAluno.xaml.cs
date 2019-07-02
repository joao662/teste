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
    public partial class NovoAluno : ContentPage
    {
        public NovoAluno()
        {
            InitializeComponent();
        }
        public void Salvarinfo(object sender,EventArgs e)
        {

        }
    }
}