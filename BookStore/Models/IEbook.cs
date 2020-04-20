using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public interface IEbook : IBookStoreItem
    {
        float FileSize { get; set; }
        string Format { get; set; }
        string ASIN { get; set; }
    }
}
