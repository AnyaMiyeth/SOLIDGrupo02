using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDGrupo02
{
    public class CompraSQLData:IPersistencia
    {
        public string Guardar(Compra compra) {
            return "Guarde en Base de Datos";
        }
    }
}
