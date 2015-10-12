using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration; // to use the ConfigurationManager
using System.Data; // to use DataSet or DataTable
using System.Data.SqlClient; // to communicate with SQL Server database
using System.Text;
using Subgurim.Controles;

public partial class detail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Master.getFindButton.Click += new EventHandler(findButton_click);
        if (!IsPostBack)
        {
            showDetail();
        }
    }

    private void findButton_click(object sender, EventArgs e)
    {
        Application["name"] = Master.getName.Text;
        Application["cat"] = Master.getCatagory.SelectedItem;
        Application["country"] = Master.getCountry.SelectedItem;

        Helper h = new Helper();
        Response.Redirect(h.generateSearchUrl(Master.getName.Text.ToString(), Master.getCatagory.SelectedItem.ToString(), Master.getCountry.SelectedItem.ToString()));
    }

    private void showDetail()
    {
        string _connStr = ConfigurationManager.ConnectionStrings["eBanglaConnectionString1"].ConnectionString;

        DataTable table = new DataTable();

        // get the connection
        using (SqlConnection conn = new SqlConnection(_connStr))
        {
            // write the sql statement to execute
            string sql = "SELECT * FROM edirectory WHERE ID = @id";

            // instantiate the command object to fire
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {

                SqlParameter prm = new SqlParameter("@id", Request.QueryString["code"]);
                cmd.Parameters.Add(prm);

                // get the adapter object and attach the command object to it
                using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                {
                    // fire Fill method to fetch the data and fill into DataTable
                    ad.Fill(table);
                }
            }
        }

        //Set title of the page
        var page = (Page)HttpContext.Current.Handler;
        page.Title = (string)table.Rows[0]["Title"];

        name.Text = table.Rows[0]["Title"].ToString();
        if (table.Rows[0]["Website"].ToString() != "")
        {
            name.NavigateUrl = "https://" + table.Rows[0]["Website"].ToString();
        }
        address.Text = table.Rows[0]["Address"].ToString() + " " + table.Rows[0]["Address2"].ToString();
        city.Text = table.Rows[0]["Description"].ToString();
        province.Text = table.Rows[0]["Province"].ToString();
        country.Text = table.Rows[0]["Country"].ToString();
        postCode.Text = table.Rows[0]["PostalCode"].ToString();
        phone.Text = table.Rows[0]["Phone"].ToString();
        fax.Text = table.Rows[0]["Fax"].ToString();

        // show the map
        string sMapKey = ConfigurationManager.AppSettings["googlemaps.subgurim.net"];
        string sStreetAddress = table.Rows[0]["Address"].ToString() + ", " + table.Rows[0]["Description"].ToString() + ", " + table.Rows[0]["Country"].ToString();
        GeoCode geoCode = GMap.geoCodeRequest(sStreetAddress, sMapKey);
        GLatLng gLatLng = new GLatLng(geoCode.Placemark.coordinates.lat, geoCode.Placemark.coordinates.lng);
        GMap1.setCenter(gLatLng, 16, Subgurim.Controles.GMapType.GTypes.Normal);
        GMarker oMarker = new GMarker(gLatLng);
        GMap1.Add(oMarker);

        GMap1.GZoom = 15;
        GMap1.enableHookMouseWheelToZoom = true;
        
    }
}