//1 - faça um programa que leia um numero e informe se esse numero é primo.

int numero;
bool ehPrimo = true;

Console.WriteLine("--Descubra se um número é primo--");
Console.Write("Digite um número: ");

numero = int.Parse(Console.ReadLine());

for (int i = 2; i < numero; i++)
{
    if (numero % i == 0)
    {
        ehPrimo = false;
        break;
    }
}

if (ehPrimo == true && numero != 1)
    Console.WriteLine($"O número {numero} é primo");
else
    Console.WriteLine($"O número {numero} não é primo");

Console.WriteLine("Pressione Enter para encerrar...");
Console.ReadLine();
