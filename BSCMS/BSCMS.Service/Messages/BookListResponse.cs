using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSCMS.Service.ViewModels;

namespace BSCMS.Service.Messages
{
    public class BookListResponse
    {
        public IList<BookViewModel> Books { get; set; }
    }
}
