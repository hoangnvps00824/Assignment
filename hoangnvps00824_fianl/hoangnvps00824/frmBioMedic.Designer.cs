namespace PhungLV_Assig9
{
    partial class frmBioMedic
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvSANPHAM = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.txtADDTENSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtADDMASP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtADDSOLUONG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtADDDONGIA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.colMASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLOAISANPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSANPHAM)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Hiện tất cả";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvSANPHAM
            // 
            this.dgvSANPHAM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSANPHAM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMASP,
            this.colTENSP,
            this.colSOLUONG,
            this.colLOAISANPHAM,
            this.colDONGIA});
            this.dgvSANPHAM.Location = new System.Drawing.Point(12, 93);
            this.dgvSANPHAM.Name = "dgvSANPHAM";
            this.dgvSANPHAM.Size = new System.Drawing.Size(568, 161);
            this.dgvSANPHAM.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboLoaiSP);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txtADDDONGIA);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtADDSOLUONG);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.txtADDTENSP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtADDMASP);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 164);
            this.panel1.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(148, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtADDTENSP
            // 
            this.txtADDTENSP.Location = new System.Drawing.Point(148, 29);
            this.txtADDTENSP.Name = "txtADDTENSP";
            this.txtADDTENSP.Size = new System.Drawing.Size(151, 20);
            this.txtADDTENSP.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên sản phẩm";
            // 
            // txtADDMASP
            // 
            this.txtADDMASP.Location = new System.Drawing.Point(148, 3);
            this.txtADDMASP.Name = "txtADDMASP";
            this.txtADDMASP.Size = new System.Drawing.Size(151, 20);
            this.txtADDMASP.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Loại sản phẩm";
            // 
            // txtADDSOLUONG
            // 
            this.txtADDSOLUONG.Location = new System.Drawing.Point(148, 55);
            this.txtADDSOLUONG.Name = "txtADDSOLUONG";
            this.txtADDSOLUONG.Size = new System.Drawing.Size(151, 20);
            this.txtADDSOLUONG.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số lương";
            // 
            // txtADDDONGIA
            // 
            this.txtADDDONGIA.Location = new System.Drawing.Point(148, 107);
            this.txtADDDONGIA.Name = "txtADDDONGIA";
            this.txtADDDONGIA.Size = new System.Drawing.Size(151, 20);
            this.txtADDDONGIA.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Đơn giá";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(229, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(310, 133);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Xóa";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // colMASP
            // 
            this.colMASP.DataPropertyName = "MASP";
            this.colMASP.HeaderText = "Mã sản phẩm";
            this.colMASP.Name = "colMASP";
            // 
            // colTENSP
            // 
            this.colTENSP.DataPropertyName = "TENSP";
            this.colTENSP.HeaderText = "Tên sản phẩm";
            this.colTENSP.Name = "colTENSP";
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.DataPropertyName = "SOLUONG";
            this.colSOLUONG.HeaderText = "Số lượng";
            this.colSOLUONG.Name = "colSOLUONG";
            // 
            // colLOAISANPHAM
            // 
            this.colLOAISANPHAM.DataPropertyName = "LOAISANPHAM";
            this.colLOAISANPHAM.HeaderText = "Loại sản phẩm";
            this.colLOAISANPHAM.Name = "colLOAISANPHAM";
            // 
            // colDONGIA
            // 
            this.colDONGIA.DataPropertyName = "DONGIA";
            this.colDONGIA.HeaderText = "Đơn giá";
            this.colDONGIA.Name = "colDONGIA";
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(149, 81);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(150, 21);
            this.cboLoaiSP.TabIndex = 19;
            // 
            // frmBioMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 424);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSANPHAM);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmBioMedic";
            this.Text = "BioMedic System";
            this.Load += new System.EventHandler(this.frmBioMedic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSANPHAM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvSANPHAM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtADDDONGIA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtADDSOLUONG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtADDTENSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtADDMASP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLOAISANPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDONGIA;
        private System.Windows.Forms.ComboBox cboLoaiSP;

    }
}

