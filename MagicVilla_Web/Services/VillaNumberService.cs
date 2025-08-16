using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Dto;
using MagicVilla_Web.Services.IServices;

namespace MagicVilla_Web.Services
{
    public class VillaNumberService : BaseService, IVillaNumberService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly string villUrl;

        public VillaNumberService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            villUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
        }

        public Task<T> CreateAsync<T>(VillaNumberCreateDTO dto)
        {
            return sendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = dto,
                Url = villUrl + "/api/VillaNumberApI"
            });
        }

        public Task<T> DeleteAsync<T>(int id)
        {
            return sendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = villUrl + "/api/VillaNumberApI/" + id
            });
        }

        public Task<T> GetAllAsync<T>()
        {
            return sendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = villUrl + "/api/VillaNumberApI"
            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return sendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = villUrl + "/api/VillaNumberApI/" + id
            });
        }

        public Task<T> UpdateAsync<T>(VillaNumberUpdateDTO dto)
        {
            return sendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = dto,
                Url = villUrl + "/api/VillaNumberApI/" + dto.VillaNo
            });
        }
    }
}
