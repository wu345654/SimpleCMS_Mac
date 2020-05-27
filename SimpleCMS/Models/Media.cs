using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCMS.Models
{
    [Table("T_Media")]
    public class Media
    {
      [Key]
        public int Id { get; set; }

       [Required]
        [MaxLength(32)]
        [Column(TypeName = "nvarchar")]
        public string FileName { get; set; }

        [Required]
        [MaxLength(255)]
        [Column(TypeName = "nvarchar")]
        public string Description { get; set; }

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "nvarchar")]
        public string path { get; set; }

        [Required]
        [Range(1,3)]
        [DefaultValue(1)]
        public byte Type { get; set; }

        [Required]
        public DateTime? Uploaded { get; set; }

        [Required]
        [DefaultValue(0)]
        public int Size { get; set; }

        public enum MediaType
        {
            Image=1,
            Audio=2,
            Video=3
        }

    }
}
