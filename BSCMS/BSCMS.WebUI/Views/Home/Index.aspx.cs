using System;
using System.Collections.Generic;
using BSCMS.Presentation;
using BSCMS.Service;
using BSCMS.Service.ViewModels;
using StructureMap;

namespace BSCMS.WebUI.Views.Home
{
    public partial class Index : System.Web.UI.Page, IHomeIndexView
    {
        private HomeIndexPresenter _presenter;

        protected void Page_Init(object sender, EventArgs e)
        {
            _presenter = new HomeIndexPresenter(this, ObjectFactory.GetInstance<BookService>());
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                _presenter.Display();
        }

        public void Display(IList<BookViewModel> books)
        {
            rBooks.DataSource = books;
            rBooks.DataBind();
        }
    }
}