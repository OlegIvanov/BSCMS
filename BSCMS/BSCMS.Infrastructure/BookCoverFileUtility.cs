using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Hosting;
using System.IO;
using System.Web;

namespace BSCMS.Infrastructure
{
    public static class BookCoverFileUtility
    {
        private static string _uploadDirectory = HostingEnvironment.MapPath(Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "/Uploads"));

        public static string SaveCover(HttpPostedFile bookCover)
        {
            Directory.CreateDirectory(_uploadDirectory);
            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(bookCover.FileName);
            
            string filePath = Path.Combine(_uploadDirectory, fileName);
            bookCover.SaveAs(filePath);

            return fileName;
        }
    }
}
