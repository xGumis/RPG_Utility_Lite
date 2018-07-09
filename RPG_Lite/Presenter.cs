using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite
{
    class Presenter
    {
        DBOperator model;
        IView view;
        public Presenter(DBOperator model, IView view)
        {
            this.model = model;
            this.view = view;
            view.SwitchMode += View_SwitchMode;
            view.GetRole += View_GetRole;
            view.RequestLogin += View_RequestLogin;
            view.GetColumns += View_GetColumns;
            view.GetTables += View_GetTables;
            view.GetList += View_GetList;
            view.DeleteItem += View_DeleteItem;
            view.CreateItem += View_CreateItem;
            view.GetItem += View_GetItem;
            view.UpdateItem += View_UpdateItem;
            view.UpdateItemList += View_UpdateItemList;
            view.SubmitItem += View_SubmitItem;
            view.StartEdit += View_StartEdit;
            view.ReadColumn += View_ReadColumn;
            view.ReadItemList += View_ReadItemList;
        }

        private Dictionary<string, object>[] View_ReadItemList(string column)
        {
            return model.ReadList(column);
        }

        private object View_ReadColumn(string column)
        {
            return model.ReadColumn(column);
        }

        private void View_StartEdit()
        {
            model.Edit();
        }

        private void View_SubmitItem()
        {
            model.InsertItem();
        }

        private void View_UpdateItemList(string col, Dictionary<string, string>[] val)
        {
            model.UpdateItemList(col,val);
        }

        private void View_UpdateItem(string col, string val)
        {
            model.UpdateItem(col,val);
        }

        private void View_GetItem(string table, string key)
        {
            model.GetItem(table,key);
        }

        private void View_CreateItem(string table)
        {
            model.CreateNewItem(table);
        }

        private void View_DeleteItem(string table, string key)
        {
            model.DeleteItem(table,key);
        }

        private List<string[]> View_GetList(string table)
        {
            return model.GetRecordsList(table);
        }

        private string[] View_GetTables()
        {
            return model.GetTables();
        }

        private string[] View_GetColumns(string table)
        {
            return model.GetColumnNames(table);
        }

        private void View_RequestLogin(string user, string pass)
        {
            model.Login(user,pass);
        }

        private string View_GetRole()
        {
            return model.Show_Role();
        }

        private void View_SwitchMode()
        {
            model.SwitchMode();
        }
    }
}
