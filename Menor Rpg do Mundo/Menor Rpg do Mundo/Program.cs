using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor_Rpg_do_Mundo
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game.Game();
            var gameLoop = new Game.GameLoop();

            gameLoop.Load(game);
            gameLoop.Start();


            //Menu:
            //Menu menu = new Menu();
            //menu.ChamarMenu();
            //switch (menu.Escolha)
            //{
            //    case "1":
            //        Console.Clear();
            //        Console.WriteLine("Iniciando o JOGO !!!!!");
            //        Jogo jogo = new Jogo();
            //        jogo.ChamarJogo();
            //        break;
            //    case "2":
            //        Console.Clear();
            //        Console.WriteLine("ESTE É O RANKING - ÁREA EM CONSTRUÇÃO\nAperte ENTER para voltar ao MENU");
            //        Console.ReadLine();
            //        Console.Clear();
            //        goto Menu;                    
            //    case "3":
            //        Console.Clear();
            //        Console.WriteLine("SAINDO DO JOGO");
            //        goto Sair;
                    
                    
            //}
                   
            //Sair:
            //Console.WriteLine();
            //Console.WriteLine("Aperte ENTER para sair");
            //Console.ReadLine();
        }
    }
}



