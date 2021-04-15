using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor_Rpg_do_Mundo
{
    public class Menu
    {
        public string Escolha { get; set; }
        public void ChamarMenu()
        {

        Escolha1:
            Console.WriteLine("MENOR RPG DO MUNDO\nCada escolha faz diferença");
        
            Console.WriteLine("Escolha uma das opções:\n1 - Jogar\n2 - Ranking\n3 - Sair ");
            Console.Write("Digite o número da opção desejada: ");
            Escolha = Console.ReadLine();
            // int opcao1 = int.Parse(Console.ReadLine());
            switch (Escolha)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Iniciando o JOGO !!!!!");
                    Jogo jogo = new Jogo();
                    jogo.ChamarJogo();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("ESTE É O RANKING - ÁREA EM CONSTRUÇÃO\nAperte ENTER para voltar ao MENU");
                    Console.ReadLine();
                    Console.Clear();
                    goto Escolha1;
                case "3": //falta consertar
                    Console.Clear();
                    Console.WriteLine("SAINDO DO JOGO");
                    goto Sair;
                   
                default:
                    Console.Clear();
                    Console.WriteLine("Você ainda parece confuso a opção não foi encontrada");
                    Console.WriteLine("Tente novamente: ");
                    goto Escolha1;
            }

        Sair:
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para sair");
            Console.ReadLine();
        }

    }
        
    }

