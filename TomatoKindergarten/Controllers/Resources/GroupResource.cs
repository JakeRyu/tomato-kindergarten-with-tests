using System.ComponentModel.DataAnnotations;

namespace TomatoKindergarten.Controllers.Resources
{
    public class GroupResource
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}