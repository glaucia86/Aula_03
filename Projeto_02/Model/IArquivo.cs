using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_02.Model
{
    interface IArquivo
    {
        //Prototipação do Método:
        void AbrirArquivo();
        void GravarConteudo(string texto);
        void FecharArquivo();
    }
}
