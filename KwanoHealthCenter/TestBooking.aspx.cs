using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Net.Mail;

namespace KwanoHealthCenter
{
    public partial class TestBooking : System.Web.UI.Page
    {
        BLL bll = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int requestID = int.Parse(Request.QueryString["RequestID"]);
            if (!IsPostBack)
            {
                int testSubjectID = int.Parse(bll.GetTestRequest(requestID).Rows[0]["TestSubjectID"].ToString());
                lblSucject.Text = bll.GetTestSubjectName(testSubjectID).Rows[0]["FullName"].ToString();
                lblEmail.Text = bll.GetTestSubjectName(testSubjectID).Rows[0]["EmailAddress"].ToString();
            }
        }

        protected void lnkPickDate_Click(object sender, EventArgs e)
        {
            datepicker.Visible = true;
        }

        protected void datepicker_SelectionChanged(object sender, EventArgs e)
        {
            txtDate.Text = datepicker.SelectedDate.ToString("dd/MM/yyyy"); // just use this method to get dd/MM/yyyy  
            datepicker.Visible = false;
        }

        protected void txtSubmit_Click(object sender, EventArgs e)
        {
            int requestID = int.Parse(Request.QueryString["RequestID"]);
            int nurseID = int.Parse(Session["UserID"].ToString());
            NurseTestBooking nurse = new NurseTestBooking(int.Parse(requestID.ToString()), txtDate.Text.ToString(), cmbSlot.SelectedItem.ToString(), int.Parse(nurseID.ToString()));
            int x = bll.InsertTestBooking(nurse);
            if(x > 0)
            {
              SendEmail();
                Response.Redirect("NurseTestRequests.aspx");
            }
        }

        protected void datepicker_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date < DateTime.Now.Date)
            {
                e.Day.IsSelectable = false;
                e.Cell.ForeColor = System.Drawing.Color.Gray;
            }
        }

        //SEND EMAIL
        public void SendEmail()
        {

            string to = lblEmail.Text; //To address    
            string from = "kwanohealthcentre@gmail.com"; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = "Good day " + lblSucject.Text + ". <br/> Test has been booked under the details below. <br/> Please be at home between the specified time slot. <br/>" +
              "<br/> <b> Date:</b> " + txtDate.Text + "<br/> <b>Time:</b> " + cmbSlot.SelectedItem.Text + "<br/><br/> Thank You, <br/> Kwano Health-Centre Management.";
            message.Subject = "TEST BOOIKING FOR: " + lblSucject.Text;
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