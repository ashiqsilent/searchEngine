using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data; // to use DataSet or DataTable
using System.Data.SqlClient;

public partial class reviewDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Master.getFindButton.Click += new EventHandler(findButton_click);
        if (Application["detailID"] != null) {
            populate();
        }
        //Application.Remove("detailID");
    }

    private void findButton_click(object sender, EventArgs e)
    {
        Application["name"] = Master.getName.Text.ToString();
        Application["cat"] = Master.getCatagory.SelectedItem;
        Application["country"] = Master.getCountry.SelectedItem;

        Helper h = new Helper();
        Response.Redirect(h.generateSearchUrl(Master.getName.Text.ToString(), Master.getCatagory.SelectedItem.ToString(), Master.getCountry.SelectedItem.ToString()));
        
    }

    private void populate()
    {
        DataTable d = (DataTable)Application["detailID"];
        title.Text = d.Rows[0]["Title"].ToString();
        address.Text = d.Rows[0]["Address"].ToString();
        city_post.Text = d.Rows[0]["Description"].ToString() + ", " + d.Rows[0]["PostalCode"].ToString(); ;
        Helper h = new Helper();
        title.NavigateUrl = h.generateDetailsURL(d.Rows[0]["ID"], d.Rows[0]["Title"]);

    }

}