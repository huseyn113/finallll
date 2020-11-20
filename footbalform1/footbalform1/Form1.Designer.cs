namespace footbalform1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.error = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datetarix = new System.Windows.Forms.DateTimePicker();
            this.cmbotaq = new System.Windows.Forms.ComboBox();
            this.cmbmeydanca = new System.Windows.Forms.ComboBox();
            this.btnrezerv = new System.Windows.Forms.Button();
            this.txtnomre = new System.Windows.Forms.TextBox();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.nmnefer = new System.Windows.Forms.NumericUpDown();
            this.numqiymet = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmnefer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numqiymet)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(12, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "NECE NEFER";
            // 
            // datagrid
            // 
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(417, 16);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(371, 429);
            this.datagrid.TabIndex = 38;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.error.Location = new System.Drawing.Point(12, 384);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(58, 13);
            this.error.TabIndex = 37;
            this.error.Text = "Musteri adi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(206, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 24);
            this.label7.TabIndex = 36;
            this.label7.Text = "TARIX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(325, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 35;
            // 
            // datetarix
            // 
            this.datetarix.Location = new System.Drawing.Point(199, 56);
            this.datetarix.Name = "datetarix";
            this.datetarix.Size = new System.Drawing.Size(200, 20);
            this.datetarix.TabIndex = 34;
            // 
            // cmbotaq
            // 
            this.cmbotaq.FormattingEnabled = true;
            this.cmbotaq.Location = new System.Drawing.Point(16, 233);
            this.cmbotaq.Name = "cmbotaq";
            this.cmbotaq.Size = new System.Drawing.Size(121, 21);
            this.cmbotaq.TabIndex = 32;
            // 
            // cmbmeydanca
            // 
            this.cmbmeydanca.FormattingEnabled = true;
            this.cmbmeydanca.Location = new System.Drawing.Point(16, 175);
            this.cmbmeydanca.Name = "cmbmeydanca";
            this.cmbmeydanca.Size = new System.Drawing.Size(121, 21);
            this.cmbmeydanca.TabIndex = 31;
            // 
            // btnrezerv
            // 
            this.btnrezerv.Location = new System.Drawing.Point(16, 411);
            this.btnrezerv.Name = "btnrezerv";
            this.btnrezerv.Size = new System.Drawing.Size(97, 34);
            this.btnrezerv.TabIndex = 30;
            this.btnrezerv.Text = "REZERV";
            this.btnrezerv.UseVisualStyleBackColor = true;
            this.btnrezerv.Click += new System.EventHandler(this.btnrezerv_Click);
            // 
            // txtnomre
            // 
            this.txtnomre.Location = new System.Drawing.Point(16, 106);
            this.txtnomre.Name = "txtnomre";
            this.txtnomre.Size = new System.Drawing.Size(114, 20);
            this.txtnomre.TabIndex = 29;
            // 
            // txtadi
            // 
            this.txtadi.Location = new System.Drawing.Point(16, 43);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(114, 20);
            this.txtadi.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "QIYMETLER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "OTAQLAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "MEYDANCALAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "MUSTERI NOMRESI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Musteri adi";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(273, 198);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 42;
            // 
            // nmnefer
            // 
            this.nmnefer.Location = new System.Drawing.Point(17, 345);
            this.nmnefer.Name = "nmnefer";
            this.nmnefer.Size = new System.Drawing.Size(120, 20);
            this.nmnefer.TabIndex = 43;
            // 
            // numqiymet
            // 
            this.numqiymet.Location = new System.Drawing.Point(12, 298);
            this.numqiymet.Name = "numqiymet";
            this.numqiymet.Size = new System.Drawing.Size(120, 20);
            this.numqiymet.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numqiymet);
            this.Controls.Add(this.nmnefer);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datetarix);
            this.Controls.Add(this.cmbotaq);
            this.Controls.Add(this.cmbmeydanca);
            this.Controls.Add(this.btnrezerv);
            this.Controls.Add(this.txtnomre);
            this.Controls.Add(this.txtadi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmnefer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numqiymet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datetarix;
        private System.Windows.Forms.ComboBox cmbotaq;
        private System.Windows.Forms.ComboBox cmbmeydanca;
        private System.Windows.Forms.Button btnrezerv;
        private System.Windows.Forms.TextBox txtnomre;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown nmnefer;
        private System.Windows.Forms.NumericUpDown numqiymet;
    }
}

