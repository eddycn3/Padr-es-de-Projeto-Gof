using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Grupo : ItemQuestionario
    {
        private IList<ItemQuestionario> _itens = new List<ItemQuestionario>(); 
        public Grupo(string descricao) : base(descricao)
        {}

        public void Add(ItemQuestionario item)
        {
            _itens.Add(item);
        }

        public void Remove(ItemQuestionario item)
        {
            _itens.Remove(item);
        }

        public override void Exibir()
        {
           Console.WriteLine($"Grupo: {Descricao}");
           foreach (ItemQuestionario item in _itens) 
           { 
               item.Exibir();
           }
        }
    }
}
