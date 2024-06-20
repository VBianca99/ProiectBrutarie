
namespace ProiectBrutarie
{
    partial class frmAprovizionare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAprovizionare));
            this.label1 = new System.Windows.Forms.Label();
            this.furnizoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adăugareFurnizorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ștergereModificareFurnizorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comenziFurnizoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportComenziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produseFurnizoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ieșireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Meniu Aprovizionări";
            // 
            // furnizoriToolStripMenuItem
            // 
            this.furnizoriToolStripMenuItem.BackColor = System.Drawing.Color.Peru;
            this.furnizoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adăugareFurnizorToolStripMenuItem,
            this.ștergereModificareFurnizorToolStripMenuItem});
            this.furnizoriToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.furnizoriToolStripMenuItem.Name = "furnizoriToolStripMenuItem";
            this.furnizoriToolStripMenuItem.Size = new System.Drawing.Size(167, 39);
            this.furnizoriToolStripMenuItem.Text = "Furnizori";
            this.furnizoriToolStripMenuItem.Click += new System.EventHandler(this.furnizoriToolStripMenuItem_Click);
            // 
            // adăugareFurnizorToolStripMenuItem
            // 
            this.adăugareFurnizorToolStripMenuItem.Name = "adăugareFurnizorToolStripMenuItem";
            this.adăugareFurnizorToolStripMenuItem.Size = new System.Drawing.Size(532, 40);
            this.adăugareFurnizorToolStripMenuItem.Text = "Adăugare Furnizor";
            this.adăugareFurnizorToolStripMenuItem.Click += new System.EventHandler(this.adăugareFurnizorToolStripMenuItem_Click);
            // 
            // ștergereModificareFurnizorToolStripMenuItem
            // 
            this.ștergereModificareFurnizorToolStripMenuItem.Name = "ștergereModificareFurnizorToolStripMenuItem";
            this.ștergereModificareFurnizorToolStripMenuItem.Size = new System.Drawing.Size(532, 40);
            this.ștergereModificareFurnizorToolStripMenuItem.Text = "Ștergere/Modificare Furnizor";
            this.ștergereModificareFurnizorToolStripMenuItem.Click += new System.EventHandler(this.ștergereModificareFurnizorToolStripMenuItem_Click);
            // 
            // comenziFurnizoriToolStripMenuItem
            // 
            this.comenziFurnizoriToolStripMenuItem.BackColor = System.Drawing.Color.Chocolate;
            this.comenziFurnizoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raportComenziToolStripMenuItem});
            this.comenziFurnizoriToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.comenziFurnizoriToolStripMenuItem.Name = "comenziFurnizoriToolStripMenuItem";
            this.comenziFurnizoriToolStripMenuItem.Size = new System.Drawing.Size(303, 39);
            this.comenziFurnizoriToolStripMenuItem.Text = "Comenzi Furnizori";
            this.comenziFurnizoriToolStripMenuItem.Click += new System.EventHandler(this.comenziFurnizoriToolStripMenuItem_Click);
            // 
            // raportComenziToolStripMenuItem
            // 
            this.raportComenziToolStripMenuItem.Name = "raportComenziToolStripMenuItem";
            this.raportComenziToolStripMenuItem.Size = new System.Drawing.Size(342, 40);
            this.raportComenziToolStripMenuItem.Text = "Raport Comenzi";
            this.raportComenziToolStripMenuItem.Click += new System.EventHandler(this.raportComenziToolStripMenuItem_Click);
            // 
            // produseFurnizoriToolStripMenuItem
            // 
            this.produseFurnizoriToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.produseFurnizoriToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.produseFurnizoriToolStripMenuItem.Name = "produseFurnizoriToolStripMenuItem";
            this.produseFurnizoriToolStripMenuItem.Size = new System.Drawing.Size(295, 39);
            this.produseFurnizoriToolStripMenuItem.Text = "Produse Furnizori";
            this.produseFurnizoriToolStripMenuItem.Click += new System.EventHandler(this.produseFurnizoriToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.furnizoriToolStripMenuItem,
            this.comenziFurnizoriToolStripMenuItem,
            this.produseFurnizoriToolStripMenuItem,
            this.ieșireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 255);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ieșireToolStripMenuItem
            // 
            this.ieșireToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.ieșireToolStripMenuItem.Name = "ieșireToolStripMenuItem";
            this.ieșireToolStripMenuItem.Size = new System.Drawing.Size(113, 39);
            this.ieșireToolStripMenuItem.Text = "Ieșire";
            this.ieșireToolStripMenuItem.Click += new System.EventHandler(this.ieșireToolStripMenuItem_Click);
            // 
            // frmAprovizionare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1017, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAprovizionare";
            this.Text = "frmAprovizionare";
            this.Load += new System.EventHandler(this.frmAprovizionare_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem furnizoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comenziFurnizoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produseFurnizoriToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adăugareFurnizorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ștergereModificareFurnizorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raportComenziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ieșireToolStripMenuItem;
    }
}