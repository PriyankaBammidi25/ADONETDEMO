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
    public partial class CLUpdate : Form
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        DataSet Ds = null;
        public CLUpdate()
        {
            InitializeComponent();
        }

        private void CLUpdate_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-B42VFF8");
            Adp = new SqlDataAdapter("Select * from Deptdata", Con);
            Ds = new DataSet();
            Adp.Fill(Ds, "D");
            cmbBox.DataSource = Ds.Tables["D"];
            cmbBox.ValueMember = "Deptno";
            cmbBox.DisplayMember = "Dname";
        }

        private void txtEmpno_Leave(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("Select * from Empdata where Empno=@E", Con);
            Adp.SelectCommand.Parameters.AddWithValue("@E", int.Parse(txtEmpno.Text));
            Ds = new DataSet();
            Adp.Fill(Ds, "E");
            DataRow R = Ds.Tables["E"].Rows[0];
            txtEname.Text = R[1].ToString();
            //txtEname.Text = Ds.Tables["E"].Rows[0][1].ToString();
            //txtJob.Text = Ds.Tables["E"].Rows[0][2].ToString();
            txtJob.Text = R[2].ToString();
            txtMGR.Text = R[3].ToString();
            dtpDate.Text = R[4].ToString();
            txtSal.Text = R[5].ToString();
            txtComm.Text = R[6].ToString();
            cmbBox.Text = R[7].ToString();

            
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("Select * from Empdata where Empno=@E", Con);
            Adp.SelectCommand.Parameters.AddWithValue("@E", int.Parse(txtEmpno.Text));
            Ds = new DataSet();
            Adp.Fill(Ds, "E");
            DataRow R = Ds.Tables["E"].Rows[0];
            R[2] = txtJob.Text;
            R[3] = int.Parse(txtMGR.Text);
            R[5] = int.Parse(txtSal.Text);
            if(txtComm.Text.Length!=0)
              R[6] = int.Parse(txtComm.Text);
            R[7] = int.Parse(cmbBox.Text);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("Select * from Empdata where Empno=@E", Con);
            Adp.SelectCommand.Parameters.AddWithValue("@E", int.Parse(txtEmpno.Text));
            Ds = new DataSet();
            Adp.Fill(Ds, "E");
            Ds.Tables["E"].Rows[0].Delete();
            SqlCommandBuilder cmb = new SqlCommandBuilder(Adp);
            Adp.DeleteCommand = cmb.GetDeleteCommand();
            Adp.Update(Ds, "E");
            MessageBox.Show("1 row Deleted");
        }
    }
}
