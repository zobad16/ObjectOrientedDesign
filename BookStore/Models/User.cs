using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class User : IUser
    {
        public int Id { set; get; }

        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string FirstName { get; set; }
        
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string LastName { get; set; }
        
        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string UserName { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}