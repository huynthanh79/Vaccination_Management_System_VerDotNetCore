using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class Dotthanhtoan
    {
        public int Mahd { get; set; }
        public int Stt { get; set; }
        public double? Sotientt { get; set; }
        public DateTime? Ngaythanhtoan { get; set; }

        public virtual Hoadonthanhtoan MahdNavigation { get; set; }
    }
}
