using System;
using System.Collections.Generic;

#nullable disable

namespace PlayerAPI.API.Models
{
    public partial class PlayerMaster
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int PlayerCountry { get; set; }
        public int PlayerType { get; set; }
        public decimal PlayerHeight { get; set; }
        public int PlayerBmi { get; set; }
        public int PlayerRuns { get; set; }
        public int PlayerWickets { get; set; }
        public int PlayerStumpings { get; set; }

        public virtual CountryMaster PlayerCountryNavigation { get; set; }
        public virtual PlayerTypeMaster PlayerTypeNavigation { get; set; }
    }
}
