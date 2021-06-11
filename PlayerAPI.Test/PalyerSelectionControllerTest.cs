using System;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using PlayerAPI.API.Controllers;
using PlayerAPI.Models.Models;

namespace PlayerAPI.Test
{
   public class PalyerSelectionControllerTest
    {
        private readonly ILogger<PlayerSelectionController> _logger;
        private PlayerSelectionController controller;
        private PlayerDTO playerdto;
        [SetUp]
        public void Setup()
        {
            controller = new PlayerSelectionController(_logger);
            playerdto = new PlayerDTO();
            playerdto.PlayerBmi = 24;
            playerdto.PlayerHeight = Convert.ToDecimal(5.4);
            playerdto.PlayerRuns = 7000;
            playerdto.PlayerWickets = 100;
            playerdto.PlayerStumpings = 100;

        }

        [Test]
        public void Test_getPlayerList_API_PositiveCase()
        {
            
            Assert.AreEqual(11, controller.getPlayerList(playerdto).Count);
        }

        [Test]
        public void Test_getPlayerList_API_NegativeCase()
        {
            PlayerDTO playerdtoobj = new PlayerDTO();
            playerdto.PlayerRuns = 70000;
            playerdtoobj.PlayerWickets = 1000;
            playerdtoobj.PlayerStumpings = 900;

            Assert.AreEqual(null, controller.getPlayerList(playerdtoobj));
        }


    }
}
