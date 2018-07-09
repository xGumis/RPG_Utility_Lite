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
        public Talent()
        {
            InitializeComponent();
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
    }
}
