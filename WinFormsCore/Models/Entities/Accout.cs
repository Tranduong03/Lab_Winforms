using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCore.Models.Entities
{
    public partial class Account
    {
        public int Id { get; set; }

        public string FullName { get; set; } = null!;

        public string UserName { get; set; } = null!;

        public string? Role { get; set; }

        public string? PassWord { get; set; }

    }
}
