using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Lite.Views.Types
{
    public partial class Talent : UserControl
    {
        public event Action<string, string> UpdateItem;
        public event Func<string, object> ReadColumn;
        public event Func<string, List<string[]>> GetList;
        public Talent()
        {
            InitializeComponent();
        }
        public void ReadItem()
        {
            var name = ReadColumn(Columns.Name);
            var desc = ReadColumn(Columns.Desc);
            var stat = ReadColumn(Columns.Con_stat);
            var bonus = ReadColumn(Columns.Value);
            textBoxName.Text = name as string;
            textBoxDesc.Text = desc as string;
            comboBoxStat.Text = stat as string;
            numericUpDownBonus.Value = decimal.Parse(bonus.ToString());
        }
        public void OnlyRead()
        {
            textBoxName.ReadOnly = true;
            textBoxDesc.ReadOnly = true;
            comboBoxStat.Enabled = false;
            numericUpDownBonus.Enabled = false;
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Name, textBoxName.Text);
        }

        private void comboBoxStat_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Con_stat, comboBoxStat.Text);
        }

        private void numericUpDownBonus_ValueChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Value, numericUpDownBonus.Value.ToString());
        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Desc, textBoxDesc.Text);
        }

        private void comboBoxStat_DropDown(object sender, EventArgs e)
        {
            comboBoxStat.Items.Clear();
            var list = GetList("Cechy");
            foreach (var i in list)
            {
                comboBoxStat.Items.Add(i[0]);
            }
        }
    }
}
