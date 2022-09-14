
namespace ReturnMedicalSystem.Forms
{
    partial class Suppllers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppllers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_supN = new System.Windows.Forms.Label();
            this.txt_supN = new System.Windows.Forms.TextBox();
            this.txt_supP = new System.Windows.Forms.TextBox();
            this.lbl_supP = new System.Windows.Forms.Label();
            this.txt_supAd = new System.Windows.Forms.RichTextBox();
            this.lbl_supAd = new System.Windows.Forms.Label();
            this.lbl_supRe = new System.Windows.Forms.Label();
            this.txt_supRe = new System.Windows.Forms.RichTextBox();
            this.btn_supSav = new System.Windows.Forms.Button();
            this.btn_supRe = new System.Windows.Forms.Button();
            this.lbl_erorname = new System.Windows.Forms.Label();
            this.lbl_errorphone = new System.Windows.Forms.Label();
            this.lbl_erroraddress = new System.Windows.Forms.Label();
            this.lbl_errorremarks = new System.Windows.Forms.Label();
            this.btn_supdel = new System.Windows.Forms.Button();
            this.btn_supUpdate = new System.Windows.Forms.Button();
            this.DataGridView_Supplier = new System.Windows.Forms.DataGridView();
            this.DGv_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_PH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_ADD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_View = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Supplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 61);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.button5.Location = new System.Drawing.Point(906, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 28);
            this.button5.TabIndex = 9;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADD SUPPLIER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_supN
            // 
            this.lbl_supN.AutoSize = true;
            this.lbl_supN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supN.Location = new System.Drawing.Point(12, 64);
            this.lbl_supN.Name = "lbl_supN";
            this.lbl_supN.Size = new System.Drawing.Size(124, 21);
            this.lbl_supN.TabIndex = 1;
            this.lbl_supN.Text = "Supplier Name";
            // 
            // txt_supN
            // 
            this.txt_supN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supN.Location = new System.Drawing.Point(16, 98);
            this.txt_supN.Name = "txt_supN";
            this.txt_supN.Size = new System.Drawing.Size(215, 33);
            this.txt_supN.TabIndex = 2;
            // 
            // txt_supP
            // 
            this.txt_supP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supP.Location = new System.Drawing.Point(16, 180);
            this.txt_supP.Name = "txt_supP";
            this.txt_supP.Size = new System.Drawing.Size(215, 33);
            this.txt_supP.TabIndex = 4;
            // 
            // lbl_supP
            // 
            this.lbl_supP.AutoSize = true;
            this.lbl_supP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supP.Location = new System.Drawing.Point(12, 146);
            this.lbl_supP.Name = "lbl_supP";
            this.lbl_supP.Size = new System.Drawing.Size(127, 21);
            this.lbl_supP.TabIndex = 3;
            this.lbl_supP.Text = "Supplier Phone";
            // 
            // txt_supAd
            // 
            this.txt_supAd.Location = new System.Drawing.Point(16, 258);
            this.txt_supAd.Name = "txt_supAd";
            this.txt_supAd.Size = new System.Drawing.Size(215, 96);
            this.txt_supAd.TabIndex = 5;
            this.txt_supAd.Text = "";
            // 
            // lbl_supAd
            // 
            this.lbl_supAd.AutoSize = true;
            this.lbl_supAd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supAd.Location = new System.Drawing.Point(12, 223);
            this.lbl_supAd.Name = "lbl_supAd";
            this.lbl_supAd.Size = new System.Drawing.Size(138, 21);
            this.lbl_supAd.TabIndex = 6;
            this.lbl_supAd.Text = "Supplier Address";
            // 
            // lbl_supRe
            // 
            this.lbl_supRe.AutoSize = true;
            this.lbl_supRe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supRe.Location = new System.Drawing.Point(12, 372);
            this.lbl_supRe.Name = "lbl_supRe";
            this.lbl_supRe.Size = new System.Drawing.Size(143, 21);
            this.lbl_supRe.TabIndex = 8;
            this.lbl_supRe.Text = "Supplier Remarks";
            // 
            // txt_supRe
            // 
            this.txt_supRe.Location = new System.Drawing.Point(16, 407);
            this.txt_supRe.Name = "txt_supRe";
            this.txt_supRe.Size = new System.Drawing.Size(215, 96);
            this.txt_supRe.TabIndex = 7;
            this.txt_supRe.Text = "";
            // 
            // btn_supSav
            // 
            this.btn_supSav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_supSav.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supSav.Location = new System.Drawing.Point(11, 549);
            this.btn_supSav.Name = "btn_supSav";
            this.btn_supSav.Size = new System.Drawing.Size(123, 42);
            this.btn_supSav.TabIndex = 9;
            this.btn_supSav.Text = "Save";
            this.btn_supSav.UseVisualStyleBackColor = false;
            this.btn_supSav.Click += new System.EventHandler(this.btn_supSav_Click);
            // 
            // btn_supRe
            // 
            this.btn_supRe.BackColor = System.Drawing.Color.Gray;
            this.btn_supRe.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supRe.Location = new System.Drawing.Point(131, 549);
            this.btn_supRe.Name = "btn_supRe";
            this.btn_supRe.Size = new System.Drawing.Size(117, 42);
            this.btn_supRe.TabIndex = 10;
            this.btn_supRe.Text = "Reset";
            this.btn_supRe.UseVisualStyleBackColor = false;
            this.btn_supRe.Click += new System.EventHandler(this.btn_supRe_Click);
            // 
            // lbl_erorname
            // 
            this.lbl_erorname.AutoSize = true;
            this.lbl_erorname.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erorname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_erorname.Location = new System.Drawing.Point(142, 62);
            this.lbl_erorname.Name = "lbl_erorname";
            this.lbl_erorname.Size = new System.Drawing.Size(20, 23);
            this.lbl_erorname.TabIndex = 19;
            this.lbl_erorname.Text = "*";
            this.lbl_erorname.Visible = false;
            // 
            // lbl_errorphone
            // 
            this.lbl_errorphone.AutoSize = true;
            this.lbl_errorphone.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_errorphone.Location = new System.Drawing.Point(145, 144);
            this.lbl_errorphone.Name = "lbl_errorphone";
            this.lbl_errorphone.Size = new System.Drawing.Size(20, 23);
            this.lbl_errorphone.TabIndex = 20;
            this.lbl_errorphone.Text = "*";
            this.lbl_errorphone.Visible = false;
            // 
            // lbl_erroraddress
            // 
            this.lbl_erroraddress.AutoSize = true;
            this.lbl_erroraddress.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erroraddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_erroraddress.Location = new System.Drawing.Point(156, 221);
            this.lbl_erroraddress.Name = "lbl_erroraddress";
            this.lbl_erroraddress.Size = new System.Drawing.Size(20, 23);
            this.lbl_erroraddress.TabIndex = 21;
            this.lbl_erroraddress.Text = "*";
            this.lbl_erroraddress.Visible = false;
            // 
            // lbl_errorremarks
            // 
            this.lbl_errorremarks.AutoSize = true;
            this.lbl_errorremarks.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorremarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_errorremarks.Location = new System.Drawing.Point(161, 372);
            this.lbl_errorremarks.Name = "lbl_errorremarks";
            this.lbl_errorremarks.Size = new System.Drawing.Size(20, 23);
            this.lbl_errorremarks.TabIndex = 22;
            this.lbl_errorremarks.Text = "*";
            this.lbl_errorremarks.Visible = false;
            // 
            // btn_supdel
            // 
            this.btn_supdel.BackColor = System.Drawing.Color.Gray;
            this.btn_supdel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supdel.Location = new System.Drawing.Point(131, 586);
            this.btn_supdel.Name = "btn_supdel";
            this.btn_supdel.Size = new System.Drawing.Size(117, 42);
            this.btn_supdel.TabIndex = 24;
            this.btn_supdel.Text = "Delete";
            this.btn_supdel.UseVisualStyleBackColor = false;
            this.btn_supdel.Click += new System.EventHandler(this.btn_supdel_Click);
            // 
            // btn_supUpdate
            // 
            this.btn_supUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_supUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supUpdate.Location = new System.Drawing.Point(11, 586);
            this.btn_supUpdate.Name = "btn_supUpdate";
            this.btn_supUpdate.Size = new System.Drawing.Size(123, 42);
            this.btn_supUpdate.TabIndex = 23;
            this.btn_supUpdate.Text = "Update";
            this.btn_supUpdate.UseVisualStyleBackColor = false;
            this.btn_supUpdate.Click += new System.EventHandler(this.btn_supUpdate_Click);
            // 
            // DataGridView_Supplier
            // 
            this.DataGridView_Supplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_Supplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Supplier.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_Supplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView_Supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Supplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGv_Id,
            this.DGv_name,
            this.DGv_PH,
            this.DGv_ADD,
            this.DGv_RE});
            this.DataGridView_Supplier.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(65)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Supplier.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_Supplier.Location = new System.Drawing.Point(254, 146);
            this.DataGridView_Supplier.Name = "DataGridView_Supplier";
            this.DataGridView_Supplier.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataGridView_Supplier.Size = new System.Drawing.Size(691, 482);
            this.DataGridView_Supplier.TabIndex = 25;
            this.DataGridView_Supplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Supplier_CellClick);
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
            this.DGv_name.HeaderText = "NAME";
            this.DGv_name.Name = "DGv_name";
            this.DGv_name.ReadOnly = true;
            // 
            // DGv_PH
            // 
            this.DGv_PH.HeaderText = "PHONE";
            this.DGv_PH.Name = "DGv_PH";
            this.DGv_PH.ReadOnly = true;
            // 
            // DGv_ADD
            // 
            this.DGv_ADD.HeaderText = "ADDRESS";
            this.DGv_ADD.Name = "DGv_ADD";
            this.DGv_ADD.ReadOnly = true;
            // 
            // DGv_RE
            // 
            this.DGv_RE.HeaderText = "REMARKS";
            this.DGv_RE.Name = "DGv_RE";
            this.DGv_RE.ReadOnly = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(660, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(285, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // btn_View
            // 
            this.btn_View.BackColor = System.Drawing.Color.Transparent;
            this.btn_View.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_View.BackgroundImage")));
            this.btn_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_View.FlatAppearance.BorderSize = 0;
            this.btn_View.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_View.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.Location = new System.Drawing.Point(254, 77);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(68, 58);
            this.btn_View.TabIndex = 27;
            this.btn_View.UseVisualStyleBackColor = false;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(677, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 29);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Suppllers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 640);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DataGridView_Supplier);
            this.Controls.Add(this.btn_supdel);
            this.Controls.Add(this.btn_supUpdate);
            this.Controls.Add(this.lbl_errorremarks);
            this.Controls.Add(this.lbl_erroraddress);
            this.Controls.Add(this.lbl_errorphone);
            this.Controls.Add(this.lbl_erorname);
            this.Controls.Add(this.btn_supRe);
            this.Controls.Add(this.btn_supSav);
            this.Controls.Add(this.lbl_supRe);
            this.Controls.Add(this.txt_supRe);
            this.Controls.Add(this.lbl_supAd);
            this.Controls.Add(this.txt_supAd);
            this.Controls.Add(this.txt_supP);
            this.Controls.Add(this.lbl_supP);
            this.Controls.Add(this.txt_supN);
            this.Controls.Add(this.lbl_supN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Suppllers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Suppllers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Supplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_supN;
        private System.Windows.Forms.TextBox txt_supN;
        private System.Windows.Forms.TextBox txt_supP;
        private System.Windows.Forms.Label lbl_supP;
        private System.Windows.Forms.RichTextBox txt_supAd;
        private System.Windows.Forms.Label lbl_supAd;
        private System.Windows.Forms.Label lbl_supRe;
        private System.Windows.Forms.RichTextBox txt_supRe;
        private System.Windows.Forms.Button btn_supSav;
        private System.Windows.Forms.Button btn_supRe;
        private System.Windows.Forms.Label lbl_erorname;
        private System.Windows.Forms.Label lbl_errorphone;
        private System.Windows.Forms.Label lbl_erroraddress;
        private System.Windows.Forms.Label lbl_errorremarks;
        private System.Windows.Forms.Button btn_supdel;
        private System.Windows.Forms.Button btn_supUpdate;
        private System.Windows.Forms.DataGridView DataGridView_Supplier;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_PH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_ADD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_RE;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
    }
}