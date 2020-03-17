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
    public partial class Insert : Form
    {
        SqlConnection Con = null;
        SqlCommand Cmd = null;
        public Insert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                //step 2
                Con.Open();
                //step 3
                Cmd = new SqlCommand("insert into Emp values(@Eno,@En,@G,@D)", Con);
                MessageBox.Show("after insert");
                Cmd.Parameters.AddWithValue("@Eno", int.Parse(txtEmpNo.Text));
                Cmd.Parameters.AddWithValue("@En", txtEname.Text);
                Cmd.Parameters.AddWithValue("@G", cpbGender.Text);
                Cmd.Parameters.AddWithValue("@D", DateTime.Parse(dtpDob.Text));
                //step 4
                int R = Cmd.ExecuteNonQuery();
                MessageBox.Show(R + "Row inserted");
            }
            catch (SqlException E)
            {
                //MessageBox.Show(E.Message);
                if (E.Message.Contains("PK_Emp"))
                    MessageBox.Show("Empno cannot be same");
                if (E.Message.Contains("CK_Dob"))
                    MessageBox.Show("age shd be min 21");
                if (E.Message.Contains("CK_Gender"))
                    MessageBox.Show("Enter gender");
            }
            finally
            {
                //step 5
                Con.Close();
            }
        }

        private void Insert_Load(object sender, EventArgs e)
        {
            //step1
            Con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ADODB;Data Source=DESKTOP-B42VFF8");
        }
    }
}
