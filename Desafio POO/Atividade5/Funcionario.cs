using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade5
{
   
    public class Funcionario : Pessoa
    {
        public double Salario;

        public Funcionario(string nome, int idade, double salario) : base(nome, idade)

        {
            Salario = salario;
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Salário: {Salario}");
        }
    }
}