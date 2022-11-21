using System;
using System.Collections.Generic;
using System.Text;

namespace Pack_Turistico.Clases
{
    public class PackTuristico
    {
        public string nombre;
        private double precioInicial;
        public string continenteDestino;
        public int cantidadPersonas;
        public string tieneReserva;
        public int cantidadDias;
        public string medioTransporte;



        public double PrecioInicial { get => precioInicial; set => precioInicial = value; }

        public void VerificarDestino()
        {
            if (continenteDestino == "america")
            {
                PrecioInicial *= 0.95;
            }
        }

        public void MultiplicarPorCantidadDePersonas()
        {
            PrecioInicial = PrecioInicial * cantidadPersonas;
        }

        public void DescuentoPorSeña()
        {

            if (tieneReserva == "si")
            {
                PrecioInicial *= 0.95;
            }
        }

        public void MedioDeTransporte()
        {

            if (medioTransporte == "tierra")
            {
                PrecioInicial *= 1.3;
            }
            else if (medioTransporte == "aire")
            {
                PrecioInicial *= 1.4;
            }
            else if (medioTransporte == "mar")
            {
                PrecioInicial *= 1.5;
            }

        }




    }


}
