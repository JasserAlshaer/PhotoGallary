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
        List<Image> GetImages();
        List<Image> SearchImages(string? name,string? description,string? extention);
        Image GetImageById(int id);
        //Register 
        void Registraion();
        //Login & Logout
        void Login();
        void Logout();
        //Image Managment 
        void UploadNewImage();
        void UpdateImage(Image image);
        void DeleteImage(int id);
        //search User
        List<User> Users();
    }
}
