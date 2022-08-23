using System;

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

            Pessoa pessoa2 = new Pessoa();

            pessoa2.ImplementaNome();
            pessoa2.ImolementaDataNascimento();
            pessoa2.ImplementaCPF();
            pessoa2.ImplementaTelefone();

            Pessoa pessoa3 = new Pessoa();

            pessoa3.ImplementaNome();
            pessoa3.ImolementaDataNascimento();
            pessoa3.ImplementaCPF();
            pessoa3.ImplementaTelefone();
            Console.ReadKey();
        }
    }
}
