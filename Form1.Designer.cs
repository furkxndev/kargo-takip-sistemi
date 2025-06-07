namespace KargoTakipSistemi
{
    partial class Form1
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
            this.lblTakipNo = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtTakipNo = new System.Windows.Forms.TextBox();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dgvGonderiler = new System.Windows.Forms.DataGridView();
            this.grpGonderiIslemleri = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGonderiler)).BeginInit();
            this.grpGonderiIslemleri.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTakipNo
            // 
            this.lblTakipNo.AutoSize = true;
            this.lblTakipNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTakipNo.Location = new System.Drawing.Point(11, 26);
            this.lblTakipNo.Name = "lblTakipNo";
            this.lblTakipNo.Size = new System.Drawing.Size(145, 31);
            this.lblTakipNo.TabIndex = 0;
            this.lblTakipNo.Text = "Takip No : ";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTip.Location = new System.Drawing.Point(11, 66);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(183, 31);
            this.lblTip.TabIndex = 1;
            this.lblTip.Text = "Gonderi Tipi : ";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(11, 106);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(235, 31);
            this.lblDurum.TabIndex = 2;
            this.lblDurum.Text = "Gonderi Durumu : ";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(6, 27);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 18);
            this.lblSonuc.TabIndex = 3;
            // 
            // txtTakipNo
            // 
            this.txtTakipNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTakipNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTakipNo.Location = new System.Drawing.Point(238, 26);
            this.txtTakipNo.Name = "txtTakipNo";
            this.txtTakipNo.Size = new System.Drawing.Size(150, 31);
            this.txtTakipNo.TabIndex = 4;
            // 
            // cmbTip
            // 
            this.cmbTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(238, 66);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(150, 33);
            this.cmbTip.TabIndex = 5;
            // 
            // cmbDurum
            // 
            this.cmbDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(238, 109);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(150, 33);
            this.cmbDurum.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEkle.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.Cyan;
            this.btnEkle.Location = new System.Drawing.Point(29, 208);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(371, 47);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSorgula
            // 
            this.btnSorgula.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSorgula.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSorgula.ForeColor = System.Drawing.Color.Cyan;
            this.btnSorgula.Location = new System.Drawing.Point(237, 261);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(163, 59);
            this.btnSorgula.TabIndex = 8;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = false;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Cyan;
            this.btnGuncelle.Location = new System.Drawing.Point(29, 261);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(163, 59);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dgvGonderiler
            // 
            this.dgvGonderiler.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvGonderiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGonderiler.Location = new System.Drawing.Point(454, 1);
            this.dgvGonderiler.Name = "dgvGonderiler";
            this.dgvGonderiler.Size = new System.Drawing.Size(361, 447);
            this.dgvGonderiler.TabIndex = 11;
            // 
            // grpGonderiIslemleri
            // 
            this.grpGonderiIslemleri.BackColor = System.Drawing.Color.White;
            this.grpGonderiIslemleri.Controls.Add(this.txtTakipNo);
            this.grpGonderiIslemleri.Controls.Add(this.cmbTip);
            this.grpGonderiIslemleri.Controls.Add(this.cmbDurum);
            this.grpGonderiIslemleri.Controls.Add(this.lblTakipNo);
            this.grpGonderiIslemleri.Controls.Add(this.lblTip);
            this.grpGonderiIslemleri.Controls.Add(this.lblDurum);
            this.grpGonderiIslemleri.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpGonderiIslemleri.Location = new System.Drawing.Point(12, 21);
            this.grpGonderiIslemleri.Name = "grpGonderiIslemleri";
            this.grpGonderiIslemleri.Size = new System.Drawing.Size(422, 168);
            this.grpGonderiIslemleri.TabIndex = 12;
            this.grpGonderiIslemleri.TabStop = false;
            this.grpGonderiIslemleri.Text = "Gönderi İşlemleri";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblSonuc);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 61);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorgu Durumu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.grpGonderiIslemleri);
            this.Controls.Add(this.dgvGonderiler);
            this.Name = "Form1";
            this.Text = "Kargo Takip Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGonderiler)).EndInit();
            this.grpGonderiIslemleri.ResumeLayout(false);
            this.grpGonderiIslemleri.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTakipNo;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtTakipNo;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dgvGonderiler;
        private System.Windows.Forms.GroupBox grpGonderiIslemleri;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

