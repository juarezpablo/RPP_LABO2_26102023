using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected bool esAWD;
        protected Guid numeroDeChasis;
        protected EPropulsion propulsion;

        public EPropulsion Propulsion
        {
            get { return this.propulsion; }
        }
        
        public Vehiculo()
        {
             this.numeroDeChasis = new Guid();
        }
        public Vehiculo(EPropulsion propulsion) 
        { 
            this.propulsion = propulsion;
            this.esAWD = false;
        }
        public Vehiculo(EPropulsion propulsion, bool esAWD)
        {
            this.esAWD = esAWD;

        }
        protected abstract string Tipo { get; }
        
        protected virtual string GetInfo()
        {
            string salida = String.Format("{0} con propulsion a {1}, {2} es AWD, numero de chasis {3}",this.Tipo,this.Propulsion,this.esAWD,this.numeroDeChasis);
            return salida;
        }

        public override string ToString()
        {
            return this.GetInfo();
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return ((v1.GetType == v2.GetType) && v1.numeroDeChasis == v2.numeroDeChasis);
        }
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return ((v1.GetType == v2.GetType) && v1.numeroDeChasis == v2.numeroDeChasis);
           
        }

    }
}
