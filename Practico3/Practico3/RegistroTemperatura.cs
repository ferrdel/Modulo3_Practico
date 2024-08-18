using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico3
{
    public class RegistroTemperatura
    {
        private string _tempeRegistrada;
        private DateTime _fechaRegistro;
        private DateTime _hraRegistro;
        private Persona _personaTurno;

        public RegistroTemperatura(string tempRegistrada, DateTime fechaRegistro, DateTime hraRegistro, Persona personaTurno)
        {
            this._tempeRegistrada = tempRegistrada;
            this._fechaRegistro = fechaRegistro;
            this._hraRegistro = hraRegistro;
            this._personaTurno = personaTurno;
        }

        public string TemperaturaRegistrada
        {
            get { return _tempeRegistrada; }
            set { _tempeRegistrada = value; }
        }
        public DateTime FechaRegistro
        {
            get { return _fechaRegistro; }
            set { _fechaRegistro = value; }
        }
        public DateTime HraRegistro
        {
            get { return _hraRegistro; }
            set { _hraRegistro = value; }
        }

        public Persona PersonaTurno
        {
            get { return _personaTurno; }
            set { _personaTurno = value; }
        }

        public void VerRegistroTemperatura()
        {


        }
    }
}
