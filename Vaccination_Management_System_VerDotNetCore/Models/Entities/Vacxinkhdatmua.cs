using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class Vacxinkhdatmua
    {
        public int Mapdmkh { get; set; }
        public int Mavc { get; set; }
        public int? Soluong { get; set; }

        public virtual PhieudatmuacuaKh MapdmkhNavigation { get; set; }
        public virtual Vacxin MavcNavigation { get; set; }
    }
}
