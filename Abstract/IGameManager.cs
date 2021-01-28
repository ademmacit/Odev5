using Odev5.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5.Abstract
{
    interface IGameManager
    {
        void AddGame(Game Game);
        void DeleteGame(int GameId);
        List<Game> ListGames();
        Game GetGameById(int id);
    }
}
