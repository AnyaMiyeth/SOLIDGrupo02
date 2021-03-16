using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDGrupo02
{
    public class FormatoExcelService:IFormato
    {
        DocumentoService documento = new DocumentoService();
        public string Generar()
        {
            return documento.CrearDocumento() + " Yo construyo un Objeto EXcel con la Informacion";
        }
    }
}
