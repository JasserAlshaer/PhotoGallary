using PhotoGallary_Reopsitary.Context;
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
        private readonly PhotoGallaryDbContext _context;
        
        public PhotoGallary(PhotoGallaryDbContext context)
        {
            _context = context;
        }
        public Task<bool> DeleteImage(UploadImageDTO dto)
        {
            throw new NotImplementedException();
            try
            {

            }catch (Exception ex) { 
            }
        }

        public Task<GallaryDTO> GetImageById(int id)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {
            }
        }

        public Task<List<ImageDTO>> GetImages()
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {
            }
        }

        public Task<string> Login(AuthanticationDTO dto)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {
            }
        }

        public Task<bool> Logout(AuthanticationDTO dto)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {
            }
        }

        public Task<bool> Registraion(AuthanticationDTO dto)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {
            }
        }

        public Task<List<ImageDTO>> SearchImages(string? name, string? description, string? extention)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {
            }
        }

        public Task<bool> UpdateImage(UploadImageDTO dto)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {
            }
        }

        public Task<bool> UploadNewImage(UploadImageDTO dto)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {
            }
        }

        public List<UserDTO> Users(string? name)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {
            }
        }
    }
}
