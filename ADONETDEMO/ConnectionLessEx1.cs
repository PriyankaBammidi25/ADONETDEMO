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
    public partial class ConnectionLessEx1 : Form
    {
        SqlConnection Con=null;
        SqlDataAdapter Adp = null;
        public ConnectionLessEx1()
        {
            InitializeComponent();
        }

        private void ConnectionLessEx1_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-B42VFF8");
            Adp = new SqlDataAdapter("Select * from Deptdata", Con);
            DataSet Ds = new DataSet();
            //DataTable dt = new DataTable();
            //DataRow row = dt.NewRow();
            ////row[0] = 0;
            //row["Code"] = "None";
            //row["Name"] = "Please select";
            //dt.Rows.InsertAt(row, 0);
            //cpbBox.ValueMember = "None";
            //cpbBox.DisplayMember = "Please select";
            Adp.Fill(Ds, "Dept");
            cpbBox.DataSource = Ds.Tables["Dept"];
            cpbBox.ValueMember = "Deptno";
            cpbBox.DisplayMember = "Dname";


        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            try
            {
                Adp = new SqlDataAdapter("Select * from Empdata where Deptno=@D", Con);
                Adp.SelectCommand.Parameters.AddWithValue("@D", int.Parse(txtDeptno.Text));

                DataSet Ds = new DataSet();
                Adp.Fill(Ds, "Emp");
                dgvData.DataSource = Ds.Tables["Emp"];
            }
            catch(FormatException E)
            {
                MessageBox.Show("Text");
            }

        }

        private void cpbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnbutton1_Click(object sender, EventArgs e)
        {

            Adp = new SqlDataAdapter("Select * from Empdata where Deptno=@D", Con);
           // Adp.SelectCommand.Parameters.AddWithValue("@D", int.Parse(cpbBox.Text));
            Adp.SelectCommand.Parameters.AddWithValue("@D", cpbBox.SelectedValue);
            DataSet Ds = new DataSet();
            Adp.Fill(Ds, "Emp");
            dgvData.DataSource = Ds.Tables["Emp"];
        }
    }
}
