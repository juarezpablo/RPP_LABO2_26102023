using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;
        public List<Vehiculo> Vehiculos { get { return vehiculos; } }
        private Fabrica()
        {
            vehiculos = new List<Vehiculo>();
        }
        public Fabrica(int capacidad)
        {
            this.capacidad = capacidad;
        }

        public static Fabrica operator +(Fabrica fabrica, Vehiculo vehiculo)
        {
            if (fabrica.vehiculos.Count < fabrica.capacidad)
            {
                fabrica.vehiculos.Add(vehiculo);
            }
            return fabrica;
        }
        public static Fabrica operator -(Fabrica fabrica, Vehiculo vehiculo)
        {
            fabrica.vehiculos.Remove(vehiculo);
            return fabrica;
        }
    }
}
