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
    public partial class Weapon : UserControl
    {
        public event Action<string, string> UpdateItem;
        public event Func<string, object> ReadColumn;
        public Weapon()
        {
            InitializeComponent();
        }
        public void ReadItem()
        {
            var name = ReadColumn(Columns.Name);
            var desc = ReadColumn(Columns.Desc);
            var avail = ReadColumn(Columns.Availability);
            var weight = ReadColumn(Columns.Weight);
            var treats = ReadColumn(Columns.Weapon_Treats);
            var range = ReadColumn(Columns.Weapon_Range);
            var reload = ReadColumn(Columns.Weapon_Reload);
            var dmg = ReadColumn(Columns.Weapon_Dmg);
            var cat = ReadColumn(Columns.Weapon_Category);
            var price = ReadColumn(Columns.Price);
            textBoxCategory.Text = cat as string;
            textBoxName.Text = name as string;
            textBoxDesc.Text = desc as string;
            comboBoxAvailability.Text = avail as string;
            numericUpDownRange.Value = decimal.Parse(range.ToString());
            textBoxDamage.Text = dmg as string;
            textBoxPrice.Text = price as string;
            textBoxTreats.Text = treats as string;
            numericUpDownReload.Value = decimal.Parse(reload.ToString());
            numericUpDownWeight.Value = decimal.Parse(weight.ToString());
        }
        public void OnlyRead()
        {
            textBoxName.ReadOnly = true;
            textBoxDesc.ReadOnly = true;
            textBoxPrice.ReadOnly = true;
            comboBoxAvailability.Enabled = false;
            numericUpDownWeight.Enabled = false;
            textBoxCategory.ReadOnly = true;
            textBoxDamage.ReadOnly = true;
            numericUpDownRange.Enabled = false;
            numericUpDownReload.Enabled = false;
            textBoxTreats.ReadOnly = true;
        }
        private void textBoxCategory_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Weapon_Category, textBoxCategory.Text);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Name, textBoxName.Text);
        }

        private void comboBoxAvailability_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Availability, comboBoxAvailability.Text);
        }

        private void numericUpDownWeight_ValueChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Weight, numericUpDownWeight.Value.ToString());
        }

        private void textBoxTreats_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Weapon_Treats, textBoxTreats.Text);
        }

        private void numericUpDownRange_ValueChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Weapon_Range, numericUpDownRange.Value.ToString());
        }

        private void numericUpDownReload_ValueChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Weapon_Reload, numericUpDownReload.Value.ToString());
        }

        private void textBoxDamage_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Weapon_Dmg, textBoxDamage.Text);
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Price, textBoxPrice.Text);
        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Desc, textBoxDesc.Text);
        }
    }
}
