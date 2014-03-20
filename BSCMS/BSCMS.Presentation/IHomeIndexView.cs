using System.Collections.Generic;
using BSCMS.Service.ViewModels;

namespace BSCMS.Presentation
{
    public interface IHomeIndexView
    {
        void Display(IList<BookViewModel> books);
    }
}
