using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades2023
{
    public class Automovil : Vehiculo
    {
        public Automovil(): base(EPropulsion.Hibrida)
        {
        }

        protected override string Tipo
        {
            get
            {
                return "Automovil";
            }
        }
    }
}
