
namespace ReturnMedicalSystem.Forms
{
    partial class Bills
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bills));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_searchBill = new Telerik.WinControls.UI.RadTextBox();
            this.DataGridView_Bills = new System.Windows.Forms.DataGridView();
            this.DGv_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_PIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_DS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_POUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_Expire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_BillView = new System.Windows.Forms.Button();
            this.DataGridView_bill = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.text_CustomerName = new System.Windows.Forms.TextBox();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_BillDis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_proceedOrder = new System.Windows.Forms.Button();
            this.btn_Cancelorder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_barcodeScan = new Telerik.WinControls.UI.RadTextBox();
            this.txt_Tamount = new System.Windows.Forms.TextBox();
            this.txt_TotalAmount = new System.Windows.Forms.TextBox();
            this.txt_totalamount2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_searchBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Bills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_barcodeScan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 39);
            this.panel1.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1125, -2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 28);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1472, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 28);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(314, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Premium v1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personalized Sailing Juncture";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(83, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Search Here";
            // 
            // txt_searchBill
            // 
            this.txt_searchBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_searchBill.BackColor = System.Drawing.Color.Silver;
            this.txt_searchBill.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchBill.Location = new System.Drawing.Point(87, 60);
            this.txt_searchBill.Name = "txt_searchBill";
            // 
            // 
            // 
            this.txt_searchBill.RootElement.BorderHighlightColor = System.Drawing.Color.Gray;
            this.txt_searchBill.RootElement.BorderHighlightThickness = 22;
            this.txt_searchBill.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 100, 20);
            this.txt_searchBill.RootElement.EnableFocusBorder = true;
            this.txt_searchBill.RootElement.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.txt_searchBill.RootElement.StretchVertically = true;
            this.txt_searchBill.Size = new System.Drawing.Size(704, 40);
            this.txt_searchBill.TabIndex = 9;
            this.txt_searchBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_searchBill.TextChanged += new System.EventHandler(this.txt_searchBill_TextChanged);
            // 
            // DataGridView_Bills
            // 
            this.DataGridView_Bills.AllowUserToAddRows = false;
            this.DataGridView_Bills.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DataGridView_Bills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Bills.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView_Bills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Bills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_Bills.ColumnHeadersHeight = 25;
            this.DataGridView_Bills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGv_Id,
            this.DGv_name,
            this.DGv_PIN,
            this.DGv_QTY,
            this.DGv_Batch,
            this.DGv_DS,
            this.DGv_POUT,
            this.DGv_Expire,
            this.DGv_Barcode,
            this.DGv_location});
            this.DataGridView_Bills.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Bills.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_Bills.Location = new System.Drawing.Point(3, 103);
            this.DataGridView_Bills.Name = "DataGridView_Bills";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Bills.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_Bills.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridView_Bills.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_Bills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Bills.Size = new System.Drawing.Size(791, 580);
            this.DataGridView_Bills.TabIndex = 12;
            this.DataGridView_Bills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Product_CellClick);
            // 
            // DGv_Id
            // 
            this.DGv_Id.HeaderText = "Id";
            this.DGv_Id.Name = "DGv_Id";
            this.DGv_Id.ReadOnly = true;
            this.DGv_Id.Visible = false;
            // 
            // DGv_name
            // 
            this.DGv_name.HeaderText = "Name";
            this.DGv_name.Name = "DGv_name";
            // 
            // DGv_PIN
            // 
            this.DGv_PIN.HeaderText = "PIN";
            this.DGv_PIN.Name = "DGv_PIN";
            // 
            // DGv_QTY
            // 
            this.DGv_QTY.HeaderText = "QYT";
            this.DGv_QTY.Name = "DGv_QTY";
            // 
            // DGv_Batch
            // 
            this.DGv_Batch.HeaderText = "Batch";
            this.DGv_Batch.Name = "DGv_Batch";
            // 
            // DGv_DS
            // 
            this.DGv_DS.HeaderText = "DS";
            this.DGv_DS.Name = "DGv_DS";
            // 
            // DGv_POUT
            // 
            this.DGv_POUT.HeaderText = "POUT";
            this.DGv_POUT.Name = "DGv_POUT";
            // 
            // DGv_Expire
            // 
            this.DGv_Expire.HeaderText = "Expire";
            this.DGv_Expire.Name = "DGv_Expire";
            // 
            // DGv_Barcode
            // 
            this.DGv_Barcode.HeaderText = "Barcode";
            this.DGv_Barcode.Name = "DGv_Barcode";
            // 
            // DGv_location
            // 
            this.DGv_location.HeaderText = "LOCATION";
            this.DGv_location.Name = "DGv_location";
            // 
            // btn_BillView
            // 
            this.btn_BillView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_BillView.BackColor = System.Drawing.Color.Transparent;
            this.btn_BillView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BillView.BackgroundImage")));
            this.btn_BillView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BillView.FlatAppearance.BorderSize = 0;
            this.btn_BillView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_BillView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_BillView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BillView.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BillView.Location = new System.Drawing.Point(4, 62);
            this.btn_BillView.Name = "btn_BillView";
            this.btn_BillView.Size = new System.Drawing.Size(77, 41);
            this.btn_BillView.TabIndex = 19;
            this.btn_BillView.UseVisualStyleBackColor = false;
            this.btn_BillView.Click += new System.EventHandler(this.btn_BillView_Click);
            // 
            // DataGridView_bill
            // 
            this.DataGridView_bill.AllowUserToAddRows = false;
            this.DataGridView_bill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DataGridView_bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_bill.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView_bill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_bill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView_bill.ColumnHeadersHeight = 25;
            this.DataGridView_bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.price,
            this.qty,
            this.ds});
            this.DataGridView_bill.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_bill.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView_bill.Location = new System.Drawing.Point(797, 103);
            this.DataGridView_bill.Name = "DataGridView_bill";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_bill.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView_bill.RowHeadersVisible = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridView_bill.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView_bill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_bill.Size = new System.Drawing.Size(359, 259);
            this.DataGridView_bill.TabIndex = 20;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // qty
            // 
            this.qty.HeaderText = "QYT";
            this.qty.Name = "qty";
            // 
            // ds
            // 
            this.ds.HeaderText = "DS";
            this.ds.Name = "ds";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(800, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(356, 41);
            this.button2.TabIndex = 21;
            this.button2.Text = "Delete Selected";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // text_CustomerName
            // 
            this.text_CustomerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_CustomerName.BackColor = System.Drawing.SystemColors.Menu;
            this.text_CustomerName.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_CustomerName.Location = new System.Drawing.Point(800, 457);
            this.text_CustomerName.Name = "text_CustomerName";
            this.text_CustomerName.Size = new System.Drawing.Size(356, 40);
            this.text_CustomerName.TabIndex = 22;
            this.text_CustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_amount
            // 
            this.lbl_amount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.Location = new System.Drawing.Point(800, 512);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(116, 20);
            this.lbl_amount.TabIndex = 23;
            this.lbl_amount.Text = "Total Amount";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(800, 556);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Discount";
            // 
            // txt_BillDis
            // 
            this.txt_BillDis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_BillDis.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_BillDis.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BillDis.Location = new System.Drawing.Point(979, 556);
            this.txt_BillDis.Name = "txt_BillDis";
            this.txt_BillDis.Size = new System.Drawing.Size(177, 30);
            this.txt_BillDis.TabIndex = 25;
            this.txt_BillDis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_BillDis.TextChanged += new System.EventHandler(this.txt_BillDis_TextChanged_1);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(800, 602);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Pyable Amount";
            // 
            // btn_proceedOrder
            // 
            this.btn_proceedOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_proceedOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_proceedOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proceedOrder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proceedOrder.ForeColor = System.Drawing.Color.White;
            this.btn_proceedOrder.Location = new System.Drawing.Point(829, 642);
            this.btn_proceedOrder.Name = "btn_proceedOrder";
            this.btn_proceedOrder.Size = new System.Drawing.Size(150, 41);
            this.btn_proceedOrder.TabIndex = 27;
            this.btn_proceedOrder.Text = "Proceed Order";
            this.btn_proceedOrder.UseVisualStyleBackColor = false;
            this.btn_proceedOrder.Click += new System.EventHandler(this.btn_proceedOrder_Click);
            // 
            // btn_Cancelorder
            // 
            this.btn_Cancelorder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Cancelorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Cancelorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelorder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelorder.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelorder.Location = new System.Drawing.Point(985, 642);
            this.btn_Cancelorder.Name = "btn_Cancelorder";
            this.btn_Cancelorder.Size = new System.Drawing.Size(150, 41);
            this.btn_Cancelorder.TabIndex = 28;
            this.btn_Cancelorder.Text = "Cancel Order";
            this.btn_Cancelorder.UseVisualStyleBackColor = false;
            this.btn_Cancelorder.Click += new System.EventHandler(this.btn_Cancelorder_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(794, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Scan Barcode";
            // 
            // txt_barcodeScan
            // 
            this.txt_barcodeScan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_barcodeScan.BackColor = System.Drawing.Color.Silver;
            this.txt_barcodeScan.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcodeScan.Location = new System.Drawing.Point(797, 62);
            this.txt_barcodeScan.Name = "txt_barcodeScan";
            // 
            // 
            // 
            this.txt_barcodeScan.RootElement.BorderHighlightColor = System.Drawing.Color.Gray;
            this.txt_barcodeScan.RootElement.BorderHighlightThickness = 22;
            this.txt_barcodeScan.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 100, 20);
            this.txt_barcodeScan.RootElement.EnableFocusBorder = true;
            this.txt_barcodeScan.RootElement.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.txt_barcodeScan.RootElement.StretchVertically = true;
            this.txt_barcodeScan.Size = new System.Drawing.Size(359, 40);
            this.txt_barcodeScan.TabIndex = 29;
            this.txt_barcodeScan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_barcodeScan.TextChanged += new System.EventHandler(this.txt_barcodeScan_TextChanged);
            // 
            // txt_Tamount
            // 
            this.txt_Tamount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Tamount.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_Tamount.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tamount.Location = new System.Drawing.Point(800, 415);
            this.txt_Tamount.Name = "txt_Tamount";
            this.txt_Tamount.Size = new System.Drawing.Size(116, 30);
            this.txt_Tamount.TabIndex = 31;
            this.txt_Tamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TotalAmount
            // 
            this.txt_TotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TotalAmount.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_TotalAmount.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalAmount.Location = new System.Drawing.Point(979, 596);
            this.txt_TotalAmount.Name = "txt_TotalAmount";
            this.txt_TotalAmount.Size = new System.Drawing.Size(111, 30);
            this.txt_TotalAmount.TabIndex = 32;
            this.txt_TotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_totalamount2
            // 
            this.txt_totalamount2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_totalamount2.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_totalamount2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalamount2.Location = new System.Drawing.Point(974, 502);
            this.txt_totalamount2.Name = "txt_totalamount2";
            this.txt_totalamount2.Size = new System.Drawing.Size(116, 30);
            this.txt_totalamount2.TabIndex = 33;
            this.txt_totalamount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 686);
            this.Controls.Add(this.txt_totalamount2);
            this.Controls.Add(this.txt_TotalAmount);
            this.Controls.Add(this.txt_Tamount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Cancelorder);
            this.Controls.Add(this.btn_proceedOrder);
            this.Controls.Add(this.txt_barcodeScan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_BillDis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.text_CustomerName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DataGridView_bill);
            this.Controls.Add(this.btn_BillView);
            this.Controls.Add(this.DataGridView_Bills);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_searchBill);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bills";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bills_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_searchBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Bills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_barcodeScan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private Telerik.WinControls.UI.RadTextBox txt_searchBill;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridView_Bills;
        private System.Windows.Forms.Button btn_BillView;
        private System.Windows.Forms.DataGridView DataGridView_bill;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox text_CustomerName;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_BillDis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_proceedOrder;
        private System.Windows.Forms.Button btn_Cancelorder;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadTextBox txt_barcodeScan;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_PIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_DS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_POUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_Expire;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_location;
        private System.Windows.Forms.TextBox txt_Tamount;
        private System.Windows.Forms.TextBox txt_TotalAmount;
        private System.Windows.Forms.TextBox txt_totalamount2;
    }
}