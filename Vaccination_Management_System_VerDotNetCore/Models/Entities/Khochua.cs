using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class Khochua
    {
        public int Mavc { get; set; }
        public int Matt { get; set; }
        public int? Soluong { get; set; }

        public virtual Trungtamtiemchung MattNavigation { get; set; }
        public virtual Vacxin MavcNavigation { get; set; }
    }
}
