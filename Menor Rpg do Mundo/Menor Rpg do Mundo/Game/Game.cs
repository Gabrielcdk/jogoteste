using System;

namespace Menor_Rpg_do_Mundo.Game
{
    class Game
    {
        /// <summary>
        /// True if is the initial menu
        /// </summary>
        private bool initialMenu { get; set; }

        /// <summary>
        /// Answer player choice
        /// </summary>
        private string choice { get; set; }

        /// <summary>
        /// GameOver state
        /// </summary>
        private bool gameOver { get; set; }

        /// <summary>
        /// Menu of the Game
        /// </summary>
        private Interface.Menu menu { get; set; }

        /// <summary>
        /// Load the game
        /// </summary>
        public void Load()
        {
            gameOver = false;
            initialMenu = true;
            menu = new Interface.Menu();
        }

        /// <summary>
        /// Unload the game
        /// </summary>
        public void Unload()
        {
            Console.WriteLine("SAINDO DO JOGO");

        }

        /// <summary>
        /// Update the game
        /// </summary>
        public bool Update()
        {
            Draw();

            switch (choice)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    gameOver = true;
                    break;
            }

            return gameOver;
        }

        /// <summary>
        /// Draw the game
        /// </summary>
        public void Draw()
        {
            Console.Clear();
            choice = menu.Draw();
        }
    }
}
