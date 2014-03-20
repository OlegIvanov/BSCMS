using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSCMS.Service.ViewModels;

namespace BSCMS.Presentation
{
    public interface IHomeIndexView
    {
        void Display(IList<BookViewModel> books);
    }
}
