

namespace ProjetoTargetSystem
{
    public class Exercicio5
    {
        public Exercicio5()
        {
            Console.WriteLine("Digite uma palavra ou uma frase: ");
            string word = Console.ReadLine();

            string reverseWord = string.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverseWord += word[i];
            }

            Console.WriteLine(reverseWord);
        }
    }
}