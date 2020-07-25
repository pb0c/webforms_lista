using System;
using System.Drawing.Imaging;
using System.Web.ClientServices.Providers;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace Evaluacion3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Log_Authenticate(object sender, AuthenticateEventArgs e)
        {
            /*if (Membership.ValidateUser(Log.UserName.ToString(), Log.Password.ToString() ))
            {
                // Session.Add("id_user", "");
                 //FormsAuthentication.RedirectFromLoginPage(Log.UserName.ToString(), Log.RememberMeSet);
                Response.Redirect("Default.aspx");
            }*/

            if (ValidateUser(Log.UserName,Log.Password))
            {

                Response.Redirect("Default.aspx");
            }
        }

        private bool ValidateUser(string User, string Pass)
        {
            if (User.Equals("secRS") && Pass.Equals("0102"))
            {
                return true;
            }
            if (User.Equals("kinRS") && Pass.Equals("0304"))
            {
                return true;
            }
            if (User.Equals("admRS") && Pass.Equals("0506"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}