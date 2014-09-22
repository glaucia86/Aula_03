using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto_02.Model
{
    class Documento : IArquivo
    {
        private StreamWriter sw;

        public void AbrirArquivo()
        {
            //Criando Arquivo
            sw = new StreamWriter("C:\\Users\\Glaucia\\Documents\\Visual Studio 2012\\Projects\\Exemplos Curso - Coti Informatica 2014\\Aula_03\\Projeto_02\\temp\\documento.doc", true);
        }

        public void GravarConteudo(string texto)
        {
            //Escrevendo o arquivo
            sw.WriteLine(texto);
        }

        public void FecharArquivo()
        {
            //Fechando o Arquivo
            sw.Close();
        }


        public void GravarConteudo()
        {
            throw new NotImplementedException();
        }

        void IArquivo.AbrirArquivo()
        {
            throw new NotImplementedException();
        }

        void IArquivo.GravarConteudo()
        {
            throw new NotImplementedException();
        }

        void IArquivo.FecharArquivo()
        {
            throw new NotImplementedException();
        }
    }
}
