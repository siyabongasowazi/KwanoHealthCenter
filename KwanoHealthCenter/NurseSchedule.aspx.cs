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
    public partial class NurseSchedule : System.Web.UI.Page
    {
        BLL bll = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int userID = int.Parse(Session["UserID"].ToString());
            dgvSchedule.DataSource = bll.GetNurseTodaysBookings(userID);
            dgvSchedule.DataBind();
        }

        protected void dgvSchedule_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName != "SendRequestID") return;
            int requestID = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("PerfomTest.aspx?RequestID=" + requestID.ToString());
        }
    }
}