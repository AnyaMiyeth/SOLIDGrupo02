using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDGrupo02
{
    class Program
    {
        static void Main(string[] args)
        {
            //FormatoExcelService formatoExcel = new FormatoExcelService();
            //FormatoPDFService formatoPDF = new FormatoPDFService();
            //FormatoXMLService formatoXML = new FormatoXMLService();
            //ImpresionService impresion= new ImpresionService(formatoXML);
            //Console.WriteLine(impresion.Imprimir());

            IPersistencia persistencia = new CompraSQLData();
            IMetodoPago metodo = new TarjetaDebito();
            CanastaCompra canasta = new CanastaCompra(persistencia, metodo);
            Compra compra = new Compra();
            Console.WriteLine(canasta.Comprar(compra));
            Console.ReadKey();
        }
    }
}
