using System;
using Atividade3;
    
        Pessoa p = new Pessoa();

        Console.WriteLine("Digite seu nome:");
        p.Nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());

        p.definirIdade(idade);

        p.Dados();
    

