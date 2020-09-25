namespace PROJE2Dictionary
{
    partial class Kelime_Ekle
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
            this.txturkce = new System.Windows.Forms.TextBox();
            this.txtrusca = new System.Windows.Forms.TextBox();
            this.txtokunus = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblturkce = new System.Windows.Forms.Label();
            this.lblRusca = new System.Windows.Forms.Label();
            this.lblOkunus = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txturkce
            // 
            this.txturkce.Location = new System.Drawing.Point(140, 26);
            this.txturkce.Name = "txturkce";
            this.txturkce.Size = new System.Drawing.Size(100, 20);
            this.txturkce.TabIndex = 0;
            // 
            // txtrusca
            // 
            this.txtrusca.Location = new System.Drawing.Point(140, 52);
            this.txtrusca.Name = "txtrusca";
            this.txtrusca.Size = new System.Drawing.Size(100, 20);
            this.txtrusca.TabIndex = 1;
            // 
            // txtokunus
            // 
            this.txtokunus.Location = new System.Drawing.Point(140, 78);
            this.txtokunus.Name = "txtokunus";
            this.txtokunus.Size = new System.Drawing.Size(100, 20);
            this.txtokunus.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(140, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblturkce
            // 
            this.lblturkce.AutoSize = true;
            this.lblturkce.Location = new System.Drawing.Point(13, 32);
            this.lblturkce.Name = "lblturkce";
            this.lblturkce.Size = new System.Drawing.Size(48, 13);
            this.lblturkce.TabIndex = 4;
            this.lblturkce.Text = "Türkçesi";
            // 
            // lblRusca
            // 
            this.lblRusca.AutoSize = true;
            this.lblRusca.Location = new System.Drawing.Point(13, 58);
            this.lblRusca.Name = "lblRusca";
            this.lblRusca.Size = new System.Drawing.Size(45, 13);
            this.lblRusca.TabIndex = 5;
            this.lblRusca.Text = "Rusçası";
            // 
            // lblOkunus
            // 
            this.lblOkunus.AutoSize = true;
            this.lblOkunus.Location = new System.Drawing.Point(13, 84);
            this.lblOkunus.Name = "lblOkunus";
            this.lblOkunus.Size = new System.Drawing.Size(50, 13);
            this.lblOkunus.TabIndex = 6;
            this.lblOkunus.Text = "Okunuşu";
            // 
            // btnGeri
            // 
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Location = new System.Drawing.Point(16, 114);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(98, 23);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "GERI";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // Kelime_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 214);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblOkunus);
            this.Controls.Add(this.lblRusca);
            this.Controls.Add(this.lblturkce);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtokunus);
            this.Controls.Add(this.txtrusca);
            this.Controls.Add(this.txturkce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kelime_Ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime_Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txturkce;
        private System.Windows.Forms.TextBox txtrusca;
        private System.Windows.Forms.TextBox txtokunus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblturkce;
        private System.Windows.Forms.Label lblRusca;
        private System.Windows.Forms.Label lblOkunus;
        private System.Windows.Forms.Button btnGeri;
    }
}