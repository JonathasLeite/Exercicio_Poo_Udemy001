using System;


namespace POO
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

       public void SalarioMaior()
        {
            var s1 = this.Salario;
            var s2 = this.Salario;

            if (s1 > s2)
            {
                Console.WriteLine($"Sálario maior: {Nome}");
            }
            else
            {
                Console.WriteLine($"Sálario maior: {Nome}");
            }
            
        }
    }
}
