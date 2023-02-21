using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ProjetoTargetSystem
{
    public class Exercicio3
    {
        public Exercicio3()
        {
            List<Faturamento> faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(File.ReadAllText(@"dados.json"));
            
            double media = 0;
            int indexMenorFaturamento = 0;
            int indexMaiorFaturamento = 0;
            List<int>indexMaioresFaturamentos = new List<int>();

            foreach (var item in faturamentos)
            {
                media += item.Valor;
            }
            media = media / faturamentos.Where(x => x.Valor > 0).Count();

            for (int i = 1; i < faturamentos.Count(); i++)
            {
                if(faturamentos[i].Valor > 0)
                {
                    if(faturamentos[i].Valor < faturamentos[indexMenorFaturamento].Valor)
                        indexMenorFaturamento = i;
                    if(faturamentos[i].Valor > faturamentos[indexMaiorFaturamento].Valor)
                        indexMaiorFaturamento = i;
                    if(faturamentos[i].Valor > media)
                        indexMaioresFaturamentos.Add(i);
                }
            }

            Console.WriteLine("O dia com menor faturamento foi dia: {0} com o total de faturamento de: R${1}", faturamentos[indexMenorFaturamento].Dia, faturamentos[indexMenorFaturamento].Valor);
            Console.WriteLine("O dia com maior faturamento foi dia: {0} com o total de faturamento de: R${1}", faturamentos[indexMaiorFaturamento].Dia, faturamentos[indexMaiorFaturamento].Valor);
            Console.WriteLine("Este mês tiveram {0} dias com o faturamento acima da média", indexMaioresFaturamentos.Count());
        }

    }

    public class Faturamento
    {
        public int Dia;
        public double Valor;
    }
}