using PhotoGallary_Reopsitary.DTOs;
using PhotoGallary_Reopsitary.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallary_Reopsitary.IReops
{
    public interface IPhotoGallary
    {
        //Gest
        Task<List<ImageDTO>> GetImages();
        Task<List<ImageDTO>> SearchImages(string? name,string? description,string? extention);
        Task<GallaryDTO> GetImageById(int id);
        //Register 
        Task<bool> Registraion(AuthanticationDTO dto);
        //Login & Logout
        Task<string> Login(AuthanticationDTO dto);
        Task<bool> Logout(AuthanticationDTO dto);
        //Image Managment 
        Task<bool> UploadNewImage(UploadImageDTO dto);
        Task<bool> UpdateImage(UploadImageDTO dto);
        Task<bool> DeleteImage(UploadImageDTO dto);
        //search User
        List<UserDTO> Users(string? name);
    }
}
