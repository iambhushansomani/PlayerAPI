using NUnit.Framework;
using PlayerAPI.Models.Models;
using PlayerAPI.Services.Implementation;
using System;

namespace PlayerAPI.Test
{
    public class PlayerServiceTests
    {
        private PlayerService playerservice;
        private PlayerDTO playerdto;
        [SetUp]
        public void Setup()
        {
            playerservice =new PlayerService();
            playerdto = new PlayerDTO();
            playerdto.PlayerBmi = 24;
            playerdto.PlayerHeight = Convert.ToDecimal(5.4);
            playerdto.PlayerRuns = 7000;
            playerdto.PlayerWickets = 100;
            playerdto.PlayerStumpings = 100;
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(5, 5)]
        public void Test_BatsmanCount__PositiveCases(int id, int expectedresult)
        {
           int actualcount= playerservice.getBatsman(id, playerdto).Count;
            Assert.AreEqual(expectedresult, actualcount);
        }

        [TestCase(0 )]
       
        public void Test_BatsmanCount__NegativeCase(int id)
        {
            var actualcount = playerservice.getBatsman(id, playerdto);
            Assert.AreEqual(null, actualcount);
        }



        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(5, 5)]
        public void Test_BowlerCount_PositiveCases(int id, int expectedresult)
        {
            int actualcount = playerservice.getBowler(id, playerdto).Count;
            Assert.AreEqual(expectedresult, actualcount);
        }

        [TestCase(0)]
        public void Test_BowlerCount_Negativecase(int id)
        {
            var actualcount = playerservice.getBowler(id, playerdto);
            Assert.AreEqual(null, actualcount);
        }


        [TestCase(1,1)]
        [TestCase(2, 2)]
        public void Test_WicketKeeperCount_PositiveCases(int id, int expectedresult)
        {
            int actualcount = playerservice.getWeeketKeeper(id, playerdto).Count;
            Assert.AreEqual(expectedresult, actualcount);
        }


        [TestCase(0)]
        public void Test_WicketKeeperCount_NegativeCases(int id)
        {
            var actualcount = playerservice.getWeeketKeeper(id, playerdto);
            Assert.AreEqual(null, actualcount);
        }

        [Test]
        public void Test_FinalList_PositiveCase()
        {
            int actualcount = playerservice.finalList(playerdto).Count;
            Assert.AreEqual(11, actualcount);
        }


        [Test]
        public void Test_FinalList_NegativeCase()
        {
            PlayerDTO playerdtoobj = new PlayerDTO();
            playerdto.PlayerRuns = 70000;
            playerdtoobj.PlayerWickets = 1000;
            playerdtoobj.PlayerStumpings = 900;
             
            Assert.AreEqual(null, playerservice.finalList(playerdtoobj));
        }


    }
}