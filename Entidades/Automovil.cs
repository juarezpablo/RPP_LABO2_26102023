﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil:Vehiculo
    {
        protected override string Tipo { get { return "Automovil"; } }
        public Automovil() {
            this.propulsion = EPropulsion.Hibrida;
        }

    }
}
