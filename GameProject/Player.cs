﻿namespace GameProject
{
    internal class Player
    {
        private string _username { get; } = string.Empty;
        private List<Game> gameLibrary;
        private List<GameConsole> gameConsole;

        public Player(string username)
        {
            _username = username;
            gameLibrary = new List<Game>();
            gameConsole = new List<GameConsole>();
        }

    }
}
