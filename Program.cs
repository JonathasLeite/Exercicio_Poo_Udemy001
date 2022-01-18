using System;
using System.Globalization;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pe = new Pessoa();

            var p1 = pe;
            Console.WriteLine("Dados da Primeira pessoa:");
            Console.Write("Nome:");            
            p1.Nome = Console.ReadLine();
            Console.Write("Sálario: ");
            p1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            var p2 = pe;
            Console.WriteLine("Dados da Segunda pessoa");
            Console.Write("Nome:");
            p2.Nome = Console.ReadLine();
            Console.Write("Sálario:");
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            pe.SalarioMaior();
        }
    }
}
