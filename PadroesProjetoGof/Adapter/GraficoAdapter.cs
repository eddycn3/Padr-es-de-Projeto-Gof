using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class GraficoAdapter : IGrafico
    {
        public string Titulo { get; set; }
        public List<string> XValores { get; set; }
        public List<int> YValores { get; set; }

        private readonly SuperGeradorGrafico superGeradorGrafico = new SuperGeradorGrafico();
        public void GerarGrafico(string titulo, List<string> x, List<int> y)
        {
            superGeradorGrafico.DesenharGrafico(titulo, x, y);
        }
    }
}
