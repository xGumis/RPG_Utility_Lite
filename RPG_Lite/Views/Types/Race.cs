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
    public partial class Race : UserControl
    {
        public event Action<string, string> UpdateItem;
        public event Action<string, Dictionary<string, string>[]> UpdateItemList;
        public event Func<string, Dictionary<string, string>[]> ReadItemList;
        public event Func<string, object> ReadColumn;
        public event Func<string, List<string[]>> GetList;
        ListViewItem hold;
        public Race()
        {
            InitializeComponent();
        }
        public void ReadItem()
        {
            var name = ReadColumn(Columns.Name);
            var his = ReadColumn(Columns.Race_History);
            var tip = ReadColumn(Columns.Race_Tips);
            var dsc = ReadColumn(Columns.Desc);
            var stats = ReadItemList(Columns.Con_stat);
            var tal = ReadItemList(Columns.Con_Talent);
            var skil = ReadItemList(Columns.Con_Skill);
            var car = ReadItemList(Columns.Con_Career);
            foreach(var i in stats)
            {
                string n, v;
                i.TryGetValue(Columns.Name, out n);
                i.TryGetValue(Columns.Con_StartStat, out v);
                var tmp = new string[] { n.ToString(), v.ToString() };
                var l = new ListViewItem(tmp);
                listViewStat.Items.Add(l);
            }
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
            foreach (var i in car)
            {
                string n;
                i.TryGetValue(Columns.Name, out n);
                var tmp = new string[] { n.ToString() };
                var l = new ListViewItem(tmp);
                listViewCareer.Items.Add(l);
            }
            textBoxDesc.Text = dsc as string;
            textBoxHistory.Text = his as string;
            textBoxName.Text = name as string;
            textBoxTips.Text = tip as string;
        }
        public void OnlyRead()
        {
            textBoxDesc.ReadOnly = true;
            textBoxHistory.ReadOnly = true;
            textBoxName.ReadOnly = true;
            textBoxTips.ReadOnly = true;
            listViewStat.ContextMenuStrip.Enabled = false;
            listViewCareer.ContextMenuStrip.Enabled = false;
            listViewSkills.ContextMenuStrip.Enabled = false;
            listViewTalents.ContextMenuStrip.Enabled = false;
        }
        private void UpdateList(string list)
        {
            ListView.ListViewItemCollection coll;
            if (list == "Stat")
                coll = listViewStat.Items;
            else if(list == "Career")
                coll = listViewCareer.Items;
            else if(list == "Skill")
                coll = listViewSkills.Items;
            else
                coll = listViewTalents.Items;
            var lis = new List<Dictionary<string, string>>();
            foreach (ListViewItem item in coll)
            {
                var dic = new Dictionary<string, string>();
                if (list == "Skill" || list == "Talent")
                {
                    dic.Add(Columns.Name, item.Text);
                    if (item.SubItems.Count > 1)
                        dic.Add(Columns.Add_Info, item.SubItems[1].Text);
                }
                else if (list == "Career")
                    dic.Add(Columns.Name, item.Text);
                else
                {
                    dic.Add(Columns.Name, item.Text);
                    if (item.SubItems.Count > 1)
                        dic.Add(Columns.Con_StartStat, item.SubItems[1].Text);
                }
                lis.Add(dic);
            }
            if (list == "Stat")
                UpdateItemList(Columns.Con_stat, lis.ToArray());
            else if (list == "Career")
                UpdateItemList(Columns.Con_Career, lis.ToArray());
            else if (list == "Skill")
                UpdateItemList(Columns.Con_Skill, lis.ToArray());
            else
                UpdateItemList(Columns.Con_Talent, lis.ToArray());
        }
        private object Window_ReadColumn(string col)
        {
            if (col == Columns.Name)
                return hold.Text;
            else
                return hold.SubItems[1].Text;
        }
        private void Window_UpdateItem(string col, string val)
        {
            if (col == Columns.Name)
                hold.Text = val;
            else
            {
                hold = new ListViewItem(new string[] { hold.Text, val.ToString() });
            }
        }
        private void Window_EndStat(bool save, bool edit)
        {
            if (save)
            {
                if (edit) listViewStat.Items.RemoveAt(listViewStat.SelectedIndices[0]);
                listViewStat.Items.Add(hold);
                UpdateList("Stat");
            }
        }
        private void Window_EndSkill(bool save, bool edit)
        {
            if (save)
            {
                if (edit) listViewSkills.Items.RemoveAt(listViewSkills.SelectedIndices[0]);
                listViewSkills.Items.Add(hold);
                UpdateList("Skill");
            }
        }
        private void Window_EndTalent(bool save, bool edit)
        {
            if (save)
            {
                if (edit) listViewTalents.Items.RemoveAt(listViewTalents.SelectedIndices[0]);
                listViewTalents.Items.Add(hold);
                UpdateList("Talent");
            }
        }
        private void Window_EndCareer(bool save, bool edit)
        {
            if (save)
            {
                if (edit) listViewCareer.Items.RemoveAt(listViewCareer.SelectedIndices[0]);
                listViewCareer.Items.Add(hold);
                UpdateList("Career");
            }
        }
        private void textBoxHistory_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Race_History, textBoxHistory.Text);
        }

        private void textBoxTips_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Race_Tips, textBoxTips.Text);
        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Desc, textBoxDesc.Text);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Name, textBoxName.Text);
        }

        private void dodajToolStripMenuItemStat_Click(object sender, EventArgs e)
        {
            var window = new Edit("ValueCechy", false, false);
            window.End += Window_EndStat;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            window.AddPanel();
            hold = new ListViewItem();
            window.Show();
        }

        private void edytujToolStripMenuItemStat_Click(object sender, EventArgs e)
        {
            hold = (ListViewItem)listViewStat.SelectedItems[0].Clone();
            var window = new Edit("ValueCechy", true, false);
            window.End += Window_EndStat;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            window.AddPanel();
            window.Show();
        }

        private void usuńToolStripMenuItemStat_Click(object sender, EventArgs e)
        {
            listViewStat.Items.RemoveAt(listViewStat.SelectedIndices[0]);
            UpdateList("Stat");
        }

        private void dodajToolStripMenuItemCareer_Click(object sender, EventArgs e)
        {
            var window = new Edit("ComboProfesje", false, false);
            window.End += Window_EndCareer;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            window.AddPanel();
            hold = new ListViewItem();
            window.Show();
        }

        private void edytujToolStripMenuItemCareer_Click(object sender, EventArgs e)
        {
            hold = (ListViewItem)listViewCareer.SelectedItems[0].Clone();
            var window = new Edit("ComboProfesje", true, false);
            window.End += Window_EndCareer;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            window.AddPanel();
            window.Show();
        }

        private void usuńToolStripMenuItemCareer_Click(object sender, EventArgs e)
        {
            listViewCareer.Items.RemoveAt(listViewCareer.SelectedIndices[0]);
            UpdateList("Career");
        }

        private void dodajToolStripMenuItemSkill_Click(object sender, EventArgs e)
        {
            var window = new Edit("AddInfoUmiejętności", false, false);
            window.End += Window_EndSkill;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            window.AddPanel();
            hold = new ListViewItem();
            window.Show();
        }

        private void edytujToolStripMenuItemSkill_Click(object sender, EventArgs e)
        {
            hold = (ListViewItem)listViewSkills.SelectedItems[0].Clone();
            var window = new Edit("AddInfoUmiejętności", true, false);
            window.End += Window_EndSkill;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            window.AddPanel();
            window.Show();
        }

        private void usuńToolStripMenuItemSkill_Click(object sender, EventArgs e)
        {
            listViewSkills.Items.RemoveAt(listViewSkills.SelectedIndices[0]);
            UpdateList("Skill");
        }

        private void dodajToolStripMenuItemTalent_Click(object sender, EventArgs e)
        {
            var window = new Edit("AddInfoZdolności", false, false);
            window.End += Window_EndTalent;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            hold = new ListViewItem();
            window.AddPanel();
            window.Show();
        }

        private void edytujToolStripMenuItemTalent_Click(object sender, EventArgs e)
        {
            hold = (ListViewItem)listViewTalents.SelectedItems[0].Clone();
            var window = new Edit("AddInfoZdolności", true, false);
            window.End += Window_EndTalent;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            window.AddPanel();
            window.Show();
        }

        private void usuńToolStripMenuItemTalent_Click(object sender, EventArgs e)
        {
            listViewTalents.Items.RemoveAt(listViewTalents.SelectedIndices[0]);
            UpdateList("Talent");
        }

        private void listViewStat_ItemActivate(object sender, EventArgs e)
        {
            hold = listViewStat.SelectedItems[0];
            var window = new Edit("ValueCechy", true, true);
            window.End += Window_EndStat;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            window.AddPanel();
            window.Show();
        }

        private void listViewCareer_ItemActivate(object sender, EventArgs e)
        {
            hold = listViewCareer.SelectedItems[0];
            var window = new Edit("ComboProfesje", true, true);
            window.End += Window_EndCareer;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            window.AddPanel();
            window.Show();
        }

        private void listViewSkills_ItemActivate(object sender, EventArgs e)
        {
            hold = listViewSkills.SelectedItems[0];
            var window = new Edit("AddInfoUmiejętności", true, true);
            window.End += Window_EndSkill;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            window.AddPanel();
            window.Show();
        }

        private void listViewTalents_ItemActivate(object sender, EventArgs e)
        {
            hold = listViewTalents.SelectedItems[0];
            var window = new Edit("AddInfoZdolności", true, true);
            window.End += Window_EndTalent;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            window.AddPanel();
            window.Show();
        }

        private void contextMenuStripStat_Opening(object sender, CancelEventArgs e)
        {
            if (listViewStat.SelectedIndices.Count < 1)
            {
                edytujToolStripMenuItemStat.Enabled = false;
                usuńToolStripMenuItemStat.Enabled = false;
            }
            else
            {
                edytujToolStripMenuItemStat.Enabled = true;
                usuńToolStripMenuItemStat.Enabled = true;
            }
        }

        private void contextMenuStripCareer_Opening(object sender, CancelEventArgs e)
        {
            if (listViewCareer.SelectedIndices.Count < 1)
            {
                edytujToolStripMenuItemCareer.Enabled = false;
                usuńToolStripMenuItemCareer.Enabled = false;
            }
            else
            {
                edytujToolStripMenuItemCareer.Enabled = true;
                usuńToolStripMenuItemCareer.Enabled = true;
            }
        }

        private void contextMenuStripSkill_Opening(object sender, CancelEventArgs e)
        {
            if (listViewSkills.SelectedIndices.Count < 1)
            {
                edytujToolStripMenuItemSkill.Enabled = false;
                usuńToolStripMenuItemSkill.Enabled = false;
            }
            else
            {
                edytujToolStripMenuItemSkill.Enabled = true;
                usuńToolStripMenuItemSkill.Enabled = true;
            }
        }

        private void contextMenuStripTalent_Opening(object sender, CancelEventArgs e)
        {
            if (listViewTalents.SelectedIndices.Count < 1)
            {
                edytujToolStripMenuItemTalent.Enabled = false;
                usuńToolStripMenuItemTalent.Enabled = false;
            }
            else
            {
                edytujToolStripMenuItemTalent.Enabled = true;
                usuńToolStripMenuItemTalent.Enabled = true;
            }
        }
    }
}
