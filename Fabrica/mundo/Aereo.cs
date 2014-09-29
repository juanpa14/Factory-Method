using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fabrica.mundo
{
    class Aereo : TipoTransporte
    {
        public override void llegada()
        {
            Console.WriteLine("El vehículo aereo ha llegado a su destino");
        }

        public override void partida()
        {
            Console.WriteLine("El vehículo aereo ha partido a su destino");
        }
    }
}
