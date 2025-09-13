using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("--SOMA E MÉDIA--\n");

List<float> numeros = [];
float numero;

Menu();
void Menu()
{
    Console.Write("Quantos números deseja usar? (3-10): ");
    int qtNumeros = int.Parse(Console.ReadLine()!);
    Console.Write("\n");
    if (qtNumeros < 3 | qtNumeros > 10)
    {
        Console.WriteLine("<ERRO>Quantidade inválida.");
        return;
    }

    for (int i = 1; i <= qtNumeros; i++)
    {
        Console.Write($"{i}º número: ");
        string? input = Console.ReadLine();
        if (float.TryParse(input, out numero))
            numeros.Add(numero);
        else
        {
            Console.WriteLine("<ERRO>Valor inválido, tente novamente.");
            i--;
        }
    }

    foreach (float num in numeros)
    {
        float aux = num;
       // TODO: Como usar foreach para somar os valores dentro da List "numeros"? 
    }
}