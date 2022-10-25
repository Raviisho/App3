using App3.Core;
using App3.Models;
using App3.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App3.ViewModels
{
    public class NuevoEditarCobradorViewModel: ObjetoNotificacion
    {
        CobradoresRepository cobradoresRepository= new CobradoresRepository();
		
		private string apellido_nombre;

		public string Apellido_Nombre
		{
			get { return apellido_nombre; }
			set { apellido_nombre = value; 
				OnPropertyChanged();
			}
		}


		public Command GuardarCommand { get; }
		public Command CancelarCommand { get; }
        public Cobrador CobradorEditado { get; internal set; }

        public NuevoEditarCobradorViewModel()
		{
			GuardarCommand = new Command(Guardar);
			CancelarCommand = new Command(Cancelar);
		}

		private void Cancelar(object obj)
		{
            MessagingCenter.Send<object>(this, "VolverACobradoresView");
        }

        private async void Guardar(object obj)
		{
			if (CobradorEditado == null)
				await cobradoresRepository.AddAsync(apellido_nombre);
			else
				await cobradoresRepository.PutAsync(apellido_nombre, CobradorEditado.Id);
			MessagingCenter.Send<object>(this, "VolverACobradoresView");
		}

        internal void CargarDatosDePantalla()
        {
            Apellido_Nombre = CobradorEditado.Apellido_Nombre;
        }
    }
}
