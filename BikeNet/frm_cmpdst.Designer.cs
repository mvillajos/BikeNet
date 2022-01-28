namespace BikeNet
{
    partial class frm_cmpdst
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btSalir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbAños1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAños2 = new System.Windows.Forms.ComboBox();
            this.chrCmpDst = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grdCmpDst = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chrCmpDst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCmpDst)).BeginInit();
            this.SuspendLayout();
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(459, 10);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 7;
            this.btSalir.Text = "VOLVER";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "AÑO 1";
            // 
            // cbAños1
            // 
            this.cbAños1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAños1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbAños1.FormattingEnabled = true;
            this.cbAños1.Location = new System.Drawing.Point(79, 12);
            this.cbAños1.Name = "cbAños1";
            this.cbAños1.Size = new System.Drawing.Size(82, 21);
            this.cbAños1.TabIndex = 5;
            this.cbAños1.SelectionChangeCommitted += new System.EventHandler(this.cbAños1_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "AÑO 2";
            // 
            // cbAños2
            // 
            this.cbAños2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAños2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbAños2.FormattingEnabled = true;
            this.cbAños2.Location = new System.Drawing.Point(247, 12);
            this.cbAños2.Name = "cbAños2";
            this.cbAños2.Size = new System.Drawing.Size(82, 21);
            this.cbAños2.TabIndex = 8;
            this.cbAños2.SelectionChangeCommitted += new System.EventHandler(this.cbAños2_SelectionChangeCommitted);
            // 
            // chrCmpDst
            // 
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Angle = 45;
            chartArea2.AxisX.LabelStyle.Interval = 1D;
            chartArea2.AxisX.MajorGrid.Interval = 1D;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisX.MajorTickMark.Interval = 1D;
            chartArea2.AxisX.MajorTickMark.Size = 2F;
            chartArea2.AxisX.MaximumAutoSize = 90F;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.BackColor = System.Drawing.Color.MistyRose;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            chartArea2.Name = "ChartArea1";
            this.chrCmpDst.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chrCmpDst.Legends.Add(legend2);
            this.chrCmpDst.Location = new System.Drawing.Point(12, 44);
            this.chrCmpDst.Name = "chrCmpDst";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.RoyalBlue;
            series3.CustomProperties = "DrawingStyle=Cylinder, EmptyPointValue=Zero, PointWidth=0.6";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series3.LabelFormat = "{0}";
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series3.MarkerColor = System.Drawing.Color.RoyalBlue;
            series3.MarkerSize = 7;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series3.Name = "dstAnyo1";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.ForestGreen;
            series4.CustomProperties = "DrawingStyle=Cylinder, EmptyPointValue=Zero, PointWidth=0.6";
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series4.LabelFormat = "{0}";
            series4.Legend = "Legend1";
            series4.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series4.MarkerColor = System.Drawing.Color.ForestGreen;
            series4.MarkerSize = 7;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series4.Name = "dstAnyo2";
            this.chrCmpDst.Series.Add(series3);
            this.chrCmpDst.Series.Add(series4);
            this.chrCmpDst.Size = new System.Drawing.Size(682, 362);
            this.chrCmpDst.TabIndex = 10;
            this.chrCmpDst.Text = "Chart1";
            // 
            // grdCmpDst
            // 
            this.grdCmpDst.AllowUserToAddRows = false;
            this.grdCmpDst.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCyan;
            this.grdCmpDst.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdCmpDst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdCmpDst.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdCmpDst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCmpDst.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdCmpDst.Location = new System.Drawing.Point(12, 421);
            this.grdCmpDst.Name = "grdCmpDst";
            this.grdCmpDst.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCmpDst.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdCmpDst.Size = new System.Drawing.Size(700, 109);
            this.grdCmpDst.TabIndex = 11;
            // 
            // frm_cmpdst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 542);
            this.Controls.Add(this.grdCmpDst);
            this.Controls.Add(this.chrCmpDst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAños2);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbAños1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_cmpdst";
            this.Text = "Compara distancia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_cmpdst_FormClosed);
            this.Load += new System.EventHandler(this.frm_cmpdst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrCmpDst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCmpDst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbAños1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAños2;
        internal System.Windows.Forms.DataVisualization.Charting.Chart chrCmpDst;
        private System.Windows.Forms.DataGridView grdCmpDst;
    }
}