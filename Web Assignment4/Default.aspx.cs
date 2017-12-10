using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using Newtonsoft.Json;

namespace Web_Assignment4
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fileJson = File.ReadAllText(@"c:\users\min gi\documents\visual studio 2015\Projects\Web Assignment4\Web Assignment4\json\Assign04.json");
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(fileJson, typeof(DataTable));
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}