﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App7.Modelos;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CursosPagina : ContentPage
    {
        public CursosPagina()
        {
            InitializeComponent();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Cursoslista.Items.Clear();

            foreach (Curso curso in Listas.Cursos)
            {
                Cursoslista.Items.Add(curso.Nome);
            }
        }
        public async void NvCursoPG(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NvCursoPG());
        }
        public async void Edtcurso(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EDTCurso());
        }
    }
}