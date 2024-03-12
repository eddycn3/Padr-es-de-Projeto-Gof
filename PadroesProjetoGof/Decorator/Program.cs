// See https://aka.ms/new-console-template for more information

using Decorator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n------- Sem adicionais: ------");
        ICafe cafeExpresso = new Espresso();
        Console.WriteLine(cafeExpresso.Descricao());
        Console.WriteLine(cafeExpresso.Preco());

        ICafe cafeFiltrado = new Filtrado();
        Console.WriteLine(cafeFiltrado.Descricao());
        Console.WriteLine(cafeFiltrado.Preco());



        Console.WriteLine("\n------- (Decorator) Com adicionais: ------");

        ICafe expressoComLeite = new LeiteDecorator(cafeExpresso);
        ICafe expressoChocolate = new ChocolateDecorator(expressoComLeite);

        Console.WriteLine(expressoChocolate.Descricao());
        Console.WriteLine($"Valor total: R$ {expressoChocolate.Preco()}");
    }
}