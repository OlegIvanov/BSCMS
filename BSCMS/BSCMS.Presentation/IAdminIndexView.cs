using System.Collections.Generic;
using BSCMS.Service.ViewModels;

namespace BSCMS.Presentation
{
    public interface IAdminIndexView
    {
        void Display(IList<BookViewModel> books);
        int BookId { get; set; }
    }
}
