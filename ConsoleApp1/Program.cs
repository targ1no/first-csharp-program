using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program

    {
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }

        static void Main(string[] args)
        {
            Opcoes();
        }

        static void Opcoes()
        {
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1 - Criar\n2 - Deletar\n3 - Editar\n4 - Listar\n5 - Atualizar");

            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Você escolheu a opção de Criar!");
                    break;

                case Opcao.Deletar:
                    Console.WriteLine("Você escolheu a opção de Deletar!");
                    break;

                case Opcao.Editar:
                    Console.WriteLine("Você escolheu a opção de Editar!");
                    break;

                case Opcao.Listar:
                    Console.WriteLine("Você escolheu a opção de Listar!");
                    break;

                case Opcao.Atualizar:
                    Console.WriteLine("Você escolheu a opção de Atualizar!");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("Sair do programa? S/N");
            string respostaUser = Console.ReadLine();

            switch (respostaUser)
            {
                case "S":
                    break;

                case "N":
                    Opcoes();
                    Console.ReadLine();
                    break;
            }
        }
    }
}
