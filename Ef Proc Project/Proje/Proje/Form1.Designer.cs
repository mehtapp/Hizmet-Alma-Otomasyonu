namespace Proje
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
            this.btnMusteri = new System.Windows.Forms.Button();
            this.btnHizmet = new System.Windows.Forms.Button();
            this.btnTalep = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hizmetlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taleplerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMusteri
            // 
            this.btnMusteri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteri.FlatAppearance.BorderSize = 4;
            this.btnMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteri.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteri.Location = new System.Drawing.Point(114, 138);
            this.btnMusteri.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(195, 175);
            this.btnMusteri.TabIndex = 0;
            this.btnMusteri.Text = "Müşteri";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHizmet
            // 
            this.btnHizmet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHizmet.FlatAppearance.BorderSize = 4;
            this.btnHizmet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHizmet.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHizmet.Location = new System.Drawing.Point(337, 138);
            this.btnHizmet.Margin = new System.Windows.Forms.Padding(4);
            this.btnHizmet.Name = "btnHizmet";
            this.btnHizmet.Size = new System.Drawing.Size(195, 175);
            this.btnHizmet.TabIndex = 0;
            this.btnHizmet.Text = "Hizmet";
            this.btnHizmet.UseVisualStyleBackColor = true;
            this.btnHizmet.Click += new System.EventHandler(this.btnHizmet_Click);
            // 
            // btnTalep
            // 
            this.btnTalep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTalep.FlatAppearance.BorderSize = 4;
            this.btnTalep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTalep.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTalep.Location = new System.Drawing.Point(564, 138);
            this.btnTalep.Margin = new System.Windows.Forms.Padding(4);
            this.btnTalep.Name = "btnTalep";
            this.btnTalep.Size = new System.Drawing.Size(195, 175);
            this.btnTalep.TabIndex = 0;
            this.btnTalep.Text = "Talep";
            this.btnTalep.UseVisualStyleBackColor = true;
            this.btnTalep.Click += new System.EventHandler(this.btnTalep_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşterilerToolStripMenuItem,
            this.hizmetlerToolStripMenuItem,
            this.taleplerToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            this.müşterilerToolStripMenuItem.Click += new System.EventHandler(this.müşterilerToolStripMenuItem_Click);
            // 
            // hizmetlerToolStripMenuItem
            // 
            this.hizmetlerToolStripMenuItem.Name = "hizmetlerToolStripMenuItem";
            this.hizmetlerToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hizmetlerToolStripMenuItem.Text = "Hizmetler";
            this.hizmetlerToolStripMenuItem.Click += new System.EventHandler(this.hizmetlerToolStripMenuItem_Click);
            // 
            // taleplerToolStripMenuItem
            // 
            this.taleplerToolStripMenuItem.Name = "taleplerToolStripMenuItem";
            this.taleplerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.taleplerToolStripMenuItem.Text = "Talepler";
            this.taleplerToolStripMenuItem.Click += new System.EventHandler(this.taleplerToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(883, 427);
            this.Controls.Add(this.btnTalep);
            this.Controls.Add(this.btnHizmet);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button btnHizmet;
        private System.Windows.Forms.Button btnTalep;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hizmetlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taleplerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
    }
}

