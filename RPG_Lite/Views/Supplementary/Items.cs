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
    public partial class Items : UserControl
    {
        public event Action<string, string> UpdateItem;
        public event Func<string, List<string[]>> GetList;
        public event Func<string, object> ReadColumn;
        private string table;
        private List<string[]> list;
        public Items(string table)
        {
            InitializeComponent();
            this.table = table;
            if (table != "Przedmioty")
                textBox.Enabled = false;
        }
        public void ReadItem()
        {
            var name = ReadColumn(Columns.Name);
            var qual = ReadColumn(Columns.Quality);
            var quan = ReadColumn(Columns.Quantity);
            var a = ReadColumn(Columns.Add_Info);
            comboBox.Text = name as string;
            comboBoxQ.Text = qual as string;
            numericUpDownQ.Value = decimal.Parse(quan.ToString());
            textBox.Text = a as string;
        }
        public void OnlyRead()
        {
            comboBox.Enabled = false;
            comboBoxQ.Enabled = false;
            numericUpDownQ.Enabled = false;
            textBox.ReadOnly = true;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Add_Info, textBox.Text);
        }

        private void numericUpDownQ_ValueChanged(object sender, EventArgs e)
        {

            UpdateItem(Columns.Quantity, numericUpDownQ.Value.ToString());
        }

        private void comboBoxQ_SelectedIndexChanged(object sender, EventArgs e)
        {

            UpdateItem(Columns.Quality, comboBoxQ.Text);
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            UpdateItem(Columns.Name, comboBox.Text);
            UpdateItem(Columns.Id, list[comboBox.SelectedIndex][0]);
        }

        private void comboBox_DropDown(object sender, EventArgs e)
        {
            comboBox.Items.Clear();
            list = GetList(table);
            foreach (var i in list)
            {
                comboBox.Items.Add(i[1]);
            }
        }
    }
}
