namespace RomaliAskerProblemi
{
    partial class frmRomaliAsker
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
            this.btnKalanAsker = new System.Windows.Forms.Button();
            this.lblAskerSayisi = new System.Windows.Forms.Label();
            this.lblAdimSayisi = new System.Windows.Forms.Label();
            this.txtAskerSayisi = new System.Windows.Forms.TextBox();
            this.txtAdimSayisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKalanAsker
            // 
            this.btnKalanAsker.Location = new System.Drawing.Point(88, 95);
            this.btnKalanAsker.Name = "btnKalanAsker";
            this.btnKalanAsker.Size = new System.Drawing.Size(138, 23);
            this.btnKalanAsker.TabIndex = 0;
            this.btnKalanAsker.Text = "Kalan Askerleri Bul";
            this.btnKalanAsker.UseVisualStyleBackColor = true;
            this.btnKalanAsker.Click += new System.EventHandler(this.btnKalanAsker_Click);
            // 
            // lblAskerSayisi
            // 
            this.lblAskerSayisi.AutoSize = true;
            this.lblAskerSayisi.Location = new System.Drawing.Point(12, 26);
            this.lblAskerSayisi.Name = "lblAskerSayisi";
            this.lblAskerSayisi.Size = new System.Drawing.Size(73, 13);
            this.lblAskerSayisi.TabIndex = 1;
            this.lblAskerSayisi.Text = "Asker Sayısı : ";
            // 
            // lblAdimSayisi
            // 
            this.lblAdimSayisi.AutoSize = true;
            this.lblAdimSayisi.Location = new System.Drawing.Point(13, 61);
            this.lblAdimSayisi.Name = "lblAdimSayisi";
            this.lblAdimSayisi.Size = new System.Drawing.Size(69, 13);
            this.lblAdimSayisi.TabIndex = 2;
            this.lblAdimSayisi.Text = "Adım Sayısı : ";
            // 
            // txtAskerSayisi
            // 
            this.txtAskerSayisi.Location = new System.Drawing.Point(88, 23);
            this.txtAskerSayisi.Name = "txtAskerSayisi";
            this.txtAskerSayisi.Size = new System.Drawing.Size(138, 20);
            this.txtAskerSayisi.TabIndex = 3;
            // 
            // txtAdimSayisi
            // 
            this.txtAdimSayisi.Location = new System.Drawing.Point(88, 58);
            this.txtAdimSayisi.Name = "txtAdimSayisi";
            this.txtAdimSayisi.Size = new System.Drawing.Size(138, 20);
            this.txtAdimSayisi.TabIndex = 4;
            // 
            // frmRomaliAsker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 135);
            this.Controls.Add(this.txtAdimSayisi);
            this.Controls.Add(this.txtAskerSayisi);
            this.Controls.Add(this.lblAdimSayisi);
            this.Controls.Add(this.lblAskerSayisi);
            this.Controls.Add(this.btnKalanAsker);
            this.Name = "frmRomaliAsker";
            this.Text = "Romalı Asker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKalanAsker;
        private System.Windows.Forms.Label lblAskerSayisi;
        private System.Windows.Forms.Label lblAdimSayisi;
        private System.Windows.Forms.TextBox txtAskerSayisi;
        private System.Windows.Forms.TextBox txtAdimSayisi;
    }
}

