
namespace Proje_2
{
    partial class frmStok
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
            this.btnRaf = new System.Windows.Forms.Button();
            this.btnDepoTedarik = new System.Windows.Forms.Button();
            this.grpBoxDepo = new System.Windows.Forms.GroupBox();
            this.grpBoxRaf = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUrün = new System.Windows.Forms.Button();
            this.grpBoxUrün = new System.Windows.Forms.GroupBox();
            this.grpBoxDepo.SuspendLayout();
            this.grpBoxRaf.SuspendLayout();
            this.grpBoxUrün.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRaf
            // 
            this.btnRaf.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaf.Location = new System.Drawing.Point(42, 65);
            this.btnRaf.Name = "btnRaf";
            this.btnRaf.Size = new System.Drawing.Size(200, 67);
            this.btnRaf.TabIndex = 0;
            this.btnRaf.Text = "Rafa Urun Ekleme";
            this.btnRaf.UseVisualStyleBackColor = true;
            // 
            // btnDepoTedarik
            // 
            this.btnDepoTedarik.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepoTedarik.Location = new System.Drawing.Point(30, 123);
            this.btnDepoTedarik.Name = "btnDepoTedarik";
            this.btnDepoTedarik.Size = new System.Drawing.Size(237, 67);
            this.btnDepoTedarik.TabIndex = 1;
            this.btnDepoTedarik.Text = "Depoya Urün Siparis Etme";
            this.btnDepoTedarik.UseVisualStyleBackColor = true;
            this.btnDepoTedarik.Click += new System.EventHandler(this.btnDepoTedarik_Click);
            // 
            // grpBoxDepo
            // 
            this.grpBoxDepo.Controls.Add(this.btnDepoTedarik);
            this.grpBoxDepo.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDepo.Location = new System.Drawing.Point(311, 48);
            this.grpBoxDepo.Name = "grpBoxDepo";
            this.grpBoxDepo.Size = new System.Drawing.Size(296, 332);
            this.grpBoxDepo.TabIndex = 2;
            this.grpBoxDepo.TabStop = false;
            this.grpBoxDepo.Text = "Depo Islemleri";
            // 
            // grpBoxRaf
            // 
            this.grpBoxRaf.Controls.Add(this.button1);
            this.grpBoxRaf.Controls.Add(this.btnRaf);
            this.grpBoxRaf.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxRaf.Location = new System.Drawing.Point(12, 48);
            this.grpBoxRaf.Name = "grpBoxRaf";
            this.grpBoxRaf.Size = new System.Drawing.Size(279, 332);
            this.grpBoxRaf.TabIndex = 3;
            this.grpBoxRaf.TabStop = false;
            this.grpBoxRaf.Text = "Raf Islemleri";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Raftan Urun Kaldırma";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnUrün
            // 
            this.btnUrün.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrün.Location = new System.Drawing.Point(42, 123);
            this.btnUrün.Name = "btnUrün";
            this.btnUrün.Size = new System.Drawing.Size(211, 67);
            this.btnUrün.TabIndex = 2;
            this.btnUrün.Text = "Urün Bilgisi Ekleme";
            this.btnUrün.UseVisualStyleBackColor = true;
            this.btnUrün.Click += new System.EventHandler(this.btnUrün_Click);
            // 
            // grpBoxUrün
            // 
            this.grpBoxUrün.Controls.Add(this.btnUrün);
            this.grpBoxUrün.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxUrün.Location = new System.Drawing.Point(654, 48);
            this.grpBoxUrün.Name = "grpBoxUrün";
            this.grpBoxUrün.Size = new System.Drawing.Size(300, 332);
            this.grpBoxUrün.TabIndex = 4;
            this.grpBoxUrün.TabStop = false;
            this.grpBoxUrün.Text = "Urün Islemleri";
            // 
            // frmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 450);
            this.Controls.Add(this.grpBoxUrün);
            this.Controls.Add(this.grpBoxRaf);
            this.Controls.Add(this.grpBoxDepo);
            this.Name = "frmStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok İşlemleri";
            this.grpBoxDepo.ResumeLayout(false);
            this.grpBoxRaf.ResumeLayout(false);
            this.grpBoxUrün.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRaf;
        private System.Windows.Forms.Button btnDepoTedarik;
        private System.Windows.Forms.GroupBox grpBoxDepo;
        private System.Windows.Forms.GroupBox grpBoxRaf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUrün;
        private System.Windows.Forms.GroupBox grpBoxUrün;
    }
}