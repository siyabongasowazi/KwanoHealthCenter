using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;

namespace KwanoHealthCenter
{
    public partial class ManagerDefault : System.Web.UI.Page
    {
        BLL bll = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int managerID = int.Parse(Session["UserID"].ToString());

            if (!IsPostBack)
            {
                string fullName = Session["FirstName"].ToString();
                Name.Text = fullName.ToString();
            }
        }
    }
}