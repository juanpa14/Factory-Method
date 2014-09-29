using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fabrica.mundo
{
    class Maritimo : TipoTransporte
    {
        public override void llegada()
        {
            Console.WriteLine("El vehículo maritimo ha llegado a su destino");
        }

        public override void partida()
        {
            Console.WriteLine("El vehículo maritimo ha partido a su destino");
        }
    }
}
