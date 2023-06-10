using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class Phieudangkytiem
    {
        public Phieudangkytiem()
        {
            Goithuocphieus = new HashSet<Goithuocphieu>();
            Hoadonthanhtoans = new HashSet<Hoadonthanhtoan>();
            Vacxinthuocphieus = new HashSet<Vacxinthuocphieu>();
        }

        public int Mapdkt { get; set; }
        public int Matt { get; set; }
        public int Manv { get; set; }
        public int Makh { get; set; }
        public string Hinhthuctiem { get; set; }
        public DateTime? Ngaylap { get; set; }
        public int? Dangkychobanthan { get; set; }

        public virtual Khachhang MakhNavigation { get; set; }
        public virtual Nhanvien ManvNavigation { get; set; }
        public virtual Trungtamtiemchung MattNavigation { get; set; }
        public virtual ICollection<Goithuocphieu> Goithuocphieus { get; set; }
        public virtual ICollection<Hoadonthanhtoan> Hoadonthanhtoans { get; set; }
        public virtual ICollection<Vacxinthuocphieu> Vacxinthuocphieus { get; set; }
    }
}
