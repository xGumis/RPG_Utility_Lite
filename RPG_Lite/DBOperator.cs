using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Lite
{
    class DBOperator
    {
        private List<Types.AType> holdList;
        public string[] GetTables()
        {
            return new string[] { "Bogowie", "Bronie", "Cechy", "Pancerze", "Postaci","Profesje","Przedmioty","Rasy","Umiejętności", "Zaklęcia", "Zdolności" };
        }
        public string[] GetColumnNames(string table)
        {
            switch (table)
            {
                default:
                    return null;
                case "Bogowie":
                    return new string[] { "Nazwa" };
                case "Bronie":
                    return new string[] { "Nazwa", "Kategoria", "Siła", "Zasięg","Cena" };
                case "Cechy":
                    return new string[] { "Nazwa" }; 
                case "Pancerze":
                    return new string[] { "Nazwa", "PZ" }; 
                case "Postaci":
                    return new string[] { "Nazwa", "Rasa", "Profesja","XP" }; 
                case"Profesje":
                    return new string[] { "Nazwa", "Rodzaj" }; 
                case"Przedmioty":
                    return new string[] { "Nazwa", "Cena" }; 
                case"Rasy":
                    return new string[] { "Nazwa" }; 
                case"Umiejętności":
                    return new string[] { "Nazwa", "Cecha", "Typ" }; 
                case "Zaklęcia":
                    return new string[] { "Nazwa", "Typ magii","Wymagany poziom" };
                case "Zdolności":
                    return new string[] { "Nazwa" };
            }
        }
        public List<string[]> GetRecordsList(string table)
        {
            var list = new List<string[]>();
            #region Bogowie
            if(table == "Bogowie")
            {

            }
            #endregion
            #region Bronie
            else if(table == "Bronie")
            {

            }
            #endregion
            #region Cechy
            else if(table == "Cechy")
            {
                holdList = Query.Records_Stats();
                foreach (Types.Stat stat in holdList)
                {
                    list.Add(new string[] { stat.Name });
                }
            }     
            #endregion
            #region Pancerze
            else if(table == "Pancerze")
            {

            }
            #endregion
            #region Postaci
            else if (table == "Postaci")
            {

            }
            #endregion
                #region Profesje
            else if(table == "Profesje")
            {

            }
            #endregion
            #region Przedmioty
            else if(table == "Przedmioty")
            {
                holdList = Query.Records_Items();
                foreach (Types.Item item in holdList)
                {
                    list.Add(new string[] { item.Name, item.Price });
                }
            }
            #endregion
            #region Rasy
            else if(table == "Rasy")
            {

            }
            #endregion
            #region Umiejętności
            else if(table == "Umiejętności")
            {
                holdList = Query.Records_Skills();
                foreach (Types.Skill skill in holdList)
                {
                     list.Add(new string[] { skill.Name,skill.Characteristic.Name,skill.Type });
                }
            }
            #endregion
            #region Zaklęcia
            else if(table == "Zaklęcia")
            {

            }
            #endregion
            #region Zdolności
            else if(table == "Zdolności")
            {

            }
            #endregion
            return list;
        }
    }
}
