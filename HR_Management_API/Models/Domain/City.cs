using System.ComponentModel.DataAnnotations;

namespace HR_Management_API.Models.Domain
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }

        public int StateId { get; set; }
    }
}
