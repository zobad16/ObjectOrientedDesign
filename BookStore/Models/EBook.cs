using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class EBook : IEbook
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Title { get; set; }
        public List<string> Author { get; set; }
        public string Publisher { get; set; }
        public string PublishDate { get; set; }
        public string Language { get; set; }
        public float FileSize { get; set; }
        public string Format { get; set; }
        public string ASIN { get; set; }
        [Required]
        [MaxLength(20)]
        [Column(TypeName = "varchar(20)")]
        public string Type { get; set; }
    }
}