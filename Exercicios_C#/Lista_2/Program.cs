using System;

class Program
{
    public static void Main(string[] args)
    {
        // Atividade 1: Verifica se dois inteiros são iguais
        Console.WriteLine("Atividade 1");
        Console.WriteLine("Digite um número inteiro: ");
        int num1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite outro número inteiro: ");
        int num2 = int.Parse(Console.ReadLine()!);
        if (num1 == num2)
            Console.WriteLine(num1 + " é igual a " + num2);
        else
            Console.WriteLine(num1 + " é diferente de " + num2);

        // Atividade 2: Verifica se é par ou ímpar
        Console.WriteLine("\nAtividade 2");
        Console.WriteLine("Digite um número: ");
        int num3 = int.Parse(Console.ReadLine()!);
        if (num3 % 2 == 0)
            Console.WriteLine(num3 + " é par");
        else
            Console.WriteLine(num3 + " é ímpar");

        // Atividade 3: Verifica se é positivo ou negativo
        Console.WriteLine("\nAtividade 3");
        Console.WriteLine("Digite um número: ");
        int num4 = int.Parse(Console.ReadLine()!);
        if (num4 > 0)
            Console.WriteLine(num4 + " é positivo");
        else if (num4 < 0)
            Console.WriteLine(num4 + " é negativo");
        else
            Console.WriteLine(num4 + " é zero");

        // Atividade 4: Elegibilidade para votar
        Console.WriteLine("\nAtividade 4");
        Console.WriteLine("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine()!);
        if (idade >= 16)
            Console.WriteLine(idade + " é elegível para votar");
        else
            Console.WriteLine(idade + " não é elegível para votar");

        // Atividade 5: Valor de m e n
        Console.WriteLine("\nAtividade 5");
        Console.WriteLine("Digite um número: ");
        int m = int.Parse(Console.ReadLine()!);
        if (m > 0) Console.WriteLine("n = 1");
        else if (m == 0) Console.WriteLine("n = 0");
        else if (m < 0) Console.WriteLine("n = -1");

        // Atividade 6: Categorizar altura
        Console.WriteLine("\nAtividade 6");
        Console.WriteLine("Digite a altura da pessoa em centímetros: ");
        double altura = Convert.ToDouble(Console.ReadLine()!);
        if (altura < 150) Console.WriteLine("Altura baixa");
        else if (altura >= 150 && altura < 170) Console.WriteLine("Altura média");
        else Console.WriteLine("Altura alta");

        // Atividade 7: Menu de operações
        Console.WriteLine("\nAtividade 7");
        Console.WriteLine("Digite um número: ");
        double num6 = Convert.ToDouble(Console.ReadLine()!);
        Console.WriteLine("Digite outro número: ");
        double num7 = Convert.ToDouble(Console.ReadLine()!);
        Console.WriteLine("Escolha uma opção:\n1 - Média\n2 - Diferença do maior pelo menor\n3 - Produto\n4 - Divisão do primeiro pelo segundo");
        int opcao = Convert.ToInt32(Console.ReadLine()!);
        
        if (opcao == 1) 
            Console.WriteLine("Média = " + (num6 + num7) / 2);
        else if (opcao == 2) 
            Console.WriteLine("Diferença = " + (Math.Max(num6, num7) - Math.Min(num6, num7)));
        else if (opcao == 3) 
            Console.WriteLine("Produto = " + (num6 * num7));
        else if (opcao == 4) 
        {
            if (num7 != 0) 
                Console.WriteLine("Divisão = " + (num6 / num7));
            else 
                Console.WriteLine("Erro: Divisão por zero.");
        }
        else 
            Console.WriteLine("Opção inválida");

        // Atividade 8: Hotel Horizonte
        Console.WriteLine("\nAtividade 8");
        Console.WriteLine("Digite o número de diárias: ");
        int numDiarias = Convert.ToInt32(Console.ReadLine()!);
        double valorDiaria = 50.00;
        double taxaServico;
        
        if (numDiarias < 15) taxaServico = 1.50;
        else if (numDiarias == 15) taxaServico = 1.00;
        else taxaServico = 0.50;
        
        Console.WriteLine("Valor total: R$ " + (numDiarias * valorDiaria + taxaServico));

        // Atividade 9: Crédito bancário
        Console.WriteLine("\nAtividade 9");
        Console.Write("Digite o saldo médio do cliente: R$ ");
        double saldoMedio = Convert.ToDouble(Console.ReadLine()!);
        double credito = 0;
        
        if (saldoMedio >= 0 && saldoMedio <= 200) credito = 0.00;
        else if (saldoMedio > 200 && saldoMedio <= 400) credito = saldoMedio * 0.20;
        else if (saldoMedio > 400 && saldoMedio <= 600) credito = saldoMedio * 0.30;
        else credito = saldoMedio * 0.40;
        
        Console.WriteLine("Saldo médio: R$ " + saldoMedio);
        Console.WriteLine("Crédito: R$ " + credito);

        // Atividade 10: Um negativo e outro positivo
        Console.WriteLine("\nAtividade 10");
        Console.WriteLine("Digite um número inteiro: ");
        int numB = Convert.ToInt32(Console.ReadLine()!);
        Console.WriteLine("Digite outro número inteiro: ");
        int numA = Convert.ToInt32(Console.ReadLine()!);
        bool resultado = (numA < 0 && numB > 0) || (numA > 0 && numB < 0);
        Console.WriteLine("Um número é negativo e o outro é positivo? " + resultado);

        // Atividade 11: Soma (e triplica se igual)
        Console.WriteLine("\nAtividade 11");
        Console.WriteLine("Digite um número inteiro: ");
        int numC = Convert.ToInt32(Console.ReadLine()!);
        Console.WriteLine("Digite outro número inteiro: ");
        int numD = Convert.ToInt32(Console.ReadLine()!);
        int soma = numC + numD;
        if (numC == numD) soma *= 3;
        Console.WriteLine("A soma é: " + soma);

        // Atividade 12: Diferença absoluta
        Console.WriteLine("\nAtividade 12");
        Console.Write("Digite o primeiro número: ");
        int num13 = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o segundo número: ");
        int num14 = int.Parse(Console.ReadLine()!);
        int diferenca;
        
        if (num13 > num14) 
            diferenca = (num13 - num14) * 2;
        else 
            diferenca = num14 - num13;
            
        Console.WriteLine("O resultado é: " + diferenca);

        // Atividade 13: True se um for 20 ou soma for 20
        Console.WriteLine("\nAtividade 13");
        Console.Write("Digite o primeiro número: ");
        int num9 = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o segundo número: ");
        int num10 = int.Parse(Console.ReadLine()!);
        bool is20 = (num9 == 20 || num10 == 20 || (num9 + num10 == 20));
        Console.WriteLine("Resultado: " + is20);

        // Atividade 14: Maior entre três
        Console.WriteLine("\nAtividade 14");
        Console.Write("Digite o primeiro número: ");
        int num11 = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o segundo número: ");
        int num12 = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o terceiro número: ");
        int num15 = int.Parse(Console.ReadLine()!);
        int maior = Math.Max(num11, Math.Max(num12, num15));
        Console.WriteLine("O maior número é: " + maior);

        // Atividade 15: Quadrantes
        Console.WriteLine("\nAtividade 15");
        Console.Write("Escreva a coordenada X: ");
        int x = int.Parse(Console.ReadLine()!);
        Console.Write("Escreva a coordenada Y: ");
        int y = int.Parse(Console.ReadLine()!);
        
        if (x > 0 && y > 0) Console.WriteLine("Quadrante I");
        else if (x < 0 && y > 0) Console.WriteLine("Quadrante II");
        else if (x < 0 && y < 0) Console.WriteLine("Quadrante III");
        else if (x > 0 && y < 0) Console.WriteLine("Quadrante IV");
        else if (x == 0 && y != 0) Console.WriteLine("Sobre o eixo Y");
        else if (y == 0 && x != 0) Console.WriteLine("Sobre o eixo X");
        else Console.WriteLine("Na origem (0,0)");

        // Atividade 16: Curso profissional
        Console.WriteLine("\nAtividade 16");
        Console.Write("Digite a nota em Matemática: ");
        int matematica = int.Parse(Console.ReadLine()!);
        Console.Write("Digite a nota em Física: ");
        int fisica = int.Parse(Console.ReadLine()!);
        Console.Write("Digite a nota em Química: ");
        int quimica = int.Parse(Console.ReadLine()!);
        bool elegivel = (matematica >= 65 && fisica >= 55 && quimica >= 50 && (matematica + fisica + quimica) >= 180) || (matematica + fisica >= 140);
        Console.WriteLine(elegivel ? "Você está elegível." : "Você não está elegível.");

        // Atividade 17: Temperatura
        Console.WriteLine("\nAtividade 17");
        Console.Write("Digite a temperatura em °C: ");
        int temp = int.Parse(Console.ReadLine()!);
        
        if (temp < 0) Console.WriteLine("Tempo congelante.");
        else if (temp < 10) Console.WriteLine("Tempo muito frio.");
        else if (temp < 20) Console.WriteLine("Tempo frio.");
        else if (temp < 30) Console.WriteLine("Temperatura Normal.");
        else if (temp < 40) Console.WriteLine("Está quente.");
        else Console.WriteLine("Está muito quente.");

        // Atividade 18: Triângulos
        Console.WriteLine("\nAtividade 18");
        Console.Write("Lado 1: "); int lado1 = int.Parse(Console.ReadLine()!);
        Console.Write("Lado 2: "); int lado2 = int.Parse(Console.ReadLine()!);
        Console.Write("Lado 3: "); int lado3 = int.Parse(Console.ReadLine()!);
        
        if (lado1 == lado2 && lado2 == lado3) Console.WriteLine("Equilátero.");
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3) Console.WriteLine("Isósceles.");
        else Console.WriteLine("Escaleno.");

        // Atividade 19: Lucro e Prejuízo
        Console.WriteLine("\nAtividade 19");
        Console.Write("Preço de custo: "); double precoCusto = double.Parse(Console.ReadLine()!);
        Console.Write("Preço de venda: "); double precoVenda = double.Parse(Console.ReadLine()!);
        double lucro = precoVenda - precoCusto;
        
        if (lucro > 0) Console.WriteLine("Lucro de: R$ " + lucro);
        else if (lucro < 0) Console.WriteLine("Prejuízo de: R$ " + Math.Abs(lucro));
        else Console.WriteLine("Não houve lucro nem prejuízo.");

        // Atividade 20: Conta de energia
        Console.WriteLine("\nAtividade 20");
        Console.Write("ID do Cliente: "); int idCliente = int.Parse(Console.ReadLine()!);
        Console.Write("Nome do Cliente: "); string nomeCliente = Console.ReadLine()!;
        Console.Write("Unidades consumidas: "); int unidades = int.Parse(Console.ReadLine()!);
        
        double taxa = 0;
        if (unidades < 200) taxa = 1.20;
        else if (unidades < 400) taxa = 1.50;
        else if (unidades < 600) taxa = 1.80;
        else taxa = 2.00;

        double fatura = unidades * taxa;
        if (fatura > 400) fatura += fatura * 0.15;
        if (fatura < 100) fatura = 100;

        Console.WriteLine("\n--- Conta de Energia ---");
        Console.WriteLine("Cliente: " + nomeCliente + " (ID: " + idCliente + ")");
        Console.WriteLine("Total a pagar: R$ " + fatura.ToString("F2"));

        // Impede que a janela feche sozinha imediatamente
        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}