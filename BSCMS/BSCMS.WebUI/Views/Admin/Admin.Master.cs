﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BSCMS.Infrastructure.Authentication;
using BSCMS.Presentation;
using BSCMS.Presentation.Navigation;

namespace BSCMS.WebUI.Views.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        private AdminMasterPresenter _presenter;

        protected void Page_Init(object sender, EventArgs e)
        {
            _presenter = new AdminMasterPresenter(new AspFormsAuthentication(), new PageNavigator());

            this.signOut.Click += new EventHandler(signOut_Click);
        }

        protected void signOut_Click(object sender, EventArgs e)
        {
            _presenter.SignOut();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}