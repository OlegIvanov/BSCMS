﻿using System;
using System.Web;
using BSCMS.Presentation;
using BSCMS.Presentation.Navigation;
using BSCMS.Service;
using StructureMap;

namespace BSCMS.WebUI.Views.Admin
{
    public partial class AddBook : System.Web.UI.Page, IAddBookView
    {
        private AddBookPresenter _presenter;

        protected void Page_Init(object sender, EventArgs e)
        {
            _presenter = new AddBookPresenter(this, ObjectFactory.GetInstance<BookService>(), ObjectFactory.GetInstance<PageNavigator>());

            lbSaveBook.Click += new EventHandler(lbSaveBook_Click);
        }

        protected void lbSaveBook_Click(object sender, EventArgs e)
        {
            _presenter.SaveBook();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
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
    }
}