using System;

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();
        aluno.ReceberDados();
        aluno.CalcularMedia();
        aluno.ImprimirNotaFinal();
        aluno.CalcularNotaFinal(7.0);
    }
}

