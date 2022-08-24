using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrientacaoObjetos
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public long Cpf { get; set; }
        public long Telefone { get; set; }

        public void ImplementaNome()
        {
            Console.Write("\nInforme seu nome: ");
            Nome = Console.ReadLine();
        }

        public void ImolementaDataNascimento()
        {
            Console.Write("Informe sua data de nascimento: ");
            DataNascimento = Console.ReadLine();
        }

        public void ImplementaCPF()
        {
            Console.Write("Informe seu cpf: ");
            Cpf = int.Parse(Console.ReadLine());
        }

        public void ImplementaTelefone()
        {
            Console.Write("Informe seu telefone: ");
            Telefone = int.Parse(Console.ReadLine());
        }
    }
}
