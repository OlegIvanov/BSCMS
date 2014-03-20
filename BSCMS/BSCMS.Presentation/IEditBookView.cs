using System.Web;
using BSCMS.Service.ViewModels;

namespace BSCMS.Presentation
{
    public interface IEditBookView
    {
        int Id { get; }
        string Title_ { get; }
        decimal Price { get; }
        HttpPostedFile Cover { get; }
        void Display(EditBookViewModel book);
    }
}