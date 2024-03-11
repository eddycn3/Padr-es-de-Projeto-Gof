using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal interface IGrafico
    {
        public string Titulo { get; set; }
        public List<string> XValores { get; set; }
        public List<int> YValores { get; set; }

        void GerarGrafico(string titulo, List<string> x, List<int> y);
    }
}
