using System;
using System.Collections.Generic;
using System.Text;
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
        private PlayerDTO playerDTO;
        [SetUp]
        public void Setup()
        {
            controller = new PlayerSelectionController(_logger);
            playerDTO = new PlayerDTO();
            playerDTO.PlayerBmi = 24;
            playerDTO.PlayerHeight = Convert.ToDecimal(5.4);
            playerDTO.PlayerRuns = 7000;
            playerDTO.PlayerWickets = 100;
            playerDTO.PlayerStumpings = 100;

        }

        [Test]
        public void Test_getPlayerList_API_PositiveCase()
        {

            Assert.AreEqual(11, controller.getPlayerList(playerDTO));
        }

        [Test]
        public void Test_getPlayerList_API_NegativeCase()
        {
            PlayerDTO playerDTOobj = new PlayerDTO();
            playerDTO.PlayerRuns = 70000;
            playerDTOobj.PlayerWickets = 1000;
            playerDTOobj.PlayerStumpings = 900;

            Assert.AreEqual(null, controller.getPlayerList(playerDTOobj));
        }


    }
}
