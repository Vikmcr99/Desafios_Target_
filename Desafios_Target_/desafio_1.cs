using System;

class desafio_1
{
    static void Main(string[] args)
    {
        int INDICE = 12;
        int SOMA = 0;
        int K = 1;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine("O valor final da variavel SOMA é: " + SOMA);
    }
}
