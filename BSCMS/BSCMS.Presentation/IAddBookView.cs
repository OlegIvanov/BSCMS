using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace BSCMS.Presentation
{
    public interface IAddBookView
    {
        string Title_ { get; }
        decimal Price { get; }
        HttpPostedFile Cover { get; }
    }
}
