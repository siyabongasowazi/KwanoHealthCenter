using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccessLayer;

namespace KwanoHealthCenter
{
    public partial class MainMemberProfile : System.Web.UI.Page
    {
        BLL bll = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            int memberID = int.Parse(Session["UserID"].ToString());
            if (!IsPostBack)
            {
                bll.GetMainMemberByID(memberID);
              
                txtName.Text = bll.GetMainMemberByID(memberID).Rows[0]["FullName"].ToString();
                txtSurname.Text = bll.GetMainMemberByID(memberID).Rows[0]["Surname"].ToString();

                txtEmail.Text = bll.GetMainMemberByID(memberID).Rows[0]["EmailAddress"].ToString();
                txtCellNumber.Text = bll.GetMainMemberByID(memberID).Rows[0]["CellNumber"].ToString();

                txtAddress1.Text = bll.GetMainMemberByID(memberID).Rows[0]["AddressLine1"].ToString();
                txtAddress2.Text = bll.GetMainMemberByID(memberID).Rows[0]["AddressLine2"].ToString();

                //cmbSuburbID.DataSource = bll.GetMemberSuburbName(patientID);
                ///cmbSuburbID.Text = bll.GetMemberSuburbName(patientID).Rows[0]["SuburbName"].ToString();
                cmbSuburbID.SelectedValue= bll.GetMemberSuburbName(memberID).Rows[0]["SuburbID"].ToString();
            }

            if (IsPostBack)
            {
                cmbSuburbID.SelectedValue = bll.GetMemberSuburbName(memberID).Rows[0]["SuburbID"].ToString();
            }


            //ENabling controls
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            txtName.Enabled = false;
            txtSurname.Enabled = false;
            txtEmail.Enabled = false;
            txtCellNumber.Enabled = false;
            txtAddress1.Enabled = false;
            txtAddress2.Enabled = false;

        }

        //protected void cmbIsMedicalAid_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        protected void txtSubmit_Click(object sender, EventArgs e)
        {

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;

            txtName.Enabled = true;
            txtSurname.Enabled = true;
            txtEmail.Enabled = true;
            txtCellNumber.Enabled = true;
            txtAddress1.Enabled = true;
            txtAddress2.Enabled = true;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void cmbSuburbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int memberID = int.Parse(Session["UserID"].ToString());
            cmbSuburbID.SelectedValue = bll.GetMemberSuburbName(memberID).Rows[0]["SuburbID"].ToString();
        }
    }
}