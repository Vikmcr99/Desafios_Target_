using System;

class desafio_5
{
    static void Main()
    {
       
        double totalDistancia = 125; 
        double velocidadeCarro = 90; 
        double velocidadeCaminhao = 80; 

     
        int qtPedaios = 3;
        double tempoPedagio = 5.0 / 60.0; // transformando o tempo de pedagio em hora
        double tempoAdicionalCarro = qtPedaios * tempoPedagio;

        
        double velocidadeSomada = velocidadeCarro + velocidadeCaminhao;


        double tempoParaCruzarem = totalDistancia / velocidadeSomada; // (t = d / v)

        double distanciaPercorridaCarro = velocidadeCarro * (tempoParaCruzarem + tempoAdicionalCarro); //dISTANCIA = VELOCIDADE X TEMPO -> no caso do carro somando o tempo dos pedagios também

        double distanciaPercorridaCaminhao = velocidadeCaminhao * tempoParaCruzarem; 

        double distanciaCarroRibeiraoPreto = distanciaPercorridaCarro; // O que ele andou é justamente a distancia de Ribeirao Preto. Ja que ele saiu de la.
        double distanciaCaminhaoRibeiraoPreto = totalDistancia - distanciaPercorridaCaminhao;

       
        Console.WriteLine($"Distância do carro para Ribeirão Preto é: {distanciaCarroRibeiraoPreto:F2} km");
        Console.WriteLine($"Distância do caminhão para Ribeirão Preto é: {distanciaCaminhaoRibeiraoPreto:F2} km");

       
        if (distanciaCarroRibeiraoPreto == distanciaCaminhaoRibeiraoPreto)
        {
            Console.WriteLine(" Os veículos estão à mesma distância de Ribeirão Preto no momento do cruzamento.");
        }
        else if (distanciaCarroRibeiraoPreto < distanciaCaminhaoRibeiraoPreto)
        {
            Console.WriteLine("O carro está mais próximo.");
        }
        else
        {
            Console.WriteLine("O caminhão está mais próximo.");
        }
    }

    // EXPLICAÇÂO: 
}
