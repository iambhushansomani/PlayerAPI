using System;
using System.Collections.Generic;

#nullable disable

namespace PlayerAPI.API.Models
{
    public partial class PlayerTypeMaster
    {
        public PlayerTypeMaster()
        {
            PlayerMasters = new HashSet<PlayerMaster>();
        }

        public int PlayerTypeId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<PlayerMaster> PlayerMasters { get; set; }
    }
}
