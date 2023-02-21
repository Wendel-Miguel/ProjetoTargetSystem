// See https://aka.ms/new-console-template for more information
using System;
namespace ProjetoTargetSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escolha um exercicio do 1 ao 5: ");
            int ex = Convert.ToInt32(Console.ReadLine());
            switch(ex)
            {
                case 1:
                    Console.WriteLine("O resultado da soma é 91");
                    break;
                case 2:
                    Exercicio2 ex2 = new Exercicio2();
                    break;
                case 3: 
                    Exercicio3 ex3 = new Exercicio3();
                    break;
                case 4:
                    Exercicio4 ex4 = new Exercicio4();
                    break;
                case 5:
                    Exercicio5 ex5 = new Exercicio5();
                    break;
                default:
                    Console.WriteLine("[Erro] Escolha um exercício existente!");
                    break;
            }
        }
    }
}
