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
    public partial class Combo : UserControl
    {
        public event Action<string, string> UpdateItem;
        public event Func<string, List<string[]>> GetList;
        public event Func<string, object> ReadColumn;
        private string table;
        private List<string[]> list;
        public Combo(string table)
        {
            InitializeComponent();
            this.table = table;
        }
        public void ReadItem()
        {
            var name = ReadColumn(Columns.Name);
            comboBox.Text = name as string;
        }
        public void OnlyRead()
        {
            comboBox.Enabled = false;
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
