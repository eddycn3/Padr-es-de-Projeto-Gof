using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Espresso : ICafe
    {
        public string Descricao()
        {
            return "Café Expresso";
        }

        public decimal Preco()
        {
            return 5.0M;
        }
    }
}
