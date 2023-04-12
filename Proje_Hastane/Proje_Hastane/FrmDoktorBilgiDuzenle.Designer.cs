namespace Proje_Hastane
{
    partial class FrmDoktorBilgiDuzenle
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
            this.btnbilgiGuncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbilgiGuncelle
            // 
            this.btnbilgiGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnbilgiGuncelle.Location = new System.Drawing.Point(180, 285);
            this.btnbilgiGuncelle.Name = "btnbilgiGuncelle";
            this.btnbilgiGuncelle.Size = new System.Drawing.Size(172, 46);
            this.btnbilgiGuncelle.TabIndex = 45;
            this.btnbilgiGuncelle.Text = "Kayıt Güncelle";
            this.btnbilgiGuncelle.UseVisualStyleBackColor = false;
            this.btnbilgiGuncelle.Click += new System.EventHandler(this.btnbilgiGuncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 28);
            this.label5.TabIndex = 41;
            this.label5.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(180, 231);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(157, 36);
            this.txtSifre.TabIndex = 40;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(180, 67);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(157, 36);
            this.txtSoyad.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 37;
            this.label1.Text = "Soayd:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(180, 25);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(157, 36);
            this.txtAd.TabIndex = 36;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(180, 119);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(157, 36);
            this.mskTc.TabIndex = 35;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "TC Kimlik No:";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(180, 173);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(157, 36);
            this.cmbBrans.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 28);
            this.label4.TabIndex = 47;
            this.label4.Text = "Branş:";
            // 
            // FrmDoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(427, 372);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.btnbilgiGuncelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "FrmDoktorBilgiDuzenle";
            this.Text = "Dokto rBilgi Duzenle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbilgiGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label label4;
    }
}