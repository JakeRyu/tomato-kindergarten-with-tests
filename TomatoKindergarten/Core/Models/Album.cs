using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TomatoKindergarten.Core.Models
{
    [Table("Albums")]
    public class Album
    {
        public int Id { get; set; }
        [Required]
        public int GroupId { get; set; }
        public Group Group { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        // public ICollection<Photo> Photos { get; set; }
    }
}