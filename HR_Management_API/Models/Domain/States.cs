using System.ComponentModel.DataAnnotations;

namespace HR_Management_API.Models.Domain
{
    public class States
    {
        [Key]
        public int StateId { get; set; }
        public string StateName { get; set; }
    }
}
