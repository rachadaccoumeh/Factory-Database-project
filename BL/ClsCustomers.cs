using System;
using System.Data;
using System.Data.SqlClient;
using Factory_Database.DAL;

namespace Factory_Database.BL {
	public class ClsCustomers {
		public void AddCustomers(string firstName, string lastName, string tel, string email, byte[] picture) {
			var dataAccessLayer = new DataAccessLayer();
			var param = new SqlParameter[5];
			param[0] = new SqlParameter("@First_Name", SqlDbType.VarChar, 25) {
				Value = firstName
			};

			param[1] = new SqlParameter("@Last_Name", SqlDbType.VarChar, 25) {
				Value = lastName
			};

			param[2] = new SqlParameter("@Tel", SqlDbType.NChar, 15) {
				Value = tel
			};

			param[3] = new SqlParameter("@Email", SqlDbType.VarChar, 25) {
				Value = email
			};

			param[4] = new SqlParameter("@IMAGE_CUSTOMER", SqlDbType.Image);
			if (picture != null) {
				param[4].Value = picture;
			} else {
				param[4].Value = DBNull.Value;
			}

			dataAccessLayer.ExecuteCommand("ADD_CUSTOMER", param);
		}

		public DataTable GetAllCustomers() {
			var dataAccessLayer = new DataAccessLayer();
			return dataAccessLayer.SelectData("GET_ALL_CUSTOMERS", null);
			
		}

		public void EditCustomer(string firstName, string lastName, string tel, string email, byte[] picture, int id) {
			var dataAccessLayer = new DataAccessLayer();
			var param = new SqlParameter[6];
			param[0] = new SqlParameter("@FirstName", SqlDbType.VarChar, 25) {
				Value = firstName
			};

			param[1] = new SqlParameter("@LastName", SqlDbType.VarChar, 25) {
				Value = lastName
			};

			param[2] = new SqlParameter("@Tel", SqlDbType.NChar, 15) {
				Value = tel
			};

			param[3] = new SqlParameter("@Email", SqlDbType.VarChar, 25) {
				Value = email
			};

			param[4] = new SqlParameter("@Image", SqlDbType.Image);
			if (picture != null) {
				param[4].Value = picture;
			} else {
				param[4].Value = DBNull.Value;
			}

			param[5] = new SqlParameter("@ID", SqlDbType.Int) {
				Value = id
			};

			dataAccessLayer.ExecuteCommand("EDIT_CUSTOMER", param);
		}

		public void DeleteCustomer(int id) {
			var dataAccessLayer = new DataAccessLayer();
			var param = new SqlParameter[1];

			param[0] = new SqlParameter("@ID", SqlDbType.Int) {
				Value = id
			};

			dataAccessLayer.ExecuteCommand("DELETE_CUSTOMER", param);
		}

		public DataTable SearchCustomer(string criterion) {
			var dataAccessLayer = new DataAccessLayer();
			var sqlParameters = new SqlParameter[1];
			sqlParameters[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50) {
				Value = criterion
			};
			return dataAccessLayer.SelectData("Search_Customer", sqlParameters);
		}
	}
}