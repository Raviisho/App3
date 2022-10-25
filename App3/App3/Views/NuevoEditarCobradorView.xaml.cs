using App3.Models;
using App3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NuevoEditarCobradorView : ContentPage
    {
        NuevoEditarCobradorViewModel nuevoEditarCobradorViewModel;
        public NuevoEditarCobradorView()
        {
            InitializeComponent();
        }
        public NuevoEditarCobradorView(Cobrador cobradorAModificar)
        {
            InitializeComponent();
            nuevoEditarCobradorViewModel= this.BindingContext as NuevoEditarCobradorViewModel;
            nuevoEditarCobradorViewModel.CobradorEditado = cobradorAModificar;
            nuevoEditarCobradorViewModel.CargarDatosDePantalla();
        }
    }
}