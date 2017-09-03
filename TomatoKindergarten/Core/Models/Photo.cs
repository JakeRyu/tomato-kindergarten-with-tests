using System;
using System.ComponentModel.DataAnnotations;

namespace TomatoKindergarten.Core.Models
{
    public class Photo
    {
        public int Id { get; set; }
        [Required]
        public int AlbumId { get; set; }
        public Album Album { get; set; }
        [Required]
        [StringLength(255)]
        public string FileName { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}