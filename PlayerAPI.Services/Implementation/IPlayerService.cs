using System;
using System.Collections.Generic;
using System.Text;
using PlayerAPI.API.Models;
using PlayerAPI.Models.Models;

namespace PlayerAPI.Services.Interfaces
{
    public interface IPlayerService
    {
        public List<PlayerMaster> getBatsman(int numberofbatsman, PlayerDTO playerdto);
        public List<PlayerMaster> getBowler(int numberofbowler, PlayerDTO playerdto);

        public List<PlayerMaster> getWeeketKeeper(int numberofwicketkeeper, PlayerDTO playerdto);
    }
}
