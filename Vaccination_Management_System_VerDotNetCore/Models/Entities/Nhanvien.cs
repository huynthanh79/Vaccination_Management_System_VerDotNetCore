using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Accounts = new HashSet<Account>();
            Giaychidinhtiemchungs = new HashSet<Giaychidinhtiemchung>();
            Hoadonthanhtoans = new HashSet<Hoadonthanhtoan>();
            Lichphancongs = new HashSet<Lichphancong>();
            Phieudangkytiems = new HashSet<Phieudangkytiem>();
            Phieudathangs = new HashSet<Phieudathang>();
            Thongtintiemchungs = new HashSet<Thongtintiemchung>();
        }

        public int Manv { get; set; }
        public int Matt { get; set; }
        public string Hotennv { get; set; }
        public string Gioitinh { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string Sdtnv { get; set; }
        public string Loainv { get; set; }
        public string Cmnd { get; set; }
        public string Diachinv { get; set; }

        public virtual Trungtamtiemchung MattNavigation { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Giaychidinhtiemchung> Giaychidinhtiemchungs { get; set; }
        public virtual ICollection<Hoadonthanhtoan> Hoadonthanhtoans { get; set; }
        public virtual ICollection<Lichphancong> Lichphancongs { get; set; }
        public virtual ICollection<Phieudangkytiem> Phieudangkytiems { get; set; }
        public virtual ICollection<Phieudathang> Phieudathangs { get; set; }
        public virtual ICollection<Thongtintiemchung> Thongtintiemchungs { get; set; }
    }
}
