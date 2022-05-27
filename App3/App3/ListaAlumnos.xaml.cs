using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaAlumnos : ContentPage
    {
        public ListaAlumnos()
        {
            InitializeComponent();
        }

        private void DarkMode(object sender, EventArgs args)
        {

            if (btnDarkMode.Text == "DarkMode")
            {
                btnDarkMode.Text = "WhiteMode";
                btnDarkMode.TextColor = Color.Azure;
                btnDarkMode.BackgroundColor = Color.FromHex("#2f2f2f");

                lblMarcos.TextColor = Color.White;
                lblTomas.TextColor = Color.White;
                lblLautaro.TextColor = Color.White;
                lblChino.TextColor = Color.White;
                lblGaspar.TextColor = Color.White;
                lblAlan.TextColor = Color.White;
                lblCesar.TextColor = Color.White;
                lblJoana.TextColor = Color.White;
                lblGabriel.TextColor = Color.White;

                stkBody.BackgroundColor = Color.FromHex("#2f2f2f");

                frmFondo.BackgroundColor = Color.FromHex("#1f1f1f");

                lblTitulo.TextColor = Color.Azure;
            }
            else
            {
                btnDarkMode.Text = "DarkMode";
                btnDarkMode.TextColor = Color.Black;
                btnDarkMode.BackgroundColor = Color.FromHex("#efefef");

                lblMarcos.TextColor = Color.FromHex("#1f1f1f");
                lblTomas.TextColor = Color.FromHex("#1f1f1f");
                lblLautaro.TextColor = Color.FromHex("#1f1f1f");
                lblChino.TextColor = Color.FromHex("#1f1f1f");
                lblGaspar.TextColor = Color.FromHex("#1f1f1f");
                lblAlan.TextColor = Color.FromHex("#1f1f1f");
                lblCesar.TextColor = Color.FromHex("#1f1f1f");
                lblJoana.TextColor = Color.FromHex("#1f1f1f");
                lblGabriel.TextColor = Color.FromHex("#1f1f1f");

                stkBody.BackgroundColor = Color.FromHex("#efefef");

                frmFondo.BackgroundColor = Color.White;

                lblTitulo.TextColor = Color.Black;
            }

        }
    }
}