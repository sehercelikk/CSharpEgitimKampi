namespace CSharpKampi601
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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnGetById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(257, 61);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(560, 333);
            this.DataGridView1.TabIndex = 33;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.Location = new System.Drawing.Point(84, 365);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(126, 23);
            this.btnSil.TabIndex = 32;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.Location = new System.Drawing.Point(84, 333);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(126, 23);
            this.btnGuncelle.TabIndex = 31;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEkle.Location = new System.Drawing.Point(84, 295);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(126, 23);
            this.btnEkle.TabIndex = 30;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListele.Location = new System.Drawing.Point(84, 255);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(126, 23);
            this.btnListele.TabIndex = 29;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(72, 210);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(153, 20);
            this.txtTutar.TabIndex = 28;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(-16, 214);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(78, 13);
            this.Label6.TabIndex = 27;
            this.Label6.Text = "Alişveriş Tutarı:";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(72, 178);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(153, 20);
            this.txtBakiye.TabIndex = 26;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(20, 182);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(42, 13);
            this.Label5.TabIndex = 25;
            this.Label5.Text = "Bakiye:";
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(72, 148);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(153, 20);
            this.txtSehir.TabIndex = 24;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(28, 152);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(34, 13);
            this.Label4.TabIndex = 23;
            this.Label4.Text = "Şehir:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(72, 116);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(153, 20);
            this.txtSoyad.TabIndex = 22;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(22, 120);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(40, 13);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(72, 86);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(153, 20);
            this.txtAd.TabIndex = 20;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(39, 90);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(23, 13);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "Ad:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(72, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(153, 20);
            this.txtId.TabIndex = 18;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(43, 61);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(19, 13);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "Id:";
            // 
            // btnGetById
            // 
            this.btnGetById.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGetById.Location = new System.Drawing.Point(84, 400);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(126, 23);
            this.btnGetById.TabIndex = 34;
            this.btnGetById.Text = "Id\'ye Göre Ara";
            this.btnGetById.UseVisualStyleBackColor = false;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Button btnSil;
        internal System.Windows.Forms.Button btnGuncelle;
        internal System.Windows.Forms.Button btnEkle;
        internal System.Windows.Forms.Button btnListele;
        internal System.Windows.Forms.TextBox txtTutar;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtBakiye;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtSehir;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtSoyad;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtAd;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnGetById;
    }
}

