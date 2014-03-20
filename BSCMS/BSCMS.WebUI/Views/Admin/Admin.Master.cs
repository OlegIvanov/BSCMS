using System;
using BSCMS.Infrastructure.Authentication;
using BSCMS.Presentation;
using BSCMS.Presentation.Navigation;
using StructureMap;

namespace BSCMS.WebUI.Views.Admin
{
    public partial class Admin : System.Web.UI.MasterPage, IAdminMasterView
    {
        private AdminMasterPresenter _presenter;

        protected void Page_Init(object sender, EventArgs e)
        {
            _presenter = new AdminMasterPresenter(this, ObjectFactory.GetInstance<AspFormsAuthentication>(), ObjectFactory.GetInstance<PageNavigator>());
          
            this.signOut.Click += new EventHandler(signOut_Click);
        }

        protected void signOut_Click(object sender, EventArgs e)
        {
            _presenter.SignOut();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            _presenter.Display();
        }

        public string Username
        {
            set { lUsername.Text = value; }
        }
    }
}