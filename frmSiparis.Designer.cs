
namespace Proje_2
{
    partial class frmSiparis
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
            this.btnSiparisEt = new System.Windows.Forms.Button();
            this.btnSiparisDüzenle = new System.Windows.Forms.Button();
            this.btnSiparisSil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSiparisEt
            // 
            this.btnSiparisEt.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisEt.Location = new System.Drawing.Point(55, 142);
            this.btnSiparisEt.Name = "btnSiparisEt";
            this.btnSiparisEt.Size = new System.Drawing.Size(200, 67);
            this.btnSiparisEt.TabIndex = 0;
            this.btnSiparisEt.Text = "Siparis Olusturma";
            this.btnSiparisEt.UseVisualStyleBackColor = true;
            this.btnSiparisEt.Click += new System.EventHandler(this.btnSiparisEt_Click);
            // 
            // btnSiparisDüzenle
            // 
            this.btnSiparisDüzenle.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisDüzenle.Location = new System.Drawing.Point(308, 142);
            this.btnSiparisDüzenle.Name = "btnSiparisDüzenle";
            this.btnSiparisDüzenle.Size = new System.Drawing.Size(181, 67);
            this.btnSiparisDüzenle.TabIndex = 1;
            this.btnSiparisDüzenle.Text = "Siparis Bilgisi Düzenleme";
            this.btnSiparisDüzenle.UseVisualStyleBackColor = true;
            // 
            // btnSiparisSil
            // 
            this.btnSiparisSil.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisSil.Location = new System.Drawing.Point(542, 142);
            this.btnSiparisSil.Name = "btnSiparisSil";
            this.btnSiparisSil.Size = new System.Drawing.Size(208, 67);
            this.btnSiparisSil.TabIndex = 2;
            this.btnSiparisSil.Text = "Siparis Silme";
            this.btnSiparisSil.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(55, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ana Menüye Dön";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSiparisSil);
            this.Controls.Add(this.btnSiparisDüzenle);
            this.Controls.Add(this.btnSiparisEt);
            this.Name = "frmSiparis";
            this.Text = "frmSiparis";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiparisEt;
        private System.Windows.Forms.Button btnSiparisDüzenle;
        private System.Windows.Forms.Button btnSiparisSil;
        private System.Windows.Forms.Button button1;
    }
}