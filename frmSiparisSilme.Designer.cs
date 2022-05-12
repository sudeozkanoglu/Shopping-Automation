
namespace Proje_2
{
    partial class frmSiparisSilme
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.dataGridSiparis = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSiparis)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(867, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "Menüye Geri Dön";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIptal.Location = new System.Drawing.Point(867, 175);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(190, 42);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "Iptal Et";
            this.btnIptal.UseVisualStyleBackColor = true;
            // 
            // dataGridSiparis
            // 
            this.dataGridSiparis.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSiparis.Location = new System.Drawing.Point(44, 175);
            this.dataGridSiparis.Name = "dataGridSiparis";
            this.dataGridSiparis.RowHeadersWidth = 51;
            this.dataGridSiparis.RowTemplate.Height = 24;
            this.dataGridSiparis.Size = new System.Drawing.Size(817, 353);
            this.dataGridSiparis.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Iptal Etmek Istediginiz Siparisi Seciniz ...";
            // 
            // frmSiparisSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1100, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.dataGridSiparis);
            this.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSiparisSilme";
            this.Text = "frmSiparisSilme";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSiparis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.DataGridView dataGridSiparis;
        private System.Windows.Forms.Label label1;
    }
}