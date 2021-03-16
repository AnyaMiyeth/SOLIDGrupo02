using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDGrupo02
{
    public class TarjetaCredito:IMetodoPago
    {
        public string Pagar(Compra compra) {
            return " Pagué con tarjeta de Crédito";
        }
    }
}
