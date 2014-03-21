using System;
using System.Web;
using BSCMS.Presentation;
using BSCMS.Presentation.Navigation;
using BSCMS.Service;
using BSCMS.Service.ViewModels;
using StructureMap;

namespace BSCMS.WebUI.Views.Admin
{
    public partial class EditBook : System.Web.UI.Page, IEditBookView
    {
        private EditBookPresenter _presenter;

        protected void Page_Init(object sender, EventArgs e)
        {
            _presenter = new EditBookPresenter(this, ObjectFactory.GetInstance<BookService>(), ObjectFactory.GetInstance<PageNavigator>());

            lbSaveBook.Click += new EventHandler(lbSaveBook_Click);
        }

        protected void lbSaveBook_Click(object sender, EventArgs e)
        {
            _presenter.EditBook();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                _presenter.Display();
        }

        public int Id
        {
            get { return Convert.ToInt32(RouteData.Values["BookId"]); }
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
            get { return Request.Files.Get(0); }
        }

        public void Display(EditBookViewModel book)
        {
            iBookCover.ImageUrl = book.CoverImageUrl;
            tbBookTitle.Text = book.Title;
            tbBookPrice.Text = book.Price;
        }
    }
}