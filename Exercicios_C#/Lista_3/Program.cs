using System;

class Program
{
    public static void Main(string[] args)
    {
        int opcaoMenu;
        
        do
        {
            Console.Clear();
            Console.WriteLine("================ MENU DE EXERCÍCIOS ================");
            Console.WriteLine(" 1 - Nota para descrição (A, C, E, F, G)");
            Console.WriteLine(" 2 - Número do dia para nome do dia");
            Console.WriteLine(" 3 - Dígito para nome por extenso");
            Console.WriteLine(" 4 - Número do mês para nome do mês");
            Console.WriteLine(" 5 - Calcular área de formas geométricas");
            Console.WriteLine(" 6 - Calculadora simples (Soma, Sub, Mult, Div)");
            Console.WriteLine(" 7 - Exibir os 10 primeiros números naturais");
            Console.WriteLine(" 8 - Soma dos 10 primeiros números naturais");
            Console.WriteLine(" 9 - Exibir N termos naturais e sua soma");
            Console.WriteLine("10 - Ler 10 números e calcular soma e média");
            Console.WriteLine("11 - Exibir o cubo do número até N");
            Console.WriteLine("12 - Tabuada de multiplicação de um número");
            Console.WriteLine("13 - Exibir N termos ímpares e sua soma");
            Console.WriteLine("14 - Imprimir alfabeto de A a Z");
            Console.WriteLine("15 - Soma de números pares entre 1 e N");
            Console.WriteLine("16 - Calcular o fatorial de um número");
            Console.WriteLine("17 - Padrão triângulo reto com *");
            Console.WriteLine("18 - Padrão triângulo reto com números iguais");
            Console.WriteLine("19 - Tabuada vertical de 1 a N");
            Console.WriteLine("20 - Soma do primeiro e último dígito");
            Console.WriteLine(" 0 - Sair");
            Console.WriteLine("====================================================");
            Console.Write("Escolha uma opção: ");
            
            opcaoMenu = int.Parse(Console.ReadLine()!);
            Console.Clear();

            switch (opcaoMenu)
            {
                case 1: // Atividade 1
                    Console.WriteLine("--- Atividade 1 ---");
                    Console.Write("Digite a nota (A, C, E, F, G): ");
                    string nota = Console.ReadLine()!.ToUpper();
                    string descricao = "";
                    if (nota == "A") descricao = "Excelente";
                    else if (nota == "C") descricao = "Muito Bom";
                    else if (nota == "E") descricao = "Bom";
                    else if (nota == "F") descricao = "Média";
                    else if (nota == "G") descricao = "Falhou";
                    else descricao = "Nota inválida!";
                    Console.WriteLine("Descrição: " + descricao);
                    break;

                case 2: // Atividade 2
                    Console.WriteLine("--- Atividade 2 ---");
                    Console.Write("Digite um número de 1 a 31: ");
                    int dia = int.Parse(Console.ReadLine()!);
                    switch (dia)
                    {
                        case 2: case 9: case 16: case 23: case 30: Console.WriteLine("Domingo"); break;
                        case 3: case 10: case 17: case 24: case 31: Console.WriteLine("Segunda-feira"); break;
                        case 4: case 11: case 18: case 25: Console.WriteLine("Terça-feira"); break;
                        case 5: case 12: case 19: case 26: Console.WriteLine("Quarta-feira"); break;
                        case 6: case 13: case 20: case 27: Console.WriteLine("Quinta-feira"); break;
                        case 7: case 14: case 21: case 28: Console.WriteLine("Sexta-feira"); break;
                        case 1: case 8: case 15: case 22: case 29: Console.WriteLine("Sábado"); break;
                        default: Console.WriteLine("Dia inválido!"); break;
                    }
                    break;

                case 3: // Atividade 3
                    Console.WriteLine("--- Atividade 3 ---");
                    Console.Write("Digite um dígito (1 a 9): ");
                    int numero = int.Parse(Console.ReadLine()!);
                    switch (numero)
                    {
                        case 1: Console.WriteLine("Um"); break;
                        case 2: Console.WriteLine("Dois"); break;
                        case 3: Console.WriteLine("Três"); break;
                        case 4: Console.WriteLine("Quatro"); break;
                        case 5: Console.WriteLine("Cinco"); break;
                        case 6: Console.WriteLine("Seis"); break;
                        case 7: Console.WriteLine("Sete"); break;
                        case 8: Console.WriteLine("Oito"); break;
                        case 9: Console.WriteLine("Nove"); break;
                        default: Console.WriteLine("Dígito inválido!"); break;
                    }
                    break;

                case 4: // Atividade 4
                    Console.WriteLine("--- Atividade 4 ---");
                    Console.Write("Digite o número do mês (1 a 12): ");
                    int mes = int.Parse(Console.ReadLine()!);
                    switch (mes)
                    {
                        case 1: Console.WriteLine("Janeiro"); break;
                        case 2: Console.WriteLine("Fevereiro"); break;
                        case 3: Console.WriteLine("Março"); break;
                        case 4: Console.WriteLine("Abril"); break;
                        case 5: Console.WriteLine("Maio"); break;
                        case 6: Console.WriteLine("Junho"); break;
                        case 7: Console.WriteLine("Julho"); break;
                        case 8: Console.WriteLine("Agosto"); break;
                        case 9: Console.WriteLine("Setembro"); break;
                        case 10: Console.WriteLine("Outubro"); break;
                        case 11: Console.WriteLine("Novembro"); break;
                        case 12: Console.WriteLine("Dezembro"); break;
                        default: Console.WriteLine("Mês inválido!"); break;
                    }
                    break;

                case 5: // Atividade 5
                    Console.WriteLine("--- Atividade 5 ---");
                    Console.WriteLine("1 - Triângulo | 2 - Quadrado | 3 - Retângulo | 4 - Círculo");
                    Console.Write("Escolha a forma: ");
                    int areaOpcao = int.Parse(Console.ReadLine()!);
                    switch (areaOpcao)
                    {
                        case 1:
                            Console.Write("Base: "); double base1 = double.Parse(Console.ReadLine()!);
                            Console.Write("Altura: "); double altura1 = double.Parse(Console.ReadLine()!);
                            Console.WriteLine("Área do triângulo: " + ((base1 * altura1) / 2));
                            break;
                        case 2:
                            Console.Write("Lado: "); double lado = double.Parse(Console.ReadLine()!);
                            Console.WriteLine("Área do quadrado: " + (lado * lado));
                            break;
                        case 3:
                            Console.Write("Base: "); double base2 = double.Parse(Console.ReadLine()!);
                            Console.Write("Altura: "); double altura2 = double.Parse(Console.ReadLine()!);
                            Console.WriteLine("Área do retângulo: " + (base2 * altura2));
                            break;
                        case 4:
                            Console.Write("Raio: "); double raio = double.Parse(Console.ReadLine()!);
                            Console.WriteLine("Área do círculo: " + (3.14 * raio * raio));
                            break;
                        default: Console.WriteLine("Opção inválida!"); break;
                    }
                    break;

                case 6: // Atividade 6
                    Console.WriteLine("--- Atividade 6 ---");
                    Console.WriteLine("1 - Soma | 2 - Subtração | 3 - Multiplicação | 4 - Divisão");
                    Console.Write("Escolha a operação: ");
                    int calcOpcao = int.Parse(Console.ReadLine()!);
                    Console.Write("Digite o primeiro número: "); double numA = double.Parse(Console.ReadLine()!);
                    Console.Write("Digite o segundo número: "); double numB = double.Parse(Console.ReadLine()!);
                    switch (calcOpcao)
                    {
                        case 1: Console.WriteLine("Soma: " + (numA + numB)); break;
                        case 2: Console.WriteLine("Subtração: " + (numA - numB)); break;
                        case 3: Console.WriteLine("Multiplicação: " + (numA * numB)); break;
                        case 4: 
                            if (numB != 0) Console.WriteLine("Divisão: " + (numA / numB));
                            else Console.WriteLine("Erro: Divisão por zero!");
                            break;
                        default: Console.WriteLine("Opção inválida!"); break;
                    }
                    break;

                case 7: // Atividade 7 (FOR e WHILE)
                    Console.WriteLine("--- Atividade 7 ---");
                    Console.WriteLine("Usando FOR:");
                    for (int j = 1; j <= 10; j++) { Console.Write(j + " "); }
                    Console.WriteLine("\n\nUsando WHILE:");
                    int k = 1;
                    while (k <= 10) { Console.Write(k + " "); k++; }
                    Console.WriteLine();
                    break;

                case 8: // Atividade 8 (FOR e WHILE)
                    Console.WriteLine("--- Atividade 8 ---");
                    int somaFor = 0;
                    for (int j = 1; j <= 10; j++) { somaFor += j; }
                    Console.WriteLine("Soma usando FOR: " + somaFor);
                    
                    int somaWhile = 0, k2 = 1;
                    while (k2 <= 10) { somaWhile += k2; k2++; }
                    Console.WriteLine("Soma usando WHILE: " + somaWhile);
                    break;

                case 9: // Atividade 9 (FOR e WHILE)
                    Console.WriteLine("--- Atividade 9 ---");
                    Console.Write("Digite o valor de N: ");
                    int n9 = int.Parse(Console.ReadLine()!);
                    
                    int somaFor2 = 0;
                    Console.Write("FOR -> Termos: ");
                    for (int j = 1; j <= n9; j++) { Console.Write(j + " "); somaFor2 += j; }
                    Console.WriteLine(" | Soma: " + somaFor2);

                    int somaWhile2 = 0, k3 = 1;
                    Console.Write("WHILE -> Termos: ");
                    while (k3 <= n9) { Console.Write(k3 + " "); somaWhile2 += k3; k3++; }
                    Console.WriteLine(" | Soma: " + somaWhile2);
                    break;

                case 10: // Atividade 10 (WHILE)
                    Console.WriteLine("--- Atividade 10 ---");
                    double soma10 = 0;
                    int cont10 = 0;
                    while (cont10 < 10)
                    {
                        Console.Write($"Digite o {cont10 + 1}º número: ");
                        soma10 += double.Parse(Console.ReadLine()!);
                        cont10++;
                    }
                    Console.WriteLine("Soma: " + soma10);
                    Console.WriteLine("Média: " + (soma10 / 10));
                    break;

                case 11: // Atividade 11 (DO-WHILE)
                    Console.WriteLine("--- Atividade 11 ---");
                    Console.Write("Digite um número: ");
                    int n11 = int.Parse(Console.ReadLine()!);
                    int cont11 = 1;
                    do
                    {
                        Console.WriteLine($"Cubo de {cont11} = {cont11 * cont11 * cont11}");
                        cont11++;
                    } while (cont11 <= n11);
                    break;

                case 12: // Atividade 12 (FOR)
                    Console.WriteLine("--- Atividade 12 ---");
                    Console.Write("Digite um número para ver a tabuada: ");
                    int n12 = int.Parse(Console.ReadLine()!);
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine($"{n12} x {j} = {n12 * j}");
                    }
                    break;

                case 13: // Atividade 13 (WHILE)
                    Console.WriteLine("--- Atividade 13 ---");
                    Console.Write("Digite a quantidade de termos ímpares: ");
                    int n13 = int.Parse(Console.ReadLine()!);
                    int soma13 = 0, numImpar = 1, cont13 = 0;
                    Console.Write("Termos: ");
                    while (cont13 < n13)
                    {
                        Console.Write(numImpar + " ");
                        soma13 += numImpar;
                        numImpar += 2;
                        cont13++;
                    }
                    Console.WriteLine("\nSoma dos ímpares: " + soma13);
                    break;

                case 14: // Atividade 14 (WHILE)
                    Console.WriteLine("--- Atividade 14 ---");
                    char letra = 'A';
                    while (letra <= 'Z')
                    {
                        Console.Write(letra + " ");
                        letra++;
                    }
                    Console.WriteLine();
                    break;

                case 15: // Atividade 15 (WHILE) - Soma dos PARES
                    Console.WriteLine("--- Atividade 15 ---");
                    Console.Write("Digite o valor de N: ");
                    int n15 = int.Parse(Console.ReadLine()!);
                    int soma15 = 0, cont15 = 1;
                    while (cont15 <= n15)
                    {
                        if (cont15 % 2 == 0) soma15 += cont15;
                        cont15++;
                    }
                    Console.WriteLine("Soma dos pares: " + soma15);
                    break;

                case 16: // Atividade 16 (FOR e WHILE)
                    Console.WriteLine("--- Atividade 16 ---");
                    Console.Write("Digite um número para calcular o fatorial: ");
                    int n16 = int.Parse(Console.ReadLine()!);
                    
                    // Usando FOR
                    long fatorialFor = 1;
                    for (int j = 1; j <= n16; j++) { fatorialFor *= j; }
                    Console.WriteLine($"Fatorial (FOR) de {n16} é {fatorialFor}");
                    
                    // Usando WHILE
                    long fatorialWhile = 1;
                    int k16 = 1;
                    while (k16 <= n16) { fatorialWhile *= k16; k16++; }
                    Console.WriteLine($"Fatorial (WHILE) de {n16} é {fatorialWhile}");
                    break;

                case 17: // Atividade 17 (FOR)
                    Console.WriteLine("--- Atividade 17 ---");
                    Console.WriteLine("Padrão com *");
                    for (int i = 1; i <= 4; i++)
                    {
                        for (int j = 1; j <= i; j++) { Console.Write("*"); }
                        Console.WriteLine();
                    }
                    break;

                case 18: // Atividade 18 (FOR)
                    Console.WriteLine("--- Atividade 18 ---");
                    Console.WriteLine("Padrão com números iguais");
                    for (int i = 1; i <= 4; i++)
                    {
                        for (int j = 1; j <= i; j++) { Console.Write(i); }
                        Console.WriteLine();
                    }
                    break;

                case 19: // Atividade 19 (FOR)
                    Console.WriteLine("--- Atividade 19 ---");
                    Console.Write("Digite o valor de N: ");
                    int n19 = int.Parse(Console.ReadLine()!);
                    for (int i = 1; i <= n19; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            Console.WriteLine($"{i} x {j} = {i * j}");
                        }
                        Console.WriteLine("----------");
                    }
                    break;

                case 20: // Atividade 20
                    Console.WriteLine("--- Atividade 20 ---");
                    Console.Write("Digite um número: ");
                    string numeroStr = Console.ReadLine()!;
                    if (!string.IsNullOrEmpty(numeroStr) && numeroStr.Length >= 2)
                    {
                        int primeiro = int.Parse(numeroStr[0].ToString());
                        int ultimo = int.Parse(numeroStr[numeroStr.Length - 1].ToString());
                        Console.WriteLine($"Soma do 1º e último dígito: {primeiro + ultimo}");
                    }
                    else if (numeroStr.Length == 1)
                    {
                        Console.WriteLine("O número tem apenas 1 dígito. Soma: " + numeroStr);
                    }
                    else
                    {
                        Console.WriteLine("Número inválido!");
                    }
                    break;

                case 0:
                    Console.WriteLine("Saindo do programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            if (opcaoMenu != 0)
            {
                Console.WriteLine("\nPressione ENTER para voltar ao menu...");
                Console.ReadLine();
            }

        } while (opcaoMenu != 0);
    }
}