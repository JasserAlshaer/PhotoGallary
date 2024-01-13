using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallary_Reopsitary.DTOs
{
    public class ImageDTO
    {
        public int Id { get; set; }
        public string? Url { get; set; }
        public string? ImagePath { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
