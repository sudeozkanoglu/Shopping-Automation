
namespace Proje_2
{
    partial class frmTdrkListSil
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTdrk = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTdrk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "TUM TEDARIKCILERIN LISTESI";
            // 
            // dataGridViewTdrk
            // 
            this.dataGridViewTdrk.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTdrk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTdrk.Location = new System.Drawing.Point(50, 170);
            this.dataGridViewTdrk.Name = "dataGridViewTdrk";
            this.dataGridViewTdrk.RowHeadersWidth = 51;
            this.dataGridViewTdrk.RowTemplate.Height = 24;
            this.dataGridViewTdrk.Size = new System.Drawing.Size(817, 353);
            this.dataGridViewTdrk.TabIndex = 4;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(907, 170);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(155, 43);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "SIL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(907, 294);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(155, 47);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Menüye Dön";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmTdrkListSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1100, 703);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridViewTdrk);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTdrkListSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTdrkListSil";
            this.Load += new System.EventHandler(this.frmTdrkListSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTdrk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTdrk;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnMenu;
    }
}