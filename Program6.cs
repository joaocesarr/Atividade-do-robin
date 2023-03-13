using System;

public class ArquivoTexto
{
    public string Conteudo { get; set; }
    public string EnderecoNomeArquivo { get; set; }

    public void SalvarDadosNoArquivo()
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(EnderecoNomeArquivo))
            {
                sw.Write(Conteudo);
            }
            Console.WriteLine("Conteúdo salvo com sucesso no arquivo: " + EnderecoNomeArquivo);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao salvar o arquivo: " + ex.Message);
        }
    }

    public string PesquisarConteudoNoArquivo()
    {
        string conteudoEncontrado = "";
        try
        {
            using (StreamReader sr = new StreamReader(EnderecoNomeArquivo))
            {
                conteudoEncontrado = sr.ReadToEnd();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao pesquisar o arquivo: " + ex.Message);
        }
        return conteudoEncontrado;
    }
}

