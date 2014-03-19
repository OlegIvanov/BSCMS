using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace BSCMS.Service.Messages
{
    public class EditBookRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public HttpPostedFile Cover { get; set; }
    }
}
