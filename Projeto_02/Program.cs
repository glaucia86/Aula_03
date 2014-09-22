using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_02.Model;

namespace Projeto_02
{
    class Program
    {
        static void Main(string[] args)
        {
            IArquivo a = new Documento();

            a.AbrirArquivo();
            //a.GravarConteudo("Testando o nosso projeto.....");
            a.FecharArquivo();

            Console.WriteLine("Dados Gravados com Sucesso!!!");
            Console.ReadKey();
        }
    }
}
