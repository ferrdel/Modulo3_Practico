using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico3
{
    public class EstacionMeteorologica
    {
        //private double[] temperaturas;
        public List<RegistroTemperatura> Temperaturas { get; set; }

        private List<RegistroTemperatura> TemperaUmbral { get; set; }

        // Constructor que realiza la carga automática de la matriz
        public EstacionMeteorologica(RegistroTemperatura registro)
        {
            this.Temperaturas.Add(registro);
        }

        public void RegistrarTemperatura(RegistroTemperatura registro)
        {
            // Inicializa la matriz con valores predeterminados
            this.Temperaturas.Add(registro); // 
        }

        public void VerTemperaturasRegistradas()
        {
            for (int i = 0; i < Temperaturas.Count; i++)
            {
                Temperaturas[i]?.VerRegistroTemperatura();
                Console.WriteLine("\n");
            }
        }

        public double TemperaturaPromMes()
        {
            double tempMesProm;
            double sumTemp = 0;

            for (int i = 0; i < Temperaturas.Count; i++)
            {
                sumTemp += Temperaturas[i]._tempeRegistrada;
                
            }

            tempMesProm = sumTemp / Temperaturas.Count;

            return tempMesProm;
        }

        public void TempMaxima()
        {
            int tempMax = 0;

            for (int i = 0; i < Temperaturas.Count; i++)
            {
                if (Temperaturas[i]._tempeRegistrada > tempMax)
                {
                    tempMax = Temperaturas[i]._tempeRegistrada;
                }
            }
            Console.WriteLine($"\nLa temperatura Maxima del Mes es: {tempMax}");
        }

        public void TempMinima()
        {
            int tempMin = 9999;

            for (int i = 0; i < Temperaturas.Count; i++)
            {
                if (Temperaturas[i]._tempeRegistrada < tempMin) 
                {
                    tempMin = Temperaturas[i]._tempeRegistrada;
                }
            }
            Console.WriteLine($"\nLa temperatura Minima del Mes es: {tempMin}");
        }

        void TemperaturaMasUmbral()
        {
            for (int i = 0; i < Temperaturas.Count; i++)
            {
                if (Temperaturas[i]._tempeRegistrada > 20)
                {
                    TemperaUmbral.Add(Temperaturas[i]);
                }
            }


            Console.WriteLine("\nLas Temperaturas por encima de un umbral (20°) son...\n");
            foreach (var valor in TemperaUmbral)
            {
                Console.Write($" {valor}");
            }

        }

        void TemperaturaUnDia()
        {
            int tempActual = 0;
            

            Console.Write("\n-- Ingrese la fecha del mes que quiere saber la temperatura... ");
            DateTime diaMes = Convert.ToDateTime(Console.ReadLine());

            for (int i = 0; i < Temperaturas.Count; i++)
            {
                if (Temperaturas[i]._fechaRegistro == diaMes)
                {
                    tempActual = Temperaturas[i]._tempeRegistrada;
                }
            }

            if (tempActual < 0)
            {
                Console.WriteLine("\n- Hizo mucho frío.\n");

            }
            else if ((tempActual >= 0) && (tempActual <= 20))
            {
                Console.WriteLine("\n- El clima estaba fresco.\n");

            }
            else if (tempActual > 20)
            {
                Console.WriteLine("\n- Hizo calor afuera.\n");

            }
        }

    }
}
