using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class Chitietpdh
    {
        public int Mavc { get; set; }
        public int Mapdh { get; set; }
        public int? Soluong { get; set; }
        public string Nhacungcap { get; set; }

        public virtual Phieudathang MapdhNavigation { get; set; }
        public virtual Vacxin MavcNavigation { get; set; }
    }
}
