

using System.Data;
using ToDoApp.Model;

namespace ToDoApp.Services.Interface
{
    public interface IServiceClass
    {
        public void AddData(ToDoItemModel itemModel);
        public void UpdateData(ToDoItemModel itemModel);
        public void DeleteData(List<string> checkedIDs);
        public DataSet GetAllRecords();
        public DataSet Search(string search, string search_criteria);
        public DataSet ExecuteQuery(string sql);

    }
}
