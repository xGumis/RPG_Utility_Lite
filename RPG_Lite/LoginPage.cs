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
            if (textBox1.Text != null)
                if (textBox2.Text != null)
                    Query.Change_Login(textBox1.Text, textBox2.Text);
            Query.Initiate();
            MessageBox.Show(Query.is_Admin());
            DBOperator asd = new DBOperator();
            asd.Testadd();
            
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            DBOperator asd = new DBOperator();
            comboBox1.Items.Clear();
            var lis = asd.GetRecordsList("Cechy");
            var range = new string[lis.Count];
            for(int i = 0; i < lis.Count; i++)
            {
                range[i] = lis[i][0];
            }
            comboBox1.Items.AddRange(range);
        }
    }
}
