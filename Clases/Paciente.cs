using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evaluacion3.Clases
{
    public class Paciente
    {
		public string _rut { get; set; }
		public string _nombre { get; set; }
		public string _apellidoP { get; set; }
		public string _apellidoM { get; set; }
		public string _fdenac { get; set; }
		public string _telefono { get; set; }
		public string _prevision { get; set; }
		public string _calle { get; set; }
		public int _numCalle { get; set; }
		public string _actividad { get; set; }
		public string _deporte { get; set; }


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