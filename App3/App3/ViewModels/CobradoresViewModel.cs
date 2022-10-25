using App3.Core;
using App3.Models;
using App3.Repositories;
using App3.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace App3.ViewModels
{
    public class CobradoresViewModel : ObjetoNotificacion
    {
        private CobradoresRepository cobradoresRepository = new CobradoresRepository();

        private ObservableCollection<Cobrador> cobradores;
        public ObservableCollection<Cobrador> Cobrador
        {
            get { return cobradores; }
            set { cobradores = value;
                OnPropertyChanged();
            }
        }
        //campo
        private Cobrador cobradorSeleccionado;

        //propiedad
        public Cobrador CobradorSeleccionado
        {
            get { return cobradorSeleccionado; }
            set { cobradorSeleccionado = value;
                    OnPropertyChanged();
            }
        }


        public Command CargarNuevoCommand { get; }
        public Command ModificarCommand { get; }
        public Command EliminarCommand { get; }
        public Command ObtenerCobradoresCommand { get; }
        
        bool isRefreshing;
        public bool IsRefreshing
        {
            get => isRefreshing;
            set
            {
                isRefreshing = value;
                OnPropertyChanged();
            }
        }
        public CobradoresViewModel()
        {
            cobradores = new ObservableCollection<Cobrador>();
            ObtenerCobradoresCommand = new Command(ObtenerCobradores);
            CargarNuevoCommand = new Command(CargarNuevo);
            ModificarCommand = new Command(Modificar);
            EliminarCommand = new Command(Eliminar);
            ObtenerCobradores(this);
        }

        private async void Eliminar(object obj)
        {
            bool respuesta = await Application.Current.MainPage.DisplayAlert("Eliminar cobrador", $"¿Está seguro que desea borrar el cobrador {cobradorSeleccionado.Apellido_Nombre}?", "Si", "No");
            if(respuesta)
            {
                cobradoresRepository.DeleteAsync(cobradorSeleccionado.Id);
                cobradorSeleccionado = null;
                ObtenerCobradores(this);
            }
        }

        private void Modificar(object obj)
        {
            MessagingCenter.Send<object,Cobrador>(this, "AbrirNuevoEditarCobradorView",CobradorSeleccionado);
        }

        private void CargarNuevo(object obj)
        {
             MessagingCenter.Send<object>(this,"AbrirNuevoEditarCobradorView");
        }

        public async void ObtenerCobradores(object obj)
        {
            cobradores.Clear();
            var cobradoresCollection = await cobradoresRepository.GetAllAsync();
            foreach(Cobrador cobrador in cobradoresCollection)
            {
                cobradores.Add(cobrador);
            }
            IsRefreshing = false;
        }
    }
}
