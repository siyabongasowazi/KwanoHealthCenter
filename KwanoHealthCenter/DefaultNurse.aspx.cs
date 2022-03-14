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
    public partial class DefaultNurse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            int NurseID = int.Parse(Session["UserID"].ToString());


            //1string fullName = bll.GetNurseDetails(NurseID).Rows[0]["FullName"].ToString() + " " + bll.GetNurseDetails(NurseID).Rows[0]["Surname"].ToString();
            //if (Session["Name"] == null)
            //{
            //    Response.Redirect("LoginPage.aspx");
            //}
            //Name.Text = fullName.ToString();

            if (!IsPostBack)
            {
                string fullName = bll.GetNurseDetails(NurseID).Rows[0]["FullName"].ToString() + " " + bll.GetNurseDetails(NurseID).Rows[0]["Surname"].ToString();
                Name.Text = fullName.ToString();
            }
        }
    }
}