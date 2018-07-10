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
    public partial class Character : UserControl
    {
        public event Action<string, string> UpdateItem;
        public event Action<string, Dictionary<string, string>[]> UpdateItemList;
        public event Func<string, Dictionary<string, string>[]> ReadItemList;
        public event Func<string, object> ReadColumn;
        public event Func<string, List<string[]>> GetList;
        private ListViewItem hold;
        public Character()
        {
            InitializeComponent();
        }
        #region NoLists
        public void ReadItem()
        {
            var name = ReadColumn(Columns.Name);
            var god = ReadColumn(Columns.Char_God);
            var race = ReadColumn(Columns.Con_Race);
            var car = ReadColumn(Columns.Con_Career);
            var gen = ReadColumn(Columns.Char_Gender);
            var eye = ReadColumn(Columns.Char_EyeColor);
            var hair = ReadColumn(Columns.Char_HairColor);
            var sign = ReadColumn(Columns.Char_StarSign);
            var birth = ReadColumn(Columns.Char_BirthPlace);
            var age = ReadColumn(Columns.Char_Age);
            var wei = ReadColumn(Columns.Char_Weight);
            var hei = ReadColumn(Columns.Char_Height);
            var add = ReadColumn(Columns.Add_Info);
            var feat = ReadColumn(Columns.Char_Features);
            var fam = ReadColumn(Columns.Char_Family);
            var men = ReadColumn(Columns.Char_MentalCondition);
            var scar = ReadColumn(Columns.Char_Scars);
            var xp = ReadColumn(Columns.Char_EXP);
            var stats = ReadItemList(Columns.Con_stat);
            var tal = ReadItemList(Columns.Con_Talent);
            var skil = ReadItemList(Columns.Con_Skill);
            var items = ReadItemList(Columns.Con_Item);
            var weap = ReadItemList(Columns.Con_Weapon);
            var arm = ReadItemList(Columns.Con_Armor);
            var spe = ReadItemList(Columns.Con_Spell);
            foreach (var i in stats)
            {
                string n, s,v,c;
                i.TryGetValue(Columns.Name, out n);
                i.TryGetValue(Columns.Con_AdvStat, out v);
                i.TryGetValue(Columns.Con_CurrStat, out c);
                i.TryGetValue(Columns.Con_StartStat, out s);
                var tmp = new string[] { n.ToString(),s.ToString(), v.ToString(),c.ToString() };
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
                string n, a,lv;
                i.TryGetValue(Columns.Name, out n);
                i.TryGetValue(Columns.Add_Info, out a);
                i.TryGetValue(Columns.Level, out lv);
                var tmp = new string[] { n.ToString(),lv.ToString(), a.ToString() };
                var l = new ListViewItem(tmp);
                listViewSkills.Items.Add(l);
            }
            foreach (var i in arm)
            {
                string n, q, qn, a;
                i.TryGetValue(Columns.Name, out n);
                i.TryGetValue(Columns.Quality, out q);
                i.TryGetValue(Columns.Quantity, out qn);
                i.TryGetValue(Columns.Con_Equipped, out a);
                var tmp = new string[] { n.ToString(), q.ToString(), qn.ToString() };
                var l = new ListViewItem(tmp);
                l.Tag = a.ToString();
                listViewArmor.Items.Add(l);
            }
            foreach (var i in weap)
            {
                string n, q, qn, a;
                i.TryGetValue(Columns.Name, out n);
                i.TryGetValue(Columns.Quality, out q);
                i.TryGetValue(Columns.Quantity, out qn);
                i.TryGetValue(Columns.Con_Equipped, out a);
                var tmp = new string[] { n.ToString(), q.ToString(), qn.ToString() };
                var l = new ListViewItem(tmp);
                l.Tag = a.ToString();
                listViewWeapon.Items.Add(l);
            }
            foreach (var i in items)
            {
                string n,q,qn,a,id;
                i.TryGetValue(Columns.Name, out n);
                i.TryGetValue(Columns.Id, out id);
                i.TryGetValue(Columns.Quality, out q);
                i.TryGetValue(Columns.Quantity, out qn);
                i.TryGetValue(Columns.Add_Info, out a);
                var tmp = new string[] { n.ToString(), q.ToString(), qn.ToString(), a.ToString() };
                var l = new ListViewItem(tmp);
                l.Tag = id.ToString();
                listViewItem.Items.Add(l);
            }
            foreach (var i in spe)
            {
                string n;
                i.TryGetValue(Columns.Name, out n);
                var tmp = new string[] { n.ToString() };
                var l = new ListViewItem(tmp);
                listViewWeapon.Items.Add(l);
            }
            textBoxName.Text = name as string;
            textBoxBirth.Text = birth as string;
            textBoxEye.Text = eye as string;
            textBoxFamily.Text = fam as string;
            textBoxFeatures.Text = feat as string;
            textBoxMental.Text = men as string;
            textBoxScars.Text = scar as string;
            textBoxSign.Text = sign as string;
            textBoxAddInfo.Text = add as string;
            textBoxHair.Text = hair as string;
            comboBoxCareer.Text = car as string;
            comboBoxGender.Text = gen as string;
            comboBoxGod.Text = god as string;
            comboBoxRace.Text = race as string;
            numericUpDownAge.Value = decimal.Parse(age.ToString());
            numericUpDownHeight.Value = decimal.Parse(hei.ToString());
            numericUpDownWeight.Value = decimal.Parse(wei.ToString());
            numericUpDownXP.Value = decimal.Parse(xp.ToString());
        }
        public void OnlyRead()
        {
            textBoxEye.ReadOnly = true;
            textBoxHair.ReadOnly = true;
            textBoxName.ReadOnly = true;
            textBoxSign.ReadOnly = true;
            textBoxAddInfo.ReadOnly = true;
            textBoxFamily.ReadOnly = true;
            textBoxBirth.ReadOnly = true;
            textBoxFeatures.ReadOnly = true;
            textBoxMental.ReadOnly = true;
            textBoxScars.ReadOnly = true;
            comboBoxCareer.Enabled = false;
            comboBoxGender.Enabled = false;
            comboBoxGod.Enabled = false;
            comboBoxRace.Enabled = false;
            numericUpDownAge.Enabled = false;
            numericUpDownHeight.Enabled = false;
            numericUpDownWeight.Enabled = false;
            numericUpDownXP.Enabled = false;
            listViewArmor.ContextMenuStrip.Enabled = false;
            listViewWeapon.ContextMenuStrip.Enabled = false;
            listViewItem.ContextMenuStrip.Enabled = false;
            listViewSkills.ContextMenuStrip.Enabled = false;
            listViewSpells.ContextMenuStrip.Enabled = false;
            listViewStat.ContextMenuStrip.Enabled = false;
            listViewTalents.ContextMenuStrip.Enabled = false;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Name, textBoxName.Text);
        }

        private void textBoxEye_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Char_EyeColor, textBoxEye.Text);
        }

        private void textBoxHair_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Char_HairColor, textBoxHair.Text);
        }

        private void textBoxSign_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Char_StarSign, textBoxSign.Text);
        }

        private void textBoxBirth_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Char_BirthPlace, textBoxBirth.Text);
        }

        private void textBoxAddInfo_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Char_AddInfo, textBoxAddInfo.Text);
        }

        private void textBoxFeatures_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Char_Features, textBoxFeatures.Text);
        }

        private void textBoxFamily_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Char_Family, textBoxFamily.Text);
        }

        private void textBoxMental_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Char_MentalCondition, textBoxMental.Text);
        }

        private void textBoxScars_TextChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Char_Scars, textBoxScars.Text);
        }

        private void comboBoxGod_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Char_God, comboBoxGod.Text);
        }

        private void comboBoxRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Con_Race, comboBoxRace.Text);
        }

        private void comboBoxCareer_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Con_Career, comboBoxCareer.Text);
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Char_Gender, comboBoxGender.Text);
        }

        private void numericUpDownXP_ValueChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Char_EXP, numericUpDownXP.Value.ToString());
        }

        private void numericUpDownAge_ValueChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Char_Age, numericUpDownAge.Value.ToString());
        }

        private void numericUpDownWeight_ValueChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Char_Weight, numericUpDownWeight.Value.ToString());
        }

        private void numericUpDownHeight_ValueChanged(object sender, EventArgs e)
        {
            UpdateItem(Columns.Char_Height, numericUpDownHeight.Value.ToString());
        }

        private void comboBoxRace_DropDown(object sender, EventArgs e)
        {
            comboBoxRace.Items.Clear();
            var list = GetList("Rasy");
            foreach (var i in list)
            {
                comboBoxRace.Items.Add(i[0]);
            }
        }

        private void comboBoxGod_DropDown(object sender, EventArgs e)
        {
            comboBoxGod.Items.Clear();
            var list = GetList("Bogowie");
            foreach (var i in list)
            {
                comboBoxGod.Items.Add(i[0]);
            }
        }

        private void comboBoxCareer_DropDown(object sender, EventArgs e)
        {
            comboBoxCareer.Items.Clear();
            var list = GetList("Profesje");
            foreach (var i in list)
            {
                comboBoxCareer.Items.Add(i[0]);
            }
        }
        #endregion
        #region Lists
        private void UpdateList(string list)
        {
            ListView.ListViewItemCollection coll;
            if (list == "Stat")
                coll = listViewStat.Items;
            else if (list == "Spell")
                coll = listViewSpells.Items;
            else if (list == "Skill")
                coll = listViewSkills.Items;
            else if (list == "Talent")
                coll = listViewTalents.Items;
            else if (list == "Weapon")
                coll = listViewWeapon.Items;
            else if (list == "Armor")
                coll = listViewArmor.Items;
            else
                coll = listViewItem.Items;
            var lis = new List<Dictionary<string, string>>();
            foreach (ListViewItem item in coll)
            {
                var dic = new Dictionary<string, string>();
                if (list == "Talent")
                {
                    dic.Add(Columns.Name, item.Text);
                    if (item.SubItems.Count > 1)
                        dic.Add(Columns.Add_Info, item.SubItems[1].Text);
                }
                else if (list == "Weapon" || list == "Armor")
                {
                    dic.Add(Columns.Name, item.Text);
                    if (item.SubItems.Count > 1)
                        dic.Add(Columns.Quality, item.SubItems[1].Text);
                    if (item.SubItems.Count > 2)
                        dic.Add(Columns.Quantity, item.SubItems[2].Text);
                }
                else if (list == "Stat")
                {
                    dic.Add(Columns.Name, item.Text);
                    if (item.SubItems.Count > 1)
                        dic.Add(Columns.Con_AdvStat, item.SubItems[1].Text);
                }
                else if (list == "Item")
                {
                    dic.Add(Columns.Name, item.Text);
                    dic.Add(Columns.Id, item.Tag.ToString());
                    if (item.SubItems.Count > 1)
                        dic.Add(Columns.Quality, item.SubItems[1].Text);
                    if (item.SubItems.Count > 2)
                        dic.Add(Columns.Quantity, item.SubItems[2].Text);
                    if (item.SubItems.Count > 3)
                        dic.Add(Columns.Add_Info, item.SubItems[3].Text);

                }
                else if(list == "Spell")
                    dic.Add(Columns.Name, item.Text);
                else
                {

                    dic.Add(Columns.Name, item.Text);
                    if (item.SubItems.Count > 1)
                        dic.Add(Columns.Level, item.SubItems[1].Text);
                    if (item.SubItems.Count > 2)
                        dic.Add(Columns.Add_Info, item.SubItems[2].Text);
                }
                lis.Add(dic);
            }
            if (list == "Stat")
                UpdateItemList(Columns.Con_stat, lis.ToArray());
            else if (list == "Spell")
                UpdateItemList(Columns.Con_Spell, lis.ToArray());
            else if (list == "Skill")
                UpdateItemList(Columns.Con_Skill, lis.ToArray());
            else if (list == "Talent")
                UpdateItemList(Columns.Con_Talent, lis.ToArray());
            else if (list == "Weapon")
                UpdateItemList(Columns.Con_Weapon, lis.ToArray());
            else if (list == "Armor")
                UpdateItemList(Columns.Con_Armor, lis.ToArray());
            else
                UpdateItemList(Columns.Con_Item, lis.ToArray());
        }
        private object Window_ReadColumnIt(string col)
        {
            if (col == Columns.Name)
                return hold.Text;
            else if (col == Columns.Quality && hold.SubItems.Count > 1)
                return hold.SubItems[1].Text;
            else if (col == Columns.Quantity && hold.SubItems.Count > 2)
                return hold.SubItems[2].Text;
            else
                return hold.SubItems[3].Text;
        }
        private void Window_UpdateItemIt(string col, string val)
        {
            if (col == Columns.Id) hold.Tag = val;
            else if (col == Columns.Name)
                hold.Text = val;
            else if(col == Columns.Quality)
            {
                if (hold.SubItems.Count > 1)
                    hold.SubItems[1].Text = val.ToString();
                else
                    hold = new ListViewItem(new string[] { hold.Text, val.ToString() });
            }
            else if (col == Columns.Quantity)
            {
                if (hold.SubItems.Count > 2)
                    hold.SubItems[2].Text = val.ToString();
                else if (hold.SubItems.Count > 1)
                    hold = new ListViewItem(new string[] { hold.Text, hold.SubItems[1].Text, val.ToString() });
                else
                    hold = new ListViewItem(new string[] { hold.Text, "", val.ToString() });
            }
            else
            {
                if (hold.SubItems.Count > 3)
                    hold.SubItems[3].Text = val.ToString();
                else if (hold.SubItems.Count > 2)
                    hold = new ListViewItem(new string[] { hold.Text, hold.SubItems[1].Text, hold.SubItems[2].Text, val.ToString() });
                else if (hold.SubItems.Count > 1)
                    hold = new ListViewItem(new string[] { hold.Text, hold.SubItems[1].Text, "", val.ToString() });
                else
                    hold = new ListViewItem(new string[] { hold.Text, "","", val.ToString() });
            }
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
            if (col == Columns.Id) hold.Tag = val;
            else if (col == Columns.Name)
                hold.Text = val;
            else
            {
                    hold = new ListViewItem(new string[] { hold.Text, val.ToString() });
            }


        }
        private object Window_ReadColumnSkill(string col)
        {
            if (col == Columns.Name)
                return hold.Text;
            else if (col == Columns.Level && hold.SubItems.Count > 1)
                return hold.SubItems[1].Text;
            else return hold.SubItems[2].Text;
        }
        private void Window_UpdateItemSkill(string col, string val)
        {
            if (col == Columns.Id) hold.Tag = val;
            else if (col == Columns.Name)
                hold.Text = val;
            else if(col == Columns.Level)
            {
                if (hold.SubItems.Count > 2)
                    hold.SubItems[1].Text = val;
                else
                hold = new ListViewItem(new string[] { hold.Text, val.ToString() });
            }
            else
            {
                if (hold.SubItems.Count > 2)
                    hold.SubItems[2].Text = val;
                else if(hold.SubItems.Count > 1)
                   hold = new ListViewItem(new string[] { hold.Text, hold.SubItems[1].Text, val.ToString() });
                else 
                    hold = new ListViewItem(new string[] { hold.Text, "", val.ToString() });
            }
        }
        private object Window_ReadColumnStat(string col)
        {
            if (col == Columns.Name)
                return hold.Text;
            else if (col == Columns.Con_StartStat && hold.SubItems.Count > 1)
                return hold.SubItems[1].Text;
            else if (col == Columns.Con_AdvStat && hold.SubItems.Count > 2)
                return hold.SubItems[2].Text;
            else
                return hold.SubItems[3].Text;
        }
        private void Window_UpdateItemStat(string col, string val)
        {
            if (col == Columns.Id) hold.Tag = val;
            else if (col == Columns.Name)
                hold.Text = val;
            else if (col == Columns.Con_StartStat)
            {
                if (hold.SubItems.Count > 1)
                    hold.SubItems[1].Text = val.ToString();
                else
                    hold = new ListViewItem(new string[] { hold.Text, val.ToString() });
            }
            else if (col == Columns.Con_AdvStat)
            {
                if (hold.SubItems.Count > 2)
                    hold.SubItems[2].Text = val.ToString();
                else if (hold.SubItems.Count > 1)
                    hold = new ListViewItem(new string[] { hold.Text, hold.SubItems[1].Text, val.ToString() });
                else
                    hold = new ListViewItem(new string[] { hold.Text, "", val.ToString() });
            }
            else
            {
                if (hold.SubItems.Count > 3)
                    hold.SubItems[3].Text = val.ToString();
                else if (hold.SubItems.Count > 2)
                    hold = new ListViewItem(new string[] { hold.Text, hold.SubItems[1].Text, hold.SubItems[2].Text, val.ToString() });
                else if (hold.SubItems.Count > 1)
                    hold = new ListViewItem(new string[] { hold.Text, hold.SubItems[1].Text, "", val.ToString() });
                else
                    hold = new ListViewItem(new string[] { hold.Text, "", "", val.ToString() });
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
        private void Window_EndSpell(bool save, bool edit)
        {
            if (save)
            {
                if (edit) listViewSpells.Items.RemoveAt(listViewSpells.SelectedIndices[0]);
                listViewSpells.Items.Add(hold);
                UpdateList("Spell");
            }
        }
        private void Window_EndItem(bool save, bool edit)
        {
            if (save)
            {
                if (edit) listViewItem.Items.RemoveAt(listViewItem.SelectedIndices[0]);
                listViewItem.Items.Add(hold);
                UpdateList("Item");
            }
        }
        private void Window_EndWeapon(bool save, bool edit)
        {
            if (save)
            {
                if (edit) listViewWeapon.Items.RemoveAt(listViewWeapon.SelectedIndices[0]);
                listViewWeapon.Items.Add(hold);
                UpdateList("Weapon");
            }
        }
        private void Window_EndArmor(bool save, bool edit)
        {
            if (save)
            {
                if (edit) listViewArmor.Items.RemoveAt(listViewArmor.SelectedIndices[0]);
                listViewArmor.Items.Add(hold);
                UpdateList("Armor");
            }
        }
        #region Opening
        private void contextMenuStripWeapon_Opening(object sender, CancelEventArgs e)
        {
            if (listViewWeapon.SelectedIndices.Count < 1)
            {
                edytujToolStripMenuItemWeapon.Enabled = false;
                usuńToolStripMenuItemWeapon.Enabled = false;
            }
            else
            {
                edytujToolStripMenuItemWeapon.Enabled = true;
                usuńToolStripMenuItemWeapon.Enabled = true;
            }
        }

        private void contextMenuStripArmor_Opening(object sender, CancelEventArgs e)
        {
            if (listViewArmor.SelectedIndices.Count < 1)
            {
                edytujToolStripMenuItemArmor.Enabled = false;
                usuńToolStripMenuItemArmor.Enabled = false;
            }
            else
            {
                edytujToolStripMenuItemArmor.Enabled = true;
                usuńToolStripMenuItemArmor.Enabled = true;
            }
        }

        private void contextMenuStripItem_Opening(object sender, CancelEventArgs e)
        {
            if (listViewItem.SelectedIndices.Count < 1)
            {
                edytujToolStripMenuItemItem.Enabled = false;
                usuńToolStripMenuItemItem.Enabled = false;
            }
            else
            {
                edytujToolStripMenuItemItem.Enabled = true;
                usuńToolStripMenuItemItem.Enabled = true;
            }
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

        private void contextMenuStripSpell_Opening(object sender, CancelEventArgs e)
        {
            if (listViewSpells.SelectedIndices.Count < 1)
            {
                edytujToolStripMenuItemSpell.Enabled = false;
                usuńToolStripMenuItemSpell.Enabled = false;
            }
            else
            {
                edytujToolStripMenuItemSpell.Enabled = true;
                usuńToolStripMenuItemSpell.Enabled = true;
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
        #endregion
        #region Buttons
        #region Stat
        private void dodajToolStripMenuItemStat_Click(object sender, EventArgs e)
        {
            var window = new Edit("CharStatCechy", false, false);
            window.End += Window_EndStat;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumnStat;
            window.UpdateItem += Window_UpdateItemStat;
            window.AddPanel();
            hold = new ListViewItem();
            window.Show();
        }

        private void edytujToolStripMenuItemStat_Click(object sender, EventArgs e)
        {
            hold = (ListViewItem)listViewStat.SelectedItems[0].Clone();
            var window = new Edit("CharStatCechy", true, false);
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
        #endregion
        #region Spell
        private void dodajToolStripMenuItemSpell_Click(object sender, EventArgs e)
        {
            var window = new Edit("ComboZaklęcia", false, false);
            window.End += Window_EndSpell;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            window.AddPanel();
            hold = new ListViewItem();
            window.Show();
        }

        private void edytujToolStripMenuItemSpell_Click(object sender, EventArgs e)
        {
            hold = (ListViewItem)listViewSpells.SelectedItems[0].Clone();
            var window = new Edit("ComboZaklęcia", true, false);
            window.End += Window_EndSpell;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            window.AddPanel();
            window.Show();
        }

        private void usuńToolStripMenuItemSpell_Click(object sender, EventArgs e)
        {
            listViewSpells.Items.RemoveAt(listViewSpells.SelectedIndices[0]);
            UpdateList("Spell");
        }
        #endregion
        #region Skill
        private void dodajToolStripMenuItemSkill_Click(object sender, EventArgs e)
        {
            var window = new Edit("CharSkiUmiejętności", false, false);
            window.End += Window_EndSkill;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumnSkill;
            window.UpdateItem += Window_UpdateItemSkill;
            window.AddPanel();
            hold = new ListViewItem();
            window.Show();
        }

        private void edytujToolStripMenuItemSkill_Click(object sender, EventArgs e)
        {
            hold = (ListViewItem)listViewSkills.SelectedItems[0].Clone();
            var window = new Edit("CharSkiUmiejętności", true, false);
            window.End += Window_EndSkill;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumnSkill;
            window.UpdateItem += Window_UpdateItemSkill;
            window.AddPanel();
            window.Show();
        }

        private void usuńToolStripMenuItemSkill_Click(object sender, EventArgs e)
        {
            listViewSkills.Items.RemoveAt(listViewSkills.SelectedIndices[0]);
            UpdateList("Skill");
        }
        #endregion
        #region Talent
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
        #endregion
        #region Weapon
        private void dodajToolStripMenuItemWeapon_Click(object sender, EventArgs e)
        {
            var window = new Edit("ItemsBronie", false, false);
            window.End += Window_EndWeapon;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumnIt;
            window.UpdateItem += Window_UpdateItemIt;
            hold = new ListViewItem();
            window.AddPanel();
            window.Show();
        }

        private void edytujToolStripMenuItemWeapon_Click(object sender, EventArgs e)
        {
            hold = (ListViewItem)listViewWeapon.SelectedItems[0].Clone();
            var window = new Edit("ItemsBronie", true, false);
            window.End += Window_EndWeapon;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            window.AddPanel();
            window.Show();
        }

        private void usuńToolStripMenuItemWeapon_Click(object sender, EventArgs e)
        {
            listViewWeapon.Items.RemoveAt(listViewWeapon.SelectedIndices[0]);
            UpdateList("Weapon");
        }
        #endregion
        #region Armor
        private void dodajToolStripMenuItemArmor_Click(object sender, EventArgs e)
        {
            var window = new Edit("ItemsPancerze", false, false);
            window.End += Window_EndArmor;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumnIt;
            window.UpdateItem += Window_UpdateItemIt;
            hold = new ListViewItem();
            window.AddPanel();
            window.Show();
        }

        private void edytujToolStripMenuItemArmor_Click(object sender, EventArgs e)
        {
            hold = (ListViewItem)listViewArmor.SelectedItems[0].Clone();
            var window = new Edit("ItemsPancerze", true, false);
            window.End += Window_EndArmor;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            window.AddPanel();
            window.Show();
        }

        private void usuńToolStripMenuItemArmor_Click(object sender, EventArgs e)
        {
            listViewArmor.Items.RemoveAt(listViewArmor.SelectedIndices[0]);
            UpdateList("Armor");
        }
        #endregion
        #region Item
        private void dodajToolStripMenuItemItem_Click(object sender, EventArgs e)
        {
            var window = new Edit("ItemsPrzedmioty", false, false);
            window.End += Window_EndItem;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumnIt;
            window.UpdateItem += Window_UpdateItemIt;
            hold = new ListViewItem();
            window.AddPanel();
            window.Show();
        }

        private void edytujToolStripMenuItemItem_Click(object sender, EventArgs e)
        {
            hold = (ListViewItem)listViewItem.SelectedItems[0].Clone();
            var window = new Edit("ItemsPrzedmioty", true, false);
            window.End += Window_EndItem;
            window.GetList += GetList;
            window.ReadColumn += Window_ReadColumn;
            window.UpdateItem += Window_UpdateItem;
            window.AddPanel();
            window.Show();
        }

        private void usuńToolStripMenuItemItem_Click(object sender, EventArgs e)
        {
            listViewItem.Items.RemoveAt(listViewItem.SelectedIndices[0]);
            UpdateList("Item");
        }
        #endregion
        #endregion
        #endregion
    }
}
