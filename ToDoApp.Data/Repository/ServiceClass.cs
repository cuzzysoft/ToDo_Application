
using System.Data;
using System.Data.SqlClient;
using ToDoApp.Model;

namespace ToDoApp.Services.Repository
{
    public class ServiceClass : ConnectionClass
    {
        //Add data to database
        public static void AddData(ToDoItemModel itemModel)
        {
            string sql = "usp_todoapp '','" + itemModel.Title + "','" + itemModel.Date + "','" + itemModel.Completed + "','" + itemModel.Description + "','ADD'";
            ExecuteQuery(sql);
        }

        public static void UpdateData(ToDoItemModel itemModel)
        {
            //Update data to database
            string sql = "usp_todoapp '" + itemModel.Id + "','" + itemModel.Title + "','" + itemModel.Date + "','" + itemModel.Completed + "','" + itemModel.Description + "','UPDATE'";
            ExecuteQuery(sql);
        }

        public static void DeleteData(List<string> checkedIDs)
        {
            //Delete all ids passed
            foreach (string id in checkedIDs)
            {
                string sql = "usp_todoapp '" + id + "','','','','','DELETE'";
                ExecuteQuery(sql);
            }

        }
        public static DataSet GetAllRecords()
        {
            string sql = "usp_todoapp '','','','','','VIEW'";
            return ExecuteQuery(sql);
        }

        public static DataSet Search(string search, string search_criteria)
        {
            string sql = "usp_todoapp '','','','','" + search + "','" + search_criteria + "'";
            return ExecuteQuery(sql);
        }

        public static DataSet ExecuteQuery(string sql)
        {   //Performing SQL commands and returning dataset
            DataSet dset = new DataSet();
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dset);
            return dset;

        }
    }
}
