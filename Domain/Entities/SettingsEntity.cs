using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSpresso.Domain.Entities
{
    public class SettingsEntity
    {
        public int Id { get; set; }
        public string CafeName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
    }
}
