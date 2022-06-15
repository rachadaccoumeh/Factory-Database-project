using System.Data;
using System.Data.SqlClient;
using Factory_Database.DAL;

namespace Factory_Database.BL {
	public class ClsRecipe {
		public DataTable GetRecipeDetails(string id) {
			var dataAccessLayer = new DataAccessLayer();
			var param = new SqlParameter[1];

			param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 30) {
				Value = id
			};

			return dataAccessLayer.SelectData("GET_RECIPE_DETAIL", param);
		}

		public void AddRecipe(string id, int id1, int qty) {
			var dataAccessLayer = new DataAccessLayer();
			var param = new SqlParameter[3];
			param[0] = new SqlParameter("@PID", SqlDbType.VarChar, 30) {
				Value = id
			};

			param[1] = new SqlParameter("@IDR", SqlDbType.Int) {
				Value = id1
			};

			param[2] = new SqlParameter("@QTY", SqlDbType.Int) {
				Value = qty
			};

			dataAccessLayer.ExecuteCommand("ADD_RECIPE", param);
		}

		public void deleteRecipe(string id) {
			var dataAccessLayer = new DataAccessLayer();
			var param = new SqlParameter[1];
			param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 30) {
				Value = id
			};
			dataAccessLayer.ExecuteCommand("DELETE_RECIPE", param);
		}
	}
}