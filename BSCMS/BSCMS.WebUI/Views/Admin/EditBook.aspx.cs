using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BSCMS.Presentation;
using StructureMap;
using BSCMS.Service;
using BSCMS.Service.ViewModels;

namespace BSCMS.WebUI.Views.Admin
{
    public partial class EditBook : System.Web.UI.Page, IEditBookView
    {
        private EditBookPresenter _presenter;

        protected void Page_Init(object sender, EventArgs e)
        {
            _presenter = new EditBookPresenter(this, ObjectFactory.GetInstance<BookService>());
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            _presenter.Display();
        }

        public int Id
        {
            get { return int.Parse(Request.Params["BookId"]); }
        }

        public string Title_
        {
            get { return tbBookTitle.Text; }
        }

        public decimal Price
        {
            get { return decimal.Parse(tbBookPrice.Text); }
        }

        public HttpPostedFile Cover
        {
            get { throw new NotImplementedException(); }
        }

        public void Display(EditBookViewModel book)
        {
            tbBookTitle.Text = book.Title;
            tbBookPrice.Text = book.Price;
        }
    }
}