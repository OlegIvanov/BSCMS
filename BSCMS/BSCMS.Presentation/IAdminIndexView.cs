using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSCMS.Service.ViewModels;

namespace BSCMS.Presentation
{
    public interface IAdminIndexView
    {
        void Display(IList<BookViewModel> books);
        int BookId { get; set; }
    }
}
