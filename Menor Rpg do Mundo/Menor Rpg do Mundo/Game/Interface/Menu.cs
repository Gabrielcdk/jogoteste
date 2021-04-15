using System;

namespace Menor_Rpg_do_Mundo.Game.Interface
{
    class Menu
    {
        private string choice { get; set; }
        public string Draw()
        {
            Console.WriteLine("MENOR RPG DO MUNDO\nCada escolha faz diferença");
            Console.WriteLine("Escolha uma das opções:\n1 - Jogar\n2 - Ranking\n3 - Sair ");
            Console.Write("Digite o número da opção desejada: ");
            choice = Console.ReadLine();

            // #TODO: convert to int
            return choice;
        }

        public Menu()
        {
            choice = "0";
        }
    }
}
