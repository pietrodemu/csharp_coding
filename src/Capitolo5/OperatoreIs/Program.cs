using System;

namespace OperatoreIs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilizzo dell'operatore Is
            object obj = 1;
            if (obj is int)
                System.Console.WriteLine("obj is int");

            // PATTERN MATCHING CON IS

            // Pattern Type: espr is tipo var
            object obj2 = "Hello";
            if (obj2 is string str)
                System.Console.WriteLine($"{str} e' composta da {str.Length} caratteri");

            // Pattern Const: espr is costante
            // Es.1
            var x = "";
            bool test = x is null; //false
            // Es.2
            DayOfWeek gg = DateTime.Today.DayOfWeek;
            bool festivo = gg is DayOfWeek.Sunday; //true se oggi e' domenica

            // Pattern ricorsivi: Annidare pattern all'interno di un pattern principale
            object obj3 = new Customer() { Name = "Pietro", Telephone = "347" };
            if (obj3 is Customer {Telephone: string tel} customer && tel.StartsWith("347"))
            {
                System.Console.WriteLine($"Nome: {customer.Name}"); //stampa Nome: Francy
            }
        }       
    }
    public class Customer { public string Name, Telephone; }
}
