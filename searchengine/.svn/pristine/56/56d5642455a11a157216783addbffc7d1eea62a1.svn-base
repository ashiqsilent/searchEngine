using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Configuration; // to use the ConfigurationManager
using System.Data; // to use DataSet or DataTable
using System.Data.SqlClient; // to communicate with SQL Server database
using System.Text;
using Subgurim.Controles;
using System.Windows.Forms;

public partial class searchResult : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Master.getFindButton.Click += new EventHandler(findButton_click);

        string country = Application["country"].ToString();
        string category = Application["cat"].ToString();
        string name = Application["name"].ToString();


        if (!IsPostBack)
        {
            Master.getName.Text = name;
            Master.getCountry.SelectedValue = country;
            Master.getCatagory.SelectedValue = category;
        }

        addParameters(name, category, country);
        if (displayTable.Rows.Count == 0)
        {
            error.Text = "Sorry no match found";
            GMap1.Visible = false;
            displayTable.Visible = false;
        }
        
    }

    private void showMap()
    {
        GridView gv = new GridView();
        gv.DataSource = SqlDataSource1;
        gv.DataBind();

        int start = displayTable.PageIndex * 10;

        string sMapKey = ConfigurationManager.AppSettings["googlemaps.subgurim.net"];
        GeoCode geoCode;
        GLatLng gLatLng = null;
        GMarker oMarker;
        string sStreetAddress;
        MarkerManager mManager = new MarkerManager();
        GMap1.Add(new GMapUI());

        for (int i = 0; i < Math.Min(10, gv.Rows.Count - displayTable.PageIndex * 10); i++)
        {
            sStreetAddress = gv.Rows[start].Cells[2].Text + ", " + gv.Rows[start].Cells[6].Text + ", " + gv.Rows[start].Cells[7].Text;
            geoCode = GMap.geoCodeRequest(sStreetAddress, sMapKey);
            gLatLng = new GLatLng(geoCode.Placemark.coordinates.lat, geoCode.Placemark.coordinates.lng);
            oMarker = new GMarker(gLatLng);
            GInfoWindow window = new GInfoWindow(oMarker, gv.Rows[start].Cells[1].Text, false, GListener.Event.mouseover);
            mManager.Add(oMarker, 0);
            mManager.Add(window, 0);
            start += 1;
        }

        GMap1.markerManager = mManager;
        GMap1.setCenter(gLatLng, 10, Subgurim.Controles.GMapType.GTypes.Normal);
        GMap1.enableHookMouseWheelToZoom = true;
        
    }

    // show map with markers
    private void showMap2(DataTable table)
    {
        string sMapKey = ConfigurationManager.AppSettings["googlemaps.subgurim.net"];
        GeoCode geoCode;
        GLatLng gLatLng = null;
        GMarker oMarker;
        string sStreetAddress;
        List<GMarker> markers = new List<GMarker>();
        GMap1.Add(new GMapUI());

        foreach (DataRow row in table.Rows)
        {
            sStreetAddress = row["Address"].ToString() + ", " + row["Description"].ToString() + ", " + row["Country"].ToString();
            geoCode = GMap.geoCodeRequest(sStreetAddress, sMapKey);
            gLatLng = new GLatLng(geoCode.Placemark.coordinates.lat, geoCode.Placemark.coordinates.lng);
            oMarker = new GMarker(gLatLng);
            GInfoWindow window = new GInfoWindow(oMarker, row["Title"].ToString(), false, GListener.Event.mouseover);
            GMap1.Add(window);
            markers.Add(oMarker);
        }
        GMap1.markerClusterer = new MarkerClusterer(markers);
        GMap1.setCenter(gLatLng, 6, Subgurim.Controles.GMapType.GTypes.Normal);
        GMap1.enableHookMouseWheelToZoom = true;
    }

    private void addParameters(string name, string cat, string country)
    {
        if (cat == "All Categories") {
            cat = "%";
        }
        if (country == "All Countries") {
            country = "%";
        }
        if (name == "")
        {
            name = "%";
        }
        SqlDataSource1.SelectParameters.Clear();

        SqlDataSource1.SelectParameters.Add("Title", name);
        SqlDataSource1.SelectParameters.Add("Category", cat);
        SqlDataSource1.SelectParameters.Add("Country", country);

    }

    private void findButton_click(object sender, EventArgs e)
    {
        Application["name"] = Master.getName.Text;
        Application["cat"] = Master.getCatagory.SelectedItem;
        Application["country"] = Master.getCountry.SelectedItem;

        Helper h = new Helper();
        Response.Redirect(h.generateSearchUrl(Master.getName.Text.ToString(), Master.getCatagory.SelectedItem.ToString(), Master.getCountry.SelectedItem.ToString()));
    }




    public string generateDetailsURL(object id, object name)
    {
        string n = name.ToString();
        n.Trim();
        n = n.ToLower();
        n = n.Replace(" ", "_");
        n = n.Replace(".","");
        n = n.Replace("&","and");
        return "~/details/" + id.ToString() + "/" + n;

    }


    protected void displayTable_PageIndexChanged(object sender, EventArgs e)
    {
        showMap();
       
    }

    protected void displayTable_OnLoad(object sender, EventArgs e)
    {
        if (displayTable.PageIndex == 0)
        {
            showMap();
        }
    }
}