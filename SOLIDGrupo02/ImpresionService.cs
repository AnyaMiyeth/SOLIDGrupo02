using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDGrupo02
{
    public class ImpresionService
    {
        IFormato formato;
        public ImpresionService(IFormato formatoRecibido)
        {
            formato = formatoRecibido;
        }
        public string Imprimir()
        {
            return formato.Generar() + " Yo Imprimo";
            
        }

       
    }
}
