namespace yazılıortalamahesaplama
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
            this.lblNot1 = new System.Windows.Forms.Label();
            this.lblNot2 = new System.Windows.Forms.Label();
            this.lblNot3 = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.txtNot1 = new System.Windows.Forms.TextBox();
            this.txtNot2 = new System.Windows.Forms.TextBox();
            this.txtNot3 = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNot1
            // 
            this.lblNot1.AutoSize = true;
            this.lblNot1.Location = new System.Drawing.Point(29, 39);
            this.lblNot1.Name = "lblNot1";
            this.lblNot1.Size = new System.Drawing.Size(30, 13);
            this.lblNot1.TabIndex = 0;
            this.lblNot1.Text = "Not1";
            // 
            // lblNot2
            // 
            this.lblNot2.AutoSize = true;
            this.lblNot2.Location = new System.Drawing.Point(29, 75);
            this.lblNot2.Name = "lblNot2";
            this.lblNot2.Size = new System.Drawing.Size(30, 13);
            this.lblNot2.TabIndex = 1;
            this.lblNot2.Text = "Not2";
            // 
            // lblNot3
            // 
            this.lblNot3.AutoSize = true;
            this.lblNot3.Location = new System.Drawing.Point(29, 115);
            this.lblNot3.Name = "lblNot3";
            this.lblNot3.Size = new System.Drawing.Size(30, 13);
            this.lblNot3.TabIndex = 2;
            this.lblNot3.Text = "Not3";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(29, 158);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(49, 13);
            this.lblOrtalama.TabIndex = 3;
            this.lblOrtalama.Text = "Ortalama";
            // 
            // txtNot1
            // 
            this.txtNot1.Location = new System.Drawing.Point(102, 31);
            this.txtNot1.Name = "txtNot1";
            this.txtNot1.Size = new System.Drawing.Size(100, 20);
            this.txtNot1.TabIndex = 4;
            // 
            // txtNot2
            // 
            this.txtNot2.Location = new System.Drawing.Point(102, 75);
            this.txtNot2.Name = "txtNot2";
            this.txtNot2.Size = new System.Drawing.Size(100, 20);
            this.txtNot2.TabIndex = 5;
            // 
            // txtNot3
            // 
            this.txtNot3.Location = new System.Drawing.Point(102, 115);
            this.txtNot3.Name = "txtNot3";
            this.txtNot3.Size = new System.Drawing.Size(100, 20);
            this.txtNot3.TabIndex = 6;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(102, 158);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 35);
            this.btnHesapla.TabIndex = 7;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 221);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtNot3);
            this.Controls.Add(this.txtNot2);
            this.Controls.Add(this.txtNot1);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.lblNot3);
            this.Controls.Add(this.lblNot2);
            this.Controls.Add(this.lblNot1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNot1;
        private System.Windows.Forms.Label lblNot2;
        private System.Windows.Forms.Label lblNot3;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.TextBox txtNot1;
        private System.Windows.Forms.TextBox txtNot2;
        private System.Windows.Forms.TextBox txtNot3;
        private System.Windows.Forms.Button btnHesapla;
    }
}

