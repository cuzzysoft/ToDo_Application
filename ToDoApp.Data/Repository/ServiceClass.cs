
using System.Data;
using System.Data.SqlClient;
using ToDoApp.Model;
using ToDoApp.Services.Interface;

namespace ToDoApp.Services.Repository
{
    public class ServiceClass : IServiceClass
    {
        //Add data to database
        public void AddData(ToDoItemModel itemModel)
        {
            string sql = "usp_todoapp '','" + itemModel.Title + "','" + itemModel.Date + "','" + itemModel.Completed + "','" + itemModel.Description + "','ADD'";
            ExecuteQuery(sql);
        }

        public void UpdateData(ToDoItemModel itemModel)
        {
            //Update data to database
            string sql = "usp_todoapp '" + itemModel.Id + "','" + itemModel.Title + "','" + itemModel.Date + "','" + itemModel.Completed + "','" + itemModel.Description + "','UPDATE'";
            ExecuteQuery(sql);
        }

        public void DeleteData(List<string> checkedIDs)
        {
            //Delete all ids passed in arguments
            foreach (string id in checkedIDs)
            {
                string sql = "usp_todoapp '" + id + "','','','','','DELETE'";
                ExecuteQuery(sql);
            }

        }
        public DataSet GetAllRecords()
        {//Display all database records
            string sql = "usp_todoapp '','','','','','VIEW'";
            return ExecuteQuery(sql);
        }

        public DataSet Search(string search, string search_criteria)
        {
            //Search for a record
            string sql = "usp_todoapp '','','','','" + search + "','" + search_criteria + "'";
            return ExecuteQuery(sql);
        }

        public DataSet ExecuteQuery(string sql)
        {   
            //Performing SQL commands and returning dataset
            DataSet dset = new DataSet();
            SqlCommand cmd = new SqlCommand(sql, ConnectionClass.sqlConnection);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dset);
            return dset;

        }
    }
}
