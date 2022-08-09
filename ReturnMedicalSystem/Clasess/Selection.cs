using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReturnMedicalSystem.Clasess
{
    class Selection
    {
        public void showproduct(DataGridView gv,DataGridViewColumn DGv_Id, DataGridViewColumn DGv_name, DataGridViewColumn DGv_PIN, DataGridViewColumn DGv_QTY, DataGridViewColumn DGv_DS, DataGridViewColumn DGv_Batch,DataGridViewColumn DGv_POUT, DataGridViewColumn DGv_category,DataGridViewColumn DGv_Barcode, DataGridViewColumn DGv_location, string data=null )
        {
			//product select in all requierd Filed opration
			try
			{
				SqlCommand cmd;
				if (data == null) {  
					cmd = new SqlCommand("stp_selectProduct", DB.con);
				}
				else
				{
					cmd = new SqlCommand("stp_searchProduct", DB.con);
					cmd.Parameters.AddWithValue("@data", data);
				}
				
				cmd.CommandType = CommandType.StoredProcedure;
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				DGv_Id.DataPropertyName = dt.Columns["ID"].ToString();
				DGv_name.DataPropertyName = dt.Columns["ProductName"].ToString();
				DGv_PIN.DataPropertyName = dt.Columns["PriceIn"].ToString();
				DGv_QTY.DataPropertyName = dt.Columns["Quantity"].ToString();
				DGv_DS.DataPropertyName = dt.Columns["Discount"].ToString();
				DGv_Batch.DataPropertyName = dt.Columns["Batch"].ToString();
				DGv_POUT.DataPropertyName = dt.Columns["PriceOut"].ToString();
				DGv_category.DataPropertyName = dt.Columns["Category"].ToString();
				DGv_Barcode.DataPropertyName = dt.Columns["Barcode"].ToString();
				DGv_location.DataPropertyName = dt.Columns["Location"].ToString();
				gv.DataSource = dt;


			}
			catch (Exception)
			{

				throw;
			}
        }


		public void showSupplier(DataGridView gv, DataGridViewColumn DGv_Id, DataGridViewColumn DGv_name, DataGridViewColumn DGv_PH, DataGridViewColumn DGv_ADD, DataGridViewColumn DGv_RE, string data = null)
		{
			//product select in all requierd Filed opration
			try
			{
				SqlCommand cmd;
				if (data == null)
				{
					cmd = new SqlCommand("stp_selectSupplier", DB.con);
				}
				else
				{
					cmd = new SqlCommand("stp_searchProduct", DB.con);
					cmd.Parameters.AddWithValue("@data", data);
				}

				cmd.CommandType = CommandType.StoredProcedure;
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				DGv_Id.DataPropertyName = dt.Columns["ID"].ToString();
				DGv_name.DataPropertyName = dt.Columns["SupplierName"].ToString();
				DGv_PH.DataPropertyName = dt.Columns["Phone"].ToString();
				DGv_ADD.DataPropertyName = dt.Columns["Address"].ToString();
				DGv_RE.DataPropertyName = dt.Columns["Remarks"].ToString();
				gv.DataSource = dt;


			}
			catch (Exception)
			{

				throw;
			}
		}


		public void showCustomer(DataGridView gv, DataGridViewColumn DGv_Id, DataGridViewColumn DGv_name, DataGridViewColumn DGv_PH, DataGridViewColumn DGv_ADD, string data = null)
		{
			//product select in all requierd Filed opration
			try
			{
				SqlCommand cmd;
				if (data == null)
				{
					cmd = new SqlCommand("stp_selectcustomer", DB.con);
				}
				else
				{
					cmd = new SqlCommand("stp_searchProduct", DB.con);
					cmd.Parameters.AddWithValue("@data", data);
				}

				cmd.CommandType = CommandType.StoredProcedure;
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				DGv_Id.DataPropertyName = dt.Columns["ID"].ToString();
				DGv_name.DataPropertyName = dt.Columns["CustomerName"].ToString();
				DGv_PH.DataPropertyName = dt.Columns["Phone"].ToString();
				DGv_ADD.DataPropertyName = dt.Columns["Address"].ToString();
				gv.DataSource = dt;


			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
