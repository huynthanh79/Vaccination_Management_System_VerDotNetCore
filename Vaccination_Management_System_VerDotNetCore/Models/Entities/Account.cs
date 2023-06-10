using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class Account
    {
        public string Username { get; set; }
        public int Manv { get; set; }
        public string Password { get; set; }

        public virtual Nhanvien ManvNavigation { get; set; }
    }
}
