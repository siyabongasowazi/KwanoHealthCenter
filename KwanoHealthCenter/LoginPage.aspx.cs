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
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            errorMessage.Visible = false;           
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            UserPassword password = new UserPassword(txtEmail.Text.Trim(), txtPassword.Text.Trim());
            Session.Clear();
            if (bll.GetUserPassword(password).Rows.Count == 1 && bll.GetUserPassword(password).Rows[0]["UserType"].ToString() == "P")
            {
                Session["Name"] = bll.GetUserPassword(password).Rows[0]["FullName"].ToString() + " " + bll.GetUserPassword(password).Rows[0]["Surname"].ToString();
                Session["UserID"] = bll.GetUserPassword(password).Rows[0]["UserID"].ToString();
                Session["FirstName"] = bll.GetUserPassword(password).Rows[0]["FullName"].ToString();
                Session["Surname"] = bll.GetUserPassword(password).Rows[0]["Surname"].ToString();

                Session["CellNumber"] = bll.GetUserPassword(password).Rows[0]["CellNumber"].ToString();
                Session["EmailAddress"] = bll.GetUserPassword(password).Rows[0]["EmailAddress"].ToString();
                Session["SuburbID"] = bll.GetUserPassword(password).Rows[0]["SuburbID"].ToString();

                Session["AddressLine1"] = bll.GetUserPassword(password).Rows[0]["AddressLine1"].ToString();
                Session["AddressLine2"] = bll.GetUserPassword(password).Rows[0]["AddressLine2"].ToString();
                Response.Redirect("DefaultMember.aspx");
                
            }
            else if (bll.GetNursePassword(password).Rows.Count == 1 && bll.GetNursePassword(password).Rows[0]["UserType"].ToString() == "N")
            {
                //Session["Name"] = bll.GetUserPassword(password).Rows[0]["FullName"].ToString() + " " + bll.GetUserPassword(password).Rows[0]["Surname"].ToString();
                Session["UserID"] = bll.GetNursePassword(password).Rows[0]["UserID"].ToString();
                //Session["FirstName"] = bll.GetUserPassword(password).Rows[0]["FullName"].ToString();
                //Session["Surname"] = bll.GetUserPassword(password).Rows[0]["Surname"].ToString();

                //Session["CellNumber"] = bll.GetUserPassword(password).Rows[0]["CellNumber"].ToString();
                //Session["EmailAddress"] = bll.GetUserPassword(password).Rows[0]["EmailAddress"].ToString();
                //Session["ResidentialSuburbID"] = bll.GetUserPassword(password).Rows[0]["SuburbID"].ToString();

                
                Response.Redirect("DefaultNurse.aspx");

            }
            else if (bll.GetManagerPassword(password).Rows.Count == 1 && bll.GetManagerPassword(password).Rows[0]["UserType"].ToString() == "M")
            {
                //Session["Name"] = bll.GetUserPassword(password).Rows[0]["FullName"].ToString() + " " + bll.GetUserPassword(password).Rows[0]["Surname"].ToString();
                Session["UserID"] = bll.GetManagerPassword(password).Rows[0]["UserID"].ToString();
                Session["FirstName"] = bll.GetManagerPassword(password).Rows[0]["FullName"].ToString();
                //Session["Surname"] = bll.GetUserPassword(password).Rows[0]["Surname"].ToString();

                //Session["CellNumber"] = bll.GetUserPassword(password).Rows[0]["CellNumber"].ToString();
                //Session["EmailAddress"] = bll.GetUserPassword(password).Rows[0]["EmailAddress"].ToString();
                //Session["ResidentialSuburbID"] = bll.GetUserPassword(password).Rows[0]["SuburbID"].ToString();


                Response.Redirect("ManagerDefault.aspx");

            }
            else
            {
                errorMessage.Visible = true;
            }
        }
    }
}