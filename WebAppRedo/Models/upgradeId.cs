using System.ComponentModel.DataAnnotations;

namespace WebAppRedo.Models
{
    public class upgradeId
    {
        public string Id { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; } = string.Empty;
        
    }
}