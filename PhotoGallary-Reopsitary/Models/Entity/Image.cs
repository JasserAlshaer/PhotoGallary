using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallary_Reopsitary.Models.Entity
{
    public class Image
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Url { get; set; }
        public string ImagePath { get; set; }
        public string Extension { get; set; }
        public virtual ICollection<Gallary> Gallaries { get; set; } 
        public bool IsActive { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
