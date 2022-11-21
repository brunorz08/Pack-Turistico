using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Pack_Turistico.Clases
{
    public class Aplicacion
    {
        public Aplicacion()
        {
            PackTuristico pack = new PackTuristico();
            PrecioTotalPack total = new PrecioTotalPack();

            Console.WriteLine("Bienvenido al sistema de reservas turísticas de ISTEA 2000");
            Console.Write("Cargando por favor espere");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Thread.Sleep(300);
            }
           
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("A continuación ingrese los siguientes datos:");

            Console.Write("Nombre del pack turístico: ");
            pack.nombre = Console.ReadLine();

            Console.Write("Precio del pack: ");
            pack.PrecioInicial = Convert.ToInt32(Console.ReadLine());

            Console.Write("Continente destino (America, Europa, Asia, Oceanía, África): ");
            pack.continenteDestino = (Console.ReadLine()).ToLower();

            Console.Write("Cantidad de personas: ");
            pack.cantidadPersonas = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿Posee reserva? Limitese a responder SI/NO: ");
            pack.tieneReserva = (Console.ReadLine()).ToLower();

            Console.Write("Cantidad de días: ");
            pack.cantidadDias = Convert.ToInt32(Console.ReadLine());

            Console.Write("Medio de transporte (tierra, aire o mar): ");
            pack.medioTransporte = (Console.ReadLine()).ToLower();
            Console.Clear();

            Console.WriteLine("Se detallan los datos ingresados:");

            Console.WriteLine($"Nombre del pack:{pack.nombre}:");
            Console.WriteLine($"Precio del pack: {pack.PrecioInicial}");
            Console.WriteLine($"Continente destino: {pack.continenteDestino}");
            Console.WriteLine($"Cantidad de personas: {pack.cantidadPersonas}");
            Console.WriteLine($"¿Posee reserva?: {pack.tieneReserva}");
            Console.WriteLine($"Cantidad de días contratados: {pack.cantidadDias}");
            Console.WriteLine($"Medio de transporte: {pack.medioTransporte}");
            Console.WriteLine();

            Console.Write("¿Los datos son correctos? Limitese a responder SI/NO: ");
            string opcion = Console.ReadLine().ToLower();

            if (opcion == "si")
            {

                pack.VerificarDestino();
                pack.MultiplicarPorCantidadDePersonas();
                pack.DescuentoPorSeña();
                pack.MedioDeTransporte();

                Console.Write($"El precio final del paquete turístico es de ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"${(total.informarPrecioFinal(pack.PrecioInicial))}.");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.WriteLine("Gracias por utilizar nuestro sistema de reservas");
            Console.WriteLine("Presione enter para continuar");
            Console.ReadKey();
            Console.WriteLine();
            Console.Write("Cerrando");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Thread.Sleep(300);
            }

        }
    }
}
