using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KwanoHealthCenter
{
    public partial class DefaultMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fullName = Session["Name"].ToString();
            if (Session["Name"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            Name.Text = fullName.ToString();
        }
    }
}