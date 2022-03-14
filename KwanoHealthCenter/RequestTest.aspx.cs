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
    public partial class RequestTest : System.Web.UI.Page
    {
        BLL bll = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pnlDep.Visible = false;
            }
        }

        protected void OnSelectedIndexChanged4(object sender, EventArgs e)
        {
            if (cmbChoice.SelectedValue.ToString() == "N")
            {
                int memberID = int.Parse(Session["UserID"].ToString());
                pnlDep.Visible = true;
                cmbDependantID.Items.Clear();

                cmbDependantID.DataSource = bll.GetMemberDependantsNames(memberID);
                cmbDependantID.DataValueField = "DependantID";
                cmbDependantID.DataTextField = "DepName";
                cmbDependantID.DataBind();
                cmbDependantID.AppendDataBoundItems = false;
               
            }
            else
            {
                //DOCUMEMNTATION COMPLEX CODE
                int memberID = int.Parse(Session["UserID"].ToString());



                pnlDep.Visible = false;
               


            }
        }

        protected void txtSubmit_Click(object sender, EventArgs e)
        {
            int memberID = int.Parse(Session["UserID"].ToString());
            DateTime now = DateTime.Now;
            string date = now.GetDateTimeFormats('d')[0];
            string time = now.GetDateTimeFormats('t')[0];
            string status = "N";
            string addressLine1 = bll.GetMainMemberByID(memberID).Rows[0]["AddressLine1"].ToString();
            string addressLine2 = bll.GetMainMemberByID(memberID).Rows[0]["AddressLine2"].ToString();
            int suburbID = int.Parse(bll.GetMainMemberByID(memberID).Rows[0]["SuburbID"].ToString());
            if (cmbChoice.SelectedValue.ToString() == "Y")
            {
                TestRequest request = new TestRequest(date.ToString(), time.ToString(), status.ToString(), int.Parse(memberID.ToString()), int.Parse(memberID.ToString()), addressLine1.ToString(), addressLine2.ToString(), int.Parse(suburbID.ToString()));
                int x = bll.InsertTestRequest(request);
                if(x > 0)
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "K", "swal('Successful', 'You have successfully requested a test!', 'success')", true);
                }
            }

            else if (cmbChoice.SelectedValue.ToString() == "N")
            {
                TestRequest request = new TestRequest(date.ToString(), time.ToString(), status.ToString(), int.Parse(memberID.ToString()), int.Parse(cmbDependantID.SelectedValue.ToString()), addressLine1.ToString(), addressLine2.ToString(), int.Parse(suburbID.ToString()));
                int x = bll.InsertTestRequest(request);
                if (x > 0)
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "K", "swal('Successful', 'You have successfully requested a test for dependant!', 'success')", true);
                }
            }
        }
    }
}