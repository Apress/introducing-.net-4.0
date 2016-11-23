using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization.Charting;

namespace Chapter10.ASP
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(System.Configuration.ConfigurationManager.AppSettings.Get("RunMode"));

            Random r = new Random();
            Series series = new Series("Line");
            series.ChartType = SeriesChartType.Line;
            for (int i = 0; i < 100; i++)
            {
                series.Points.AddY(r.Next(0, 100));
            }
            chart1.Series.Add(series);

            //Response.RedirectPermanent("/newPath.aspx");

            //Routing
            //System.Web.Routing.RouteTable.Routes.MapPageRoute("myProductGroupRoute", "{groups}", "~/default.aspx?id=123");
            //string searchTerm=Page.RouteData.Values["group"];
            //Page.GetRouteUrl("myProductGroupRoute", new { group = "brandNew" })

        }
    }
}
