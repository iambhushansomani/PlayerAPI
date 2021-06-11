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

        public List<PlayerMaster> getBatsman(int numberofbatsman, PlayerDTO playerdto)
        {
            try
            {
                var batsmanlist = (from n in dbcontectobj.PlayerMasters
                                   where n.PlayerType == 1 && n.PlayerRuns > playerdto.PlayerRuns && n.PlayerHeight > Convert.ToDecimal(playerdto.PlayerHeight) && n.PlayerBmi < playerdto.PlayerBmi
                                  orderby n.PlayerRuns descending
                                   select n).Take(numberofbatsman);

               

                if (batsmanlist.ToList().Count > 0)
                    return batsmanlist.ToList();
                else
                    return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<PlayerMaster> getBowler(int numberofbowler, PlayerDTO playerdto)
        {
            try
            {
                var bowlerlist = (from n in dbcontectobj.PlayerMasters
                                  where n.PlayerType == 2 && n.PlayerWickets > playerdto.PlayerWickets && n.PlayerHeight > Convert.ToDecimal(playerdto.PlayerHeight) && n.PlayerBmi < playerdto.PlayerBmi
                                  orderby n.PlayerWickets descending
                                  select n).Take(numberofbowler);
                if (bowlerlist.ToList().Count > 0)
                    return bowlerlist.ToList();
                else
                    return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<PlayerMaster> getWeeketKeeper(int numberofwicketkeeper, PlayerDTO playerdto)
        {
            var wicketkeeperlist = (from n in dbcontectobj.PlayerMasters
                                    where n.PlayerType == 3 && n.PlayerStumpings > playerdto.PlayerStumpings && n.PlayerHeight > Convert.ToDecimal(playerdto.PlayerHeight) && n.PlayerBmi < playerdto.PlayerBmi
                                    orderby n.PlayerStumpings descending
                                    select n).Take(numberofwicketkeeper);
            if (wicketkeeperlist.ToList().Count > 0)
                return wicketkeeperlist.ToList();
            else
                return null;

        }

        public List<PlayerMaster> finalList(PlayerDTO playerdto)
        {
            try
            {
                PlayerService playerserviceobj = new PlayerService();
                List<PlayerMaster> finallist = new List<PlayerMaster>();
                if(playerserviceobj.getBatsman(5, playerdto)!=null)
                finallist.AddRange(playerserviceobj.getBatsman(5, playerdto));
                if (playerserviceobj.getBowler(5, playerdto)!=null)
                finallist.AddRange(playerserviceobj.getBowler(5, playerdto));
                if (playerserviceobj.getWeeketKeeper(1, playerdto)!=null)
                    finallist.AddRange(playerserviceobj.getWeeketKeeper(1, playerdto));
                if (finallist.Count==11)
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
