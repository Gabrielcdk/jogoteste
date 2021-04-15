using System;

namespace Menor_Rpg_do_Mundo.Game
{
    class GameLoop
    {
        private Game myGame;

        /// <summary>
        /// Status of GameLoop
        /// </summary>
        public bool running { get; private set; }

        /// <summary>
        /// Load Game into Loop
        /// </summary>
        /// <param name="gameObj"></param>
        public void Load(Game gameObj)
        {
            myGame = gameObj;
        }

        /// <summary>
        /// Start GameLoop
        /// </summary>
        public async void Start()
        {
            if (myGame == null)
                throw new ArgumentException("Game not loaded!");

            // Load game content
            myGame.Load();

            // Set gameLoop state
            running = true;

            while (running)
            {
                running = !myGame.Update();
            }

            Stop();
        }

        /// <summary>
        /// Stop the game
        /// </summary>
        public async void Stop()
        {
            running = false;
            myGame?.Unload();
        }
    }
}
