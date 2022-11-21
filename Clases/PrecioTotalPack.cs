using System;
using System.Collections.Generic;
using System.Text;

namespace Pack_Turistico.Clases
{
    public class PrecioTotalPack
    {
        
        private double precioFinal;

        private double PrecioFinal { get => precioFinal; set => precioFinal = value; }

        public double informarPrecioFinal(double precioInicial)
        {
            PrecioFinal = Math.Round(precioInicial, 2);
            return PrecioFinal;
        }

    }
}
