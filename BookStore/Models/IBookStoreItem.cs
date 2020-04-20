using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public interface IBookStoreItem
    {
         int Id { get; set; }
         string Title { get; set; }
         List<string> Author { get; set; }
         string Publisher { get; set; }
         string PublishDate { get; set; }
         string Language { get; set; }
         string Type { get; set; }
    }
}
