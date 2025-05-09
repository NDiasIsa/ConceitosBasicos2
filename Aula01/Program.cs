// See https://aka.ms/new-console-template for more information
using Aula01._1bim;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

int opcao = 0;
bool continuar = true;
while (continuar)
{
    Console.WriteLine("0 - Sair");
    Console.WriteLine("1 - Somar dois números");
    Console.WriteLine("2 - Converter metros para milimetros");
    Console.WriteLine("Informe a opção desejada: ");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Soma();
            break;
        case 2:
            Conversor();
            break;
        case 0:
            continuar = false;
            break;
    }

}
void Soma()
{
    int num1, int num2;
    Console.WriteLine("Informe o primeiro número");
    somadoisnumeros somador = new somadoisnumeros();
    int resultado = somador.Somar(num1, num2);
    Console.WriteLine($"A soma dos números {num1} e {num2} é {resultado}");
}
void Conversor()
{
    int num1, int num2;
    Console.WriteLine("Informe o primeiro número");
    MetrosMilimetros multiplicador = new MetrosMilimetros();
    int resultado = multiplicador.Multiplicar(num1, num2);
    Console.WriteLine($"O metro em milimetro é {resultado}");
}



/*EXERCICIO 1
int num1 = 12;
int num2 = 1000;
MetrosMilimetros multiplicador = new MetrosMilimetros();
int resultado = multiplicador.Multiplicar(num1, num2);
Console.WriteLine($"O metro em milimetro é {resultado}");


/*EXERCICIO 1
int num1 = 20;
int num2=22;
somadoisnumeros somador = new somadoisnumeros();
int resultado = somador.Somar(num1, num2);
Console.WriteLine($"A soma dos números {num1} e {num2} é {resultado}");

/*
Console.WriteLine("Hello, Human Beings!");
Console.WriteLine("Qual seu nome?");
string nome = Console.ReadLine();
Console.WriteLine($"Seja bem-vinda, {nome}!");
Console.WriteLine("Quantos anos você tem?????? :(");
try
{
    int idade = int.Parse(Console.ReadLine());
    Console.WriteLine("A idade informada foi " + idade);
    if (idade == 1)
    {
        throw new DuvidaMatematicaException();
    }
    if (idade % 2 == 0)
    {
        Console.WriteLine("A idade informada corresponde a um número par! ");
    }
    else
    {
        Console.WriteLine("A idade informada corresponde a um número ímpar!");
    }
    bool primo = true;
    int divis = 0;
    for (int i = 1; i <= idade; i++)
    {
        if (idade % i == 0)
        {
            primo = false;
            divis++;
        }
    }
    if (divis == 2)
    {
        Console.WriteLine("A idade é um número primo!");
    }
    else
    {
        Console.WriteLine($"A idade não é um número primo, ela tem {divis} divisores!");
    }
}
catch (FormatException e)
{
    Console.WriteLine("A idade não é um inteiro");
}
catch(DuvidaMatematicaException e)
{
    Console.WriteLine("Esse número é uma exceção");
}
catch (Exception e)
{
    Console.WriteLine("Ocorreu um erro desconhecido");
}

[Serializable]
internal class DuvidaMatematicaException : Exception
{
    public DuvidaMatematicaException()
    {
    }

    public DuvidaMatematicaException(string? message) : base(message)
    {
    }

    public DuvidaMatematicaException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}

*/
