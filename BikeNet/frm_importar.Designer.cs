namespace BikeNet
{
    partial class frm_importar
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
            this.dgvImport = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtVolver = new System.Windows.Forms.Button();
            this.BtExcelToBD = new System.Windows.Forms.Button();
            this.txtLogSql = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvImport
            // 
            this.dgvImport.AllowUserToAddRows = false;
            this.dgvImport.AllowUserToDeleteRows = false;
            this.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.dst,
            this.time,
            this.velo});
            this.dgvImport.Location = new System.Drawing.Point(60, 37);
            this.dgvImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvImport.Name = "dgvImport";
            this.dgvImport.Size = new System.Drawing.Size(693, 294);
            this.dgvImport.TabIndex = 0;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "fecha";
            this.fecha.Name = "fecha";
            this.fecha.Width = 80;
            // 
            // dst
            // 
            this.dst.HeaderText = "dst";
            this.dst.Name = "dst";
            // 
            // time
            // 
            this.time.HeaderText = "time";
            this.time.Name = "time";
            // 
            // velo
            // 
            this.velo.HeaderText = "velo";
            this.velo.Name = "velo";
            // 
            // BtVolver
            // 
            this.BtVolver.Location = new System.Drawing.Point(443, 549);
            this.BtVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtVolver.Name = "BtVolver";
            this.BtVolver.Size = new System.Drawing.Size(132, 35);
            this.BtVolver.TabIndex = 15;
            this.BtVolver.Text = "VOLVER";
            this.BtVolver.UseVisualStyleBackColor = true;
            this.BtVolver.Click += new System.EventHandler(this.BtVolver_Click);
            // 
            // BtExcelToBD
            // 
            this.BtExcelToBD.Location = new System.Drawing.Point(257, 549);
            this.BtExcelToBD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtExcelToBD.Name = "BtExcelToBD";
            this.BtExcelToBD.Size = new System.Drawing.Size(136, 35);
            this.BtExcelToBD.TabIndex = 13;
            this.BtExcelToBD.Text = "XLS to BD";
            this.BtExcelToBD.UseVisualStyleBackColor = true;
            this.BtExcelToBD.Click += new System.EventHandler(this.BtVolcar_Click);
            // 
            // txtLogSql
            // 
            this.txtLogSql.Location = new System.Drawing.Point(63, 345);
            this.txtLogSql.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLogSql.Multiline = true;
            this.txtLogSql.Name = "txtLogSql";
            this.txtLogSql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogSql.Size = new System.Drawing.Size(686, 178);
            this.txtLogSql.TabIndex = 14;
            // 
            // frm_importar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 612);
            this.Controls.Add(this.txtLogSql);
            this.Controls.Add(this.BtExcelToBD);
            this.Controls.Add(this.BtVolver);
            this.Controls.Add(this.dgvImport);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frm_importar";
            this.Text = "frm_importar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_importar_FormClosed);
            this.Load += new System.EventHandler(this.frm_importar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImport;
        private System.Windows.Forms.Button BtVolver;
        private System.Windows.Forms.Button BtExcelToBD;
        private System.Windows.Forms.TextBox txtLogSql;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dst;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn velo;
    }
}