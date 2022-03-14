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
    public partial class AddDependant : System.Web.UI.Page
    {
        BLL bll = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pnl1.Visible = false;
                pnl2.Visible = false;
                pnl3.Visible = false;

                pnlAdd1.Visible = false;
                pnlAdd2.Visible = false;
                pnlCity.Visible = false;
                pnlSub.Visible = false;

                cmbMedicalAid.DataSource = bll.GetMedicalAids();
                cmbMedicalAid.DataValueField = "MedicalAidID";
                cmbMedicalAid.DataTextField = "MedicalAidName";
                cmbMedicalAid.DataBind();
                cmbMedicalAid.AppendDataBoundItems = false;

                cmbCityID.DataSource = bll.GetCities();
                cmbCityID.DataValueField = "CityID";
                cmbCityID.DataTextField = "CityName";
                cmbCityID.DataBind();

                cmbPersonResponsible.Items.Add(Session["Name"].ToString());
                cmbPersonResponsible.Items.Add("Will pay for myself");
            }
        }

        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbIsMedicalAid.SelectedValue.ToString() == "Y")
            {
                pnl2.Visible = true;
                pnl1.Visible = true;
                pnl3.Visible = true;
            }
            else
            {
                pnl1.Visible = false;
                pnl2.Visible = false;
                pnl3.Visible = false;
            }
        }

        protected void OnSelectedIndexChanged4(object sender, EventArgs e)
        {
            if (cmbAddress.SelectedValue.ToString() == "N")
            {
                pnlAdd1.Visible = true;
                pnlAdd2.Visible = true;
                pnlCity.Visible = true;
                pnlSub.Visible = true;
            }
            else
            {
                //DOCUMEMNTATION COMPLEX CODE
                int memberID = int.Parse(Session["UserID"].ToString());

            
               
                pnlAdd1.Visible = false;
                pnlAdd2.Visible = false;
                pnlCity.Visible = false;
                pnlSub.Visible = false;

                
            }
        }

        protected void OnSelectedIndexChanged2(object sender, EventArgs e)
        {
            this.cmbMedicalAidPlan.Items.Clear();
            string medicalAidID = this.cmbMedicalAid.SelectedItem.Value;            
                cmbMedicalAidPlan.DataSource = bll.GetMedicalAidPlans(int.Parse(medicalAidID));
                cmbMedicalAidPlan.DataValueField = "MedicalAidPlanID";
                cmbMedicalAidPlan.DataTextField = "MedicalPlanName";
                cmbMedicalAidPlan.DataBind();
                cmbMedicalAidPlan.AppendDataBoundItems = false;
            
            
        }

        protected void OnSelectedIndexChanged3(object sender, EventArgs e)
        {
            this.cmbSuburbID.Items.Clear();
            string cityID = this.cmbCityID.SelectedItem.Value;
            cmbSuburbID.DataSource = bll.GetSuburbs(int.Parse(cityID));
            cmbSuburbID.DataValueField = "SuburbID";
            cmbSuburbID.DataTextField = "SuburbName";
            cmbSuburbID.DataBind();
            // cmbSuburbID.AppendDataBoundItems = false;


        }

        protected void txtSubmit_Click(object sender, EventArgs e)
        {
            //int medNo = Convert.ToInt32(txtMedicalAidNo.Text);
            int memberID = int.Parse(Session["UserID"].ToString());
            if (cmbAddress.SelectedValue.ToString() == "N")
            {
                Dependant dep = new Dependant(int.Parse(memberID.ToString()),txtName.Text.ToString(), txtSurname.Text.ToString(), txtIDNumber.Text.ToString(), txtCellNumber.Text.ToString(), txtEmail.Text.ToString(), cmbIsMedicalAid.SelectedValue.ToString().ToString(), int.Parse(cmbMedicalAidPlan.SelectedValue.ToString()), txtMedicalAidNo.Text.ToString(), txtAddress1.Text.ToString(), txtAddress2.Text.ToString(), int.Parse(cmbSuburbID.SelectedValue.ToString()), cmbPersonResponsible.SelectedItem.ToString());
                int x = bll.InsertDependant(dep);
                if(x > 0)
                {
                    Response.Redirect("DefaultMember.aspx");
                }
            }

            else if (cmbAddress.SelectedValue.ToString() == "Y")
            {
                string address1 = bll.GetMainMemberByID(memberID).Rows[0]["AddressLine1"].ToString();
                string address2 = bll.GetMainMemberByID(memberID).Rows[0]["AddressLine2"].ToString();
                int suburbID = int.Parse(bll.GetMainMemberByID(memberID).Rows[0]["SuburbID"].ToString());
                Dependant dep = new Dependant(int.Parse(memberID.ToString()), txtName.Text.ToString(), txtSurname.Text.ToString(), txtIDNumber.Text.ToString(), txtCellNumber.Text.ToString(), txtEmail.Text.ToString(), cmbIsMedicalAid.SelectedValue.ToString().ToString(), int.Parse(cmbMedicalAidPlan.SelectedValue.ToString()), txtMedicalAidNo.Text.ToString(), address1.ToString(), address2.ToString(), int.Parse(suburbID.ToString()), cmbPersonResponsible.SelectedItem.ToString());
                int x = bll.InsertDependant(dep);
                if (x > 0)
                {
                    //    ScriptManager.RegisterStartupScript(this, this.GetType(),
                    //"alert",
                    //"swal('Successful', 'You have successfully registered dependant!', 'success').then((value) => { window.location ='DefaultMembers.aspx'; });",
                    //true);
                    Response.Redirect("MyDependants.aspx");
                    
                }
            }
        }
    }
}