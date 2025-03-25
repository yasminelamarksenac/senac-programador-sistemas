
using System;

class Program
{
    static void Main()
    {
        int INDICE = 13, SOMA = 0, K = 0;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine("Valor da variável SOMA: " + SOMA);

      
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        if (PertenceFibonacci(num))
            Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"O número {num} não pertence à sequência de Fibonacci.");

      
        double[] faturamento = { 15.5, 23.0, 12.4, 0, 34.1, 50.2, 0, 48.3, 27.8, 35.6 };
        List<double> valores = new List<double>();

        foreach (double valor in faturamento)
        {
            if (valor > 0)
                valores.Add(valor);
        }

        double menorValor = valores.Min();
        double maiorValor = valores.Max();
        double mediaMensal = valores.Average();
        int diasAcimaDaMedia = valores.Count(v => v > mediaMensal);

        Console.WriteLine($"Menor faturamento: {menorValor}");
        Console.WriteLine($"Maior faturamento: {maiorValor}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");

      
        Dictionary<string, double> faturamentoEstados = new Dictionary<string, double>
        {
            {"SP", 67836.43},
            {"RJ", 36678.66},
            {"MG", 29229.88},
            {"ES", 27165.48},
            {"Outros", 19849.53}
        };

        double totalFaturamento = faturamentoEstados.Values.Sum();

        foreach (var estado in faturamentoEstados)
        {
            double percentual = (estado.Value / totalFaturamento) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }

    
        Console.Write("Digite uma string: ");
        string inputString = Console.ReadLine();
        Console.WriteLine("String invertida: " + InverterString(inputString));
    }

    static bool PertenceFibonacci(int n)
    {
        int a = 0, b = 1;
        while (b < n)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        return b == n || n == 0;
    }

    static string InverterString(string s)
    {
        string invertida = "";
        for (int i = s.Length - 1; i >= 0; i--)
        {
            invertida += s[i];
        }
        return invertida;
    }
}

