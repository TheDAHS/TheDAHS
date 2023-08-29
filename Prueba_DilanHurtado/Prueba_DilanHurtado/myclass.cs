using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_DilanHurtado
{
    internal class myclass
    {
        public string NombreEstudiante { get; private set; }
        public int[] Calificaciones { get; private set; }

        public myclass(string nombreEstudiante, int calificacion1, int calificacion2, int calificacion3)
        {
            NombreEstudiante = nombreEstudiante;
            Calificaciones = new int[] { calificacion1, calificacion2, calificacion3 };
        }

        public double ObtenerPromedio()
        {
            double suma = 0;
            foreach (int calificacion in Calificaciones)
            {
                suma += calificacion;
            }
            return suma / Calificaciones.Length;
        }
    }
}
