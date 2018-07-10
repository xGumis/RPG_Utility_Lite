using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Lite.Views
{
    public partial class List : UserControl
    {
        public event Func<string[]> LoadTables;
        public event Func<string, string[]> LoadColumns;
        public event Func<string, List<string[]>> LoadList;
        public event Action<bool> Close;
        public event Action<string,string> Delete;
        public event Action Save;
        public event Action<string> Create;
        public event Action<string, string> LoadItem;
        public event Action EditItem;
        public event Action ShowHide;
        public event Action<string, string> UpdateItem;
        public event Action<string, Dictionary<string, string>[]> UpdateItemList;
        public event Func<string, object> ReadColumn;
        public event Func<string, Dictionary<string, string>[]> ReadItemList;
        private bool admin;
        private string table;
        private string key;
        public List(Size size, ref Size minimumSize, bool admin)
        {
            InitializeComponent();
            this.Size = size;
            minimumSize = this.MinimumSize;
            this.admin = admin;
        }
        private void Reload()
        {
            listView_Records.Items.Clear();
            var table = comboBoxTables.Text;
            var l = LoadList(table);
            foreach (var i in l)
            {
                var tmp = new ListViewItem(i.Skip(1).ToArray());
                tmp.Tag = i[0];
                listView_Records.Items.Add(tmp);
            }
        }
        private void comboBoxTables_DropDown(object sender, EventArgs e)
        {
            comboBoxTables.Items.Clear();
            comboBoxTables.Items.AddRange(LoadTables());
        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (admin&&comboBoxTables.Text=="Postaci")
                pokażukryjToolStripMenuItem.Visible = true;
            else pokażukryjToolStripMenuItem.Visible = false;
            listView_Records.Items.Clear();
            listView_Records.Columns.Clear();
            table = comboBoxTables.Text;
            var width = listView_Records.Width;
            var c = LoadColumns(table);
            var count = c.Length;
            foreach (var i in c)
                listView_Records.Columns.Add(i, width / count);
            var l = LoadList(table);
            foreach(var i in l)
            {
                var tmp = new ListViewItem(i.Skip(1).ToArray());
                tmp.Tag = i[0];
                listView_Records.Items.Add(tmp);
            }
            listView_Records.Enabled = true;
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(true);
        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(false);
        }

        private void listView_Records_ItemActivate(object sender, EventArgs e)
        {
            key = listView_Records.SelectedItems[0].Tag.ToString();
            LoadItem(table, key);
            AddEditWindow(true, true);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            dodajToolStripMenuItem.Enabled = false;
            edytujToolStripMenuItem.Enabled = false;
            usuńToolStripMenuItem.Enabled = false;
            if (admin || table == "Postaci")
            {
                dodajToolStripMenuItem.Enabled = true;
                if (listView_Records.SelectedIndices.Count >= 1)
                {
                    edytujToolStripMenuItem.Enabled = true;
                    usuńToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var key = listView_Records.SelectedItems[0].Tag.ToString();
            Delete(table,key);
            Reload();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create(table);
            AddEditWindow(false,false);
        }
        private void AddEditWindow(bool load,bool view)
        {
            var window = new Edit(table,load,view);
            window.End += Window_Close;
            window.UpdateItem += UpdateItem;
            window.UpdateItemList += UpdateItemList;
            window.ReadColumn += ReadColumn;
            window.ReadItemList += ReadItemList;
            window.GetList += LoadList;
            window.AddPanel();
            window.Show();
            this.Enabled = false;
        }
        private void Window_Close(bool save, bool edit)
        {
            if (save)
            {
                if (edit) Delete(table, key);
                Save();
                Reload();
            }
            this.Enabled = true;
        }

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            key = listView_Records.SelectedItems[0].Tag.ToString();
            LoadItem(table, key);
            EditItem();
            AddEditWindow(true,false);
        }

        private void pokażukryjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHide();
        }
    }
}
