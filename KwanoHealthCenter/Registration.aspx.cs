using System;
using System.IO;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Web.UI;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace KwanoHealthCenter
{
    public partial class Registration : System.Web.UI.Page
    {
        BLL bll = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pnl1.Visible = false;
                pnl2.Visible = false;
                pnl3.Visible = false;

                cmbMedicalAid.DataSource = bll.GetMedicalAids();
                cmbMedicalAid.DataValueField = "MedicalAidID";
                cmbMedicalAid.DataTextField = "MedicalAidName";
                cmbMedicalAid.DataBind();
                cmbMedicalAid.AppendDataBoundItems = false;

                cmbCityID.DataSource = bll.GetCities();
                cmbCityID.DataValueField = "CityID";
                cmbCityID.DataTextField = "CityName";
                cmbCityID.DataBind();
                //cmbIsMedicalAid.AppendDataBoundItems = false;
            }

        }

        protected void txtSubmit_Click(object sender, EventArgs e)
        {
            
            User user = new User(txtEmail.Text.ToString(), txtPasswordConfirm.Text.ToString(), "A", "P");
            MainMember main = new MainMember(txtName.Text.ToString(), txtSurname.Text.ToString(), txtIDNumber.Text.ToString(), txtCellNumber.Text.ToString(), txtEmail.Text.ToString(), cmbIsMedicalAid.SelectedValue.ToString().ToString(), int.Parse(cmbMedicalAidPlan.SelectedValue.ToString()), txtMedicalAidNo.Text.ToString(), txtAddress1.Text.ToString(), txtAddress2.Text.ToString(), int.Parse(cmbSuburbID.SelectedValue.ToString()), txtPersonResponsible.Text.ToString());
            int x = bll.InsertMainMember(user, main);
            if ( x > 0)
            {
                SendEmail();
                Response.Redirect("Home.aspx");
            }
        }

        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIsMedicalAid.SelectedValue.ToString() == "Y")
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

        //SEND EMAIL
        public void SendEmail()
        {

            string to = txtEmail.Text; //To address    
            string from = "kwanohealthcentre@gmail.com"; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = "Good day " + txtName.Text + ". <br/> You have successfully registered on the Kwano Health-Centre Website. <br/> To add dependants or to request a Covid-19 Test please use the following details: <br/><br/> <b>Your Username:</b> " + txtEmail.Text + "<br/> <b>Password:</b> " + txtPasswordConfirm.Text + "<br/><br/> Thank You, <br/> Kwano Health-Centre Management.";
            message.Subject = "Welcome " + txtName.Text + " " + txtSurname.Text;
            message.Body = mailbody;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);//Gmail smtp        
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("kwanohealthcentre@gmail.com", "Kwan0_He@lth");
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}