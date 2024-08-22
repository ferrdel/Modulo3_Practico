using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico3
{
    public class Profesional : Persona
    {
        public string _nroMatricula { get; set; }

        public Profesional(string nombre, string apellido, int dni, int edad, string genero, string telefono, string turno,string nroMatricula) : base(nombre, apellido, dni, edad, genero, telefono, turno)
        {
            this._nroMatricula=nroMatricula ;
        }


        public string VerMatricula()
        {
            return _nroMatricula;
        }


    }
}
