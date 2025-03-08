namespace Hesap_Makinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EkranLabel = new System.Windows.Forms.Label();
            this.rakan1button = new System.Windows.Forms.Button();
            this.rakam2button = new System.Windows.Forms.Button();
            this.rakam3button = new System.Windows.Forms.Button();
            this.rakam6button = new System.Windows.Forms.Button();
            this.rakam5button = new System.Windows.Forms.Button();
            this.rakam4button = new System.Windows.Forms.Button();
            this.EşittirButon = new System.Windows.Forms.Button();
            this.rakam0button = new System.Windows.Forms.Button();
            this.temizleButon = new System.Windows.Forms.Button();
            this.rakam9button = new System.Windows.Forms.Button();
            this.rakam8button = new System.Windows.Forms.Button();
            this.rakam7button = new System.Windows.Forms.Button();
            this.BölmeButon = new System.Windows.Forms.Button();
            this.ÇarpmaButon = new System.Windows.Forms.Button();
            this.ÇıkarmaButon = new System.Windows.Forms.Button();
            this.ToplamaButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EkranLabel
            // 
            this.EkranLabel.BackColor = System.Drawing.Color.White;
            this.EkranLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EkranLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkranLabel.Location = new System.Drawing.Point(13, 9);
            this.EkranLabel.Name = "EkranLabel";
            this.EkranLabel.Size = new System.Drawing.Size(318, 62);
            this.EkranLabel.TabIndex = 0;
            this.EkranLabel.Text = "0";
            this.EkranLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rakan1button
            // 
            this.rakan1button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rakan1button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakan1button.Location = new System.Drawing.Point(13, 89);
            this.rakan1button.Name = "rakan1button";
            this.rakan1button.Size = new System.Drawing.Size(75, 75);
            this.rakan1button.TabIndex = 1;
            this.rakan1button.Text = "1";
            this.rakan1button.UseVisualStyleBackColor = false;
            this.rakan1button.Click += new System.EventHandler(this.rakan1button_Click);
            // 
            // rakam2button
            // 
            this.rakam2button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rakam2button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam2button.Location = new System.Drawing.Point(94, 89);
            this.rakam2button.Name = "rakam2button";
            this.rakam2button.Size = new System.Drawing.Size(75, 75);
            this.rakam2button.TabIndex = 2;
            this.rakam2button.Text = "2";
            this.rakam2button.UseVisualStyleBackColor = false;
            this.rakam2button.Click += new System.EventHandler(this.rakam2button_Click);
            // 
            // rakam3button
            // 
            this.rakam3button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rakam3button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam3button.Location = new System.Drawing.Point(175, 89);
            this.rakam3button.Name = "rakam3button";
            this.rakam3button.Size = new System.Drawing.Size(75, 75);
            this.rakam3button.TabIndex = 3;
            this.rakam3button.Text = "3";
            this.rakam3button.UseVisualStyleBackColor = false;
            this.rakam3button.Click += new System.EventHandler(this.rakam3button_Click);
            // 
            // rakam6button
            // 
            this.rakam6button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rakam6button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam6button.Location = new System.Drawing.Point(174, 170);
            this.rakam6button.Name = "rakam6button";
            this.rakam6button.Size = new System.Drawing.Size(75, 75);
            this.rakam6button.TabIndex = 6;
            this.rakam6button.Text = "6";
            this.rakam6button.UseVisualStyleBackColor = false;
            this.rakam6button.Click += new System.EventHandler(this.rakam6button_Click);
            // 
            // rakam5button
            // 
            this.rakam5button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rakam5button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam5button.Location = new System.Drawing.Point(93, 170);
            this.rakam5button.Name = "rakam5button";
            this.rakam5button.Size = new System.Drawing.Size(75, 75);
            this.rakam5button.TabIndex = 5;
            this.rakam5button.Text = "5";
            this.rakam5button.UseVisualStyleBackColor = false;
            this.rakam5button.Click += new System.EventHandler(this.rakam5button_Click);
            // 
            // rakam4button
            // 
            this.rakam4button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rakam4button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam4button.Location = new System.Drawing.Point(12, 170);
            this.rakam4button.Name = "rakam4button";
            this.rakam4button.Size = new System.Drawing.Size(75, 75);
            this.rakam4button.TabIndex = 4;
            this.rakam4button.Text = "4";
            this.rakam4button.UseVisualStyleBackColor = false;
            this.rakam4button.Click += new System.EventHandler(this.rakam4button_Click);
            // 
            // EşittirButon
            // 
            this.EşittirButon.BackColor = System.Drawing.Color.Bisque;
            this.EşittirButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EşittirButon.Location = new System.Drawing.Point(173, 332);
            this.EşittirButon.Name = "EşittirButon";
            this.EşittirButon.Size = new System.Drawing.Size(75, 75);
            this.EşittirButon.TabIndex = 12;
            this.EşittirButon.Text = "=";
            this.EşittirButon.UseVisualStyleBackColor = false;
            this.EşittirButon.Click += new System.EventHandler(this.EşittirButon_Click);
            // 
            // rakam0button
            // 
            this.rakam0button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rakam0button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam0button.Location = new System.Drawing.Point(92, 332);
            this.rakam0button.Name = "rakam0button";
            this.rakam0button.Size = new System.Drawing.Size(75, 75);
            this.rakam0button.TabIndex = 11;
            this.rakam0button.Text = "0";
            this.rakam0button.UseVisualStyleBackColor = false;
            this.rakam0button.Click += new System.EventHandler(this.rakam0button_Click);
            // 
            // temizleButon
            // 
            this.temizleButon.BackColor = System.Drawing.Color.Red;
            this.temizleButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizleButon.ForeColor = System.Drawing.Color.White;
            this.temizleButon.Location = new System.Drawing.Point(11, 332);
            this.temizleButon.Name = "temizleButon";
            this.temizleButon.Size = new System.Drawing.Size(75, 75);
            this.temizleButon.TabIndex = 10;
            this.temizleButon.Text = "C";
            this.temizleButon.UseVisualStyleBackColor = false;
            this.temizleButon.Click += new System.EventHandler(this.temizleButon_Click);
            // 
            // rakam9button
            // 
            this.rakam9button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rakam9button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam9button.Location = new System.Drawing.Point(174, 251);
            this.rakam9button.Name = "rakam9button";
            this.rakam9button.Size = new System.Drawing.Size(75, 75);
            this.rakam9button.TabIndex = 9;
            this.rakam9button.Text = "9";
            this.rakam9button.UseVisualStyleBackColor = false;
            this.rakam9button.Click += new System.EventHandler(this.rakam9button_Click);
            // 
            // rakam8button
            // 
            this.rakam8button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rakam8button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam8button.Location = new System.Drawing.Point(92, 251);
            this.rakam8button.Name = "rakam8button";
            this.rakam8button.Size = new System.Drawing.Size(75, 75);
            this.rakam8button.TabIndex = 8;
            this.rakam8button.Text = "8";
            this.rakam8button.UseVisualStyleBackColor = false;
            this.rakam8button.Click += new System.EventHandler(this.rakam8button_Click);
            // 
            // rakam7button
            // 
            this.rakam7button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rakam7button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam7button.Location = new System.Drawing.Point(12, 251);
            this.rakam7button.Name = "rakam7button";
            this.rakam7button.Size = new System.Drawing.Size(75, 75);
            this.rakam7button.TabIndex = 7;
            this.rakam7button.Text = "7";
            this.rakam7button.UseVisualStyleBackColor = false;
            this.rakam7button.Click += new System.EventHandler(this.rakam7button_Click);
            // 
            // BölmeButon
            // 
            this.BölmeButon.BackColor = System.Drawing.Color.Thistle;
            this.BölmeButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BölmeButon.Location = new System.Drawing.Point(254, 332);
            this.BölmeButon.Name = "BölmeButon";
            this.BölmeButon.Size = new System.Drawing.Size(75, 75);
            this.BölmeButon.TabIndex = 16;
            this.BölmeButon.Text = "/";
            this.BölmeButon.UseVisualStyleBackColor = false;
            this.BölmeButon.Click += new System.EventHandler(this.BölmeButon_Click);
            // 
            // ÇarpmaButon
            // 
            this.ÇarpmaButon.BackColor = System.Drawing.Color.Thistle;
            this.ÇarpmaButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ÇarpmaButon.Location = new System.Drawing.Point(255, 251);
            this.ÇarpmaButon.Name = "ÇarpmaButon";
            this.ÇarpmaButon.Size = new System.Drawing.Size(75, 75);
            this.ÇarpmaButon.TabIndex = 15;
            this.ÇarpmaButon.Text = "X";
            this.ÇarpmaButon.UseVisualStyleBackColor = false;
            this.ÇarpmaButon.Click += new System.EventHandler(this.ÇarpmaButon_Click);
            // 
            // ÇıkarmaButon
            // 
            this.ÇıkarmaButon.BackColor = System.Drawing.Color.Thistle;
            this.ÇıkarmaButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ÇıkarmaButon.Location = new System.Drawing.Point(253, 170);
            this.ÇıkarmaButon.Name = "ÇıkarmaButon";
            this.ÇıkarmaButon.Size = new System.Drawing.Size(75, 75);
            this.ÇıkarmaButon.TabIndex = 14;
            this.ÇıkarmaButon.Text = "-";
            this.ÇıkarmaButon.UseVisualStyleBackColor = false;
            this.ÇıkarmaButon.Click += new System.EventHandler(this.ÇıkarmaButon_Click);
            // 
            // ToplamaButon
            // 
            this.ToplamaButon.BackColor = System.Drawing.Color.Thistle;
            this.ToplamaButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToplamaButon.Location = new System.Drawing.Point(256, 89);
            this.ToplamaButon.Name = "ToplamaButon";
            this.ToplamaButon.Size = new System.Drawing.Size(75, 75);
            this.ToplamaButon.TabIndex = 13;
            this.ToplamaButon.Text = "+";
            this.ToplamaButon.UseVisualStyleBackColor = false;
            this.ToplamaButon.Click += new System.EventHandler(this.ToplamaButon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 417);
            this.Controls.Add(this.BölmeButon);
            this.Controls.Add(this.ÇarpmaButon);
            this.Controls.Add(this.ÇıkarmaButon);
            this.Controls.Add(this.ToplamaButon);
            this.Controls.Add(this.EşittirButon);
            this.Controls.Add(this.rakam0button);
            this.Controls.Add(this.temizleButon);
            this.Controls.Add(this.rakam9button);
            this.Controls.Add(this.rakam8button);
            this.Controls.Add(this.rakam7button);
            this.Controls.Add(this.rakam6button);
            this.Controls.Add(this.rakam5button);
            this.Controls.Add(this.rakam4button);
            this.Controls.Add(this.rakam3button);
            this.Controls.Add(this.rakam2button);
            this.Controls.Add(this.rakan1button);
            this.Controls.Add(this.EkranLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EkranLabel;
        private System.Windows.Forms.Button rakan1button;
        private System.Windows.Forms.Button rakam2button;
        private System.Windows.Forms.Button rakam3button;
        private System.Windows.Forms.Button rakam6button;
        private System.Windows.Forms.Button rakam5button;
        private System.Windows.Forms.Button rakam4button;
        private System.Windows.Forms.Button EşittirButon;
        private System.Windows.Forms.Button rakam0button;
        private System.Windows.Forms.Button temizleButon;
        private System.Windows.Forms.Button rakam9button;
        private System.Windows.Forms.Button rakam8button;
        private System.Windows.Forms.Button rakam7button;
        private System.Windows.Forms.Button BölmeButon;
        private System.Windows.Forms.Button ÇarpmaButon;
        private System.Windows.Forms.Button ÇıkarmaButon;
        private System.Windows.Forms.Button ToplamaButon;
    }
}

