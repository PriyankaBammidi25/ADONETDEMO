using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADONETDEMO
{
    public partial class Extract : Form
    {
        SqlConnection Con = null;
        SqlCommand Cmd = null;
        public Extract()
        {
            InitializeComponent();
        }

        private void Extract_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-B42VFF8");
           
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            Con.Open();
            Cmd = new SqlCommand("Select * from Empdata where Deptno=@D", Con);
            Cmd.Parameters.AddWithValue("@D", int.Parse(txtDeptno.Text));
            SqlDataReader R=Cmd.ExecuteReader();
            DataSet Ds = new DataSet();//temporarily creating db which is empty
            Ds.Tables.Add("Deptdata"); //Adding table with table name(Creating table which is empty)
            Ds.Tables["Deptdata"].Load(R);//table is loaded which data(Executereader)
            dgvData.DataSource = Ds.Tables["Deptdata"];//data is shown in gridview ;assigning the datasource to show to the end user
           Con.Close();

        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            Con.Open();
            Cmd = new SqlCommand("Select * from Empdata where hiredate between @S and @E", Con);
            Cmd.Parameters.AddWithValue("@S", DateTime.Parse(dtp1.Text));
            Cmd.Parameters.AddWithValue("@E", DateTime.Parse(dtp2.Text));
            SqlDataReader R = Cmd.ExecuteReader();
            DataSet Ds = new DataSet();
            Ds.Tables.Add("Deptdata");
            Ds.Tables["Deptdata"].Load(R);
            dgv1.DataSource = Ds.Tables["Deptdata"];
            Con.Close();
        }

        private void btnbutton1_Click(object sender, EventArgs e)
        {
            Con.Open();
            Cmd = new SqlCommand("Select * from View2", Con);
            SqlDataReader R = Cmd.ExecuteReader();
            DataSet Ds = new DataSet();
            Ds.Tables.Add("Deptdata");
            Ds.Tables["Deptdata"].Load(R);
            dgv2.DataSource = Ds.Tables["Deptdata"];
            Con.Close();
        }
    }
}
