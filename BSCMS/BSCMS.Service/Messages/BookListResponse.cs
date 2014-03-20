using System.Collections.Generic;
using BSCMS.Service.ViewModels;

namespace BSCMS.Service.Messages
{
    public class BookListResponse
    {
        public IList<BookViewModel> Books { get; set; }
    }
}
