using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.Dto
{
    //Data Transfer Object (DTO) ===> This gives you separation of concerns.
    public class VillaNumberDTO
    {
        [Required]
        public int VillaNo { get; set; }
        [Required]
        public int VillaID { get; set; }
        public string SpecialDetails { get; set; }
        public VillaDTO Villa { get; set; }
    }
}
