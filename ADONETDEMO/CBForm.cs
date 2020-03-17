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
    public partial class CBForm : Form
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        public CBForm()
        {
            InitializeComponent();
        }

        private void btnButton1_Click(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-B42VFF8");
            Adp = new SqlDataAdapter("Select * from Empdata", Con);//adapter in connectionless takes only DML command
            DataSet Ds = new DataSet();
            SqlCommandBuilder Cmb = new SqlCommandBuilder(Adp);
            SqlCommand Cmd = Cmb.GetInsertCommand();
            MessageBox.Show(Cmd.CommandText);
            SqlCommand Cmd1 = Cmb.GetUpdateCommand();
            MessageBox.Show(Cmd1.CommandText);
            SqlCommand Cmd2 = Cmb.GetDeleteCommand();
            MessageBox.Show(Cmd2.CommandText);
        }
    }
}
