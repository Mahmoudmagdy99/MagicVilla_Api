using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Dto;
using MagicVilla_Web.Services.IServices;
using Newtonsoft.Json.Linq;

namespace MagicVilla_Web.Services
{
    public class VillaService : BaseService, IVillaService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string VillaUrl;
        public VillaService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            VillaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
        }
        public Task<T> CreateAsync<T>(VillaCreateDTO dto, string token)
        {
            return sendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = dto,
                Url = VillaUrl + "/api/VillaApI",
                Token = token
            });
        }

        public Task<T> DeleteAsync<T>(int id, string token)
        {
            return sendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = VillaUrl + "/api/VillaApI/" + id,
                Token = token
            });
        }

        public Task<T> GetAllAsync<T>( string token)
        {
            return sendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = VillaUrl + "/api/VillaApI",
                Token = token
            });
        }

        public Task<T> GetAsync<T>(int id, string token)
        {
            return sendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = VillaUrl + "/api/VillaApI/" + id,
                Token = token
            });
        }

        public Task<T> UpdateAsync<T>(VillaUpdateDTO dto, string token)
        {
            return sendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = dto,
                Url = VillaUrl + "/api/VillaApI/" + dto.Id,
                Token = token
            });
        }
    }
}
