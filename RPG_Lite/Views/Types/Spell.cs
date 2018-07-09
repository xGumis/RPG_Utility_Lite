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
        public Spell()
        {
            InitializeComponent();
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
           // UpdateItem(Columns.Con_Item, comboBoxItem.SelectedItem);
        }// to do

        private void numericUpDownBonus_ValueChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Spell_Bonus, numericUpDownBonus.Value.ToString());
        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Desc, textBoxDesc.Text);
        }
    }
}
