using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite
{
    interface IView
    {
        event Func<string,List<string[]>> GetList;
        event Func<string, string[]> GetColumns;
        event Action StartEdit;
        event Func<string[]> GetTables;
        event Action<string, Dictionary<string,string>[]> UpdateItemList;
        event Action<string, string> DeleteItem;
        event Action<string, string> GetItem;
        event Action<string, string> UpdateItem;
        event Action<string> CreateItem;
        event Action SubmitItem;
        event Action<string, string> RequestLogin;
        event Func<string> GetRole;
        event Action SwitchMode;
        event Func<string, object> ReadColumn;
        event Func<string, Dictionary<string, object>[]> ReadItemList;
    }
}
