using PVservices.Resources.Cloudinary;

namespace PVservices.Interfaces
{
    public interface ICloudinaryService
    {
        Task<CloudinaryResponse> SubirImagen(string nombreImagen, Stream formatoImagen);
        Task<bool> BorrarImagen(string publicId);
    }
}
