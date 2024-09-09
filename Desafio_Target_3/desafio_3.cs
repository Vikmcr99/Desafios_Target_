using System;
using System.Linq;

class desafio_3
{
    static void Main(string[] args)
    {
        decimal[] faturamento = new decimal[365];
        Random random = new Random();

        for (int i = 0; i < faturamento.Length; i++)
        {
            if (i < 0 || i >= faturamento.Length)
            {
                throw new IndexOutOfRangeException($"Índice {i} está fora dos limites do array.");
            }

            //faturamento aleatorio entre 0 e 3000
            faturamento[i] = (decimal)(random.NextDouble() * 3000);
        }

        // faturamento > 0
        var diasComFaturamento = faturamento.Where(valor => valor > 0).ToArray();

        // menor valor de faturamento
        decimal menorValor = diasComFaturamento.Min();

        // maior valor de faturamento
        decimal maiorValor = diasComFaturamento.Max();

        // média anual(somente dias validos)
        decimal mediaAnual = diasComFaturamento.Average();

        // faturamento acima da média anual
        int diasAcimaDaMedia = diasComFaturamento.Count(valor => valor > mediaAnual);

        Console.WriteLine($"Menor valor de faturamento: {menorValor:F2}");
        Console.WriteLine($"Maior valor de faturamento: {maiorValor:F2}");
        Console.WriteLine($"Número de dias com faturamento acima da média anual: {diasAcimaDaMedia}");
    }
}
