using System.ComponentModel.DataAnnotations;

namespace BakendProject.Models
{
    public class Subscribe
    {
        public int Id{ get; set; }
        [Required,EmailAddress]
        public string Email{ get; set; }
    }
}
