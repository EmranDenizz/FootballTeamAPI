using FootballTeam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeam.BusinessLayer.Abstract
{
    public interface IFootballTeamService
    {
        List<Footballers> GetAllPlayers();
        Footballers GetPlayerById(int id);
        Footballers CreatePlayers(Footballers footballers);
        Footballers UpdatePlayers(Footballers footballers);
        void DeletePlayers(int id);
    }
}
