using System;

class Program
{
    public static void Main(string[] args)
    {
        // Atividade 1 - Imprimir Hello e seu nome em linhas separadas
        Console.WriteLine("=== Atividade 1 ===");
        Console.WriteLine("Hello");
        Console.WriteLine("Júllia"); // Substitua pelo seu nome
        Console.WriteLine();

        // Atividade 2
        Console.WriteLine("=== Atividade 2 ===");
        Console.WriteLine(20 + 80);
        Console.WriteLine();

        // Atividade 3
        Console.WriteLine("=== Atividade 3 ===");
        Console.WriteLine(90 / 2);
        Console.WriteLine();

        // Atividade 4 
        Console.WriteLine("=== Atividade 4 ===");
        Console.WriteLine(-1 + 4 * 6);
        Console.WriteLine((35 + 5) % 7);
        Console.WriteLine(14 + -4 * 6 / 11);
        Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        Console.WriteLine();

        // Atividade 5 - Trocar números
        Console.WriteLine("=== Atividade 5 ===");
        Console.WriteLine("Algoritmo para Trocar números inteiros");
        Console.Write("Informe o primeiro número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine()!);
        Console.Write("Informe o segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine()!);
        Console.WriteLine($"\nAntes de fazer a troca: numero1 = {numero1}, numero2 = {numero2}");
        
        int temp = numero1;
        numero1 = numero2;
        numero2 = temp;
        
        Console.WriteLine($"Depois de fazer a troca: numero1 = {numero1}, numero2 = {numero2}\n");

        // Atividade 6 - Multiplicação de 3 números
        Console.WriteLine("=== Atividade 6 ===");
        Console.WriteLine("Algoritmo para multiplicar três números inteiros");
        Console.Write("Informe o primeiro número: ");
        int mult1 = Convert.ToInt32(Console.ReadLine()!);
        Console.Write("Informe o segundo número: ");
        int mult2 = Convert.ToInt32(Console.ReadLine()!);
        Console.Write("Informe o terceiro número: ");
        int mult3 = Convert.ToInt32(Console.ReadLine()!);
        Console.WriteLine($"\nResultado: {mult1} * {mult2} * {mult3} = {mult1 * mult2 * mult3}\n");

        // Atividade 7 - 4 operações
        Console.WriteLine("=== Atividade 7 ===");
        Console.Write("Informe o primeiro número: ");
        float num1 = float.Parse(Console.ReadLine()!);
        Console.Write("Informe o segundo número: ");
        float num2 = float.Parse(Console.ReadLine()!);
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        if (num2 != 0)
        {
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
        }
        else
        {
            Console.WriteLine("Não é possível dividir ou calcular módulo por zero.");
        }
        Console.WriteLine();

        // Atividade 8 - Tabuada
        Console.WriteLine("=== Atividade 8 ===");
        Console.Write("Informe o número: ");
        int numTab = int.Parse(Console.ReadLine()!);
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{numTab} * {i} = {numTab * i}");
        }
        Console.WriteLine();

        // Atividade 9 - Média de 4 números
        Console.WriteLine("=== Atividade 9 ===");
        Console.Write("Informe o primeiro número: ");
        int num3 = int.Parse(Console.ReadLine()!);
        Console.Write("Informe o segundo número: ");
        int num4 = int.Parse(Console.ReadLine()!);
        Console.Write("Informe o terceiro número: ");
        int num5 = int.Parse(Console.ReadLine()!);
        Console.Write("Informe o quarto número: ");
        int num6 = int.Parse(Console.ReadLine()!);
        double media = (num3 + num4 + num5 + num6) / 4.0;
        Console.WriteLine($"A média é: {media}\n");

        // Atividade 10
        Console.WriteLine("=== Atividade 10 ===");
        Console.Write("Informe o primeiro número (x): ");
        int x = int.Parse(Console.ReadLine()!);
        Console.Write("Informe o segundo número (y): ");
        int y = int.Parse(Console.ReadLine()!);
        Console.Write("Informe o terceiro número (z): ");
        int z = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Resultado: (x+y)*z = {(x + y) * z} e xy+yz = {(x * y) + (y * z)}\n");

        // Atividade 11
        Console.WriteLine("=== Atividade 11 ===");
        Console.Write("Informe a sua idade: ");
        int idade = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Você parece ter mais de {idade} anos\n");

        // Atividade 12 - Retângulo
        Console.WriteLine("=== Atividade 12 ===");
        Console.Write("Informe o número: ");
        string num7 = Console.ReadLine()!;
        Console.WriteLine($"{num7}{num7}{num7}");
        Console.WriteLine($"{num7} {num7}");
        Console.WriteLine($"{num7} {num7}");
        Console.WriteLine($"{num7} {num7}");
        Console.WriteLine($"{num7}{num7}{num7}\n");

        // Atividade 13 - Temperatura
        Console.WriteLine("=== Atividade 13 ===");
        Console.Write("Informe os graus em Celsius: ");
        double celsius = double.Parse(Console.ReadLine()!);
        double fahrenheit = (celsius * 9 / 5) + 32;
        double kelvin = celsius + 273.15;
        Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}");
        Console.WriteLine($"A temperatura em Kelvin é: {kelvin}\n");

        // Atividade 14 - Média Aritmética
        Console.WriteLine("=== Atividade 14 ===");
        Console.Write("Informe o primeiro número: ");
        int num8 = int.Parse(Console.ReadLine()!);
        Console.Write("Informe o segundo número: ");
        int num9 = int.Parse(Console.ReadLine()!);
        Console.Write("Informe o terceiro número: ");
        int num10 = int.Parse(Console.ReadLine()!);
        double mediaArit = (num8 + num9 + num10) / 3.0;
        Console.WriteLine($"A média aritmética é: {mediaArit}\n");

        // Atividade 15 - Média Ponderada
        Console.WriteLine("=== Atividade 15 ===");
        Console.Write("Informe o primeiro número: ");
        int num11 = int.Parse(Console.ReadLine()!);
        Console.Write("Informe o peso do primeiro: ");
        int peso1 = int.Parse(Console.ReadLine()!);
        Console.Write("Informe o segundo número: ");
        int num12 = int.Parse(Console.ReadLine()!);
        Console.Write("Informe o peso do segundo: ");
        int peso2 = int.Parse(Console.ReadLine()!);
        Console.Write("Informe o terceiro número: ");
        int num13 = int.Parse(Console.ReadLine()!);
        Console.Write("Informe o peso do terceiro: ");
        int peso3 = int.Parse(Console.ReadLine()!);
        double mediaPond = (double)((num11 * peso1) + (num12 * peso2) + (num13 * peso3)) / (peso1 + peso2 + peso3);
        Console.WriteLine($"A média ponderada é: {mediaPond}\n");

        // Atividade 16 - Salário com aumento (25% fixo)
        Console.WriteLine("=== Atividade 16 ===");
        Console.Write("Informe o seu salário: ");
        double salario = double.Parse(Console.ReadLine()!);
        Console.WriteLine($"O novo salário com 25% de aumento é: {salario * 1.25}\n");

        // Atividade 17 - Salário com porcentagem personalizada
        Console.WriteLine("=== Atividade 17 ===");
        Console.Write("Informe o seu salário: ");
        double salario1 = double.Parse(Console.ReadLine()!);
        Console.Write("Informe a porcentagem do aumento: ");
        double aumento1 = double.Parse(Console.ReadLine()!);
        double valorAumento = salario1 * (aumento1 / 100);
        Console.WriteLine($"O valor do aumento é: {valorAumento}");
        Console.WriteLine($"O seu novo salário é: {salario1 + valorAumento}\n");

        // Atividade 18 - Salário com gratificação e imposto
        Console.WriteLine("=== Atividade 18 ===");
        Console.Write("Informe o seu salário base: ");
        double salario2 = double.Parse(Console.ReadLine()!);
        double gratificacao = salario2 * 0.05;
        double imposto = salario2 * 0.07;
        double salarioFinal = salario2 + gratificacao - imposto;
        Console.WriteLine($"O seu salário a receber é: {salarioFinal}\n");

        // Atividade 19 - Antecessor e Sucessor
        Console.WriteLine("=== Atividade 19 ===");
        Console.Write("Informe o número: ");
        int num14 = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"O antecessor é: {num14 - 1}");
        Console.WriteLine($"O sucessor é: {num14 + 1}\n");

