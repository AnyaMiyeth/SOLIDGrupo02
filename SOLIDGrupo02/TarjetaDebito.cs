using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDGrupo02
{
    public class TarjetaDebito : IMetodoPago
    {
        public string Pagar(Compra compra)
        {
           return " Yo pago con tarjeta debito";
        }
    }
}
