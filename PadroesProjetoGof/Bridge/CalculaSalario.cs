using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class CalculaSalario : Arquivo
    {
        public CalculaSalario(IGeraArquivo geraArquivo) : base(geraArquivo)
        {
        }

        public void ProcessaSalarioFuncionario(Funcionario func) 
        {
            func.SalarioTotal = func.SalarioBase + func.Incentivo;
            Console.WriteLine($"Valor do salário para o funcionario {func.Nome} R$ {func.SalarioTotal}");
            _geraArquivo.GerarArquivo(func);
        }
    }
}
