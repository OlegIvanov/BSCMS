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
