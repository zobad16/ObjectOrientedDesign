using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Book : IBook
    {        
        public int Id { get; set; }
        public string Title { get; set; }
        public List<string> Author { get; set; }
        public string Publisher { get; set; }
        public string PublishDate { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }
        public string Isbn { get; set; }
        public string Type { get; set; }
    }
}