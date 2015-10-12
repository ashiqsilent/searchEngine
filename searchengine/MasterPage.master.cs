﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["user"] != null)
            {
                signIn.Visible = false;
                register.Visible = false;
                user.Visible = true;
                username.Text = Session["user"].ToString();
            }
        }
    }

    public TextBox getName 
    {
        get { return this.TextBox1; }
    }

    public DropDownList getCatagory
    {
        get { return this.categoryList ; }
    }

    public DropDownList getCountry
    {
        get { return this.countryList; }
    }

    public Button getFindButton
    {
        get { return this.findButton; }
    }

    public HyperLink getSignIn
    {
        get { return this.signIn; }
    }

    public HyperLink getRegister
    {
        get { return this.register; }
    }

    public HyperLink getUsername
    {
        get { return this.username; }
    }

    public HtmlGenericControl getUsernameDiv {
        get { return this.user; }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Session.Remove("user");
        Response.Redirect("index.aspx");
    }

    protected void addBusiness_Click(object sender, EventArgs e)
    {
        if (Session["user"] == null) {
            Session["message"] = "Please log in to add business";
            Response.Redirect("login.aspx");
        }
        Response.Redirect("addBusiness.aspx");
    }
}