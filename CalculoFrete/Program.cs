using System;

class Programa {
    static void Main() {
        // Solicita a distância e o peso do produto ao usuário
        Console.WriteLine("Informe a distância em km entre o distribuidor e o local de entrega:");
        int distancia = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o peso do produto em kg:");
        double peso = double.Parse(Console.ReadLine());

        // Calcula o valor base do frete
        double valorFrete = distancia * 0.10;

        // Adiciona taxa a cada 200 km
        valorFrete += (distancia / 200) * 1.00;

        // Adiciona taxa a cada 1000 km
        valorFrete += (distancia / 1000) * 10.00;

        // Ajusta o frete com base no peso do produto
        if (peso > 5 && peso <= 25) {
            valorFrete *= 5;  // Multiplica por 5 para produtos entre 5 kg e 25 kg
        }
        else if (peso > 25 && peso <= 75) {
            valorFrete *= 3;  // Multiplica por 3 para produtos entre 25 kg e 75 kg
        }
        // Para produtos até 5 kg, o valor do frete permanece o mesmo

        // Exibe o valor final do frete
        Console.WriteLine($"O valor do frete é: R$ {valorFrete:F2}");
    }
}

