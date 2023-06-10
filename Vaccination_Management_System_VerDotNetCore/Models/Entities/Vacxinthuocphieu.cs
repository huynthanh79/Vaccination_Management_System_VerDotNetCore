using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class Vacxinthuocphieu
    {
        public int Mapdkt { get; set; }
        public int Mavc { get; set; }

        public virtual Phieudangkytiem MapdktNavigation { get; set; }
        public virtual Vacxin MavcNavigation { get; set; }
    }
}
