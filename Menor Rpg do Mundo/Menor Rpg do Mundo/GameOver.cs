using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor_Rpg_do_Mundo
{
   public class GameOver
    {
       public GameOver()
        {

        }
        public void TextoGameOver()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Com meus últimos esforços escrevo aqui os meus feitos...\npara que o mundo nunca se esqueça de Sir " + Jogo.nomedoJogador);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("= = = R A N K I N G T O P 3 = = ="); //ainda implementar
            Console.WriteLine("1º - "+ Jogo.nomedoJogador + " sobreviveu " + Jogo.diasCont + " dias");
            Console.WriteLine("2º - " + Jogo.nomedoJogador + " sobreviveu " + Jogo.diasCont + " dias");
            Console.WriteLine("3º - " + Jogo.nomedoJogador + " sobreviveu " + Jogo.diasCont + " dias");
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER PARA VOLTAR AO MENU");
            Console.ReadLine();
            Console.Clear();
            ChamaroMenu();
        }

        static void ChamaroMenu()
        {
            Menu menu = new Menu();
            menu.ChamarMenu();
        }

       

    }
}
