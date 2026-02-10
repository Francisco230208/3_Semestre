using System;

namespace Atividade3
{
    public class Pessoa
    {
        public string Nome = "";
        public int Idade;

        public void definirIdade(int novaIdade)
        {
            if (novaIdade > 0)
            {
                Idade = novaIdade;
            }
            else
            {
                Console.WriteLine("Idade inválida! Tem que ser maior que 0");
            }
            return;
        }

        public void Dados()
        {
            Console.WriteLine("O seu nome é: " + Nome);
            Console.WriteLine("A sua idade é: " + Idade);
        }
    }
}
