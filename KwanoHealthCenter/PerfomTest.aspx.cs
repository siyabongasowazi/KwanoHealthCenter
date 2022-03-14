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
    public partial class PerfomTest : System.Web.UI.Page
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

        protected void txtSubmit_Click(object sender, EventArgs e)
        {
            string barcode = txtBarcode.Text;
            string temperature = txtTemperature.Text;
            string BloodPress = txtBloodPressure.Text;
            int requestID = int.Parse(Request.QueryString["RequestID"]);
            int patientID = int.Parse(bll.GetTestRequest(requestID).Rows[0]["TestSubjectID"].ToString());
           
            int oxy = int.Parse(txtOxygenLevel.Text.ToString());
            PatientTestResults patient = new PatientTestResults(int.Parse(requestID.ToString()), int.Parse(patientID.ToString()), barcode.ToString(), temperature.ToString(), BloodPress.ToString(), int.Parse(oxy.ToString()));
            int x = bll.InsertTestResults(patient);
            if(x > 0)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "K", "swal('Successful', 'You have successfully perfomed the test!', 'success')", true);
            }
        }
    }
}