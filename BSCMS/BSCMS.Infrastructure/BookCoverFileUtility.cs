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
        private static string _uploadDirectory = HostingEnvironment.MapPath(Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "/BookCovers"));

        public static string SaveCover(HttpPostedFile bookCover)
        {
            Directory.CreateDirectory(_uploadDirectory);
            string coverFileName = Guid.NewGuid().ToString() + Path.GetExtension(bookCover.FileName);
            
            string filePath = Path.Combine(_uploadDirectory, coverFileName);
            bookCover.SaveAs(filePath);
            
            return coverFileName;
        }

        public static void DeleteCover(string coverFileName)
        {
            File.Delete(Path.Combine(_uploadDirectory, coverFileName));
        }
    }
}
