using Microsoft.Data.SqlClient;
using System.Data;

namespace DoctorWho.Db
{
    public class SqlCommander
    {
        private string _connectionString;

        public SqlCommander(
            string connectionString = "Server = DESKTOP-EDE547A; Database = DoctorWhoCore; Trusted_Connection = True;Integrated Security=True;MultipleActiveResultSets=True"
            )
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Execute sql command in the database and return the result as Dataset
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <returns></returns>
        public DataSet ExecuteSqlCommand(string sqlCommand)
        {
            var dataSet = new DataSet();
            var adapter = new SqlDataAdapter();

            var command = new SqlCommand(sqlCommand, new SqlConnection(_connectionString));

            adapter.SelectCommand = command;
            adapter.Fill(dataSet);

            return dataSet;
        }
    }
}
