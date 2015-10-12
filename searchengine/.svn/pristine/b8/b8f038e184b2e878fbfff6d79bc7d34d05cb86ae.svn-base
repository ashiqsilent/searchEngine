using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Master.getFindButton.Click += new EventHandler(findButton_click);
    }

    private void findButton_click(object sender, EventArgs e)
    {
        Application["name"] = Master.getName.Text.ToString();
        Application["cat"] = Master.getCatagory.SelectedItem;
        Application["country"] = Master.getCountry.SelectedItem;

        Helper h = new Helper();
        Response.Redirect(h.generateSearchUrl(Master.getName.Text.ToString(), Master.getCatagory.SelectedItem.ToString(), Master.getCountry.SelectedItem.ToString()));

    }

    protected void usernameValidate(object sender, ServerValidateEventArgs args)
    {
        string _connStr = ConfigurationManager.ConnectionStrings["eBanglaConnectionString1"].ConnectionString;
        SqlConnection conn = new SqlConnection(_connStr);
        string sql = "SELECT Username FROM Users";
        DataTable table = new DataTable();
        SqlCommand cmd = new SqlCommand(sql, conn);
        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        ad.Fill(table);
        conn.Close();

        foreach (DataRow row in table.Rows) {
            if (usernamesignup.Value == row["Username"].ToString()) {
                args.IsValid = false;
                usernameValidator.Text = "* the username already exists";
                break;
            }
        }

    }

    protected void emailValidate(object sender, ServerValidateEventArgs args)
    {
        string _connStr = ConfigurationManager.ConnectionStrings["eBanglaConnectionString1"].ConnectionString;
        SqlConnection conn = new SqlConnection(_connStr);
        string sql = "SELECT Email FROM Users";
        DataTable table = new DataTable();
        SqlCommand cmd = new SqlCommand(sql, conn);
        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        ad.Fill(table);
        conn.Close();

        foreach (DataRow row in table.Rows)
        {
            if (emailsignup.Value == row["Email"].ToString())
            {
                args.IsValid = false;
                emailValidator.Text = "* the email aready exists";
                break;
            }
        }
        
    }

    protected void button_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            head.Visible = false;
            recordData();
            if (confirmation.Text == "")
            {
                confirmation.Text = "Your Account has been successfully created";
                go.Visible = true;
            }
        }
    }

    private void recordData()
    {
        string _connStr = ConfigurationManager.ConnectionStrings["eBanglaConnectionString1"].ConnectionString;
        SqlConnection conn = new SqlConnection(_connStr);
        string sql = "INSERT INTO Users (Username, Password, Email) values (@username, @password, @email)";
        SqlCommand cmd = new SqlCommand(sql, conn);
        SqlParameter prm = new SqlParameter("@username", usernamesignup.Value);
        cmd.Parameters.Add(prm);
        prm = new SqlParameter("@email", emailsignup.Value);
        cmd.Parameters.Add(prm);
        Helper h = new Helper();
        prm = new SqlParameter("@password", h.GetMD5HashData(passwordsignup.Value));
        cmd.Parameters.Add(prm);
        cmd.Connection.Open();
        try
        {
            cmd.ExecuteNonQuery();
        }
        
        catch (SqlException e) {
            confirmation.Text = "Sorry we have encountered a problem with our database, please try again later";
        }

        conn.Close();
    }


    protected void passwordValidate(object source, ServerValidateEventArgs args)
    {
        if (passwordsignup.Value.Length >= 6)
        {
            Regex r = new Regex("[a-zA-Z]+"); // match letters
            if (r.IsMatch(passwordsignup.Value))
            {
                r = new Regex("[0-9]+");
                if (r.IsMatch(passwordsignup.Value))
                {
                    r = new Regex("^[a-zA-z0-9]*$");
                    if (!r.IsMatch(passwordsignup.Value))
                    {
                        args.IsValid = false;
                        passwordValidator.Text = "* password must contain not contain space or any special characters";
                    }
                }
                else
                {
                    args.IsValid = false;
                    passwordValidator.Text = "* password must contain atleast one number";
                }
            }
            else
            {
                args.IsValid = false;
                passwordValidator.Text = "* password must contain atleast one letter";
            }
        }
        else
        {
            args.IsValid = false;
            passwordValidator.Text = "* password must be atleast 6 characters";
        }
    }
}