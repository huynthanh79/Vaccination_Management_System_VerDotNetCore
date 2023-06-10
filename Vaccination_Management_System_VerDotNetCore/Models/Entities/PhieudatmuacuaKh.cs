using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class PhieudatmuacuaKh
    {
        public PhieudatmuacuaKh()
        {
            Vacxinkhdatmuas = new HashSet<Vacxinkhdatmua>();
        }

        public int Mapdmkh { get; set; }
        public int Makh { get; set; }
        public DateTime? Ngaydukiennhan { get; set; }
        public DateTime? Ngaylap { get; set; }

        public virtual Khachhang MakhNavigation { get; set; }
        public virtual ICollection<Vacxinkhdatmua> Vacxinkhdatmuas { get; set; }
    }
}
