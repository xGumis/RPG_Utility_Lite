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
    public partial class Skill : UserControl
    {
        public event Action<string, string> UpdateItem;
        public event Func<string, object> ReadColumn;
        public event Func<string, List<string[]>> GetList;
        public Skill()
        {
            InitializeComponent();
        }
        public void ReadItem()
        {
            var name = ReadColumn(Columns.Name);
            var desc = ReadColumn(Columns.Desc);
            var stat = ReadColumn(Columns.Skill_Stat);
            var type = ReadColumn(Columns.Skill_Type);
            textBoxName.Text = name as string;
            textBoxDesc.Text = desc as string;
            comboBoxStat.Text = stat as string;
            comboBoxType.Text = type as string;
        }
        public void OnlyRead()
        {
            textBoxName.ReadOnly = true;
            textBoxDesc.ReadOnly = true;
            comboBoxStat.Enabled = false;
            comboBoxType.Enabled = false;
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Name, textBoxName.Text);
        }
        private void comboBoxStat_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Skill_Stat, comboBoxStat.Text);
        }
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Skill_Type, comboBoxType.Text);
        }
        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Desc, textBoxDesc.Text);
        }
        private void comboBoxStat_DropDown(object sender, EventArgs e)
        {
            comboBoxStat.Items.Clear();
            var list = GetList("Cechy");
            foreach(var i in list)
            {
                comboBoxStat.Items.Add(i[0]);
            }
        }
    }
}
