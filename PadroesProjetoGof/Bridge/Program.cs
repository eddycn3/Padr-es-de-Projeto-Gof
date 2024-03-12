// See https://aka.ms/new-console-template for more information
using Bridge;

class Program
{
    static void Main(string[] args)
    {

        var funcionarios = new List<Funcionario>
        {
            new () { Id = 1,Nome = "Duardo", SalarioBase = 100, Incentivo=500 },
            new () { Id = 2,Nome = "Melin", SalarioBase = 250, Incentivo=500 },
            new () { Id = 3,Nome = "Jade", SalarioBase = 500, Incentivo=50 },
        };

        var gerarArquivoJson = new CalculaSalario(new GeraJson());
        var gerarArquivoXML = new CalculaSalario(new GeraXML());

        foreach (var f in funcionarios)
        {
            gerarArquivoJson.ProcessaSalarioFuncionario(f);
            gerarArquivoXML.ProcessaSalarioFuncionario(f);
        }
    }
}