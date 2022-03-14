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
    public partial class NurseFavouriteSuburbs : System.Web.UI.Page
    {
        BLL bll = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int NurseID = int.Parse(Session["UserID"].ToString());
           

            if (!IsPostBack)
            {
                cmbCityID.DataSource = bll.GetCities();
                cmbCityID.DataValueField = "CityID";
                cmbCityID.DataTextField = "CityName";
                cmbCityID.DataBind();

                dgvFavSurbs.DataSource = bll.GetNurseSuburbs(NurseID);
                dgvFavSurbs.DataBind();
            }
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
            int NurseID = int.Parse(Session["UserID"].ToString());
            int subID = int.Parse(cmbSuburbID.SelectedValue.ToString());
            int x = bll.InsertNurseSuburb(NurseID, subID);
            if(x > 0){
                
                ClientScript.RegisterClientScriptBlock(this.GetType(), "K", "swal('Successful', 'You have successfully recorded suburb!', 'success')", true);
                dgvFavSurbs.DataSource = bll.GetNurseSuburbs(NurseID);
                dgvFavSurbs.DataBind();
            }
        }
    }
}