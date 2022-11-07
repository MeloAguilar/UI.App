using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UI.ViewModels
{
	public class InicioViewModel : INotifyPropertyChanged
	{
	
	
		private clsPersona persona;


		public clsPersona Persona { get { return persona; } set { persona = value; } }
		public String NombreCompleto
		{
			get
			{
				
				return Persona.NombreCompleto;
				
			}
			set
			{
				Persona.NombreCompleto = value;
				
			}
		}
		public String Nombre { 
			get 
			{ 
				return Persona.Nombre;
			} 
			set 
			{ 
				Persona.Nombre = value;
				if (Persona.Nombre.Contains("n"))
				{
					Persona.Nombre = "";
				}
				Persona.NombreCompleto += "";
				NotifyPropertyChanged();
			} 
		}

		public String Apellidos { 
			get 
			{ 
				return Persona.Apellidos; 
			} 
			set
			{
				Persona.Apellidos = value;
				
				if (Persona.Apellidos.Contains("n"))
				{
					Persona.Apellidos = "";
				}
				NotifyPropertyChanged();
			
			}  
		}

		public InicioViewModel()
		{
			persona = new clsPersona();
			Nombre = "Carmelo";
			Apellidos = "Aguilar";
			
		}




		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}


		private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

	}
}
