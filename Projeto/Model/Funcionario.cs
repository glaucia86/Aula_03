using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Model
{
    public class Funcionario
    {
        //Encapsulamento implícito:
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }

        //Construtor
        //ctor + tab[2x]
        public Funcionario()
        {
            //Default
        }

        //Sobrecarga de Construtores (Overloading):
        public Funcionario(int IdFuncionario, string Nome, decimal Salario) 
        {
            this.IdFuncionario  = IdFuncionario;
            this.Nome           = Nome;
            this.Salario        = Salario;
        }

        public override string ToString()
        {
            //Método para retornar uma linha de
            //texto com os dados referentes a classe
            return String.Format("{0},{1},{2:c}", IdFuncionario, Nome, Salario);
        }
    }

    
}
