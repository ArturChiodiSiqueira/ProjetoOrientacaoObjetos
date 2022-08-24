using System;

namespace ProjetoOrientacaoObjetos
{
    internal class Pessoa
    {
        String Nome;
        DateTime DataNascimento;
        String Cpf;
        long Telefone;

        public Pessoa()
        {

        }

        public void setNome()
        {
            Console.Write("\nInforme seu nome: ");
            this.Nome = Console.ReadLine();
        }
        public void getNome()
        {
            Console.WriteLine("Nome: " + this.Nome);
        }

        public void setDataNascimento()
        {
            Console.Write("Informe sua data de nascimento (dd/MM/yyyy): ");
            this.DataNascimento = DateTime.Parse(Console.ReadLine());
        }
        public void getDataNascimento()
        {
            Console.WriteLine("Data de nascimento: " + this.DataNascimento);
        }
        public void setCpf()
        {
            Console.Write("Informe seu cpf: ");
            this.Cpf = Console.ReadLine();
        }
        public void getCpf()
        {
            Console.WriteLine("CPF: " + this.Cpf);
        }
        public void setTelefone()
        {
            Console.Write("Informe seu telefone: ");
            this.Telefone = long.Parse(Console.ReadLine());
        }
        public void getTelefone()
        {
            Console.WriteLine("Telefone: " + this.Telefone);
        }

        ///////////////////////////////////

        //public string Nome { get; set; }
        //public string DataNascimento { get; set; }
        //public long Cpf { get; set; }
        //public long Telefone { get; set; }

        //public void ImplementaNome()
        //{
        //    Console.Write("\nInforme seu nome: ");
        //    Nome = Console.ReadLine();
        //}

        //public void ImolementaDataNascimento()
        //{
        //    Console.Write("Informe sua data de nascimento: ");
        //    DataNascimento = Console.ReadLine();
        //}

        //public void ImplementaCPF()
        //{
        //    Console.Write("Informe seu cpf: ");
        //    Cpf = int.Parse(Console.ReadLine());
        //}

        //public void ImplementaTelefone()
        //{
        //    Console.Write("Informe seu telefone: ");
        //    Telefone = int.Parse(Console.ReadLine());
        //}
    }
}
