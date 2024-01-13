using PhotoGallary_Reopsitary.DTOs;
using PhotoGallary_Reopsitary.IReops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallary_Reopsitary.Implementation
{
    public class PhotoGallary : IPhotoGallary
    {
        public Task<bool> DeleteImage(UploadImageDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<GallaryDTO> GetImageById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ImageDTO>> GetImages()
        {
            throw new NotImplementedException();
        }

        public Task<string> Login(AuthanticationDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Logout(AuthanticationDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Registraion(AuthanticationDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<ImageDTO>> SearchImages(string? name, string? description, string? extention)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateImage(UploadImageDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UploadNewImage(UploadImageDTO dto)
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> Users(string? name)
        {
            throw new NotImplementedException();
        }
    }
}
