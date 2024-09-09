using System;

class desafio_2
{
    static void Main(string[] args)
    {
        int[] sequenciaA = { 1, 3, 5, 7 };
        int proximoA = sequenciaA[sequenciaA.Length - 1] + 2; // incremento de 2

        int[] sequenciaB = { 2, 4, 8, 16, 32, 64 };
        int priximoB = sequenciaB[sequenciaB.Length - 1] * 2; // multiplicação por 2

        int[] sequenciaC = { 0, 1, 4, 9, 16, 25, 36 };
        int proximoC = (sequenciaC.Length) * (sequenciaC.Length); // quadrado dos numeros 

        int[] sequenciaD = { 4, 16, 36, 64 };
        int proximoD = ((sequenciaD.Length + 1) * 2) * ((sequenciaD.Length + 1) * 2); // quadrados dos pares

        int[] sequenciaE = { 1, 1, 2, 3, 5, 8 };
        int proximoE = sequenciaE[sequenciaE.Length - 1] + sequenciaE[sequenciaE.Length - 2]; //Fibonacci

        int[] sequenciaF = { 2, 10, 12, 16, 17, 18, 19 }; //começa com d
        int proximoF = 200;

        Console.WriteLine("a) Próximo elemento: " + proximoA);
        Console.WriteLine("b) Próximo elemento: " + priximoB);
        Console.WriteLine("c) Próximo elemento: " + proximoC);
        Console.WriteLine("d) Próximo elemento: " + proximoD);
        Console.WriteLine("e) Próximo elemento: " + proximoE);
        Console.WriteLine("f) Próximo elemento: " + proximoF);
    }
}
