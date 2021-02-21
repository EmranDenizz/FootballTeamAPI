using FootballTeam.BusinessLayer.Abstract;
using FootballTeam.DAL.Abstract;
using FootballTeam.DAL.Concrete;
using FootballTeam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeam.BusinessLayer.Concrete
{
    public class FootballTeamManager : IFootballTeamService
    {
        private IFootballTeamRepository _footballTeamRepository;
        public FootballTeamManager(IFootballTeamRepository footballTeamRepository)//Dependency Injections işlemi
        {
            _footballTeamRepository = footballTeamRepository;
        }
        public Footballers CreatePlayers(Footballers footballers)
        {
            return _footballTeamRepository.CreatePlayers(footballers);
        }

        public void DeletePlayers(int id)
        {
            _footballTeamRepository.DeletePlayers(id);
        }

        public List<Footballers> GetAllPlayers()
        {
            return _footballTeamRepository.GetAllPlayers();
        }

        public Footballers GetPlayerById(int id)
        {
            return _footballTeamRepository.GetPlayerById(id);
        }

        public Footballers UpdatePlayers (Footballers footballers)
        {
            return _footballTeamRepository.UpdatePlayers(footballers);
        }
    }
}
