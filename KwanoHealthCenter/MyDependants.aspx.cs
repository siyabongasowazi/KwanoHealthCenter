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
    public partial class MyDependants : System.Web.UI.Page
    {
        BLL bll = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int userID = int.Parse(Session["UserID"].ToString());
            if (!IsPostBack)
            {
                dgvDependants.DataSource = bll.GetMemberDependants(userID);
                dgvDependants.DataBind();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Server.Transfer("AddDependant.aspx");
        }

        protected void btnViewDep_Click(object sender, EventArgs e)
        {

        }

        protected void dgvDependants_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int userID = int.Parse(Session["UserID"].ToString());
            //int IDNo = Convert.ToInt16(dgvDependants.DataKeys[e.RowIndex].Value);
            int IDNo = int.Parse(dgvDependants.DataKeyNames[e.RowIndex].ToString());
            int x = bll.RemoveDependant(IDNo);
            if(x > 0)
            {
                dgvDependants.DataSource = bll.GetMemberDependants(userID);
                dgvDependants.DataBind();
            }
        }

      
    }
}