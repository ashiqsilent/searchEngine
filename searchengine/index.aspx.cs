﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
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

}