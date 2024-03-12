// See https://aka.ms/new-console-template for more information
using Composite;
class Program
{
    static void Main(string[] args)
    {
        var GrupoA = new Grupo("A) Portugês");
        var questao1 = new Questao("Quando usamos a crase?");
        var questao2 = new Questao("Quando usamos a acento?");
        GrupoA.Add(questao1);
        GrupoA.Add(questao2);

        var GrupoB = new Grupo("A) Fisica");
        var questao3 = new Questao("Quando uma estrela morre?");
        var questao4 = new Questao("Quanto tempo tem o tempo?");
        GrupoB.Add(questao3);
        GrupoB.Add(questao4);

        var grupoRaiz = new Grupo("Questionário");
        grupoRaiz.Add(GrupoA);
        grupoRaiz.Add(GrupoB);
        grupoRaiz.Exibir();
        Console.ReadKey();
    }
}