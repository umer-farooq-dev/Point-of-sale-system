namespace ReturnMedicalSystem.Forms
{
    partial class ProductsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_searchProduct = new Telerik.WinControls.UI.RadTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView_Product = new System.Windows.Forms.DataGridView();
            this.DGv_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_PIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_POUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_DS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_Expire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_EmptyProduct = new System.Windows.Forms.Button();
            this.Btn_ExpireProduct = new System.Windows.Forms.Button();
            this.btn_RequiredProduct = new System.Windows.Forms.Button();
            this.lbl_Marquee = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_searchProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_searchProduct);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 66);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(817, -1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 22);
            this.label11.TabIndex = 10;
            this.label11.Text = "Search Here";
            // 
            // txt_searchProduct
            // 
            this.txt_searchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_searchProduct.BackColor = System.Drawing.Color.Gray;
            this.txt_searchProduct.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchProduct.ForeColor = System.Drawing.Color.White;
            this.txt_searchProduct.Location = new System.Drawing.Point(822, 21);
            this.txt_searchProduct.Name = "txt_searchProduct";
            // 
            // 
            // 
            this.txt_searchProduct.RootElement.BorderHighlightColor = System.Drawing.Color.Gray;
            this.txt_searchProduct.RootElement.BorderHighlightThickness = 22;
            this.txt_searchProduct.RootElement.EnableFocusBorder = true;
            this.txt_searchProduct.RootElement.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.txt_searchProduct.Size = new System.Drawing.Size(255, 40);
            this.txt_searchProduct.TabIndex = 9;
            this.txt_searchProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_searchProduct.TextChanged += new System.EventHandler(this.txt_searchProduct_TextChanged);
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
            this.button5.Location = new System.Drawing.Point(1141, -2);
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
            this.button1.Location = new System.Drawing.Point(1488, 12);
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
            this.label2.Location = new System.Drawing.Point(127, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Premium v1.0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zam Zam";
            // 
            // DataGridView_Product
            // 
            this.DataGridView_Product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Product.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView_Product.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView_Product.ColumnHeadersHeight = 25;
            this.DataGridView_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGv_Id,
            this.DGv_name,
            this.DGv_Batch,
            this.DGv_QTY,
            this.DGv_PIN,
            this.DGv_POUT,
            this.DGv_DS,
            this.DGv_Expire,
            this.DGv_Barcode,
            this.DGv_location});
            this.DataGridView_Product.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Product.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView_Product.Location = new System.Drawing.Point(0, 108);
            this.DataGridView_Product.Name = "DataGridView_Product";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Product.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView_Product.RowHeadersVisible = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridView_Product.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Product.Size = new System.Drawing.Size(1184, 517);
            this.DataGridView_Product.TabIndex = 11;
            this.DataGridView_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Product_CellClick);
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
            // DGv_Batch
            // 
            this.DGv_Batch.HeaderText = "Batch";
            this.DGv_Batch.Name = "DGv_Batch";
            // 
            // DGv_QTY
            // 
            this.DGv_QTY.HeaderText = "QYT";
            this.DGv_QTY.Name = "DGv_QTY";
            // 
            // DGv_PIN
            // 
            this.DGv_PIN.HeaderText = "PIN";
            this.DGv_PIN.Name = "DGv_PIN";
            // 
            // DGv_POUT
            // 
            this.DGv_POUT.HeaderText = "POUT";
            this.DGv_POUT.Name = "DGv_POUT";
            // 
            // DGv_DS
            // 
            this.DGv_DS.HeaderText = "DS";
            this.DGv_DS.Name = "DGv_DS";
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
            // Btn_EmptyProduct
            // 
            this.Btn_EmptyProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_EmptyProduct.BackColor = System.Drawing.Color.DarkKhaki;
            this.Btn_EmptyProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_EmptyProduct.FlatAppearance.BorderSize = 2;
            this.Btn_EmptyProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EmptyProduct.Location = new System.Drawing.Point(692, 631);
            this.Btn_EmptyProduct.Name = "Btn_EmptyProduct";
            this.Btn_EmptyProduct.Size = new System.Drawing.Size(159, 46);
            this.Btn_EmptyProduct.TabIndex = 13;
            this.Btn_EmptyProduct.Text = "Empty Product";
            this.Btn_EmptyProduct.UseVisualStyleBackColor = false;
            this.Btn_EmptyProduct.Click += new System.EventHandler(this.Btn_EmptyProduct_Click);
            // 
            // Btn_ExpireProduct
            // 
            this.Btn_ExpireProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_ExpireProduct.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_ExpireProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_ExpireProduct.FlatAppearance.BorderSize = 2;
            this.Btn_ExpireProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExpireProduct.Location = new System.Drawing.Point(362, 631);
            this.Btn_ExpireProduct.Name = "Btn_ExpireProduct";
            this.Btn_ExpireProduct.Size = new System.Drawing.Size(159, 46);
            this.Btn_ExpireProduct.TabIndex = 12;
            this.Btn_ExpireProduct.Text = "Expire Product";
            this.Btn_ExpireProduct.UseVisualStyleBackColor = false;
            this.Btn_ExpireProduct.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // btn_RequiredProduct
            // 
            this.btn_RequiredProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_RequiredProduct.BackColor = System.Drawing.Color.Tan;
            this.btn_RequiredProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_RequiredProduct.FlatAppearance.BorderSize = 2;
            this.btn_RequiredProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RequiredProduct.Location = new System.Drawing.Point(527, 631);
            this.btn_RequiredProduct.Name = "btn_RequiredProduct";
            this.btn_RequiredProduct.Size = new System.Drawing.Size(159, 46);
            this.btn_RequiredProduct.TabIndex = 14;
            this.btn_RequiredProduct.Text = "Required Product";
            this.btn_RequiredProduct.UseVisualStyleBackColor = false;
            this.btn_RequiredProduct.Click += new System.EventHandler(this.btn_RequiredProduct_Click);
            // 
            // lbl_Marquee
            // 
            this.lbl_Marquee.AutoSize = true;
            this.lbl_Marquee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Marquee.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marquee.ForeColor = System.Drawing.Color.White;
            this.lbl_Marquee.Location = new System.Drawing.Point(462, 75);
            this.lbl_Marquee.Name = "lbl_Marquee";
            this.lbl_Marquee.Size = new System.Drawing.Size(228, 25);
            this.lbl_Marquee.TabIndex = 11;
            this.lbl_Marquee.Text = "Zam Zam Super Store";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.lbl_Marquee);
            this.Controls.Add(this.btn_RequiredProduct);
            this.Controls.Add(this.Btn_EmptyProduct);
            this.Controls.Add(this.Btn_ExpireProduct);
            this.Controls.Add(this.DataGridView_Product);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_searchProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private Telerik.WinControls.UI.RadTextBox txt_searchProduct;
        private System.Windows.Forms.DataGridView DataGridView_Product;
        private System.Windows.Forms.Button Btn_EmptyProduct;
        private System.Windows.Forms.Button Btn_ExpireProduct;
        private System.Windows.Forms.Button btn_RequiredProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_PIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_POUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_DS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_Expire;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_location;
        private System.Windows.Forms.Label lbl_Marquee;
        private System.Windows.Forms.Timer timer1;
    }
}