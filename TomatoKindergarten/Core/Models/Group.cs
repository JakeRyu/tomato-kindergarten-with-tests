using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TomatoKindergarten.Core.Models
{
    [Table("Groups")]
    public class Group
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<Album> Albums { get; set; }

        public Group()
        {
            Albums = new Collection<Album>();
        }
    }
}