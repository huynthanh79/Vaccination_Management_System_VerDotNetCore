using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class Vacxinthuocgoi
    {
        public int Magoi { get; set; }
        public int Mavc { get; set; }

        public virtual Goivacxin MagoiNavigation { get; set; }
        public virtual Vacxin MavcNavigation { get; set; }
    }
}
