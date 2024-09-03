using System;

class Program
{
    static void Main()
    {
        // Opção para escolher qual funcionalidade utilizar
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1. Verificar se um número pertence à sequência de Fibonacci");
        Console.WriteLine("2. Contar a ocorrência da letra 'a' em uma string");
        Console.WriteLine("3. Calcular a soma dos números de 1 até um índice definido");
        Console.Write("Digite o número da opção escolhida: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                CheckFibonacci();
                break;
            case "2":
                CountLetterA();
                break;
            case "3":
                CalculateSum();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }

    // Método para verificar se um número pertence à sequência de Fibonacci
    static void CheckFibonacci()
    {
        Console.WriteLine("Digite um número para verificar se ele pertence à sequência de Fibonacci:");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            if (IsFibonacci(num))
            {
                Console.WriteLine($"{num} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{num} não pertence à sequência de Fibonacci.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, insira um número válido.");
        }
    }

    // Função para verificar se um número pertence à sequência de Fibonacci
    static bool IsFibonacci(int num)
    {
        if (num < 0)
        {
            return false;
        }

        int a = 0;
        int b = 1;

        if (num == a || num == b)
        {
            return true;
        }

        while (b <= num)
        {
            int next = a + b;
            a = b;
            b = next;

            if (b == num)
            {
                return true;
            }
        }

        return false;
    }

    // Método para contar a ocorrência da letra 'a'
    static void CountLetterA()
    {
        Console.WriteLine("Digite uma string para verificar a ocorrência da letra 'a':");
        string input = Console.ReadLine();

        int count = CountOccurrencesOfA(input);

        if (count > 0)
        {
            Console.WriteLine($"A letra 'a' (maiúscula ou minúscula) ocorre {count} vez(es) na string.");
        }
        else
        {
            Console.WriteLine("A letra 'a' (maiúscula ou minúscula) não ocorre na string.");
        }
    }

    // Função para contar as ocorrências da letra 'a'
    static int CountOccurrencesOfA(string input)
    {
        int count = 0;

        if (string.IsNullOrEmpty(input))
        {
            return count;
        }

        string lowerInput = input.ToLower();

        foreach (char c in lowerInput)
        {
            if (c == 'a')
            {
                count++;
            }
        }

        return count;
    }

    // Método para calcular a soma dos números
    static void CalculateSum()
    {
        int INDICE = 12;
        int SOMA = 0;
        int K = 1;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine($"A soma dos números de 1 até {INDICE - 1} é {SOMA}.");
    }
}

// 4) Descubra a lógica e complete o próximo elemento:
//
// a) 1, 3, 5, 7, (9)
// b) 2, 4, 8, 16, 32, 64, (128)
// c) 0, 1, 4, 9, 16, 25, 36, (49)
// d) 4, 16, 36, 64, (100)
// e) 1, 1, 2, 3, 5, 8, (13)
// f) 2,10, 12, 16, 17, 18, 19, (20)


//5) descobrir qual interruptor controla cada lâmpada
// Primeiro, eu ligaria os Interruptores 1 e 2 e os deixaria ligados por alguns minutos. Depois, desligaria o Interruptor 1 e manteria o Interruptor 2 ligado. Em seguida, eu iria até a primeira sala. Se a lâmpada estiver acesa, isso significa que ela é controlada pelo Interruptor 2. Se estiver apagada, a lâmpada pode ser controlada pelo Interruptor 1 (se estiver quente ao tocar) ou pelo Interruptor 3 (se nunca foi ligada).

// Depois, eu iria à segunda sala. Se a lâmpada estiver acesa, ela é controlada pelo Interruptor 2. Se estiver apagada, então a lâmpada na segunda sala é controlada pelo Interruptor 3, e a lâmpada na primeira sala que estava apagada e quente é controlada pelo Interruptor 1. A lâmpada na terceira sala será a que resta.