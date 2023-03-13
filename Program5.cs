using System;

class Program
{
    static void Main(string[] args)
    {
        
        ArquivoTexto arquivo = new ArquivoTexto();

        
        arquivo.Conteudo = "Teste, salve esse conteúdo para o teste ser um sucesso.";
        arquivo.EnderecoNomeArquivo = "C:\\JC\\salveagora.txt";

        
        arquivo.SalvarDadosNoArquivo();

        
        string conteudoEncontrado = arquivo.PesquisarConteudoNoArquivo();
        Console.WriteLine("Conteúdo encontrado no arquivo: " + conteudoEncontrado);
    }
}
