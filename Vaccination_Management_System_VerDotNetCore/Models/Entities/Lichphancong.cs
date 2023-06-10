using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class Lichphancong
    {
        public int Manv { get; set; }
        public string Calam { get; set; }
        public DateTime Ngaylam { get; set; }
        public string Vitri { get; set; }

        public virtual Nhanvien ManvNavigation { get; set; }
    }
}
