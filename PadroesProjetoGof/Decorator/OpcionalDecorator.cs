using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class OpcionalDecorator : ICafe
    {
        private readonly ICafe _cafe;
        protected OpcionalDecorator(ICafe cafe)
        {
            _cafe = cafe;
        }

        public virtual string Descricao()
        {
            return _cafe.Descricao();
        }

        public virtual decimal Preco()
        {
            return _cafe.Preco();
        }
    }
}
