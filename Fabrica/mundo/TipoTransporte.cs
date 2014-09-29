using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fabrica.mundo
{
    abstract class TipoTransporte
    {
        abstract public void llegada();

        abstract public void partida();
    }
}
