using System;
using System.Data;
using System.Data.SqlClient;
using Factory_Database.DAL;

namespace Factory_Database.BL {
	public class ClsRawMaterial {
		public void AddRawMaterials(string text, int s) {
			var dataAccessLayer = new DataAccessLayer();
			var param = new SqlParameter[2];

			param[0] = new SqlParameter("@MAT_NAME", SqlDbType.VarChar, 25) {
				Value = text
			};

			param[1] = new SqlParameter("@qty", SqlDbType.Int) {
				Value = s
			};
			dataAccessLayer.ExecuteCommand("ADD_RawMaterial", param);
		}

		public DataTable GetAllRawMaterials() {
			var dataAccessLayer = new DataAccessLayer();
			return dataAccessLayer.SelectData("GET_ALL_RawMaterialS", null);
		}

		public void EditRawMaterial(string text, int s, int value) {
			var dataAccessLayer = new DataAccessLayer();
			var param = new SqlParameter[3];
			param[0] = new SqlParameter("@ID", SqlDbType.Int) {
				Value = value
			};

			param[1] = new SqlParameter("@MAT_NAME", SqlDbType.VarChar, 25) {
				Value = text
			};

			param[2] = new SqlParameter("@qty", SqlDbType.Int) {
				Value = s
			};

			dataAccessLayer.ExecuteCommand("EDIT_RawMaterial", param);
		}

		public void DeleteRawMaterial(int id) {
			var dataAccessLayer = new DataAccessLayer();
			var param = new SqlParameter[1];

			param[0] = new SqlParameter("@ID", SqlDbType.Int) {
				Value = id
			};

			dataAccessLayer.ExecuteCommand("DELETE_RawMaterial", param);
		}

		public DataTable SearchRawMaterial(string criterion) {
			var dataAccessLayer = new DataAccessLayer();
			var sqlParameters = new SqlParameter[1];
			sqlParameters[0] = new SqlParameter("@S", SqlDbType.VarChar, 50) {
				Value = criterion
			};
			return dataAccessLayer.SelectData("Search_RawMaterial", sqlParameters);
		}
		
	}
}