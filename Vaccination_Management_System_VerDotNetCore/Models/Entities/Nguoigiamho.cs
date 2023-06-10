using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class Nguoigiamho
    {
        public Nguoigiamho()
        {
            Khachhangs = new HashSet<Khachhang>();
        }

        public int Mangh { get; set; }
        public string CmndNgh { get; set; }
        public string Hotenngh { get; set; }
        public string Sdtngh { get; set; }
        public string Diachingh { get; set; }

        public virtual ICollection<Khachhang> Khachhangs { get; set; }
    }
}
