using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Arquivo
    {
        protected IGeraArquivo _geraArquivo;
        public Arquivo(IGeraArquivo geraArquivo)
        {
            _geraArquivo = geraArquivo;
        }

        public void GravaArquivo(Funcionario func) 
        {
           _geraArquivo.GerarArquivo(func);
        }
    }
}
