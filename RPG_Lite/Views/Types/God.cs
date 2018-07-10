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
    public partial class God : UserControl
    {
        public event Action<string, string> UpdateItem;
        public event Action<string, Dictionary<string, string>[]> UpdateItemList;
        public event Func<string, Dictionary<string, string>[]> ReadItemList;
        public event Func<string, object> ReadColumn;
        public event Func<string, List<string[]>> GetList;
        private ListViewItem hold;
        public God()
        {
            InitializeComponent();
        }
        public void ReadItem()
        {
            var name = ReadColumn(Columns.Name);
            var dsc = ReadColumn(Columns.Desc);
            var tal = ReadItemList(Columns.Con_Talent);
            var skil = ReadItemList(Columns.Con_Skill);
            var sym = ReadColumn(Columns.God_Symbol);

            foreach (var i in tal)
            {
                string n, a;
                i.TryGetValue(Columns.Name, out n);
                i.TryGetValue(Columns.Add_Info, out a);
                var tmp = new string[] { n.ToString(), a.ToString() };
                var l = new ListViewItem(tmp);
                listViewTalents.Items.Add(l);
            }
            foreach (var i in skil)
            {
                string n, a;
                i.TryGetValue(Columns.Name, out n);
                i.TryGetValue(Columns.Add_Info, out a);
                var tmp = new string[] { n.ToString(), a.ToString() };
                var l = new ListViewItem(tmp);
                listViewSkills.Items.Add(l);
            }
            textBoxDesc.Text = dsc as string;
            textBoxName.Text = name as string;
            pictureBoxSymbol.Image = (Bitmap)sym;
        }
        public void OnlyRead()
        {
            textBoxDesc.ReadOnly = true;
            textBoxName.ReadOnly = true;
            buttonSymbol.Enabled = false;
            listViewSkills.ContextMenuStrip.Enabled = false;
            listViewTalents.ContextMenuStrip.Enabled = false;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Name, textBoxName.Text);
        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Desc, textBoxDesc.Text);
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewSkills.Items.RemoveAt(listViewSkills.SelectedIndices[0]);
            UpdateList(true);
        }
        private void UpdateList(bool skill)
        {
            ListView.ListViewItemCollection coll;
            if (skill)
                coll = listViewSkills.Items;
            else
                coll = listViewTalents.Items;
            var lis = new List<Dictionary<string, string>>();
            foreach(ListViewItem item in coll)
            {
                var dic = new Dictionary<string, string>();
                dic.Add(Columns.Name, item.Text);
                if (item.SubItems.Count > 1)
                    dic.Add(Columns.Add_Info, item.SubItems[1].Text);
                lis.Add(dic);
            }
            if (skill)
                UpdateItemList(Columns.Con_Skill, lis.ToArray());
            else
                UpdateItemList(Columns.Con_Talent, lis.ToArray());
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var window = new Edit("AddInfoUmiejętności", false, false);
            window.End += Window_End;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            window.AddPanel();
            hold = new ListViewItem();
            window.Show();
        }

        private void Window_UpdateItem(string col, string val)
        {

            if (col == Columns.Name)
                hold.Text = val;
            else
            {
                hold = new ListViewItem(new string[] {hold.Text,val });
            }
        }

        private object Window_ReadColumn(string col)
        {
            if (col == Columns.Name)
                return hold.Text;
            else
                return hold.SubItems[1].Text;
        }

        private void Window_End(bool save, bool edit)
        {
            if (save)
            {
                if(edit) listViewSkills.Items.RemoveAt(listViewSkills.SelectedIndices[0]);
                listViewSkills.Items.Add(hold);
                UpdateList(true);
            }
        }
        private void Window_EndT(bool save, bool edit)
        {
            if (save)
            {
                if (edit) listViewTalents.Items.RemoveAt(listViewTalents.SelectedIndices[0]);
                listViewTalents.Items.Add(hold);
                UpdateList(false);
            }
        }
        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hold = (ListViewItem)listViewSkills.SelectedItems[0].Clone();
            var window = new Edit("AddInfoUmiejętności", true, false);
            window.End += Window_End;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            window.AddPanel();
            window.Show();
        }

        private void listViewSkills_ItemActivate(object sender, EventArgs e)
        {
            hold = listViewSkills.SelectedItems[0];
            var window = new Edit("AddInfoUmiejętności", true, true);
            window.End += Window_End;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            window.AddPanel();
            window.Show();
        }

        private void dodajToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            var window = new Edit("AddInfoZdolności", false, false);
            window.End += Window_EndT;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            hold = new ListViewItem();
            window.AddPanel();
            window.Show();
        }

        private void edytujToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hold = (ListViewItem)listViewTalents.SelectedItems[0].Clone();
            var window = new Edit("AddInfoZdolności", true, false);
            window.End += Window_EndT;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            window.AddPanel();
            window.Show();
        }

        private void usuńToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listViewTalents.Items.RemoveAt(listViewTalents.SelectedIndices[0]);
            UpdateList(false);
        }

        private void contextMenuStripSkill_Opening(object sender, CancelEventArgs e)
        {
            if(listViewSkills.SelectedIndices.Count < 1)
            {
                edytujToolStripMenuItem.Enabled = false;
                usuńToolStripMenuItem.Enabled = false;
            }
            else
            {
                edytujToolStripMenuItem.Enabled = true;
                usuńToolStripMenuItem.Enabled = true;
            }

        }

        private void contextMenuStripTalent_Opening(object sender, CancelEventArgs e)
        {
            if (listViewTalents.SelectedIndices.Count < 1)
            {
                edytujToolStripMenuItem1.Enabled = false;
                usuńToolStripMenuItem1.Enabled = false;
            }
            else
            {
                edytujToolStripMenuItem1.Enabled = true;
                usuńToolStripMenuItem1.Enabled = true;
            }
        }
    }
}
