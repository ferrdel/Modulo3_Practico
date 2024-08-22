using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico3
{
    public class Pasante : Persona
    {
        public string _nroLegajo { get; set; }

        public Pasante(string nombre, string apellido, int dni, int edad, string genero, string telefono, string turno,string nroLegajo) : base(nombre, apellido, dni, edad, genero, telefono, turno)
        {
            this._nroLegajo = nroLegajo;
        }

        public string VerNroLegajo()
        {
            return _nroLegajo;
        }
    }
}
