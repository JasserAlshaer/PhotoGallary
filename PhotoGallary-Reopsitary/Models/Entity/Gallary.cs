using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallary_Reopsitary.Models.Entity
{
    public class Gallary
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public virtual Image Image { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
