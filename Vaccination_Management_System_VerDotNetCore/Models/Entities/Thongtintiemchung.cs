using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class Thongtintiemchung
    {
        public int Mathongtin { get; set; }
        public int Makh { get; set; }
        public int Mavc { get; set; }
        public int Manv { get; set; }
        public DateTime? Ngaytiem { get; set; }
        public DateTime? Ngaytiemtieptheo { get; set; }
        public string Tinhtrangbn { get; set; }
        public string Ghichu { get; set; }
    }
}