        // Atividade 20 - Operações com A e B
        Console.WriteLine("=== Atividade 20 ===");
        Console.Write("Informe o primeiro número (A): ");
        float a = float.Parse(Console.ReadLine()!);
        Console.Write("Informe o segundo número (B): ");
        float b = float.Parse(Console.ReadLine()!);
        Console.WriteLine($"{a} + {b} = {a + b}");
        Console.WriteLine($"{a} - {b} = {a - b}");
        Console.WriteLine($"{a} * {b} = {a * b}");
        if (b != 0)
            Console.WriteLine($"{a} / {b} = {a / b}");
        else
            Console.WriteLine("Divisão por zero não permitida.");
        Console.WriteLine();

        // Atividade 21 - Custo Coelhos
        Console.WriteLine("=== Atividade 21 ===");
        Console.Write("Informe o número de coelhos: ");
        double ncoelhos = double.Parse(Console.ReadLine()!);
        double custo = ((ncoelhos * 0.70) / 18) + 10;
        Console.WriteLine($"O custo total dos coelhos é: {custo}\n");

        // Atividade 22 - Calorias
        Console.WriteLine("=== Atividade 22 ===");
        Console.Write("Informe o seu peso (kg): ");
        double peso = double.Parse(Console.ReadLine()!);
        Console.Write("Tempo correndo por semana (min): ");
        double tempoCorrida = double.Parse(Console.ReadLine()!);
        Console.Write("Tempo pedalando por semana (min): ");
        double tempoPedala = double.Parse(Console.ReadLine()!);
        Console.Write("Tempo nadando por semana (min): ");
        double tempoNada = double.Parse(Console.ReadLine()!);
        
