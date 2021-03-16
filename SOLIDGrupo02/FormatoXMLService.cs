using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDGrupo02
{
    public class FormatoXMLService : IFormato
    {
        DocumentoService documento = new DocumentoService();
        public string Generar()
        {
            return documento.CrearDocumento()+" Lo cosntruya en XML";
        }
    }
}
