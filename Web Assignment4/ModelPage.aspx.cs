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
    public partial class ModelPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int sel = Convert.ToInt32(Request.QueryString["Name"]);


            //SqlCommand comm = new SqlCommand("SELECT a.StudentID, a.LastName, a.FirstMidName, b.CourseID, b.Title, b.Credits FROM Students a JOIN Enrollments e on(a.StudentID = e.StudentID) JOIN Courses b ON(e.CourseID = b.CourseID) where a.StudentID = @StudentID", conn);
            //comm.Parameters.Add("@StudentID", System.Data.SqlDbType.Int);
            //comm.Parameters["@StudentID"].Value = StudentID;
            //conn.Open();
            //SqlDataReader reader = comm.ExecuteReader();
            //GridView1.DataSource = reader;
            //GridView1.DataBind();
            //reader.Close();
            //conn.Close();
        }

        protected void open()
        {
            string fileJson = File.ReadAllText(@"c:\users\min gi\documents\visual studio 2015\Projects\Web Assignment4\Web Assignment4\json\Assign04.json");
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(fileJson, typeof(DataTable));
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}