using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Configuration;
using PVservices.Interfaces;
using PVservices.Resources.Cloudinary;

namespace PVservices.Implementation
{
    public class CloudinaryService : ICloudinaryService
    {
        private readonly IConfiguration _configuracion;
        private readonly Cloudinary _cloudinary;
        public CloudinaryService(IConfiguration configuration)
        {
            _configuracion = configuration;

            var CloudName = _configuracion["Cloudinary:CloudName"];
            var ApiKey = _configuracion["Cloudinary:ApiKey"];
            var ApiSecret = _configuracion["Cloudinary:ApiSecret"];

            _cloudinary = new Cloudinary(new Account(CloudName, ApiKey, ApiSecret));
        }

        public async Task<CloudinaryResponse> SubirImagen(string nombreImagen, Stream formatoImagen)
        {
            var cloudinaryResponse = new CloudinaryResponse();
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(nombreImagen, formatoImagen),
                AssetFolder = "PvMB_escritorio"
            };
            var upLoadResult = await _cloudinary.UploadAsync(uploadParams);
            if (upLoadResult.StatusCode==System.Net.HttpStatusCode.OK)
            {
                cloudinaryResponse.PublicId = upLoadResult.PublicId;
                cloudinaryResponse.SecureUrl = upLoadResult.SecureUrl.ToString();
            }
            else
            {
                cloudinaryResponse.PublicId ="";
            }
            return cloudinaryResponse;
        }

        public Task<bool> BorrarImagen(string publicId)
        {
            var deleteParams = new DeletionParams(publicId);
            var deleteResult = _cloudinary.Destroy(deleteParams);
            if (deleteResult.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(false);
            }
        }

        
    }
}
