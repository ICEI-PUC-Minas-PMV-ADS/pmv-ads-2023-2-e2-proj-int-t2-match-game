using IGDB;
using IGDB.Models;
using System;
using System.Threading.Tasks;

namespace Match_Game_Oficial.Models
{
    public class IGDBClass
    {
        private readonly IGDBClient igdb;

        public IGDBClass()
        {
            // Inicialize o cliente IGDB no construtor
            igdb = new IGDBClient(
                "5mkw3nhbkgynl2ce8v0if2hgtq6wvc",
               "feh5a7mdwa4cl9xx97ejxh5fh8duvd"
            );
        }

        public async Task<List<Game>> GetGamesAsync()
        {
            // Realize a consulta dentro de um método assíncrono
            var games = await igdb.QueryAsync<Game>(IGDBClient.Endpoints.Games, query: "fields id,name, first_release_date, storyline; limit 50;");
            var gameList = games.ToList();

            return gameList;
        }
    }
}
