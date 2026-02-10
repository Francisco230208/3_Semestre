using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade4
{
    public class Pessoa
    {
        public  string nome;
        public  int idade;

        public Pessoa(string n, int i)
        {
            nome = n;
            idade = i;
        }

        public void exibirDados()
        {
            System.Console.WriteLine("Seu nome é:" + nome);
            System.Console.WriteLine("Sua idade é:" + idade);
        }
    }
}