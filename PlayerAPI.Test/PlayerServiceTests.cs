using NUnit.Framework;
using PlayerAPI.Services.Implementation;

namespace PlayerAPI.Test
{
    public class PlayerServiceTests
    {
        PlayerService playerservice;
        [SetUp]
        public void Setup()
        {
             playerservice =new PlayerService();
        }

        [Test]
        public void Test1()
        {
            playerservice.getBatsman(5);
            Assert.Pass();
        }
    }
}