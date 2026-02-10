using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade2
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public void exibirDados()
        {
            System.Console.WriteLine(Nome);
            System.Console.WriteLine(Idade);
        }
    }
}