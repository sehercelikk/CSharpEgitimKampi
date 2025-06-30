namespace CSharpKampi601
{
    partial class FrmEmployee
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
            this.btnGetById = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetById
            // 
            this.btnGetById.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGetById.Location = new System.Drawing.Point(91, 313);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(126, 23);
            this.btnGetById.TabIndex = 66;
            this.btnGetById.Text = "Id\'ye Göre Ara";
            this.btnGetById.UseVisualStyleBackColor = false;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(263, 12);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(480, 324);
            this.DataGridView1.TabIndex = 65;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.Location = new System.Drawing.Point(91, 281);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(126, 23);
            this.btnSil.TabIndex = 64;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.Location = new System.Drawing.Point(91, 249);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(126, 23);
            this.btnGuncelle.TabIndex = 63;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEkle.Location = new System.Drawing.Point(91, 211);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(126, 23);
            this.btnEkle.TabIndex = 62;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListele.Location = new System.Drawing.Point(91, 175);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(126, 23);
            this.btnListele.TabIndex = 61;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(78, 113);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(153, 20);
            this.txtMaas.TabIndex = 60;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(40, 117);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(36, 13);
            this.Label4.TabIndex = 59;
            this.Label4.Text = "Maaş:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(78, 81);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(153, 20);
            this.txtSoyad.TabIndex = 58;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(36, 85);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(40, 13);
            this.Label3.TabIndex = 57;
            this.Label3.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(78, 51);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(153, 20);
            this.txtAd.TabIndex = 56;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 55);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(67, 13);
            this.Label2.TabIndex = 55;
            this.Label2.Text = "Personel Ad:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(78, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(153, 20);
            this.txtId.TabIndex = 54;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(57, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(19, 13);
            this.Label1.TabIndex = 53;
            this.Label1.Text = "Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Departman:";
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(78, 140);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(153, 21);
            this.cmbDepartman.TabIndex = 69;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 342);
            this.Controls.Add(this.cmbDepartman);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Label1);
            this.Name = "FrmEmployee";
            this.Text = "FrmEmployee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnGetById;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Button btnSil;
        internal System.Windows.Forms.Button btnGuncelle;
        internal System.Windows.Forms.Button btnEkle;
        internal System.Windows.Forms.Button btnListele;
        internal System.Windows.Forms.TextBox txtMaas;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtSoyad;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtAd;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDepartman;
    }
}