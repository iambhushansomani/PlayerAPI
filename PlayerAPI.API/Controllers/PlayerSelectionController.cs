using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlayerAPI.Services.Implementation;
using PlayerAPI.API.Models;
using PlayerAPI.Models.Models;

namespace PlayerAPI.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlayerSelectionController : ControllerBase
    {
        private readonly ILogger<PlayerSelectionController> _logger;

        public PlayerSelectionController(ILogger<PlayerSelectionController> logger)
        {
            _logger = logger;
        }



        [HttpGet]
        public string Get()
        {
            return "Welcome to Player Selection API !!";
        }


        [HttpPost]
        [Route("getBatsmanList")]
        public List<PlayerMaster> getBatsmanList( PlayerDTO playerDTO)
        {
            PlayerService playerservice = new PlayerService();
            return playerservice.getBatsman(5, playerDTO);
        }


        [HttpPost]
        [Route("getBowlerList")]
        public List<PlayerMaster> getBowlerList( PlayerDTO playerDTO)
        {
            PlayerService playerservice = new PlayerService();
            return playerservice.getBowler(5,  playerDTO);
        }


        [HttpPost]
        [Route("getWicketKeeperList")]
        public List<PlayerMaster> getWicketKeeperList( PlayerDTO playerDTO)
        {
            PlayerService playerservice = new PlayerService();
            return playerservice.getWeeketKeeper(1, playerDTO);
        }

        [HttpPost]
        [Route("getPlayerList")]
        public IEnumerable<PlayerMaster> getPlayerList(PlayerDTO playerDTO)
        {
            PlayerService playerservice = new PlayerService();
            return playerservice.finalList(playerDTO);
        }

        
    }
}
