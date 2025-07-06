using MagicVilla_VillaApi.Models.Dto;

namespace MagicVilla_VillaApi.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO> {
            new VillaDTO { Id=1, Name="Pool View"},
            new VillaDTO { Id=2, Name="Beach View"},
            //new VillaDTO { Id=3, Name="Mountain View"},
            //new VillaDTO { Id=4, Name="Garden View"},
            //new VillaDTO { Id=5, Name="City View"}
        };
    }
}
