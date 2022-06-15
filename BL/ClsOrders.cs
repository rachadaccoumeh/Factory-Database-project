using System;
using System.Data;
using System.Data.SqlClient;
using Factory_Database.DAL;

namespace Factory_Database.BL {
	public class ClsOrders {
		public DataTable GetLastOrderId() {
			var dataAccessLayer = new DataAccessLayer();
			var dataTable = dataAccessLayer.SelectData("GET_LAST_ORDER_ID", null);
			return dataTable;
		}

		public void AddOrder(int idOrder, DateTime dateOrder, int customerId, string descriptionOrder,
			string salesman) {
			var dataAccessLayer = new DataAccessLayer();
			var param = new SqlParameter[5];
			param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int) {
				Value = idOrder
			};

			param[1] = new SqlParameter("@DATE_ORDER", SqlDbType.DateTime) {
				Value = dateOrder
			};

			param[2] = new SqlParameter("@CUSTOMER_ID", SqlDbType.Int) {
				Value = customerId
			};

			param[3] = new SqlParameter("@DESCRIPTION_ORDER", SqlDbType.VarChar, 250) {
				Value = descriptionOrder
			};

			param[4] = new SqlParameter("@SALES_MAN", SqlDbType.VarChar, 50) {
				Value = salesman
			};
			dataAccessLayer.ExecuteCommand("ADD_ORDER", param);
		}

		public void AddOrderDetails(string idProduct, int idOrder, int qte, string price, double discount,
			string amount, string totalAmount) {
			var dataAccessLayer = new DataAccessLayer();
			var param = new SqlParameter[7];
			param[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30) {
				Value = idProduct
			};

			param[1] = new SqlParameter("@ID_ORDER", SqlDbType.Int) {
				Value = idOrder
			};

			param[2] = new SqlParameter("@QTE", SqlDbType.Int) {
				Value = qte
			};

			param[3] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50) {
				Value = price
			};

			param[4] = new SqlParameter("@DISCOUNT", SqlDbType.Float) {
				Value = discount
			};

			param[5] = new SqlParameter("@AMOUNT", SqlDbType.VarChar, 50) {
				Value = amount
			};

			param[6] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.VarChar, 50) {
				Value = totalAmount
			};
			dataAccessLayer.ExecuteCommand("ADD_ORDER_DETAILS", param);
		}

		public DataTable VerifyQty(string idProduct, int qtyEntered) {
			var dataAccessLayer = new DataAccessLayer();
			var param = new SqlParameter[2];

			param[0] = new SqlParameter("@PRODUCT_ID", SqlDbType.VarChar, 30) {
				Value = idProduct
			};

			param[1] = new SqlParameter("@QTE", SqlDbType.Int) {
				Value = qtyEntered
			};

			return dataAccessLayer.SelectData("VERIFY_QTY", param);
		}

		public DataTable GetOrderDetails(int idOrder) {
			var dataAccessLayer = new DataAccessLayer();
			var param = new SqlParameter[1];

			param[0] = new SqlParameter("@ORDER_ID", SqlDbType.Int) {
				Value = idOrder
			};

			return dataAccessLayer.SelectData("GET_ORDER_DETAIL", param);
		}

		public DataTable GetLastOrderForPrint() {
			var dataAccessLayer = new DataAccessLayer();
			return dataAccessLayer.SelectData("GET_LAST_ORDER_FOR_PRINT", null);
		}

		public DataTable SearchOrders(string criterion) {
			var dataAccessLayer = new DataAccessLayer();
			var param = new SqlParameter[1];
			param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50) {
				Value = criterion
			};
			return dataAccessLayer.SelectData("SEARCH_ORDER", param);
		}
	}
}