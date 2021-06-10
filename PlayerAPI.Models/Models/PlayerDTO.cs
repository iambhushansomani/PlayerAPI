using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerAPI.Models.Models
{
    public partial class PlayerDTO
    {
            public decimal PlayerHeight { get; set; }
            public int PlayerBmi { get; set; }
            public int PlayerRuns { get; set; }
            public int PlayerWickets { get; set; }
            public int PlayerStumpings { get; set; }

        
    }
}
