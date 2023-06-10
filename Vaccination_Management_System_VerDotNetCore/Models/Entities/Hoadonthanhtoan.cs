using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class Hoadonthanhtoan
    {
        public Hoadonthanhtoan()
        {
            Dotthanhtoans = new HashSet<Dotthanhtoan>();
        }

        public int Mahd { get; set; }
        public int Makh { get; set; }
        public int Manv { get; set; }
        public int Mapdkt { get; set; }
        public DateTime? Ngaylap { get; set; }
        public string Hinhthuctt { get; set; }
        public double? Tongtien { get; set; }
        public double? Sotiendatt { get; set; }

        public virtual Khachhang MakhNavigation { get; set; }
        public virtual Nhanvien ManvNavigation { get; set; }
        public virtual Phieudangkytiem MapdktNavigation { get; set; }
        public virtual ICollection<Dotthanhtoan> Dotthanhtoans { get; set; }
    }
}
