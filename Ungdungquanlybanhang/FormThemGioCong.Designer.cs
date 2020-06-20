namespace Ungdungquanlybanhang
{
    partial class FormThemGioCong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemGioCong = new System.Windows.Forms.Button();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtgiocong = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGV = new System.Windows.Forms.DataGridView();
            this.colmanv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgiocong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemGioCong);
            this.panel1.Controls.Add(this.txttennv);
            this.panel1.Controls.Add(this.txtgiocong);
            this.panel1.Controls.Add(this.txtmanv);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 148);
            this.panel1.TabIndex = 0;
            // 
            // btnThemGioCong
            // 
            this.btnThemGioCong.Location = new System.Drawing.Point(157, 104);
            this.btnThemGioCong.Name = "btnThemGioCong";
            this.btnThemGioCong.Size = new System.Drawing.Size(124, 23);
            this.btnThemGioCong.TabIndex = 6;
            this.btnThemGioCong.Text = "Thêm giờ công";
            this.btnThemGioCong.UseVisualStyleBackColor = true;
            this.btnThemGioCong.Click += new System.EventHandler(this.btnThemGioCong_Click);
            // 
            // txttennv
            // 
            this.txttennv.Enabled = false;
            this.txttennv.Location = new System.Drawing.Point(115, 52);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(273, 20);
            this.txttennv.TabIndex = 5;
            // 
            // txtgiocong
            // 
            this.txtgiocong.Location = new System.Drawing.Point(311, 15);
            this.txtgiocong.Name = "txtgiocong";
            this.txtgiocong.Size = new System.Drawing.Size(100, 20);
            this.txtgiocong.TabIndex = 4;
            // 
            // txtmanv
            // 
            this.txtmanv.Enabled = false;
            this.txtmanv.Location = new System.Drawing.Point(115, 15);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(100, 20);
            this.txtmanv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giờ công";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // dtGV
            // 
            this.dtGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmanv,
            this.coltennv,
            this.colgiocong});
            this.dtGV.Location = new System.Drawing.Point(-2, 146);
            this.dtGV.Name = "dtGV";
            this.dtGV.Size = new System.Drawing.Size(455, 119);
            this.dtGV.TabIndex = 1;
            this.dtGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colmanv
            // 
            this.colmanv.DataPropertyName = "colmanv";
            this.colmanv.HeaderText = "Mã nhân viên";
            this.colmanv.Name = "colmanv";
            this.colmanv.Width = 105;
            // 
            // coltennv
            // 
            this.coltennv.DataPropertyName = "coltennv";
            this.coltennv.HeaderText = "Tên nhân viên";
            this.coltennv.Name = "coltennv";
            this.coltennv.Width = 200;
            // 
            // colgiocong
            // 
            this.colgiocong.DataPropertyName = "colgiocong";
            this.colgiocong.HeaderText = "Giờ công";
            this.colgiocong.Name = "colgiocong";
            this.colgiocong.Width = 103;
            // 
            // FormThemGioCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(448, 261);
            this.Controls.Add(this.dtGV);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormThemGioCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Giờ Công";
            this.Load += new System.EventHandler(this.FormThemGioCong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtGV;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtgiocong;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemGioCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmanv;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgiocong;
    }
}