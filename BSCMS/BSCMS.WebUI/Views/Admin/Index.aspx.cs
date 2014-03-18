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
    public partial class Index : System.Web.UI.Page, IAdminIndexView
    {
        private AdminIndexPresenter _presenter;

        protected void Page_Init(object sender, EventArgs e)
        {
            _presenter = new AdminIndexPresenter(this, ObjectFactory.GetInstance<BookService>());
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            _presenter.Display();
        }

        public void Display(IList<BookViewModel> books)
        {
            this.books.DataSource = books;
            this.books.DataBind();
        }
    }
}