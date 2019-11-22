using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AzureWeb
{
    public partial class Azure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtValue.Text == "")
                {
                    lblErrorMessage.Text = "Please enter Name";
                }

                lblErrorMessage.Text = "Welcome " + txtValue.Text;

                ExecuteNonQuery("Insert into Entries values ('" + txtValue.Text + "', Getdate())");
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = ex.Message;
            }
        }

        public bool ExecuteNonQuery(string sqlText)
        {
            bool result;
            SqlCommand dbcom;
            SqlConnection dbcon;
            dbcon = new SqlConnection("Data Source=aptechpoc.database.windows.net;Initial Catalog=BookingPOC;Persist Security Info=True;User ID=Kathayat;Password=Aptech@123; Min Pool Size=10; Max Pool Size=1000;Connection Timeout=2000;");
            try
            {
                // connection string


                //call the stored procedure
                dbcom = new SqlCommand(sqlText, dbcon);
                dbcom.CommandType = CommandType.Text;
                dbcon.Open();
                dbcom.ExecuteNonQuery();

                result = true;
            }
            catch (Exception err)
            {
				lblErrorMessage.Text = err.Message;
                result = false;
            }
            finally
            {
                dbcon.Close();
            }
            return result;

        }
    }
}