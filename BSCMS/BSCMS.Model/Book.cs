using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSCMS.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string FileName { get; set; }
    }
}
