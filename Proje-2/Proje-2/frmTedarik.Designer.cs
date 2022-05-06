
namespace Proje_2
{
    partial class frmTedarik
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
            this.btnTdrkEkle = new System.Windows.Forms.Button();
            this.btnTdrkGuncelle = new System.Windows.Forms.Button();
            this.btnTdrkListSil = new System.Windows.Forms.Button();
            this.btnAna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTdrkEkle
            // 
            this.btnTdrkEkle.Location = new System.Drawing.Point(26, 237);
            this.btnTdrkEkle.Name = "btnTdrkEkle";
            this.btnTdrkEkle.Size = new System.Drawing.Size(157, 34);
            this.btnTdrkEkle.TabIndex = 0;
            this.btnTdrkEkle.Text = "Tedarikçi Ekle";
            this.btnTdrkEkle.UseVisualStyleBackColor = true;
            this.btnTdrkEkle.Click += new System.EventHandler(this.btnTdrkEkle_Click);
            // 
            // btnTdrkGuncelle
            // 
            this.btnTdrkGuncelle.Location = new System.Drawing.Point(263, 237);
            this.btnTdrkGuncelle.Name = "btnTdrkGuncelle";
            this.btnTdrkGuncelle.Size = new System.Drawing.Size(212, 34);
            this.btnTdrkGuncelle.TabIndex = 1;
            this.btnTdrkGuncelle.Text = "Tedarikçi Güncelleme";
            this.btnTdrkGuncelle.UseVisualStyleBackColor = true;
            this.btnTdrkGuncelle.Click += new System.EventHandler(this.btnTdrkGuncelle_Click);
            // 
            // btnTdrkListSil
            // 
            this.btnTdrkListSil.Location = new System.Drawing.Point(555, 237);
            this.btnTdrkListSil.Name = "btnTdrkListSil";
            this.btnTdrkListSil.Size = new System.Drawing.Size(273, 34);
            this.btnTdrkListSil.TabIndex = 2;
            this.btnTdrkListSil.Text = "Tedarikçi Listeleme ve Silme";
            this.btnTdrkListSil.UseVisualStyleBackColor = true;
            this.btnTdrkListSil.Click += new System.EventHandler(this.btnTdrkListSil_Click);
            // 
            // btnAna
            // 
            this.btnAna.Location = new System.Drawing.Point(26, 529);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(157, 34);
            this.btnAna.TabIndex = 3;
            this.btnAna.Text = "Ana Menüye Dön";
            this.btnAna.UseVisualStyleBackColor = true;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // frmTedarik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(857, 587);
            this.Controls.Add(this.btnAna);
            this.Controls.Add(this.btnTdrkListSil);
            this.Controls.Add(this.btnTdrkGuncelle);
            this.Controls.Add(this.btnTdrkEkle);
            this.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTedarik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarikçi İşlemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTdrkEkle;
        private System.Windows.Forms.Button btnTdrkGuncelle;
        private System.Windows.Forms.Button btnTdrkListSil;
        private System.Windows.Forms.Button btnAna;
    }
}