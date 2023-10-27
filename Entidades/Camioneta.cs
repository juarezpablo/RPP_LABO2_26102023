using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta:Vehiculo
    {
        private bool cabinaSimple;
        protected override string Tipo { get { return "Camioneta"; } }

        public Camioneta(EPropulsion propulsion, bool cabinaSimple)
        {
            base.esAWD = true;
            this.cabinaSimple = cabinaSimple;
        }
        protected override string GetInfo()
        {
            string cabina;
            StringBuilder sb = new StringBuilder();
            if (cabinaSimple)
            {
                cabina = "Simple";
            }
            else { cabina = "Doble"; }
            sb.Append(base.GetInfo());
            sb.Append($", con cabina {cabina} ");
            return sb.ToString();
        }
    }
}
