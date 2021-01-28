using Odev5.Abstract;
using Odev5.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5.Concrete
{
    class GameManager : IGameManager
    {

        List<Game> games;

        public GameManager()
        {
            games = new List<Game>();
        }

        public void AddGame(Game game)
        {
          
                games.Add(game);
                Console.WriteLine("game added");
         
        }

        public void DeleteGame(int gameId)
        {
            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].Id == gameId)
                {
                    games.RemoveAt(i);
                    break;
                }
            }

        }

        public Game GetGameById(int id)
        {
            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].Id == id)
                {
                    return games[i];
                }
            }
            return games[0];
        }

        public List<Game> ListGames()
        {
            return games;
        }
    }
}
