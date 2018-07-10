using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Lite.Views.Supplementary
{
    public partial class AddInfo : UserControl
    {
        public event Action<string, string> UpdateItem;
        public event Func<string, List<string[]>> GetList;
        public event Func<string, object> ReadColumn;
        private string table;
        public AddInfo(string table)
        {
            InitializeComponent();
            this.table = table;
        }
        public void ReadItem()
        {
            var name = ReadColumn(Columns.Name);
            var inf = ReadColumn(Columns.Add_Info);
            comboBoxFind.Text = name as string;
            textBox.Text = inf as string;
        }
        public void OnlyRead()
        {
            comboBoxFind.Enabled = false;
            textBox.ReadOnly = true;
        }
        private void comboBoxFind_DropDown(object sender, EventArgs e)
        {
            comboBoxFind.Items.Clear();
            var list = GetList(table);
            foreach (var i in list)
            {
                comboBoxFind.Items.Add(i[0]);
            }
        }

        private void comboBoxFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Name, comboBoxFind.Text);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Add_Info, textBox.Text);
        }
    }
}
