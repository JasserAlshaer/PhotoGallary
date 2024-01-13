using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallary_Reopsitary.DTOs
{
    public class UploadImageDTO
    {
        public int? Id { get; set; }
        public string? URL {  get; set; }
        public string? FileName { get; set; }

        public IFormFile? File { get; set; }
    }
}
