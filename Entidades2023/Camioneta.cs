using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Entidades2023
{
    public class Camioneta : Vehiculo
    {
        private bool cabinaSimple;
        public Camioneta(EPropulsion propulsion, bool cabinaSimple) : base(true,propulsion)
        {
            this.cabinaSimple = cabinaSimple;
        }

        protected override string Tipo
        {
            get 
            {
                return "Camioneta";
            }
        }

        protected override string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.GetInfo());
            if (this.cabinaSimple)
            {
                sb.Append("Con cabina simple");
            }
            sb.Append("Con cabina doble");

            return sb.ToString();
        } 


    }
}
