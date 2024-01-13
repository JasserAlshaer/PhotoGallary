using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhotoGallary_Reopsitary.DTOs;
using PhotoGallary_Reopsitary.IReops;

namespace PhotoGallary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoGallaryController : ControllerBase
    {
        private readonly IPhotoGallary _photoGallary;
        public PhotoGallaryController(IPhotoGallary photoGallary) {
            _photoGallary= photoGallary;
        }
        #region HttpGet
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetImages()
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {
            }
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetImageById(int id)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {
            }
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> SearchImages(string? name, string? description, string? extention)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {
            }
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Users(string? name)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {
            }
        }
        #endregion
        #region HttpPost
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> UploadNewImage(UploadImageDTO dto)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {
            }
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Registraion(AuthanticationDTO dto)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {
            }
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Login(AuthanticationDTO dto)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {
            }
        }

        #endregion
        #region HttpPut
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> Logout(AuthanticationDTO dto)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {
            }
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateImage(UploadImageDTO dto)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {
            }
        }
        #endregion
        #region HttpDelete
        [HttpDelete]
        [Route("[action]")]
        public async Task<IActionResult> DeleteImage(UploadImageDTO dto)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {
            }
        }
        #endregion
    }
}
