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
    public partial class CharStat : UserControl
    {
        public event Action<string, string> UpdateItem;
        public event Func<string, List<string[]>> GetList;
        public event Func<string, object> ReadColumn;
        private string table;
        public CharStat(string table)
        {
            InitializeComponent();
            this.table = table;
        }
        public void ReadItem()
        {
            var name = ReadColumn(Columns.Name);
            var bas = ReadColumn(Columns.Con_StartStat);
            var cur = ReadColumn(Columns.Con_CurrStat);
            var adv = ReadColumn(Columns.Con_AdvStat);
            comboBox.Text = name as string;
            numericUpDownA.Value = decimal.Parse(cur.ToString());
            numericUpDownB.Value = decimal.Parse(bas.ToString());
            numericUpDownS.Value = decimal.Parse(adv.ToString());
        }
        public void OnlyRead()
        {
            comboBox.Enabled = false;
            numericUpDownA.Enabled = false;
            numericUpDownB.Enabled = false;
            numericUpDownS.Enabled = false;
        }

        private void numericUpDownB_ValueChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Con_StartStat, numericUpDownB.Value.ToString());
        }

        private void numericUpDownS_ValueChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Con_AdvStat, numericUpDownS.Value.ToString());
        }

        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Con_CurrStat, numericUpDownA.Value.ToString());
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Name, comboBox.Text);
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
