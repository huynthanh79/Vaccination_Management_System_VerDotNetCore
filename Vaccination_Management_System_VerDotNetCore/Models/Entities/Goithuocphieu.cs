using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class Goithuocphieu
    {
        public int Magoi { get; set; }
        public int Mapdkt { get; set; }

        public virtual Goivacxin MagoiNavigation { get; set; }
        public virtual Phieudangkytiem MapdktNavigation { get; set; }
    }
}
