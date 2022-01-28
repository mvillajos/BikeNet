namespace BikeNet
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenMensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparativaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distanciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distanciaAcumuladaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.resumenMensualToolStripMenuItem,
            this.comparativaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(510, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarToolStripMenuItem,
            this.importarExcelToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.insertarToolStripMenuItem.Text = "Insertar";
            this.insertarToolStripMenuItem.Click += new System.EventHandler(this.insertarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // resumenMensualToolStripMenuItem
            // 
            this.resumenMensualToolStripMenuItem.Name = "resumenMensualToolStripMenuItem";
            this.resumenMensualToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.resumenMensualToolStripMenuItem.Text = "Resumen Mensual";
            this.resumenMensualToolStripMenuItem.Click += new System.EventHandler(this.resumenMensualToolStripMenuItem_Click);
            // 
            // comparativaToolStripMenuItem
            // 
            this.comparativaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.distanciaToolStripMenuItem,
            this.distanciaAcumuladaToolStripMenuItem});
            this.comparativaToolStripMenuItem.Name = "comparativaToolStripMenuItem";
            this.comparativaToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.comparativaToolStripMenuItem.Text = "Comparativa";
            // 
            // distanciaToolStripMenuItem
            // 
            this.distanciaToolStripMenuItem.Name = "distanciaToolStripMenuItem";
            this.distanciaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.distanciaToolStripMenuItem.Text = "Distancia";
            this.distanciaToolStripMenuItem.Click += new System.EventHandler(this.distanciaToolStripMenuItem_Click);
            // 
            // distanciaAcumuladaToolStripMenuItem
            // 
            this.distanciaAcumuladaToolStripMenuItem.Name = "distanciaAcumuladaToolStripMenuItem";
            this.distanciaAcumuladaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.distanciaAcumuladaToolStripMenuItem.Text = "Distancia acumulada";
            this.distanciaAcumuladaToolStripMenuItem.Click += new System.EventHandler(this.distanciaAcumuladaToolStripMenuItem_Click);
            // 
            // importarExcelToolStripMenuItem
            // 
            this.importarExcelToolStripMenuItem.Name = "importarExcelToolStripMenuItem";
            this.importarExcelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importarExcelToolStripMenuItem.Text = "Importar Excel";
            this.importarExcelToolStripMenuItem.Click += new System.EventHandler(this.importarExcelToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BikeNet.Properties.Resources.bike2;
            this.pictureBox1.Location = new System.Drawing.Point(36, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 304);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(510, 368);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_main_close);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem resumenMensualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comparativaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distanciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distanciaAcumuladaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarExcelToolStripMenuItem;
    }
}

