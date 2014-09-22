using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Model; //importanto dados

namespace Projeto.Colecoes
{
    public class Estudo
    {
        public void Teste01()
        { 
            //Vetor:
            int[] vetor = new int[3]; //vetor de 3 posições

            vetor[0] = 10;
            vetor[1] = 20;
            vetor[2] = 30;

            int i = 0;
            while (i < vetor.Length) //condição do loop
            {
                Console.WriteLine(vetor[i]);
                i++;
            }

            //Vetor de Objetos:
            Funcionario[] equipe = new Funcionario[4];

            equipe[0] = new Funcionario(1, "Glaucia", 1500);
            equipe[1] = new Funcionario(2, "Jurema", 2000);
            equipe[2] = new Funcionario(3, "Jose", 3000);
            equipe[3] = new Funcionario(4, "Jake", 3500);

            /*foreach -> para cada...
             * varre toda a coleção não usa indexador
             * Para cada Funcionário contido em equipe, crie um objeto 'f'
             */
            foreach (Funcionario f in equipe)
            {
                Console.WriteLine(f.ToString());
            }
        }

        public void Teste02()
        { 
            //Listas - > System.Collections.Generic
            List<Funcionario> lista = new List<Funcionario>(); //vazia

            //Recebe elementos e organiza como uma fila : FIFO = Firs In Firs Out
            lista.Add(new Funcionario(1, "Luciano", 1500));
            lista.Add(new Funcionario(2, "Max", 2500));
            lista.Add(new Funcionario(3, "Fernando", 3000));

            Console.WriteLine("Quantidade de Funcionarios........: " + lista.Count);

            foreach (Funcionario f in lista)
            {
                Console.WriteLine(f.ToString());
            }
        }

        public void Teste03(string chave)
        { 
            //Mapa - > Armazenamento baseado em CHAVE / Conteudo:
            Dictionary<string, Funcionario> mapa = new Dictionary<string, Funcionario>();

            mapa.Add("professor", new Funcionario(1, "Paulo", 1000));
            mapa.Add("arquiteto", new Funcionario(2, "Tiago", 1500));

            if (mapa.ContainsKey(chave))
            {
                //Buscar um elemento do mapa:
                Funcionario f = mapa[chave];
                Console.WriteLine(f.ToString());
            }
            else
            {
                Console.WriteLine("Funcionario não encontrado");
            }
        }
    }
}
