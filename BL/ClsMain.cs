using System.Data;
using Factory_Database.DAL;

namespace Factory_Database.BL {
	public class ClsMain {
		public DataTable GetLpQty() {
			var dataAccessLayer = new DataAccessLayer();
			return dataAccessLayer.SelectData("GET_LP_QTY", null);
		}

		public DataTable GetLrmQty() {
			var dataAccessLayer = new DataAccessLayer();
			return dataAccessLayer.SelectData("GET_LRM_QTY", null);
		}
	}
}