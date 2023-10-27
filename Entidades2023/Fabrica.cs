using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades2023
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        private Fabrica()
        {
            vehiculos = new List<Vehiculo>();
        }

        public Fabrica(int capacidad): this()
        {
            this.capacidad = capacidad;
        }
        public List<Vehiculo> Vehiculos 
        {
            get
            {
                return vehiculos;
            }
        }


        public static Fabrica operator +(Fabrica fabrica, Vehiculo vehiculo)
        {
            if (fabrica.capacidad != 0)
            {
                fabrica.vehiculos.Add(vehiculo);
            }
            
            return fabrica;
        }

        public static Fabrica operator -(Fabrica fabrica, Vehiculo vehiculo)
        {
            foreach (var item in fabrica.Vehiculos)
            {
                if (item == vehiculo)
                {
                    fabrica.vehiculos.Remove(item);
                }
            }

            return fabrica;
        }
    }
}
