
namespace ReturnMedicalSystem.Forms
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cusdel = new System.Windows.Forms.Button();
            this.btn_cusUpdate = new System.Windows.Forms.Button();
            this.lbl_erroraddress = new System.Windows.Forms.Label();
            this.lbl_errorphone = new System.Windows.Forms.Label();
            this.lbl_erorname = new System.Windows.Forms.Label();
            this.btn_cusRe = new System.Windows.Forms.Button();
            this.btn_cusSav = new System.Windows.Forms.Button();
            this.lbl_cusAdd = new System.Windows.Forms.Label();
            this.txt_cusAd = new System.Windows.Forms.RichTextBox();
            this.txt_cusP = new System.Windows.Forms.TextBox();
            this.lbl_cusP = new System.Windows.Forms.Label();
            this.txt_cusN = new System.Windows.Forms.TextBox();
            this.lbl_cusN = new System.Windows.Forms.Label();
            this.DataGridView_Customer = new System.Windows.Forms.DataGridView();
            this.DGv_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_PH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_ADD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_View = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Customer)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(377, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADD CUSTOMER";
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
            // btn_cusdel
            // 
            this.btn_cusdel.BackColor = System.Drawing.Color.Gray;
            this.btn_cusdel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cusdel.Location = new System.Drawing.Point(131, 472);
            this.btn_cusdel.Name = "btn_cusdel";
            this.btn_cusdel.Size = new System.Drawing.Size(117, 42);
            this.btn_cusdel.TabIndex = 40;
            this.btn_cusdel.Text = "Delete";
            this.btn_cusdel.UseVisualStyleBackColor = false;
            this.btn_cusdel.Click += new System.EventHandler(this.btn_cusdel_Click);
            // 
            // btn_cusUpdate
            // 
            this.btn_cusUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_cusUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cusUpdate.Location = new System.Drawing.Point(11, 472);
            this.btn_cusUpdate.Name = "btn_cusUpdate";
            this.btn_cusUpdate.Size = new System.Drawing.Size(123, 42);
            this.btn_cusUpdate.TabIndex = 39;
            this.btn_cusUpdate.Text = "Update";
            this.btn_cusUpdate.UseVisualStyleBackColor = false;
            this.btn_cusUpdate.Click += new System.EventHandler(this.btn_cusUpdate_Click);
            // 
            // lbl_erroraddress
            // 
            this.lbl_erroraddress.AutoSize = true;
            this.lbl_erroraddress.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erroraddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_erroraddress.Location = new System.Drawing.Point(157, 229);
            this.lbl_erroraddress.Name = "lbl_erroraddress";
            this.lbl_erroraddress.Size = new System.Drawing.Size(20, 23);
            this.lbl_erroraddress.TabIndex = 37;
            this.lbl_erroraddress.Text = "*";
            this.lbl_erroraddress.Visible = false;
            // 
            // lbl_errorphone
            // 
            this.lbl_errorphone.AutoSize = true;
            this.lbl_errorphone.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_errorphone.Location = new System.Drawing.Point(150, 152);
            this.lbl_errorphone.Name = "lbl_errorphone";
            this.lbl_errorphone.Size = new System.Drawing.Size(20, 23);
            this.lbl_errorphone.TabIndex = 36;
            this.lbl_errorphone.Text = "*";
            this.lbl_errorphone.Visible = false;
            // 
            // lbl_erorname
            // 
            this.lbl_erorname.AutoSize = true;
            this.lbl_erorname.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erorname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_erorname.Location = new System.Drawing.Point(138, 71);
            this.lbl_erorname.Name = "lbl_erorname";
            this.lbl_erorname.Size = new System.Drawing.Size(20, 23);
            this.lbl_erorname.TabIndex = 35;
            this.lbl_erorname.Text = "*";
            this.lbl_erorname.Visible = false;
            // 
            // btn_cusRe
            // 
            this.btn_cusRe.BackColor = System.Drawing.Color.Gray;
            this.btn_cusRe.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cusRe.Location = new System.Drawing.Point(131, 435);
            this.btn_cusRe.Name = "btn_cusRe";
            this.btn_cusRe.Size = new System.Drawing.Size(117, 42);
            this.btn_cusRe.TabIndex = 34;
            this.btn_cusRe.Text = "Reset";
            this.btn_cusRe.UseVisualStyleBackColor = false;
            // 
            // btn_cusSav
            // 
            this.btn_cusSav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_cusSav.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cusSav.Location = new System.Drawing.Point(11, 435);
            this.btn_cusSav.Name = "btn_cusSav";
            this.btn_cusSav.Size = new System.Drawing.Size(123, 42);
            this.btn_cusSav.TabIndex = 33;
            this.btn_cusSav.Text = "Save";
            this.btn_cusSav.UseVisualStyleBackColor = false;
            this.btn_cusSav.Click += new System.EventHandler(this.btn_cusSav_Click);
            // 
            // lbl_cusAdd
            // 
            this.lbl_cusAdd.AutoSize = true;
            this.lbl_cusAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cusAdd.Location = new System.Drawing.Point(8, 231);
            this.lbl_cusAdd.Name = "lbl_cusAdd";
            this.lbl_cusAdd.Size = new System.Drawing.Size(147, 21);
            this.lbl_cusAdd.TabIndex = 30;
            this.lbl_cusAdd.Text = "Customer Address";
            // 
            // txt_cusAd
            // 
            this.txt_cusAd.Location = new System.Drawing.Point(12, 266);
            this.txt_cusAd.Name = "txt_cusAd";
            this.txt_cusAd.Size = new System.Drawing.Size(215, 96);
            this.txt_cusAd.TabIndex = 29;
            this.txt_cusAd.Text = "";
            // 
            // txt_cusP
            // 
            this.txt_cusP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cusP.Location = new System.Drawing.Point(12, 188);
            this.txt_cusP.Name = "txt_cusP";
            this.txt_cusP.Size = new System.Drawing.Size(215, 33);
            this.txt_cusP.TabIndex = 28;
            // 
            // lbl_cusP
            // 
            this.lbl_cusP.AutoSize = true;
            this.lbl_cusP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cusP.Location = new System.Drawing.Point(8, 154);
            this.lbl_cusP.Name = "lbl_cusP";
            this.lbl_cusP.Size = new System.Drawing.Size(136, 21);
            this.lbl_cusP.TabIndex = 27;
            this.lbl_cusP.Text = "Customer Phone";
            // 
            // txt_cusN
            // 
            this.txt_cusN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cusN.Location = new System.Drawing.Point(12, 106);
            this.txt_cusN.Name = "txt_cusN";
            this.txt_cusN.Size = new System.Drawing.Size(215, 33);
            this.txt_cusN.TabIndex = 26;
            // 
            // lbl_cusN
            // 
            this.lbl_cusN.AutoSize = true;
            this.lbl_cusN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cusN.Location = new System.Drawing.Point(8, 73);
            this.lbl_cusN.Name = "lbl_cusN";
            this.lbl_cusN.Size = new System.Drawing.Size(133, 21);
            this.lbl_cusN.TabIndex = 25;
            this.lbl_cusN.Text = "Customer Name";
            // 
            // DataGridView_Customer
            // 
            this.DataGridView_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_Customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Customer.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_Customer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGv_Id,
            this.DGv_name,
            this.DGv_PH,
            this.DGv_ADD});
            this.DataGridView_Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(65)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Customer.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_Customer.Location = new System.Drawing.Point(254, 146);
            this.DataGridView_Customer.Name = "DataGridView_Customer";
            this.DataGridView_Customer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataGridView_Customer.Size = new System.Drawing.Size(691, 482);
            this.DataGridView_Customer.TabIndex = 41;
            this.DataGridView_Customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Supplier_CellClick);
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
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(660, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(285, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
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
            this.btn_View.Location = new System.Drawing.Point(254, 81);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(68, 58);
            this.btn_View.TabIndex = 43;
            this.btn_View.UseVisualStyleBackColor = false;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 640);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DataGridView_Customer);
            this.Controls.Add(this.btn_cusdel);
            this.Controls.Add(this.btn_cusUpdate);
            this.Controls.Add(this.lbl_erroraddress);
            this.Controls.Add(this.lbl_errorphone);
            this.Controls.Add(this.lbl_erorname);
            this.Controls.Add(this.btn_cusRe);
            this.Controls.Add(this.btn_cusSav);
            this.Controls.Add(this.lbl_cusAdd);
            this.Controls.Add(this.txt_cusAd);
            this.Controls.Add(this.txt_cusP);
            this.Controls.Add(this.lbl_cusP);
            this.Controls.Add(this.txt_cusN);
            this.Controls.Add(this.lbl_cusN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cusdel;
        private System.Windows.Forms.Button btn_cusUpdate;
        private System.Windows.Forms.Label lbl_erroraddress;
        private System.Windows.Forms.Label lbl_errorphone;
        private System.Windows.Forms.Label lbl_erorname;
        private System.Windows.Forms.Button btn_cusRe;
        private System.Windows.Forms.Button btn_cusSav;
        private System.Windows.Forms.Label lbl_cusAdd;
        private System.Windows.Forms.RichTextBox txt_cusAd;
        private System.Windows.Forms.TextBox txt_cusP;
        private System.Windows.Forms.Label lbl_cusP;
        private System.Windows.Forms.TextBox txt_cusN;
        private System.Windows.Forms.Label lbl_cusN;
        private System.Windows.Forms.DataGridView DataGridView_Customer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_PH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_ADD;
        private System.Windows.Forms.Button button5;
    }
}