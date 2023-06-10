using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class Phieudathang
    {
        public Phieudathang()
        {
            Chitietpdhs = new HashSet<Chitietpdh>();
        }

        public int Mapdh { get; set; }
        public int Manv { get; set; }
        public DateTime? Ngaydat { get; set; }

        public virtual Nhanvien ManvNavigation { get; set; }
        public virtual ICollection<Chitietpdh> Chitietpdhs { get; set; }
    }
}
