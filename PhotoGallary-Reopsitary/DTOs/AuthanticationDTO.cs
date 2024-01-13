using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallary_Reopsitary.DTOs
{
    public class AuthanticationDTO
    {
        public int? Id;
        public string? Name { get; set; }
        public string? Email { get; set; }   
        public string? Password { get; set; }
    }
}
