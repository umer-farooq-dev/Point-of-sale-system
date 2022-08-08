using DGVPrinterHelper;
using MigraDoc.DocumentObjectModel.Shapes;
using ReturnMedicalSystem.Clasess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReturnMedicalSystem.Forms
{
    public partial class Bills : Form
    {
        public Bills()
        {
            InitializeComponent();
        }
        Selection s = new Selection();

        int productid;
        private void Bills_Load(object sender, EventArgs e)
        {

        }

        private void btn_BillView_Click(object sender, EventArgs e)
        {
            s.showproduct(DataGridView_Bills, DGv_Id, DGv_name, DGv_PIN, DGv_QTY, DGv_DS, DGv_Batch, DGv_POUT, DGv_Expire, DGv_Barcode, DGv_location);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Close();
        }

        private void DataGridView_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
                foreach (DataGridViewRow item in DataGridView_Bills.SelectedRows)
                {
                    int n = DataGridView_bill.Rows.Add();
                    DataGridViewRow row = DataGridView_Bills.Rows[e.RowIndex];
                    DataGridView_bill.Rows[n].Cells[0].Value=item.Cells[1].Value.ToString();
                    DataGridView_bill.Rows[n].Cells[1].Value=item.Cells[2].Value.ToString();
                    DataGridView_bill.Rows[n].Cells[2].Value=item.Cells[3].Value.ToString();
                    DataGridView_bill.Rows[n].Cells[3].Value=item.Cells[4].Value.ToString();
                   
                }
            PriceCount();




        }

        public void PriceCount()
        {
            double RowCalculate = 0;
            for (int a = 0; a<DataGridView_bill.Rows.Count; a++)
            {
                try
                {
                    RowCalculate = RowCalculate + double.Parse(DataGridView_bill.Rows[a].Cells[1].Value.ToString());
                }
                catch (Exception)
                {

                    throw;
                }
                txt_Tamount.Text = RowCalculate.ToString("0.00");
                txt_totalamount2.Text = RowCalculate.ToString("0.00");
          
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridView_bill.Rows.Clear();
            txt_BillDis.Clear();
            txt_Tamount.Clear();
            txt_TotalAmount.Clear();
            txt_totalamount2.Clear();
        }

        int orignalprice=0 ;
        double discount, discountgiven=0;

        public object BarcodeScanner { get; private set; }

        private void btn_proceedOrder_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Today.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount: " + txt_TotalAmount.Text;
            printer.FooterSpacing =-5;
            printer.PrintDataGridView(DataGridView_bill);
        }

        private void txt_BillDis_TextChanged_1(object sender, EventArgs e)
        {

            try
            {
                double originalPrice, discountPercentage, discountAmount, salePrice;

                // Get item's original price.
                originalPrice = double.Parse(txt_Tamount.Text);

                // Get discount percentage.
                discountPercentage = double.Parse(txt_BillDis.Text);

                // Create decimal representation of %  (move point left two places)
                discountPercentage = discountPercentage / 100;

                // Calculate amount of the discount.
                discountAmount = originalPrice * discountPercentage;

                // Calculate sale price.
                salePrice = originalPrice - discountAmount;

                // Display sale price as Currency ("c")
                txt_TotalAmount.Text = salePrice.ToString("0.00");
            }
            catch (Exception)
            {


            }
        }

        private void btn_Cancelorder_Click(object sender, EventArgs e)
        {
            DataGridView_bill.Rows.Clear();
            txt_BillDis.Clear();
            txt_Tamount.Clear();
            txt_TotalAmount.Clear();
            txt_totalamount2.Clear();
        }

        private void txt_searchBill_TextChanged(object sender, EventArgs e)
        {
            if (txt_searchBill.Text != "")
            {
                s.showproduct(DataGridView_Bills, DGv_Id, DGv_name, DGv_PIN, DGv_QTY, DGv_DS, DGv_Batch, DGv_POUT, DGv_Expire, DGv_Barcode, DGv_location, txt_searchBill.Text);
            }
            else
            {
                s.showproduct(DataGridView_Bills, DGv_Id, DGv_name, DGv_PIN, DGv_QTY, DGv_DS, DGv_Batch, DGv_POUT, DGv_Expire, DGv_Barcode, DGv_location);
            }
        }

        private void txt_barcodeScan_TextChanged(object sender, EventArgs e)
        {
            
        }
        //private String[] ReadBarcodeFromBitmap(Bitmap _bimapimage)
      //  {
           // System.Drawing.Bitmap objImage = _bimapimage;
           // String[] barcodes = BarcodeScanner.Scan(objImage,BarcodeType.Barcode39);
           // return barcodes;
      //  }

        private void txt_BillDis_TextChanged(object sender, EventArgs e)
        {
            try
            {
                orignalprice = int.Parse(txt_Tamount.Text);
                discount = double.Parse(txt_BillDis.Text);

                discountgiven = orignalprice * (discount / 100);
                txt_TotalAmount.Text = discountgiven.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
