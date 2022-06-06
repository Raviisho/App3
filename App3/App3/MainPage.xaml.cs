using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenListaAlumnos(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaAlumnos());
        }

        private void OpenListaProvincias(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaProvincias());
        }
    }
}
