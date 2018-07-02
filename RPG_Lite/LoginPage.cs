using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Lite
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Query.Initiate();
            MessageBox.Show(Query.Show_Role());
            
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            DBOperator asd = new DBOperator();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(asd.GetTables());
        }
    }
}
