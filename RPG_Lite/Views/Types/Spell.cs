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
    public partial class Spell : UserControl
    {
        public event Action<string, string> UpdateItem;
        public event Func<string, object> ReadColumn;
        public event Func<string, List<string[]>> GetList;
        private List<string[]> items;
        public Spell()
        {
            InitializeComponent();
        }
        public void ReadItem()
        {
            var name = ReadColumn(Columns.Name);
            var desc = ReadColumn(Columns.Desc);
            var talent = ReadColumn(Columns.Spell_ReqTal);
            var bonus = ReadColumn(Columns.Spell_Bonus);
            var cast = ReadColumn(Columns.Spell_Cast);
            var dur = ReadColumn(Columns.Spell_Durat);
            var lvl = ReadColumn(Columns.Spell_Lvl);
            var type = ReadColumn(Columns.Spell_MType);
            var item = ReadColumn(Columns.Con_Item);
            textBoxName.Text = name as string;
            textBoxDesc.Text = desc as string;
            comboBoxTalent.Text = talent as string;
            numericUpDownBonus.Value = decimal.Parse(bonus.ToString());
            numericUpDownCast.Value = decimal.Parse(cast.ToString());
            numericUpDownDur.Value = decimal.Parse(dur.ToString());
            numericUpDownLevel.Value = decimal.Parse(lvl.ToString());
            textBoxType.Text = type as string;
            comboBoxItem.Text = item as string;
        }
        public void OnlyRead()
        {
            textBoxName.ReadOnly = true;
            textBoxDesc.ReadOnly = true;
            textBoxType.ReadOnly = true;
            comboBoxTalent.Enabled = false;
            numericUpDownBonus.Enabled = false;
            comboBoxItem.Enabled = false;
            numericUpDownCast.Enabled = false;
            numericUpDownDur.Enabled = false;
            numericUpDownLevel.Enabled = false;
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Name, textBoxName.Text);
        }
        private void comboBoxTalent_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Spell_ReqTal, comboBoxTalent.Text);
        }
        private void textBoxType_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Spell_MType, textBoxType.Text);
        }
        private void numericUpDownLevel_ValueChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Spell_Lvl, numericUpDownLevel.Value.ToString());
        }
        private void numericUpDownCast_ValueChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Spell_Cast, numericUpDownCast.Value.ToString());
        }
        private void numericUpDownDur_ValueChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Spell_Durat, numericUpDownDur.Value.ToString());
        }
        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var item in items)
            {
                if(item[1] == comboBoxItem.Text)
                    UpdateItem(Columns.Con_Item, item[0]);
            }
        }
        private void numericUpDownBonus_ValueChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Spell_Bonus, numericUpDownBonus.Value.ToString());
        }
        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Desc, textBoxDesc.Text);
        }
        private void comboBoxTalent_DropDown(object sender, EventArgs e)
        {
            comboBoxTalent.Items.Clear();
            var list = GetList("Zdolności");
            foreach (var i in list)
            {
                comboBoxTalent.Items.Add(i[0]);
            }
        }
        private void comboBoxItem_DropDown(object sender, EventArgs e)
        {
            comboBoxItem.Items.Clear();
            items = GetList("Przedmioty");
            foreach (var i in items)
            {
                comboBoxItem.Items.Add(i[1]);
            }
        }
    }
}
