namespace Kdv_Hesabı
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tutar_al_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uygulanan_kdv_yuzdesi_lbl = new System.Windows.Forms.Label();
            this.kdv_tutar_lbl = new System.Windows.Forms.Label();
            this.toplam_fiyat_lbl = new System.Windows.Forms.Label();
            this.temel_gıda_chck = new System.Windows.Forms.RadioButton();
            this.tekstil_urun_chck = new System.Windows.Forms.RadioButton();
            this.beyaz_esya_chck = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(116, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alışveriş Tutarı :";
            // 
            // tutar_al_txt
            // 
            this.tutar_al_txt.Location = new System.Drawing.Point(138, 15);
            this.tutar_al_txt.Name = "tutar_al_txt";
            this.tutar_al_txt.Size = new System.Drawing.Size(144, 20);
            this.tutar_al_txt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(89, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ürünün Türünü Seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(125, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "KDV Tutarı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(2, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ürünün Toplam Fiyatı (KDV dahil) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(45, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Uygulanan KDV Yüzdesi :";
            // 
            // uygulanan_kdv_yuzdesi_lbl
            // 
            this.uygulanan_kdv_yuzdesi_lbl.AutoSize = true;
            this.uygulanan_kdv_yuzdesi_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uygulanan_kdv_yuzdesi_lbl.Location = new System.Drawing.Point(233, 273);
            this.uygulanan_kdv_yuzdesi_lbl.Name = "uygulanan_kdv_yuzdesi_lbl";
            this.uygulanan_kdv_yuzdesi_lbl.Size = new System.Drawing.Size(84, 16);
            this.uygulanan_kdv_yuzdesi_lbl.TabIndex = 10;
            this.uygulanan_kdv_yuzdesi_lbl.Text = "___________";
            // 
            // kdv_tutar_lbl
            // 
            this.kdv_tutar_lbl.AutoSize = true;
            this.kdv_tutar_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kdv_tutar_lbl.Location = new System.Drawing.Point(233, 299);
            this.kdv_tutar_lbl.Name = "kdv_tutar_lbl";
            this.kdv_tutar_lbl.Size = new System.Drawing.Size(84, 16);
            this.kdv_tutar_lbl.TabIndex = 11;
            this.kdv_tutar_lbl.Text = "___________";
            // 
            // toplam_fiyat_lbl
            // 
            this.toplam_fiyat_lbl.AutoSize = true;
            this.toplam_fiyat_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplam_fiyat_lbl.Location = new System.Drawing.Point(233, 325);
            this.toplam_fiyat_lbl.Name = "toplam_fiyat_lbl";
            this.toplam_fiyat_lbl.Size = new System.Drawing.Size(84, 16);
            this.toplam_fiyat_lbl.TabIndex = 12;
            this.toplam_fiyat_lbl.Text = "___________";
            // 
            // temel_gıda_chck
            // 
            this.temel_gıda_chck.AutoSize = true;
            this.temel_gıda_chck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temel_gıda_chck.Location = new System.Drawing.Point(108, 94);
            this.temel_gıda_chck.Name = "temel_gıda_chck";
            this.temel_gıda_chck.Size = new System.Drawing.Size(96, 20);
            this.temel_gıda_chck.TabIndex = 13;
            this.temel_gıda_chck.TabStop = true;
            this.temel_gıda_chck.Text = "Temel Gıda";
            this.temel_gıda_chck.UseVisualStyleBackColor = true;
            // 
            // tekstil_urun_chck
            // 
            this.tekstil_urun_chck.AutoSize = true;
            this.tekstil_urun_chck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tekstil_urun_chck.Location = new System.Drawing.Point(108, 130);
            this.tekstil_urun_chck.Name = "tekstil_urun_chck";
            this.tekstil_urun_chck.Size = new System.Drawing.Size(103, 20);
            this.tekstil_urun_chck.TabIndex = 14;
            this.tekstil_urun_chck.TabStop = true;
            this.tekstil_urun_chck.Text = "Tekstil Ürünü";
            this.tekstil_urun_chck.UseVisualStyleBackColor = true;
            // 
            // beyaz_esya_chck
            // 
            this.beyaz_esya_chck.AutoSize = true;
            this.beyaz_esya_chck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.beyaz_esya_chck.Location = new System.Drawing.Point(109, 165);
            this.beyaz_esya_chck.Name = "beyaz_esya_chck";
            this.beyaz_esya_chck.Size = new System.Drawing.Size(97, 20);
            this.beyaz_esya_chck.TabIndex = 15;
            this.beyaz_esya_chck.TabStop = true;
            this.beyaz_esya_chck.Text = "Beyaz Eşya";
            this.beyaz_esya_chck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(340, 363);
            this.Controls.Add(this.beyaz_esya_chck);
            this.Controls.Add(this.tekstil_urun_chck);
            this.Controls.Add(this.temel_gıda_chck);
            this.Controls.Add(this.toplam_fiyat_lbl);
            this.Controls.Add(this.kdv_tutar_lbl);
            this.Controls.Add(this.uygulanan_kdv_yuzdesi_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tutar_al_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "KDV Hesaplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tutar_al_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label uygulanan_kdv_yuzdesi_lbl;
        private System.Windows.Forms.Label kdv_tutar_lbl;
        private System.Windows.Forms.Label toplam_fiyat_lbl;
        private System.Windows.Forms.RadioButton temel_gıda_chck;
        private System.Windows.Forms.RadioButton tekstil_urun_chck;
        private System.Windows.Forms.RadioButton beyaz_esya_chck;
    }
}

