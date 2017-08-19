using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorTestDemo.Models
{
    public class Moive
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Price { get; set; }
    }
}
