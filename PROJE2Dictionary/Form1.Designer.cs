namespace PROJE2Dictionary
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
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.lblGiris = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstCeviri = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCeviri = new System.Windows.Forms.TextBox();
            this.btngizle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGiris
            // 
            this.txtGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGiris.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtGiris.Location = new System.Drawing.Point(47, 89);
            this.txtGiris.Multiline = true;
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Size = new System.Drawing.Size(476, 31);
            this.txtGiris.TabIndex = 0;
            this.txtGiris.Text = "Türkçe..";
            this.txtGiris.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtGiris.Enter += new System.EventHandler(this.txtGiris_Enter);
            this.txtGiris.Leave += new System.EventHandler(this.txtGiris_Leave);
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGiris.Location = new System.Drawing.Point(44, 68);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(132, 18);
            this.lblGiris.TabIndex = 2;
            this.lblGiris.Text = "Bir sözcuk giriniz";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBaslik.Location = new System.Drawing.Point(130, 34);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(328, 34);
            this.lblBaslik.TabIndex = 5;
            this.lblBaslik.Text = "TURKISH - RUSSIAN ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(584, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 23);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lstCeviri
            // 
            this.lstCeviri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstCeviri.FormattingEnabled = true;
            this.lstCeviri.ItemHeight = 20;
            this.lstCeviri.Location = new System.Drawing.Point(47, 257);
            this.lstCeviri.Name = "lstCeviri";
            this.lstCeviri.Size = new System.Drawing.Size(476, 164);
            this.lstCeviri.TabIndex = 11;
            this.lstCeviri.Visible = false;
            this.lstCeviri.SelectedIndexChanged += new System.EventHandler(this.lstCeviri_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(47, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(476, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "KELIMELERI GÖSTER";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCeviri
            // 
            this.txtCeviri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCeviri.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtCeviri.Location = new System.Drawing.Point(47, 152);
            this.txtCeviri.Multiline = true;
            this.txtCeviri.Name = "txtCeviri";
            this.txtCeviri.Size = new System.Drawing.Size(476, 31);
            this.txtCeviri.TabIndex = 14;
            this.txtCeviri.TextChanged += new System.EventHandler(this.txtCeviri_TextChanged);
            // 
            // btngizle
            // 
            this.btngizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngizle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btngizle.Location = new System.Drawing.Point(47, 228);
            this.btngizle.Name = "btngizle";
            this.btngizle.Size = new System.Drawing.Size(476, 23);
            this.btngizle.TabIndex = 15;
            this.btngizle.Text = "KELIMELERI GIZLE";
            this.btngizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btngizle.UseVisualStyleBackColor = true;
            this.btngizle.Click += new System.EventHandler(this.btngizle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(45, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tercümesi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(607, 219);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btngizle);
            this.Controls.Add(this.txtCeviri);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstCeviri);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.txtGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGiris;
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstCeviri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCeviri;
        private System.Windows.Forms.Button btngizle;
        private System.Windows.Forms.Label label2;
    }
}

