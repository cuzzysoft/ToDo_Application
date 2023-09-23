
using System.Data.SqlClient;

namespace ToDoApp.Services.Repository
{
    public class ConnectionClass
    {
        //Creating SQL Connection to the database
        public static SqlConnection sqlConnection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=ToDoAppDB;Trusted_Connection=True");
        
    }
}
