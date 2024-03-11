using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ChocolateDecorator : OpcionalDecorator
    {
        public ChocolateDecorator(ICafe cafe) : base(cafe)
        {}

        public override string Descricao()
        {
            var descricao =  base.Descricao();
            return descricao + "\r\n com Chocolate";
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            return preco + 8.0M;
        }


    }
}
