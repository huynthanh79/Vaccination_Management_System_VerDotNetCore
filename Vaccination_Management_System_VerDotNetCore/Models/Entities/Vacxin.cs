using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class Vacxin
    {
        public Vacxin()
        {
            Chitietpdhs = new HashSet<Chitietpdh>();
            Giaychidinhtiemchungs = new HashSet<Giaychidinhtiemchung>();
            Khochuas = new HashSet<Khochua>();
            Thongtintiemchungs = new HashSet<Thongtintiemchung>();
            Vacxinkhdatmuas = new HashSet<Vacxinkhdatmua>();
            Vacxinthuocgois = new HashSet<Vacxinthuocgoi>();
            Vacxinthuocphieus = new HashSet<Vacxinthuocphieu>();
        }

        public int Mavc { get; set; }
        public string Tenvc { get; set; }
        public string Mota { get; set; }

        public virtual ICollection<Chitietpdh> Chitietpdhs { get; set; }
        public virtual ICollection<Giaychidinhtiemchung> Giaychidinhtiemchungs { get; set; }
        public virtual ICollection<Khochua> Khochuas { get; set; }
        public virtual ICollection<Thongtintiemchung> Thongtintiemchungs { get; set; }
        public virtual ICollection<Vacxinkhdatmua> Vacxinkhdatmuas { get; set; }
        public virtual ICollection<Vacxinthuocgoi> Vacxinthuocgois { get; set; }
        public virtual ICollection<Vacxinthuocphieu> Vacxinthuocphieus { get; set; }
    }
}
