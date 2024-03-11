using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class LeiteDecorator : OpcionalDecorator
    {
        public LeiteDecorator(ICafe cafe) : base(cafe)
        {}

        public override string Descricao()
        {
            var descricao = base.Descricao();
            return descricao + "\r\n com Leite";
        }


        public override decimal Preco()
        {
            var preco = base.Preco();
            return preco + 5.0M;
        }


    }
}
