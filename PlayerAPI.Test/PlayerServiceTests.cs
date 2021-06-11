using NUnit.Framework;
using PlayerAPI.Models.Models;
using PlayerAPI.Services.Implementation;
using System;

namespace PlayerAPI.Test
{
    public class PlayerServiceTests
    {
        private PlayerService playerservice;
        private PlayerDTO playerDTO;
        [SetUp]
        public void Setup()
        {
            playerservice =new PlayerService();
            playerDTO = new PlayerDTO();
            playerDTO.PlayerBmi = 24;
            playerDTO.PlayerHeight = Convert.ToDecimal(5.4);
            playerDTO.PlayerRuns = 7000;
            playerDTO.PlayerWickets = 100;
            playerDTO.PlayerStumpings = 100;
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(5, 5)]
        public void Test_BatsmanCount(int id, int expectedresult)
        {
           int actualcount= playerservice.getBatsman(id, playerDTO).Count;
            Assert.AreEqual(expectedresult, actualcount);
        }



        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(5, 5)]
        public void Test_BowlerCount(int id, int expectedresult)
        {
            int actualcount = playerservice.getBowler(id, playerDTO).Count;
            Assert.AreEqual(expectedresult, actualcount);
        }

            
        [TestCase(1,1)]
        [TestCase(2, 2)]
        public void Test_WicketKeeperCount(int id, int expectedresult)
        {
            int actualcount = playerservice.getWeeketKeeper(id, playerDTO).Count;
            Assert.AreEqual(expectedresult, actualcount);
        }


       [Test]
        public void Test_FinalList_PositiveCase()
        {
            int actualcount = playerservice.finalList(playerDTO).Count;
            Assert.AreEqual(11, actualcount);
        }


        [Test]
        public void Test_FinalList_NegativeCase()
        {
            PlayerDTO playerDTOobj = new PlayerDTO();
            playerDTO.PlayerRuns = 70000;
            playerDTOobj.PlayerWickets = 1000;
            playerDTOobj.PlayerStumpings = 900;
             
            Assert.AreEqual(null, playerservice.finalList(playerDTOobj));
        }


    }
}