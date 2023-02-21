namespace ProjetoTargetSystem
{
    public class Exercicio2
    {
        public Exercicio2()
        {
            int result = 0;
            Console.WriteLine("Insira um numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int prevfibo = 0;
            int fibo = 1;
            for (int i = 0; i <= 20; i++)
            {
                result = prevfibo + fibo;
                prevfibo = fibo;
                fibo = result;
                if(fibo == num)
                {
                Console.WriteLine("O numero {0} pertence a escala fibonacci ;)", num);
                return;
                }
            }
            Console.WriteLine("O seu numero não pertence a escala fibonacci ;-;");
        }
    }
    
}