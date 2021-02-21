using FootballTeam.DAL.Abstract;
using FootballTeam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeam.DAL.Concrete
{
    public class FootballTeamRepository : IFootballTeamRepository
    {
        public Footballers CreatePlayers(Footballers footballers)
        {
            using(var fteamDb = new FteamDbContext())
            {
                fteamDb.players.Add(footballers);
                fteamDb.SaveChanges();
                return footballers;
            }
        }

        public void DeletePlayers(int id)
        {
           using(var fteamDb = new FteamDbContext())
            {
                var deletedPlayer = GetPlayerById(id);
                fteamDb.players.Remove(deletedPlayer);
                fteamDb.SaveChanges();
            }
        }

        public List<Footballers> GetAllPlayers()
        {
            using (var fteamDb = new FteamDbContext()) //Veritabanı için gerekli yol tarifini değişkene atadık. 
            {
                return fteamDb.players.ToList(); 
            }
        }

        public Footballers GetPlayerById(int id)
        {
            using(var fteamDb = new FteamDbContext())
            {
                var player = fteamDb.players.FirstOrDefault(x => x.Id == id);
                return player;
            }
        }

        public Footballers UpdatePlayers(Footballers footballers)
        {
           using(var fteamDb = new FteamDbContext())
            {
                fteamDb.players.Update(footballers);
                fteamDb.SaveChanges();
                return footballers;
            }
        }
    }
}
