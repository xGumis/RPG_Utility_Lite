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
        public event Func<string, Dictionary<string, object>[]> ReadItemList;
        private bool end;
        private string table;
        private bool load;
        public Edit(string table, bool load)
        {
            InitializeComponent();
            this.table = table;
            this.load = load;
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
            }
            #endregion
            #region Pancerz
            else if (c is Types.Armor)
            {
                var armor = c as Types.Armor;
                armor.UpdateItem += UpdateItem;
                armor.ReadColumn += ReadColumn;
                if (load) armor.ReadItem();
            }
            #endregion
            #region Broń
            else if (c is Types.Weapon)
            {
                var weapon = c as Types.Weapon;
                weapon.UpdateItem += UpdateItem;
                weapon.ReadColumn += ReadColumn;
                if (load) weapon.ReadItem();
            }
            #endregion
            #region Przedmiot
            else if (c is Types.Item)
            {
                var item = c as Types.Item;
                item.UpdateItem += UpdateItem;
                item.ReadColumn += ReadColumn;
                if (load) item.ReadItem();
            }
            #endregion
            #region Zdolność
            else if (c is Types.Talent)
            {
                var talent = c as Types.Talent;
            }
            #endregion
            #region Profesja
            else if (c is Types.Career)
            {
                var career = c as Types.Career;
            }
            #endregion
            #region Postać
            else if (c is Types.Character)
            {
                var character = c as Types.Character;
            }
            #endregion
            #region Umiejętność
            else if (c is Types.Skill)
            {
                var skill = c as Types.Skill;
            }
            #endregion
            #region Zaklęcie
            else if (c is Types.Spell)
            {
                var spell = c as Types.Spell;
            }
            #endregion
            #region Bóg
            else if (c is Types.God)
            {
                var god = c as Types.God;
            }
            #endregion
            #region Rasa
            else if (c is Types.Race)
            {
                var race = c as Types.Race;
            }
            #endregion
            splitContainerEdit.Panel1.Controls.Add(c);
            c.Dock = DockStyle.Fill;
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
