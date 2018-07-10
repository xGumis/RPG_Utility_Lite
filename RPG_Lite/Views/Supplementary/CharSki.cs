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
    public partial class CharSki : UserControl
    {
        public event Action<string, string> UpdateItem;
        public event Func<string, List<string[]>> GetList;
        public event Func<string, object> ReadColumn;
        private string table;
        public CharSki(string table)
        {
            InitializeComponent();
            this.table = table;
        }
        public void ReadItem()
        {
            var name = ReadColumn(Columns.Name);
            var inf = ReadColumn(Columns.Add_Info);
            var lv = ReadColumn(Columns.Level);
            comboBox.Text = name as string;
            textBox.Text = inf as string;
            numericUpDown.Value = decimal.Parse(lv.ToString());
        }
        public void OnlyRead()
        {
            comboBox.Enabled = false;
            textBox.ReadOnly = true;
            numericUpDown.Enabled = false;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Name, comboBox.Text);
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Level, numericUpDown.Value.ToString());
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Add_Info, textBox.Text);
        }

        private void comboBox_DropDown(object sender, EventArgs e)
        {
            comboBox.Items.Clear();
            var list = GetList(table);
            foreach (var i in list)
            {
                comboBox.Items.Add(i[0]);
            }
        }
    }
}
