using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public interface IBook: IBookStoreItem
    {
        int Pages { get; set; }
        string Isbn { get; set; }
    }
}
