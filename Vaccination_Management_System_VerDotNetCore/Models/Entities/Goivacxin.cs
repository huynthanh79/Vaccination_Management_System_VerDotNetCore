using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class Goivacxin
    {
        public Goivacxin()
        {
            Goithuocphieus = new HashSet<Goithuocphieu>();
            Vacxinthuocgois = new HashSet<Vacxinthuocgoi>();
        }

        public int Magoi { get; set; }
        public string Tengoi { get; set; }
        public string Ghichu { get; set; }

        public virtual ICollection<Goithuocphieu> Goithuocphieus { get; set; }
        public virtual ICollection<Vacxinthuocgoi> Vacxinthuocgois { get; set; }
    }
}
