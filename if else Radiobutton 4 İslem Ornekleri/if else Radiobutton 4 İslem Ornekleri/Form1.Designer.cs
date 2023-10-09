namespace if_else_Radiobutton_4_İslem_Ornekleri
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
            this.grbIslemler = new System.Windows.Forms.GroupBox();
            this.rbTopla = new System.Windows.Forms.RadioButton();
            this.rbCıkar = new System.Windows.Forms.RadioButton();
            this.rbCarp = new System.Windows.Forms.RadioButton();
            this.rbBol = new System.Windows.Forms.RadioButton();
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.grbIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbIslemler
            // 
            this.grbIslemler.Controls.Add(this.rbBol);
            this.grbIslemler.Controls.Add(this.rbCarp);
            this.grbIslemler.Controls.Add(this.rbCıkar);
            this.grbIslemler.Controls.Add(this.rbTopla);
            this.grbIslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbIslemler.Location = new System.Drawing.Point(12, 26);
            this.grbIslemler.Name = "grbIslemler";
            this.grbIslemler.Size = new System.Drawing.Size(328, 120);
            this.grbIslemler.TabIndex = 0;
            this.grbIslemler.TabStop = false;
            this.grbIslemler.Text = "İŞLEMLER";
            // 
            // rbTopla
            // 
            this.rbTopla.AutoSize = true;
            this.rbTopla.Location = new System.Drawing.Point(17, 54);
            this.rbTopla.Name = "rbTopla";
            this.rbTopla.Size = new System.Drawing.Size(57, 17);
            this.rbTopla.TabIndex = 0;
            this.rbTopla.TabStop = true;
            this.rbTopla.Text = "Topla";
            this.rbTopla.UseVisualStyleBackColor = true;
            // 
            // rbCıkar
            // 
            this.rbCıkar.AutoSize = true;
            this.rbCıkar.Location = new System.Drawing.Point(96, 54);
            this.rbCıkar.Name = "rbCıkar";
            this.rbCıkar.Size = new System.Drawing.Size(54, 17);
            this.rbCıkar.TabIndex = 1;
            this.rbCıkar.TabStop = true;
            this.rbCıkar.Text = "Çıkar";
            this.rbCıkar.UseVisualStyleBackColor = true;
            // 
            // rbCarp
            // 
            this.rbCarp.AutoSize = true;
            this.rbCarp.Location = new System.Drawing.Point(178, 54);
            this.rbCarp.Name = "rbCarp";
            this.rbCarp.Size = new System.Drawing.Size(51, 17);
            this.rbCarp.TabIndex = 2;
            this.rbCarp.TabStop = true;
            this.rbCarp.Text = "Çarp";
            this.rbCarp.UseVisualStyleBackColor = true;
            // 
            // rbBol
            // 
            this.rbBol.AutoSize = true;
            this.rbBol.Location = new System.Drawing.Point(257, 54);
            this.rbBol.Name = "rbBol";
            this.rbBol.Size = new System.Drawing.Size(43, 17);
            this.rbBol.TabIndex = 3;
            this.rbBol.TabStop = true;
            this.rbBol.Text = "Böl";
            this.rbBol.UseVisualStyleBackColor = true;
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi1.ForeColor = System.Drawing.Color.Black;
            this.lblSayi1.Location = new System.Drawing.Point(22, 170);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(42, 13);
            this.lblSayi1.TabIndex = 1;
            this.lblSayi1.Text = "1.Sayı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "2.Sayı";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(81, 167);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtSayi1.TabIndex = 3;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(81, 207);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 4;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHesapla.Location = new System.Drawing.Point(81, 253);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 33);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(219, 240);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(47, 13);
            this.lblSonuc.TabIndex = 6;
            this.lblSonuc.Text = "Sonuç:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(366, 316);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSayi1);
            this.Controls.Add(this.grbIslemler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbIslemler.ResumeLayout(false);
            this.grbIslemler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbIslemler;
        private System.Windows.Forms.RadioButton rbBol;
        private System.Windows.Forms.RadioButton rbCarp;
        private System.Windows.Forms.RadioButton rbCıkar;
        private System.Windows.Forms.RadioButton rbTopla;
        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
    }
}

