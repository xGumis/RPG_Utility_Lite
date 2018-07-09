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
        public View()
        {
            InitializeComponent();
        }

        public event Action<string> CreateItem;
        public event Action<string, string> DeleteItem;
        public event Func<string, string[]> GetColumns;
        public event Action<string, string> GetItem;
        public event Func<string, List<string[]>> GetList;
        public event Func<string> GetRole;
        public event Func<string[]> GetTables;
        public event Func<string, object> ReadColumn;
        public event Func<string, Dictionary<string, object>[]> ReadItemList;
        public event Action<string, string> RequestLogin;
        public event Action StartEdit;
        public event Action SubmitItem;
        public event Action SwitchMode;
        public event Action<string, string> UpdateItem;
        public event Action<string, Dictionary<string, string>[]> UpdateItemList;
    }
}
