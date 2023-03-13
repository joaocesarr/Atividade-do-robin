using System;
using System.Collections.Generic;

class Aluno
{
    public string Nome { get; set; }
    public List<double> Notas { get; set; }

    public Aluno()
    {
        Notas = new List<double>();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a quantidade de alunos: ");
        int quantidadeAlunos = int.Parse(Console.ReadLine());

        List<Aluno> alunos = new List<Aluno>();

        for (int i = 0; i < quantidadeAlunos; i++)
        {
            Console.WriteLine($"Aluno {i+1}:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Quantidade de notas: ");
            int quantidadeNotas = int.Parse(Console.ReadLine());

            Aluno aluno = new Aluno();
            aluno.Nome = nome;

            for (int j = 0; j < quantidadeNotas; j++)
            {
                Console.Write($"Nota {j+1}: ");
                double nota = double.Parse(Console.ReadLine());
                aluno.Notas.Add(nota);
            }

            alunos.Add(aluno);
        }

        Console.WriteLine();
        Console.WriteLine("Dados dos alunos:");

        foreach (Aluno aluno in alunos)
        {
            Console.WriteLine($"Nome: {aluno.Nome}");

            Console.Write("Notas: ");
            foreach (double nota in aluno.Notas)
            {
                Console.Write($"{nota} ");
            }
            Console.WriteLine();

            double media = 0;
            foreach (double nota in aluno.Notas)
            {
                media += nota;
            }
            media /= aluno.Notas.Count;
            Console.WriteLine($"Média: {media}");

            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
