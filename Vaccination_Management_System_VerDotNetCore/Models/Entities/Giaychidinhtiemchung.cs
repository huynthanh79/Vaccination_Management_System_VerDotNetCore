using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class Giaychidinhtiemchung
    {
        public int Magcd { get; set; }
        public int Mavc { get; set; }
        public int Manv { get; set; }
        public int Makh { get; set; }
        public int? SttTiem { get; set; }
        public DateTime? Ngaytiem { get; set; }
        public string Trangthaichidinh { get; set; }
        public string Mota { get; set; }

        public virtual Khachhang MakhNavigation { get; set; }
        public virtual Nhanvien ManvNavigation { get; set; }
        public virtual Vacxin MavcNavigation { get; set; }
    }
}
