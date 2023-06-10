using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class Trungtamtiemchung
    {
        public Trungtamtiemchung()
        {
            Khochuas = new HashSet<Khochua>();
            Nhanviens = new HashSet<Nhanvien>();
            Phieudangkytiems = new HashSet<Phieudangkytiem>();
        }

        public int Matt { get; set; }
        public string Tentt { get; set; }
        public string Diachi { get; set; }

        public virtual ICollection<Khochua> Khochuas { get; set; }
        public virtual ICollection<Nhanvien> Nhanviens { get; set; }
        public virtual ICollection<Phieudangkytiem> Phieudangkytiems { get; set; }
    }
}
