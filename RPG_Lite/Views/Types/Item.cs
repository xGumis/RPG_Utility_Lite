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
    public partial class Item : UserControl
    {
        public event Action<string, string> UpdateItem;
        public event Func<string, object> ReadColumn;
        public Item()
        {
            InitializeComponent();
        }
        public void ReadItem()
        {
            var name = ReadColumn(Columns.Name);
            var desc = ReadColumn(Columns.Desc);
            var avail = ReadColumn(Columns.Availability);
            var weight = ReadColumn(Columns.Weight);
            var price = ReadColumn(Columns.Price);
            textBoxName.Text = name as string;
            textBoxDesc.Text = desc as string;
            comboBoxAvailability.Text = avail as string;
            textBoxPrice.Text = price as string;
            numericUpDownWeight.Value = decimal.Parse(weight.ToString());
        }
        public void OnlyRead()
        {
            textBoxName.ReadOnly = true;
            textBoxDesc.ReadOnly = true;
            textBoxPrice.ReadOnly = true;
            comboBoxAvailability.Enabled = false;
            numericUpDownWeight.Enabled = false;
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
