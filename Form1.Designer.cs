namespace MayinTarlasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radio_zor = new System.Windows.Forms.RadioButton();
            this.radio_orta = new System.Windows.Forms.RadioButton();
            this.radio_kolay = new System.Windows.Forms.RadioButton();
            this.btn_oyna = new System.Windows.Forms.Button();
            this.lbl_puan = new System.Windows.Forms.Label();
            this.lbl_mayin_sayisi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(529, 523);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = "";
            this.panel1.AccessibleName = "";
            this.panel1.Controls.Add(this.radio_zor);
            this.panel1.Controls.Add(this.radio_orta);
            this.panel1.Controls.Add(this.radio_kolay);
            this.panel1.Location = new System.Drawing.Point(588, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 124);
            this.panel1.TabIndex = 1;
            this.panel1.Tag = "";
            // 
            // radio_zor
            // 
            this.radio_zor.AutoSize = true;
            this.radio_zor.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_zor.ForeColor = System.Drawing.Color.BurlyWood;
            this.radio_zor.Location = new System.Drawing.Point(16, 83);
            this.radio_zor.Name = "radio_zor";
            this.radio_zor.Size = new System.Drawing.Size(56, 19);
            this.radio_zor.TabIndex = 2;
            this.radio_zor.TabStop = true;
            this.radio_zor.Text = "Zor";
            this.radio_zor.UseVisualStyleBackColor = true;
            this.radio_zor.CheckedChanged += new System.EventHandler(this.radio_zor_CheckedChanged);
            // 
            // radio_orta
            // 
            this.radio_orta.AutoSize = true;
            this.radio_orta.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_orta.ForeColor = System.Drawing.Color.BurlyWood;
            this.radio_orta.Location = new System.Drawing.Point(16, 57);
            this.radio_orta.Name = "radio_orta";
            this.radio_orta.Size = new System.Drawing.Size(66, 19);
            this.radio_orta.TabIndex = 1;
            this.radio_orta.TabStop = true;
            this.radio_orta.Text = "Orta";
            this.radio_orta.UseVisualStyleBackColor = true;
            this.radio_orta.CheckedChanged += new System.EventHandler(this.radio_orta_CheckedChanged);
            // 
            // radio_kolay
            // 
            this.radio_kolay.AutoSize = true;
            this.radio_kolay.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_kolay.ForeColor = System.Drawing.Color.BurlyWood;
            this.radio_kolay.Location = new System.Drawing.Point(16, 30);
            this.radio_kolay.Name = "radio_kolay";
            this.radio_kolay.Size = new System.Drawing.Size(73, 19);
            this.radio_kolay.TabIndex = 0;
            this.radio_kolay.TabStop = true;
            this.radio_kolay.Text = "Kolay";
            this.radio_kolay.UseVisualStyleBackColor = true;
            this.radio_kolay.CheckedChanged += new System.EventHandler(this.radio_kolay_CheckedChanged);
            // 
            // btn_oyna
            // 
            this.btn_oyna.BackColor = System.Drawing.Color.Tan;
            this.btn_oyna.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_oyna.ForeColor = System.Drawing.Color.Brown;
            this.btn_oyna.Location = new System.Drawing.Point(588, 170);
            this.btn_oyna.Name = "btn_oyna";
            this.btn_oyna.Size = new System.Drawing.Size(200, 54);
            this.btn_oyna.TabIndex = 2;
            this.btn_oyna.Text = "OYNA";
            this.btn_oyna.UseVisualStyleBackColor = false;
            this.btn_oyna.Click += new System.EventHandler(this.btn_oyna_Click);
            // 
            // lbl_puan
            // 
            this.lbl_puan.AutoSize = true;
            this.lbl_puan.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_puan.ForeColor = System.Drawing.Color.BurlyWood;
            this.lbl_puan.Location = new System.Drawing.Point(585, 282);
            this.lbl_puan.Name = "lbl_puan";
            this.lbl_puan.Size = new System.Drawing.Size(70, 23);
            this.lbl_puan.TabIndex = 3;
            this.lbl_puan.Text = "PUAN:";
            // 
            // lbl_mayin_sayisi
            // 
            this.lbl_mayin_sayisi.AutoSize = true;
            this.lbl_mayin_sayisi.Location = new System.Drawing.Point(588, 231);
            this.lbl_mayin_sayisi.Name = "lbl_mayin_sayisi";
            this.lbl_mayin_sayisi.Size = new System.Drawing.Size(16, 16);
            this.lbl_mayin_sayisi.TabIndex = 4;
            this.lbl_mayin_sayisi.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(804, 550);
            this.Controls.Add(this.lbl_mayin_sayisi);
            this.Controls.Add(this.lbl_puan);
            this.Controls.Add(this.btn_oyna);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mayın Tarlası";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radio_zor;
        private System.Windows.Forms.RadioButton radio_orta;
        private System.Windows.Forms.RadioButton radio_kolay;
        private System.Windows.Forms.Button btn_oyna;
        private System.Windows.Forms.Label lbl_puan;
        private System.Windows.Forms.Label lbl_mayin_sayisi;
    }
}

