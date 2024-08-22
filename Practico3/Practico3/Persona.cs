using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico3
{
    public class Persona
    {
        private string nombre_p;
        private string apellido_p;
        private int dni_p;
        private int edad_p;
        private string genero_p;
        private string telefono_p;
        private string turno_p;

        public Persona(string nombre, string apellido, int dni, int edad, string genero, string telefono, string turno)
        {
            //Inicialización de los atributos de la clase Persona
            this.nombre_p = nombre;
            this.apellido_p = apellido;
            this.dni_p = dni;
            this.edad_p = edad;
            this.genero_p = genero;
            this.telefono_p = telefono;
            this.turno_p = turno;
        }

        public string Nombre
        {
            get { return nombre_p; }
            set { nombre_p = value; }
        }

        public string Apellido
        {
            get { return apellido_p; }
            set { apellido_p = value; }
        }

        public int DNI
        {
            get { return dni_p; }
            set { dni_p = value; }
        }
        public int Edad
        {
            get { return edad_p; }
            set { edad_p = value; }
        }
        public string Genero
        {
            get { return genero_p; }
            set { genero_p = value; }
        }
        public string Telefono
        {
            get { return telefono_p; }
            set { telefono_p = value; }
        }
        public string Turno
        {
            get { return turno_p; }
            set { turno_p = value; }
        }

        public void VerInfoPersona()
        {
            Console.WriteLine($"Nombre: {nombre_p}, Apellido: {apellido_p}, Edad: {edad_p}, DNI: {dni_p}, Genero: {genero_p}, Telefono: {telefono_p} ");
        }

        public string TurnoAsignado()
        {
            return turno_p;
        }

    }
}
