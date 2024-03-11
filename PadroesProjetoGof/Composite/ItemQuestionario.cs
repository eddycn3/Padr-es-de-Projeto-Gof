using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class ItemQuestionario
    {
        protected string Descricao { get; set; }

        protected ItemQuestionario(string descricao)
        {
            Descricao = descricao;
        }

        public abstract void Exibir();

    }
}
