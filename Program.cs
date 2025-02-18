﻿double numero1 = 0;
double numero2 = 0;
double resultado = 0;
string operacao;
string sair;



do
{
    ExibeMenu();
    ExibeOpcao();

    resultado = ExecutaOperacao(operacao, numero1, numero2);

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("{0}", resultado);

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Deseja sair? S/N: ");
    Console.WriteLine();
    Console.ResetColor();
    sair = Console.ReadLine().ToUpper();
}
while (sair != "S" && sair != "SIM");
{
    Console.WriteLine();
    Console.WriteLine("\nVolte sempre!");
}

void ExibeMenu()
{
    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine("+---------------------------+");
    Console.WriteLine("|       Seja-bem vindo      |");
    Console.WriteLine("+---------------------------+");
    Console.WriteLine("|   Comandos das operações: |");
    Console.WriteLine("+---------------------------+");
    Console.WriteLine("|          Soma (+)         |");
    Console.WriteLine("|        Subtração (-)      |");
    Console.WriteLine("|      Multiplicação (*)    |");
    Console.WriteLine("|         Divisão (/)       |");
    Console.WriteLine("|      Exponeciação (^)     |");
    Console.WriteLine("|      Radiação (R ou r)    |");
    Console.WriteLine("+---------------------------+");

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("+--------------------------------------------------------------------------------+");
    Console.WriteLine("|   Observação: a cada etapa, leia as orientações e tecle ENTER para continuar.  |");
    Console.WriteLine("|na radiação (raiz quadrada), o número que irá contar é o primeiro valor digitado|");
    Console.WriteLine("+--------------------------------------------------------------------------------+");
    Console.ResetColor();
}

void ExibeOpcao()
{
Console.WriteLine();
Console.WriteLine("Aguarde...");
Console.WriteLine();

numero1 = SolicitaNumero("primeiro");

Console.WriteLine("Escolha uma operação: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.ResetColor();
operacao = Console.ReadLine();

numero2 = SolicitaNumero("segundo");
Console.WriteLine();
}

double SolicitaNumero(string ordemNumero)
{
    double numero = 0;

    Console.Write("Digite o ");

    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(ordemNumero);
    Console.ResetColor();

    Console.WriteLine(" número");

    numero = Convert.ToDouble(Console.ReadLine());

    return numero;
}

double Soma(double soma1, double soma2)
{
    if (soma1 <= 0 || soma2 <=0)
    {
        return 0;
    } 
    return soma1 + soma2;
}

double Divisao(double dividendo, double divisor)
{
    if (divisor == 0)
    {
        return 0;
    }
    else
    {
        return dividendo / divisor;
    }
}

double Subtracao(double minuendo, double subtraendo)
{
  double Subtracao = minuendo - subtraendo;
  return Subtracao;
}

double Multiplicacao (double fator1, double fator2)
{   
    double Multiplicacao = fator1 * fator2;
    return Multiplicacao;
}

double Exponeciacao (double expoente, double base1)
{
    double Exponeciacao = Math.Pow(base1,expoente);
    return Exponeciacao;
}

double Raiz (double radicando)
{ 
    double Raiz = Math.Sqrt(radicando);
    return Raiz;
}

double ExecutaOperacao(string operacao, double numero01, double numero02)
{
         double resultado = 0;
          switch (operacao)
          {
        case "+":
            resultado = Soma(numero01, numero02);
            Console.Write("O valor da soma é: ");
            break;
        case "-":
            resultado = Subtracao(numero01, numero02);
            Console.Write("O valor da subtração é: ");
            break;
        case "/":
            resultado = Divisao(numero01, numero02);
            Console.Write("O valor da divisão é: ");
            break;
        case "*":
            resultado = Multiplicacao(numero01, numero02);
            Console.Write("O valor da multiplicação é: ");
            break;
        case "^":
            resultado = Exponeciacao(numero01, numero02);
            Console.Write("O valor da exponeciação é: ");
            break;
        case "R":
            numero02 = Convert.ToDouble(numero01);
            resultado = Raiz(numero02);
            Console.WriteLine($"A raiz quadrada de {numero02} é: ");
            break;
        case "r":
            numero02 = Convert.ToDouble(numero01);
            resultado = Raiz(numero02);
            Console.WriteLine($"A raiz quadrada de {numero02} é: ");
            break;

        default:
            Console.WriteLine("Operação incorreta!");
            break;
                        
           }
           return resultado;
}
