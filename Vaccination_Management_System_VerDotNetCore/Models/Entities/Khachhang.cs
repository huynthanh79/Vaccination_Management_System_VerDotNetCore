using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class Khachhang
    {
        public Khachhang()
        {
            Giaychidinhtiemchungs = new HashSet<Giaychidinhtiemchung>();
            Hoadonthanhtoans = new HashSet<Hoadonthanhtoan>();
            Phieudangkytiems = new HashSet<Phieudangkytiem>();
            PhieudatmuacuaKhs = new HashSet<PhieudatmuacuaKh>();
            Thongtintiemchungs = new HashSet<Thongtintiemchung>();
        }

        public int Makh { get; set; }
        public int? Mangh { get; set; }
        public string Hotenkh { get; set; }
        public string Sdt { get; set; }
        public string Cmnd { get; set; }
        public string Diachi { get; set; }

        public virtual Nguoigiamho ManghNavigation { get; set; }
        public virtual ICollection<Giaychidinhtiemchung> Giaychidinhtiemchungs { get; set; }
        public virtual ICollection<Hoadonthanhtoan> Hoadonthanhtoans { get; set; }
        public virtual ICollection<Phieudangkytiem> Phieudangkytiems { get; set; }
        public virtual ICollection<PhieudatmuacuaKh> PhieudatmuacuaKhs { get; set; }
        public virtual ICollection<Thongtintiemchung> Thongtintiemchungs { get; set; }
    }
}
