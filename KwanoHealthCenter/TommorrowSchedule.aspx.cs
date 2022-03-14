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
    public partial class TommorrowSchedule : System.Web.UI.Page
    {
        BLL bll = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {

            int userID = int.Parse(Session["UserID"].ToString());
            dgvSchedule.DataSource = bll.GetNurseTestBookings(userID);
            dgvSchedule.DataBind();

        }
    }
}