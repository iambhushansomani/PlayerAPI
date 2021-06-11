using System;
using System.Collections.Generic;
using System.Text;
using PlayerAPI.API.Models;
using PlayerAPI.Services.Interfaces;
using System.Linq;
using PlayerAPI.Models.Models;

namespace PlayerAPI.Services.Implementation
{
    public class PlayerService : IPlayerService
    {
        private PlayerDBContext dbcontectobj = new PlayerDBContext();
        
        public List<PlayerMaster> getBatsman(int numberofbatsman, PlayerDTO playerDTO)
        {
            try
            {
                var batsmanlist = (from n in dbcontectobj.PlayerMasters
                                   where n.PlayerType == 1 && n.PlayerRuns > playerDTO.PlayerRuns && n.PlayerHeight > Convert.ToDecimal(playerDTO.PlayerHeight) && n.PlayerBmi < playerDTO.PlayerBmi
                                   select n).Take(numberofbatsman);

                return batsmanlist.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
          
        }

        public List<PlayerMaster> getBowler(int numberofbowler, PlayerDTO playerDTO)
        {
            try
            {
                var bowlerlist = (from n in dbcontectobj.PlayerMasters
                                  where n.PlayerType==2 && n.PlayerWickets > playerDTO.PlayerWickets && n.PlayerHeight > Convert.ToDecimal(playerDTO.PlayerHeight) && n.PlayerBmi < playerDTO.PlayerBmi
                                  select n).Take(numberofbowler);

                return bowlerlist.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        }

        public List<PlayerMaster> getWeeketKeeper(int numberofwicketkeeper, PlayerDTO playerDTO)
        {
            var wicketkeeperlist = (from n in dbcontectobj.PlayerMasters
                              where n.PlayerType == 3 && n.PlayerStumpings > playerDTO.PlayerStumpings && n.PlayerHeight> Convert.ToDecimal(playerDTO.PlayerHeight) && n.PlayerBmi< playerDTO.PlayerBmi
                                    select n).Take(numberofwicketkeeper);

            return wicketkeeperlist.ToList();
             
        }

        public List<PlayerMaster> finalList(PlayerDTO playerDTO)
        {
            try
            {
                PlayerService playerserviceobj = new PlayerService();
                List<PlayerMaster> finallist = new List<PlayerMaster>();
                finallist.AddRange(playerserviceobj.getBatsman(5, playerDTO));
                finallist.AddRange(playerserviceobj.getBowler(5, playerDTO));
                finallist.AddRange(playerserviceobj.getWeeketKeeper(1, playerDTO));
                if (finallist.Count == 11)
                    return finallist;
                else
                    return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
