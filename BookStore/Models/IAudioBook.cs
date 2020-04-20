using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    interface IAudioBook:IBookStoreItem
    {
        string Duration { get; set; }
        string Narator { get; set; }
        string ASIN { get; set; }
        string Version { get; set; }
    }
}
