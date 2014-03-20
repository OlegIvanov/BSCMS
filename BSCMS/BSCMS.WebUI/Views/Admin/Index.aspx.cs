using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using BSCMS.Presentation;
using BSCMS.Service;
using BSCMS.Service.ViewModels;
using StructureMap;

namespace BSCMS.WebUI.Views.Admin
{
    public partial class Index : System.Web.UI.Page, IAdminIndexView
    {
        private AdminIndexPresenter _presenter;

        protected void Page_Init(object sender, EventArgs e)
        {
            _presenter = new AdminIndexPresenter(this, ObjectFactory.GetInstance<BookService>());
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                _presenter.Display();

            foreach (RepeaterItem repeaterItem in rBooks.Items)
            {
                LinkButton lbDeleteBook = repeaterItem.FindControl("lbDeleteBook") as LinkButton;
                lbDeleteBook.Click += new EventHandler(lbDeleteBook_Click);
            }
        }

        protected void lbDeleteBook_Click(object sender, EventArgs e)
        {
            LinkButton lbDeleteBook = sender as LinkButton;
            HiddenField hfBookId = lbDeleteBook.Parent.FindControl("hfBookId") as HiddenField;

            BookId = int.Parse(hfBookId.Value);

            _presenter.DeleteBook();
            _presenter.Display();
        }

        public void Display(IList<BookViewModel> books)
        {
            rBooks.DataSource = books;
            rBooks.DataBind();
        }

        public int BookId { get; set; }
    }
}