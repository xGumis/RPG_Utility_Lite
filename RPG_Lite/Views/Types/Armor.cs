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
    public partial class Armor : UserControl
    {
        public event Action<string, string> UpdateItem;
        public event Func<string, object> ReadColumn;
        public Armor()
        {
            InitializeComponent();
        }
        public void ReadItem()
        {
            var name = ReadColumn(Columns.Name);
            var desc = ReadColumn(Columns.Desc);
            var avail = ReadColumn(Columns.Availability);
            var weight = ReadColumn(Columns.Weight);
            var pt = ReadColumn(Columns.Armor_Points);
            var cover = ReadColumn(Columns.Armor_Cover);
            textBoxName.Text = name as string;
            textBoxDesc.Text = desc as string;
            comboBoxAvailability.Text = avail as string;
            numericUpDownPoints.Value = decimal.Parse(pt.ToString());
            textBoxCover.Text = cover as string;
            numericUpDownWeight.Value = decimal.Parse(weight.ToString());
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

        private void textBoxCover_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Armor_Cover, textBoxCover.Text);
        }

        private void numericUpDownPoints_ValueChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Armor_Points, numericUpDownPoints.Value.ToString());
        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Desc, textBoxDesc.Text);
        }
    }
}
