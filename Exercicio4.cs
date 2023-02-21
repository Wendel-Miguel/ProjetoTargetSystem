using System;
using System.Collections.Generic;

namespace ProjetoTargetSystem
{
    public class Exercicio4
    {
        private Dictionary<string, decimal> estados;
        public Exercicio4()
        {
            estados = new Dictionary<string, decimal>();
            estados.Add("SP", decimal.Parse("67.836,43"));
            estados.Add("RJ", decimal.Parse("36.678,66"));
            estados.Add("MG", decimal.Parse("29.229,88"));
            estados.Add("ES", decimal.Parse("27.165,48"));
            estados.Add("Outros", decimal.Parse("19.849,53"));

            decimal total = 0;
            foreach (var estado in estados)
            {
                total += estado.Value;
            }
            foreach (var estado in estados)
            {
                Console.WriteLine("O estado {0} representa {1}% do faturamento mensal.", estado.Key, ((estado.Value/total)*100).ToString("N2"));
            }
        }
    }
}