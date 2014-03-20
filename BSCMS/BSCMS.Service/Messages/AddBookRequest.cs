using System.Web;

namespace BSCMS.Service.Messages
{
    public class AddBookRequest
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public HttpPostedFile Cover { get; set; }
    }
}
