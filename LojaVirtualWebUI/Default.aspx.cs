using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LojaVirtualWebUI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ClienteId"] != null)
            {
                btnLogin.Text = "Sair";
            }
            else
            {
                btnLogin.Text = "Login";
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text == "Sair")
            {
                Session["ClienteId"] = null;
                Session["ClienteAlbum"] = null;
                btnLogin.Text = "Login";
                Response.Redirect("Portfolio.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}