using System;
using System.IO;

namespace Arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt"; // caminho do arquivo de origem
            string targetPath = @"c:\temp\file2.txt"; // caminho do arquivo de destino
            try
            {
                File.Copy(sourcePath, targetPath); // copia o arquivo de origem para o destino
                string[] lines = File.ReadAllLines(sourcePath); // lê todas as linhas do arquivo de origem e armazena em um array de strings
                foreach (string line in lines)
                {
                    Console.WriteLine(line);  // exibe cada linha do arquivo de origem no console
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}

// O código acima copia um arquivo de texto de um local para outro e exibe o conteúdo do arquivo de origem no console.
// Ele utiliza a classe File do namespace System.IO para realizar as operações de leitura e escrita de arquivos.
// O método File.Copy é usado para copiar o arquivo,
// enquanto o método File.ReadAllLines é utilizado para ler todas as linhas do arquivo de origem e armazená-las em um array de strings.
// Em seguida, um loop foreach é usado para exibir cada linha do arquivo no console.
// O código também inclui um bloco try-catch para lidar com possíveis exceções de entrada/saída (IOException) que podem ocorrer durante as operações de arquivo.


//O FileInfo é uma classe do namespace System.IO que fornece propriedades e métodos para criar, copiar, excluir, mover e abrir arquivos.
// Ele é usado para manipular arquivos de forma mais detalhada,
// permitindo acesso a informações como o nome do arquivo, extensão, tamanho, data de criação e data de modificação.

// O FileStream é uma classe do namespace System.IO que fornece uma maneira de ler e gravar bytes em um arquivo.
// Ele é usado para manipular arquivos de forma mais flexível, permitindo a leitura e escrita de dados em um formato binário.
// O FileStream pode ser utilizado para criar, abrir, ler, escrever e fechar arquivos, oferecendo controle total sobre o processo de manipulação de arquivos.
// Ele é especialmente útil quando se trabalha com arquivos grandes ou quando se precisa de acesso direto aos bytes do arquivo.

// O StreamReader é uma classe do namespace System.IO que fornece uma maneira de ler caracteres de um fluxo de entrada, como um arquivo.
// Ele é usado para ler arquivos de texto de forma eficiente, permitindo a leitura de linhas, palavras ou caracteres individuais.