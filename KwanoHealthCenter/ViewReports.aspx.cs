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
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

namespace KwanoHealthCenter
{
    public partial class ViewReports : System.Web.UI.Page
    {
        BLL bll = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cmbNurse.DataSource = bll.GetNurses();
                cmbNurse.DataValueField = "NurseID";
                cmbNurse.DataTextField = "Name";
                cmbNurse.DataBind();
                cmbNurse.AppendDataBoundItems = false;
            }
        }

        protected void cmbNurse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nurseID = int.Parse(cmbNurse.SelectedValue.ToString());
            dgvResults.DataSource = bll.GetTestResultsByNurse(nurseID);
            dgvResults.DataBind();
        }

        protected void dgvResults_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvResults.PageIndex = e.NewPageIndex;
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Verifies that the control is rendered */
        }

        protected void ExportToPDF(object sender, EventArgs e)
        {
            using (StringWriter sw = new StringWriter())
            {
                using (HtmlTextWriter hw = new HtmlTextWriter(sw))
                {
                    //To Export all pages
                    dgvResults.AllowPaging = false;
                    

                    dgvResults.RenderControl(hw);
                    StringReader sr = new StringReader(sw.ToString());
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                    PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                    pdfDoc.Open();
                    htmlparser.Parse(sr);
                    pdfDoc.Close();

                    Response.ContentType = "application/pdf";
                    Response.AddHeader("content-disposition", "attachment;filename=GridViewExport.pdf");
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.Write(pdfDoc);
                    Response.End();
                }
            }
        }
    }
}