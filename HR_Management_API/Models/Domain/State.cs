using System.ComponentModel.DataAnnotations;

namespace HR_Management_API.Models.Domain
{
    public class State
    {
        [Key]
        public int StateId { get; set; }
        public string StateName { get; set; }
    }
}
