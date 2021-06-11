
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
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
        public List<PlayerMaster> getBatsmanList( PlayerDTO playerdto)
        {
            PlayerService playerservice = new PlayerService();
            return playerservice.getBatsman(5, playerdto);
        }


        [HttpPost]
        [Route("getBowlerList")]
        public List<PlayerMaster> getBowlerList( PlayerDTO playerdto)
        {
            PlayerService playerservice = new PlayerService();
            return playerservice.getBowler(5,  playerdto);
        }


        [HttpPost]
        [Route("getWicketKeeperList")]
        public List<PlayerMaster> getWicketKeeperList( PlayerDTO playerdto)
        {
            PlayerService playerservice = new PlayerService();
            return playerservice.getWeeketKeeper(1, playerdto);
        }

        [HttpPost]
        [Route("getPlayerList")]
        public List<PlayerMaster> getPlayerList(PlayerDTO playerdto)
        {
            PlayerService playerservice = new PlayerService();
            return playerservice.finalList(playerdto);
        }

        
    }
}
