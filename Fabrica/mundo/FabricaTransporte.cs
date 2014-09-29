using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fabrica.mundo
{
    class FabricaTransporte
    {
        public FabricaTransporte()
        {

        }

        public TipoTransporte crearTransporte(int tipo)
        {
            TipoTransporte transporte;
            if (tipo == 1)
                transporte = new Aereo();
            else if (tipo == 2)
                transporte = new Maritimo();
            else if (tipo == 3)
                transporte = new Terrestre();
            else
                transporte = null;
            return transporte;
        }
    }
}
