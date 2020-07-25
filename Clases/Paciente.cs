using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evaluacion3.Clases
{
    public class Paciente
    {
		private string _rut { get; set; }
		private string _nombre { get; set; }
		private string _apellidoP { get; set; }
		private string _apellidoM { get; set; }
		private string _fdenac { get; set; }
		private string _telefono { get; set; }
		private string _prevision { get; set; }
		private string _calle { get; set; }
		private int _numCalle { get; set; }
		private string _actividad { get; set; }
		private string _deporte { get; set; }


		public Paciente(string rut, string nombre, string apellidoP, string apellidoM, string fdenac, string telefono, string prevision, string calle, int numCalle, string actividad, string deporte)
		{
			this._rut = rut;
			this._nombre = nombre;
			this._apellidoP = apellidoP;
			this._apellidoM = apellidoM;
			this._fdenac = fdenac;
			this._telefono = telefono;
			this._prevision = prevision;
			this._calle = calle;
			this._numCalle = numCalle;
			this._actividad = actividad;
			this._deporte = deporte;

		}
	}
}