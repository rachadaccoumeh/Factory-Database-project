using System.Data;
using System.Data.SqlClient;

namespace Factory_Database.DAL {
	public class DataAccessLayer {
		private readonly SqlConnection _sqlConnection;

		public DataAccessLayer() {
			_sqlConnection = new SqlConnection(@"Server=.\SQLEXPRESS; DATABASE=sales; INTEGRATED SECURITY =TRUE;");
			/*_sqlConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;
                          AttachDbFilename=C:\Users\Rachad\Documents\db\sales.mdf;
                          Integrated Security=True;
                          Connect Timeout=30;
                          User Instance=True");*/
		}

		private void Open() {
			if (_sqlConnection.State != ConnectionState.Open) {
				_sqlConnection.Open();
			}
		}

		private void Close() {
			if (_sqlConnection.State == ConnectionState.Open) {
				_sqlConnection.Close();
			}
		}

		public DataTable SelectData(string storedProcedure, SqlParameter[] sqlParameters) {
			var sqlCommand = new SqlCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = storedProcedure;
			sqlCommand.Connection = _sqlConnection;
			if (sqlParameters != null) {
				sqlCommand.Parameters.AddRange(sqlParameters);
			}

			var sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			var dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			Close();
			return dataTable;
		}

		public void ExecuteCommand(string storedProcedure, SqlParameter[] sqlParameters) {
			Open();
			var sqlCommand = new SqlCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = storedProcedure;
			sqlCommand.Connection = _sqlConnection;
			if (sqlParameters != null) {
				sqlCommand.Parameters.AddRange(sqlParameters);
			}

			sqlCommand.ExecuteNonQuery();
			Close();
		}
	}
}