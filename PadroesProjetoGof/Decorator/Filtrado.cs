using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Filtrado : ICafe
    {
        public string Descricao()
        {
            return "Café filtrado";
        }

        public decimal Preco()
        {
            return 3.0M;
        }
    }
}
