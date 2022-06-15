using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Factory_Database.DAL;

namespace Factory_Database.BL {
	public class ClsProducts {
		public DataTable GetAllCategories() {
			var dataAccessLayer = new DataAccessLayer();
			return dataAccessLayer.SelectData("GET_ALL_CATEGORIES", null);
		}

		public void AddProduct(string labelProduct, string idProduct, int qteInStock, string price,
			byte[] imageProduct) {
			var dataAccessLayer = new DataAccessLayer();
			var sqlParameters = new SqlParameter[5];

			sqlParameters[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30) {
				Value = idProduct
			};
			sqlParameters[1] = new SqlParameter("@Label", SqlDbType.VarChar, 30) {
				Value = labelProduct
			};
			sqlParameters[2] = new SqlParameter("@quantity", SqlDbType.Int) {
				Value = qteInStock
			};
			sqlParameters[3] = new SqlParameter("@price", SqlDbType.VarChar, 50) {
				Value = price
			};
			sqlParameters[4] = new SqlParameter("@Image", SqlDbType.Image) {
				Value = imageProduct
			};
			dataAccessLayer.ExecuteCommand("ADD_PRODUCT", sqlParameters);
		}

		public DataTable VerifyProductId(string id) {
			var dataAccessLayer = new DataAccessLayer();
			var sqlParameters = new SqlParameter[1];
			sqlParameters[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50) {
				Value = id
			};
			return dataAccessLayer.SelectData("VerifyProductId", sqlParameters);
		}

		public DataTable GetAllProducts() {
			var dataAccessLayer = new DataAccessLayer();
			return dataAccessLayer.SelectData("GET_ALL_PRODUCTS", null);
		}

		public DataTable SearchProduct(string search) {
			var dataAccessLayer = new DataAccessLayer();
			var sqlParameters = new SqlParameter[1];
			sqlParameters[0] = new SqlParameter("@S", SqlDbType.VarChar, 50) {
				Value = search
			};
			return dataAccessLayer.SelectData("SEARCH_PRODUCT", sqlParameters);
		}

		public void DeleteProduct(string delete) {
			var dataAccessLayer = new DataAccessLayer();
			var sqlParameters = new SqlParameter[1];
			sqlParameters[0] = new SqlParameter("@D", SqlDbType.VarChar, 50) {
				Value = delete
			};

			dataAccessLayer.ExecuteCommand("DELETE_PRODUCT", sqlParameters);
		}

		public DataTable GetProductImage(string id) {
			var dataAccessLayer = new DataAccessLayer();
			var sqlParameters = new SqlParameter[1];
			sqlParameters[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50) {
				Value = id
			};
			return dataAccessLayer.SelectData("GEt_IMAGE_PRODUCT", sqlParameters);
		}

		public void UpdateProduct(string labelProduct, string idProduct, int qteInStock, string price,
			byte[] imageProduct) {
			var dataAccessLayer = new DataAccessLayer();
			var sqlParameters = new SqlParameter[5];

			sqlParameters[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30) {
				Value = idProduct
			};
			sqlParameters[1] = new SqlParameter("@Label", SqlDbType.VarChar, 30) {
				Value = labelProduct
			};
			sqlParameters[2] = new SqlParameter("@quantity", SqlDbType.Int) {
				Value = qteInStock
			};
			sqlParameters[3] = new SqlParameter("@price", SqlDbType.VarChar, 50) {
				Value = price
			};
			sqlParameters[4] = new SqlParameter("@Image", SqlDbType.Image) {
				Value = imageProduct
			};
			dataAccessLayer.ExecuteCommand("UPDATE_PRODUCT", sqlParameters);
		}
	}
}