using System.Data;
using System.Data.SqlClient;
using Factory_Database.DAL;

namespace Factory_Database.BL {
	public class ClsLogin {
		public DataTable Login(string id, string pwd) {
			var dataAccessLayer = new DataAccessLayer();
			var sqlParameters = new SqlParameter[2];
			sqlParameters[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50) {
				Value = id
			};
			sqlParameters[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50) {
				Value = pwd
			};
			return dataAccessLayer.SelectData("SP_LOGIN", sqlParameters);
		}

		public void AddUser(string id, string fullName, string pwd, string userType) {
			var dataAccessLayer = new DataAccessLayer();
			var sqlParameters = new SqlParameter[4];
			sqlParameters[0] = new SqlParameter("@USERNAME", SqlDbType.VarChar, 50) {
				Value = id
			};

			sqlParameters[1] = new SqlParameter("@FULL_NAME", SqlDbType.VarChar, 50) {
				Value = fullName
			};

			sqlParameters[2] = new SqlParameter("@PASSWORD", SqlDbType.VarChar, 50) {
				Value = pwd
			};

			sqlParameters[3] = new SqlParameter("@USERTYPE", SqlDbType.VarChar, 50) {
				Value = userType
			};

			dataAccessLayer.ExecuteCommand("ADD_USER", sqlParameters);
		}

		public void EditUser(string id, string fullName, string pwd, string userType) {
			var dataAccessLayer = new DataAccessLayer();
			var param = new SqlParameter[4];
			param[0] = new SqlParameter("@USERNAME", SqlDbType.VarChar, 50) {
				Value = id
			};

			param[1] = new SqlParameter("@FULL_NAME", SqlDbType.VarChar, 50) {
				Value = fullName
			};

			param[2] = new SqlParameter("@PASSWORD", SqlDbType.VarChar, 50) {
				Value = pwd
			};

			param[3] = new SqlParameter("@USERTYPE", SqlDbType.VarChar, 50) {
				Value = userType
			};

			dataAccessLayer.ExecuteCommand("EDIT_USER", param);
		}


		public void DeleteUser(string id) {
			var dataAccessLayer = new DataAccessLayer();
			var param = new SqlParameter[1];
			param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50) {
				Value = id
			};

			dataAccessLayer.ExecuteCommand("DELETE_USER", param);
		}

		public DataTable SearchUsers(string criterion) {
			var dataAccessLayer = new DataAccessLayer();
			var param = new SqlParameter[1];
			param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50) {
				Value = criterion
			};

			return dataAccessLayer.SelectData("SEARCH_USER", param);
		}
	}
}