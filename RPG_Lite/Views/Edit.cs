using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Lite.Views
{
    public partial class Edit : Form
    {
        public event Action<bool,bool> End;
        public event Action<string, string> UpdateItem;
        public event Action<string, Dictionary<string, string>[]> UpdateItemList;
        public event Func<string, object> ReadColumn;
        public event Func<string, Dictionary<string, string>[]> ReadItemList;
        public event Func<string, List<string[]>> GetList;
        private bool end;
        private string table;
        private bool load = false;
        private bool view = false;
        public Edit(string table, bool load, bool view)
        {
            InitializeComponent();
            this.table = table;
            this.load = load;
            this.view = view;
            if (view)
                splitContainerEdit.Panel2Collapsed = true;
        }
        public void AddPanel()
        {
            #region Bogowie
            if (table == "Bogowie")
            {
                IniControl(new Types.God());
            }
            #endregion
            #region Bronie
            else if (table == "Bronie")
            {
                IniControl(new Types.Weapon());
            }
            #endregion
            #region Cechy
            else if (table == "Cechy")
            {
                IniControl(new Types.Stat());
            }
            #endregion
            #region Pancerze
            else if (table == "Pancerze")
            {
                IniControl(new Types.Armor());
            }
            #endregion
            #region Profesje
            else if (table == "Profesje")
            {
                IniControl(new Types.Career());
            }
            #endregion
            #region Przedmioty
            else if (table == "Przedmioty")
            {
                IniControl(new Types.Item());
            }
            #endregion
            #region Rasy
            else if (table == "Rasy")
            {
                IniControl(new Types.Race());
            }
            #endregion
            #region Umiejętności
            else if (table == "Umiejętności")
            {
                IniControl(new Types.Skill());
            }
            #endregion
            #region Zaklęcia
            else if (table == "Zaklęcia")
            {
                IniControl(new Types.Spell());
            }
            #endregion
            #region Zdolności
            else if (table == "Zdolności")
            {
                IniControl(new Types.Talent());
            }
            #endregion
            #region Postaci
            else if (table == "Postaci")
            {
                IniControl(new Types.Character());
            }
            #endregion
            #region Supp
            else if (table.StartsWith("AddInfo"))
            {
                IniControl(new Supplementary.AddInfo(table.Substring(7)));
            }
            else if (table.StartsWith("Combo"))
            {
                IniControl(new Supplementary.Combo(table.Substring(5)));
            }
            else if (table.StartsWith("Value"))
            {
                IniControl(new Supplementary.Value(table.Substring(5)));
            }
            else if (table.StartsWith("CharSki"))
            {
                IniControl(new Supplementary.CharSki(table.Substring(7)));
            }
            else if (table.StartsWith("CharStat"))
            {
                IniControl(new Supplementary.CharStat(table.Substring(8)));
            }
            else if (table.StartsWith("Items"))
            {
                IniControl(new Supplementary.Items(table.Substring(5)));
            }
            #endregion
        }
        private void IniControl(Control c)
        {
            #region Cecha
            if(c is Types.Stat)
            {
                var stat = c as Types.Stat;
                stat.UpdateItem += UpdateItem;
                stat.ReadColumn += ReadColumn;
                if (load) stat.ReadItem();
                if (view) stat.OnlyRead();
            }
            #endregion
            #region Pancerz
            else if (c is Types.Armor)
            {
                var armor = c as Types.Armor;
                armor.UpdateItem += UpdateItem;
                armor.ReadColumn += ReadColumn;
                if (load) armor.ReadItem();
                if (view) armor.OnlyRead();
            }
            #endregion
            #region Broń
            else if (c is Types.Weapon)
            {
                var weapon = c as Types.Weapon;
                weapon.UpdateItem += UpdateItem;
                weapon.ReadColumn += ReadColumn;
                if (load) weapon.ReadItem();
                if (view) weapon.OnlyRead();
            }
            #endregion
            #region Przedmiot
            else if (c is Types.Item)
            {
                var item = c as Types.Item;
                item.UpdateItem += UpdateItem;
                item.ReadColumn += ReadColumn;
                if (load) item.ReadItem();
                if (view) item.OnlyRead();
            }
            #endregion
            #region Zdolność
            else if (c is Types.Talent)
            {
                var talent = c as Types.Talent;
                talent.UpdateItem += UpdateItem;
                talent.ReadColumn += ReadColumn;
                talent.GetList += GetList;
                if (load) talent.ReadItem();
                if (view) talent.OnlyRead();
            }
            #endregion
            #region Profesja
            else if (c is Types.Career)
            {
                var career = c as Types.Career;
                career.UpdateItem += UpdateItem;
                career.UpdateItemList += UpdateItemList;
                career.ReadColumn += ReadColumn;
                career.ReadItemList += ReadItemList;
                career.GetList += GetList;
                if (load) career.ReadItem();
                if (view) career.OnlyRead();
            }
            #endregion
            #region Postać
            else if (c is Types.Character)
            {
                var character = c as Types.Character;
                character.UpdateItem += UpdateItem;
                character.UpdateItemList += UpdateItemList;
                character.ReadColumn += ReadColumn;
                character.ReadItemList += ReadItemList;
                character.GetList += GetList;
                if (load) character.ReadItem();
                if (view) character.OnlyRead();
            }
            #endregion
            #region Umiejętność
            else if (c is Types.Skill)
            {
                var skill = c as Types.Skill;
                skill.ReadColumn += ReadColumn;
                skill.UpdateItem += UpdateItem;
                skill.GetList += GetList;
                if (load) skill.ReadItem();
                if (view) skill.OnlyRead();
            }
            #endregion
            #region Zaklęcie
            else if (c is Types.Spell)
            {
                var spell = c as Types.Spell;
                spell.ReadColumn += ReadColumn;
                spell.UpdateItem += UpdateItem;
                spell.GetList += GetList;
                if (load) spell.ReadItem();
                if (view) spell.OnlyRead();
            }
            #endregion
            #region Bóg
            else if (c is Types.God)
            {
                var god = c as Types.God;
                god.UpdateItem += UpdateItem;
                god.UpdateItemList += UpdateItemList;
                god.ReadColumn += ReadColumn;
                god.ReadItemList += ReadItemList;
                god.GetList += GetList;
                if (load) god.ReadItem();
                if (view) god.OnlyRead();
            }
            #endregion
            #region Rasa
            else if (c is Types.Race)
            {
                var race = c as Types.Race;
                race.UpdateItem += UpdateItem;
                race.UpdateItemList += UpdateItemList;
                race.ReadColumn += ReadColumn;
                race.ReadItemList += ReadItemList;
                race.GetList += GetList;
                if (load) race.ReadItem();
                if (view) race.OnlyRead();
            }
            #endregion
            #region Supp
            else if(c is Supplementary.AddInfo)
            {
                var sup = c as Supplementary.AddInfo;
                sup.UpdateItem += UpdateItem;
                sup.ReadColumn += ReadColumn;
                sup.GetList += GetList;
                if (load) sup.ReadItem();
                if (view) sup.OnlyRead();
            }
            else if(c is Supplementary.Value)
            {
                var sup = c as Supplementary.Value;
                sup.UpdateItem += UpdateItem;
                sup.ReadColumn += ReadColumn;
                sup.GetList += GetList;
                if (load) sup.ReadItem();
                if (view) sup.OnlyRead();
            }
            else if(c is Supplementary.Combo)
            {
                var sup = c as Supplementary.Combo;
                sup.UpdateItem += UpdateItem;
                sup.ReadColumn += ReadColumn;
                sup.GetList += GetList;
                if (load) sup.ReadItem();
                if (view) sup.OnlyRead();
            }
            else if (c is Supplementary.CharSki)
            {
                var sup = c as Supplementary.CharSki;
                sup.UpdateItem += UpdateItem;
                sup.ReadColumn += ReadColumn;
                sup.GetList += GetList;
                if (load) sup.ReadItem();
                if (view) sup.OnlyRead();
            }
            else if (c is Supplementary.CharStat)
            {
                var sup = c as Supplementary.CharStat;
                sup.UpdateItem += UpdateItem;
                sup.ReadColumn += ReadColumn;
                sup.GetList += GetList;
                if (load) sup.ReadItem();
                if (view) sup.OnlyRead();
            }
            else if (c is Supplementary.Items)
            {
                var sup = c as Supplementary.Items;
                sup.UpdateItem += UpdateItem;
                sup.ReadColumn += ReadColumn;
                sup.GetList += GetList;
                if (load) sup.ReadItem();
                if (view) sup.OnlyRead();
            }
            #endregion
            splitContainerEdit.Panel1.Controls.Add(c);
            c.Dock = DockStyle.Fill;
            this.MinimumSize = c.MinimumSize + new Size(20, 85);
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            end = true;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            end = false;
            this.Close();
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            End(end,load);
        }
    }
}
