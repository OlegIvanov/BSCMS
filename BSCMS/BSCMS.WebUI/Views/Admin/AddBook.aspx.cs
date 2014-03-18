using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BSCMS.Presentation;
using StructureMap;
using BSCMS.Service;

namespace BSCMS.WebUI.Views.Admin
{
    public partial class AddBook : System.Web.UI.Page, IAddBookView
    {
        private AddBookPresenter _presenter;

        protected void Page_Init(object sender, EventArgs e)
        {
            _presenter = new AddBookPresenter(this, ObjectFactory.GetInstance<BookService>());

            this.saveBook.Click += new EventHandler(saveBook_Click);
        }

        protected void saveBook_Click(object sender, EventArgs e)
        {
            _presenter.SaveBook();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public string Title_
        {
            get { return this.bookTitle.Text; }
        }

        public decimal Price
        {
            get { return decimal.Parse(this.bookPrice.Text); }
        }

        public HttpPostedFile Cover
        {
            get { return Request.Files.Get(0); }
        }
    }
}