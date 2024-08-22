using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico3
{
    public class RegistroTemperatura
    {
        public int _tempeRegistrada { get; set; }
        public DateTime _fechaRegistro { get; set; }
        public DateTime _hraRegistro { get; set; }
        public Profesional _profesionalTurno { get; set; }
        public Pasante _pasanteTurno { get; set; }

        public RegistroTemperatura(int tempRegistrada, DateTime fechaRegistro, DateTime hraRegistro, Profesional profTurno,Pasante pasanteTurno)
        {
            this._tempeRegistrada = tempRegistrada;
            this._fechaRegistro = fechaRegistro;
            this._hraRegistro = hraRegistro;
            this._profesionalTurno = profTurno;
            this._pasanteTurno = pasanteTurno;
        }


        public void VerRegistroTemperatura()
        {
            Console.WriteLine($"Temperatura Registrada: {_tempeRegistrada}, Fecha Registro: {_fechaRegistro}, Hra Registro: {_hraRegistro}, Empleado: {_pasanteTurno._nroLegajo}");
        }
    }
}
