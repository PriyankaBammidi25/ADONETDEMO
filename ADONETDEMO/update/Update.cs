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

namespace ADONETDEMO.update
{
    
    public partial class Update : Form
    {
        SqlConnection Con = null;
        SqlCommand Cmd = null;
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            //step 1
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=ADODB;Data Source=DESKTOP-B42VFF8");


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //step 2
            try
            {
                Con.Open();
                Cmd = new SqlCommand("Update Emp set Ename=@En,Deptno=@D where Empno=@Eno", Con);
                Cmd.Parameters.AddWithValue("@En", txtEname.Text);
                Cmd.Parameters.AddWithValue("@D", int.Parse(txtDeptno.Text));
                Cmd.Parameters.AddWithValue("@Eno", int.Parse(txtEmpNo.Text));
                int R = Cmd.ExecuteNonQuery();
                if (R != 0)
                    MessageBox.Show(R + "rows updated");
                else
                    MessageBox.Show("No emp exists");

            }
            catch (SqlException E)
            {
                MessageBox.Show("Enter name in required characters");
            }
            catch (FormatException E)
            {
                MessageBox.Show("Enter details in deptno");
            }
            catch (InvalidOperationException E)
            {
                MessageBox.Show("no emp exits with this number");
            }
            finally
            {
                Con.Close();
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                Cmd = new SqlCommand("Select * from Emp where Empno=@Eno", Con);//to check 
                Cmd.Parameters.AddWithValue("@Eno", int.Parse(txtEmpNo.Text));
                SqlDataReader R = Cmd.ExecuteReader();
                R.Read();
                txtEname.Text = R[1].ToString();
                cpbGender.Text = R[2].ToString();
                dtpDob.Text = R[3].ToString();
                txtDeptno.Text = R[4].ToString();
            }
            catch (InvalidOperationException E)
            {
                MessageBox.Show("no emp exits with this number");
                txtEname.Text = "";
                txtEmpNo.Text = "";
                txtDeptno.Text = "";
                cpbGender.Text = "";
                dtpDob.Text = "";

            }
            catch(FormatException E)
            {
                MessageBox.Show("Enter only numbers");
            }
            catch (SqlException E)
            {
                MessageBox.Show("Enter name in required characters");
            }
           

            finally
            {
                Con.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                Cmd = new SqlCommand("delete from Emp where Empno=@Eno", Con);
                Cmd.Parameters.AddWithValue("@Eno", int.Parse(txtEmpNo.Text));
                int R = Cmd.ExecuteNonQuery();
                MessageBox.Show(R + "row deleted");
                if (R != 0)
                    MessageBox.Show(R + "rows deleted");
                else
                    MessageBox.Show("No emp exists");
            }
            
            catch(FormatException E)
            {
                MessageBox.Show("Enter details");
            }
            finally
            {
                Con.Close();
            }
        }
    }
}
