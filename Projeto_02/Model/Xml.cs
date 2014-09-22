using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Projeto_02.Model
{
    public class Xml : IArquivo
    {
        private StreamWriter sw;

        public void AbrirArquivo()
        {
            //Criando o arquivo:
            sw = new StreamWriter("C:\\Users\\Glaucia\\Documents\\Visual Studio 2012\\Projects\\Exemplos Curso - Coti Informatica 2014\\Aula_03\\Projeto_02\temp\\aula.xml");
        }

        public void GravarConteudo(string texto)
        {
            //Construtor de string:
            StringBuilder sb = new StringBuilder();

            sb.Append("<?xml version='1.0'?>");
            sb.Append("<dados>");
            sb.AppendFormat("<texto>{0}</texto>", texto);
            sb.Append("</dados>");
            sw.WriteLine(sb.ToString());
        }

        public void FecharArquivo()
        {
            sw.Close();
        }
    }
}
