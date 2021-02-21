using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballTeam.BusinessLayer.Abstract;
using FootballTeam.BusinessLayer.Concrete;
using FootballTeam.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootballTeam.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballTeamController : ControllerBase
    {
        private IFootballTeamService _footballTeamService;
        public FootballTeamController(IFootballTeamService footballMangerService)
        {
            _footballTeamService = footballMangerService;
        }

        /// <summary>
        /// Futbolcuları listeler.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Footballers> Get()
        {
            return _footballTeamService.GetAllPlayers();
        }

        /// <summary>
        /// id numaralı futbolcuyu getirir.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Footballers Get(int id)
        {
            return _footballTeamService.GetPlayerById(id);
        }

        /// <summary>
        /// Futbolcu ekler.
        /// </summary>
        /// <param name="footballers"></param>
        /// <returns></returns>
        [HttpPost]
        public Footballers Post([FromBody]Footballers footballers)
        {
            return _footballTeamService.CreatePlayers(footballers);
        }

        /// <summary>
        /// Varolan futbolcu bilgileri günceller.
        /// </summary>
        /// <param name="footballers"></param>
        /// <returns></returns>
        [HttpPut]
        public Footballers Put([FromBody]Footballers footballers)
        {
            return _footballTeamService.UpdatePlayers(footballers);
        }

        /// <summary>
        /// Kayıtlı futbolcuyu siler.
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _footballTeamService.DeletePlayers(id);
        }
    }
}