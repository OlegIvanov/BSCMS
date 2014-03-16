using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSCMS.Presentation.Navigation
{
    public interface IPageNavigator
    {
        void NavigateTo(PageDirectory pageDirectory);
    }
}
