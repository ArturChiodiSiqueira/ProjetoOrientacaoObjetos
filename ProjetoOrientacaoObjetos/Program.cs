﻿using System;

namespace ProjetoOrientacaoObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();

            pessoa1.ImplementaNome();
            pessoa1.ImolementaDataNascimento();
            pessoa1.ImplementaCPF();
            pessoa1.ImplementaTelefone();

            Console.WriteLine("\nDados pessoais:");
            Console.WriteLine("Nome da pessoa 1: " + pessoa1.Nome);
            Console.WriteLine("Data de nascimento da pessoa 1: " + pessoa1.DataNascimento);
            Console.WriteLine("CPF da pessoa 1: " + pessoa1.Cpf);
            Console.WriteLine("Telefone da pessoa 1: " + pessoa1.Telefone);

            //////////////////////////////////
            
            Pessoa pessoa2 = new Pessoa();

            pessoa2.ImplementaNome();
            pessoa2.ImolementaDataNascimento();
            pessoa2.ImplementaCPF();
            pessoa2.ImplementaTelefone();

            Console.WriteLine("\nDados pessoais:");
            Console.WriteLine("Nome da pessoa 2: " + pessoa2.Nome);
            Console.WriteLine("Data de nascimento da pessoa 2: " + pessoa2.DataNascimento);
            Console.WriteLine("CPF da pessoa 2: " + pessoa2.Cpf);
            Console.WriteLine("Telefone da pessoa 2: " + pessoa2.Telefone);

            //////////////////////////////////

            Pessoa pessoa3 = new Pessoa();

            pessoa3.ImplementaNome();
            pessoa3.ImolementaDataNascimento();
            pessoa3.ImplementaCPF();
            pessoa3.ImplementaTelefone();

            Console.WriteLine("\nDados pessoais:");
            Console.WriteLine("Nome da pessoa 3: " + pessoa3.Nome);
            Console.WriteLine("Data de nascimento da pessoa 3: " + pessoa3.DataNascimento);
            Console.WriteLine("CPF da pessoa 3: " + pessoa3.Cpf);
            Console.WriteLine("Telefone da pessoa 3: " + pessoa3.Telefone);

            Console.ReadKey();
        }
    }
}
