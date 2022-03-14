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
    public partial class NurseTestRequests : System.Web.UI.Page
    {
        BLL bll = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int userID = int.Parse(Session["UserID"].ToString());
            if (!IsPostBack)
            {
                dgvRequests.DataSource = bll.GetTestRequestsForNurse(userID);
                dgvRequests.DataBind();
            }
        }

        protected void dgvRequests_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName != "SendRequestID") return;
            int requestID = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("TestBooking.aspx?RequestID=" + requestID.ToString());
        }

        protected void cmbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            int userID = int.Parse(Session["UserID"].ToString());
            if (cmbChoice.SelectedValue.ToString() == "1")
            {
                dgvRequests.DataSource = bll.GetTestRequestsForNurse(userID);
                dgvRequests.DataBind();
            }

           else if (cmbChoice.SelectedValue.ToString() == "2")
            {
                dgvRequests.DataSource = bll.GetAllTestRequests();
                dgvRequests.DataBind();
            }
        }
    }
}