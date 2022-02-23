using System;

namespace Area_Circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, pi = 3.1416, area;
            Console.WriteLine("Qual o valor do raio?");
            raio = double.Parse(Console.ReadLine());
            area = pi * raio * raio;
            Console.WriteLine("A area do circulo e : {0}", area);
        }
    }
}
