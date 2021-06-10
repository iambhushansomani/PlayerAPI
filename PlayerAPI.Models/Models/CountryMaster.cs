using System;
using System.Collections.Generic;

#nullable disable

namespace PlayerAPI.API.Models
{
    public partial class CountryMaster
    {
        public CountryMaster()
        {
            PlayerMasters = new HashSet<PlayerMaster>();
        }

        public int CountryId { get; set; }
        public string Country { get; set; }

        public virtual ICollection<PlayerMaster> PlayerMasters { get; set; }
    }
}
