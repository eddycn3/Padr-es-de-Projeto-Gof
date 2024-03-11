using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class GeraXML : IGeraArquivo
    {
        public void GerarArquivo(Funcionario func)
        {
            Console.WriteLine($"Dados funcionário em XML: Nome {func.Nome} \n");
        }
    }
}
