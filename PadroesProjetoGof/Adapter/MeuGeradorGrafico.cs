using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class MeuGeradorGrafico
    {
        public string Titulo { get; set; }
        public List<string> XValores { get; set; }
        public List<int> YValores { get; set; }
        public void GerarGrafico(string titulo, List<string> x, List<int> y)
        {
            Console.WriteLine("MeuGeradorGrafico: Gerando Gráfico");
        }
    }
}
