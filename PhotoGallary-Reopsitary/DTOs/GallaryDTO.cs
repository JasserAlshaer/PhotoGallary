using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallary_Reopsitary.DTOs
{
    public class GallaryDTO
    {
        public ImageDTO ImageDTO { get; set; }
        public List<UserDTO> UserDTOs { get; set; }
    }
}
