using System;
using ExercicioVetoresPOO;

int aluguel = 1;
Estudante[] lista = new Estudante[10];
Console.Write("Quantos quartos serão alugados? ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();

Estudante[] vet = new Estudante[N];

for(int i = 0; i < N; i++)
{
    Console.WriteLine("Aluguel #" + aluguel);
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto: ");
    int quarto = int.Parse(Console.ReadLine());
    vet[i] = new Estudante { Nome = nome, Email = email, Quarto = quarto };
    aluguel++;
    Console.WriteLine();
}

for(int i = 0; i < N; i++)
{
    for(int j = 0; j < 10; j++)
    {
        if (j == vet[i].Quarto)
        {
            lista[j] = vet[i];
        }
    }
}

for(int i = 0; i < 10; i++)
{
    if(lista[i]?.Quarto != null)
    {
        Console.WriteLine($"{lista[i].Quarto}: {lista[i].Nome}, {lista[i].Email}");
    }
}