        double calorias = (7.0 * peso * tempoCorrida / 60) + (7.0 * peso * tempoPedala / 60) + (8.0 * peso * tempoNada / 60);
        Console.WriteLine($"A queima de calorias por semana será: {calorias} kcal\n");

        // Atividade 23 - MUV
        Console.WriteLine("=== Atividade 23 ===");
        Console.Write("Informe a posição inicial (S0): ");
        double posicaoInicial = double.Parse(Console.ReadLine()!);
        Console.Write("Informe a velocidade inicial (V0): ");
        double velocidadeInicial = double.Parse(Console.ReadLine()!);
        Console.Write("Informe a aceleração (a): ");
        double aceleracao = double.Parse(Console.ReadLine()!);
        Console.Write("Informe o tempo de duração (t): ");
        double tempoDuracao = double.Parse(Console.ReadLine()!);
        double posicaoFinal = posicaoInicial + (velocidadeInicial * tempoDuracao) + (aceleracao * (tempoDuracao * tempoDuracao));
        Console.WriteLine($"A posição final é: {posicaoFinal}\n");

        // Atividade 24 - Eleitores
        Console.WriteLine("=== Atividade 24 ===");
        Console.Write("Informe o número de eleitores: ");
        double eleitores = double.Parse(Console.ReadLine()!);
        Console.Write("Informe o número de votos brancos: ");
        double brancos = double.Parse(Console.ReadLine()!);
        Console.Write("Informe o número de votos nulos: ");
        double nulos = double.Parse(Console.ReadLine()!);
        Console.Write("Informe o número de votos válidos: ");
        double validos = double.Parse(Console.ReadLine()!);
        
        Console.WriteLine($"A porcentagem de votos brancos é: {(brancos * 100) / eleitores}%");
        Console.WriteLine($"A porcentagem de votos nulos é: {(nulos * 100) / eleitores}%");
        Console.WriteLine($"A porcentagem de votos válidos é: {(validos * 100) / eleitores}%\n");

        // Atividade 25 - Peso
        Console.WriteLine("=== Atividade 25 ===");
        Console.Write("Informe o seu peso: ");
        double pesoPessoa = double.Parse(Console.ReadLine()!);
        Console.WriteLine($"Se engordar 15%: Novo peso = {pesoPessoa * 1.15}");
        Console.WriteLine($"Se emagrecer 22%: Novo peso = {pesoPessoa * 0.78}\n");

        Console.WriteLine("Fim da lista! Pressione qualquer tecla para sair.");
        Console.ReadKey();
    }
}