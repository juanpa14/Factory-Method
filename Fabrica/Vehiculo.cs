using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fabrica.mundo;

namespace Fabrica
{
    class Vehiculo
    {
        static void Main()
        {
            Console.WriteLine("Seleccione el tipo de transporte en el que desea envíar la mercancia");
            Console.WriteLine("Aereo = 1");
            Console.WriteLine("Maritimo = 2");
            Console.WriteLine("Terrestre = 3");
            int tipo = Convert.ToInt32(Console.ReadLine());
            FabricaTransporte fabrica = new FabricaTransporte();

            TipoTransporte transporte = fabrica.crearTransporte(tipo);
            if (transporte != null)
                transporte.partida();
            else
                Console.WriteLine("No ha seleccionado el tipo de transporte para envío de mercancia");
        }
    }
}
