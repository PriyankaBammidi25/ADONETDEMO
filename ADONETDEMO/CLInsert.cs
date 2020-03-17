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
    public partial class CLInsert : Form
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        DataSet Ds = null;
        public CLInsert()
        {
            InitializeComponent();
        }

        private void CLInsert_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-B42VFF8");
            Adp = new SqlDataAdapter("Select * from Deptdata", Con);
             Ds = new DataSet();
            Adp.Fill(Ds, "D");
            cmbBox.DataSource = Ds.Tables["D"];
            cmbBox.ValueMember = "Deptno";
            cmbBox.DisplayMember = "Dname";


        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            try
            {
                Adp = new SqlDataAdapter("Select * from Empdata", Con);
                Ds = new DataSet();
                Adp.Fill(Ds, "E");
                DataRow R = Ds.Tables["E"].NewRow();
                R[0] = int.Parse(txtEmpno.Text);
                R[1] = txtEname.Text;
                R[2] = txtJob.Text;
                R[3] = int.Parse(txtMGR.Text);
                R[4] = DateTime.Parse(dtpDate.Text);
                R[5] = int.Parse(txtSal.Text);
                R[6] = int.Parse(txtComm.Text);
                R[7] = cmbBox.SelectedValue;
                Ds.Tables["E"].Rows.Add(R);
                //MessageBox.Show("HELLO");
                //to send the new insert recirds into db
                SqlCommandBuilder cmb = new SqlCommandBuilder(Adp);
                Adp.InsertCommand = cmb.GetInsertCommand();//generate insert command and stored in adp
                Adp.Update(Ds, "E");//through update we are updating the record in database
                MessageBox.Show("1 row inserted");
                clear();
            }
            catch(SqlException E)
            {
                MessageBox.Show(E.Message);
            }
           //Adp.DeleteCommand = cmb.GetDeleteCommand();
           // Adp.Update(Ds, "E");
           
        }
        private void clear()
        {
            txtEmpno.Text = " ";
            txtEname.Text = "";
            txtMGR.Text = "";
            txtJob.Text = "";
            txtComm.Text = " ";
            txtSal.Text = "";
            //dtpDate.Text = "";
            cmbBox.Text = "";
        }
    }
}
