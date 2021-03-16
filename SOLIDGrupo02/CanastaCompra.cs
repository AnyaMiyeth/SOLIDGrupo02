using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDGrupo02
{
    public class CanastaCompra
    {
        IMetodoPago metodoPago;
        IPersistencia persistencia;
        public CanastaCompra(IPersistencia _persistencia, IMetodoPago _metodoPago)
        {
            metodoPago = _metodoPago;
            persistencia = _persistencia;
        }

        public string Comprar(Compra compra)
        {
            string mensaje = "";
            ;
            mensaje= persistencia.Guardar(compra);
            TarjetaCredito tarjeta = new TarjetaCredito();
            mensaje+= metodoPago.Pagar(compra);
            return mensaje;
        }

    }
}
