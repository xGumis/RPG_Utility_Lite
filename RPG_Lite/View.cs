using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Lite
{
    public partial class View : Form, IView
    {
        public event Action<string> CreateItem;
        public event Action<string, string> DeleteItem;
        public event Func<string, string[]> GetColumns;
        public event Action<string, string> GetItem;
        public event Func<string, List<string[]>> GetList;
        public event Func<string> GetRole;
        public event Func<string[]> GetTables;
        public event Func<string, object> ReadColumn;
        public event Func<string, Dictionary<string, string>[]> ReadItemList;
        public event Func<string, string,bool> RequestLogin;
        public event Action StartEdit;
        public event Action SubmitItem;
        public event Action SwitchMode;
        public event Action<string, string> UpdateItem;
        public event Action<string, Dictionary<string, string>[]> UpdateItemList;
        public View()
        {
            Size minSize = new Size();
            InitializeComponent();
            ChangeControl(new Views.Login(this.panelView.Size, ref minSize),minSize);
        }
        private void ChangeControl(Control c,Size minSize)
        {
            if(c is Views.Login)
            {
                var login = c as Views.Login;
                login.RequestLogin += Login_RequestLogin;
            }
            if(c is Views.List)
            {
                var list = c as Views.List;
                list.LoadColumns += GetColumns;
                list.LoadTables += GetTables;
                list.LoadList += GetList;
                list.Close += List_Close;
                list.Delete += DeleteItem;
                list.Save += SubmitItem;
                list.Create += CreateItem;
                list.LoadItem += GetItem;
                list.EditItem += StartEdit;
                list.ShowHide += SwitchMode;
                list.UpdateItem += UpdateItem;
                list.UpdateItemList += UpdateItemList;
                list.ReadColumn += ReadColumn;
                list.ReadItemList += ReadItemList;
            }
            this.panelView.Controls.Clear();
            this.panelView.Controls.Add(c);
            this.MinimumSize = minSize + new Size(10, 37);
            c.Dock = DockStyle.Fill;
        }
        private void List_Close(bool exit)
        {
            if (exit)
                this.Close();
            else
            {
                Size minSize = new Size();
                ChangeControl(new Views.Login(this.panelView.Size, ref minSize), minSize);
            }
        }

        private void Login_RequestLogin(string user, string pass)
        {
            Task<bool> task = Task<bool>.Factory.StartNew(() => RequestLogin(user, pass));
            if (task.Result)
            {
                var minSize = new Size();
                task.Wait();
                if (GetRole() == "admin")
                    ChangeControl(new Views.List(this.panelView.Size, ref minSize, true), minSize);
                else
                    ChangeControl(new Views.List(this.panelView.Size, ref minSize, false), minSize);
            }
        }
    }
}
