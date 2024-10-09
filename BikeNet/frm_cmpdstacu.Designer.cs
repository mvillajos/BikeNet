namespace BikeNet
{
    partial class frm_cmpdstacu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grdCmpDst = new System.Windows.Forms.DataGridView();
            this.chrCmpDst = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAños2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbAños1 = new System.Windows.Forms.ComboBox();
            this.btSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCmpDst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrCmpDst)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCmpDst
            // 
            this.grdCmpDst.AllowUserToAddRows = false;
            this.grdCmpDst.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.grdCmpDst.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCmpDst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdCmpDst.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdCmpDst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCmpDst.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdCmpDst.Location = new System.Drawing.Point(9, 513);
            this.grdCmpDst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdCmpDst.Name = "grdCmpDst";
            this.grdCmpDst.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCmpDst.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdCmpDst.RowHeadersWidth = 51;
            this.grdCmpDst.Size = new System.Drawing.Size(997, 134);
            this.grdCmpDst.TabIndex = 17;
            // 
            // chrCmpDst
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = 45;
            chartArea1.AxisX.LabelStyle.Interval = 1D;
            chartArea1.AxisX.MajorGrid.Interval = 1D;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorTickMark.Interval = 1D;
            chartArea1.AxisX.MajorTickMark.Size = 2F;
            chartArea1.AxisX.MaximumAutoSize = 90F;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.BackColor = System.Drawing.Color.MistyRose;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            chartArea1.Name = "ChartArea1";
            this.chrCmpDst.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chrCmpDst.Legends.Add(legend1);
            this.chrCmpDst.Location = new System.Drawing.Point(9, 49);
            this.chrCmpDst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chrCmpDst.Name = "chrCmpDst";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.RoyalBlue;
            series1.CustomProperties = "EmptyPointValue=Zero, DrawingStyle=Cylinder, PointWidth=0.6";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series1.LabelFormat = "{0}";
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series1.MarkerColor = System.Drawing.Color.RoyalBlue;
            series1.MarkerSize = 7;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "dstAnyo1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.ForestGreen;
            series2.CustomProperties = "EmptyPointValue=Zero, DrawingStyle=Cylinder, PointWidth=0.6";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series2.LabelFormat = "{0}";
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series2.MarkerColor = System.Drawing.Color.ForestGreen;
            series2.MarkerSize = 7;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series2.Name = "dstAnyo2";
            this.chrCmpDst.Series.Add(series1);
            this.chrCmpDst.Series.Add(series2);
            this.chrCmpDst.Size = new System.Drawing.Size(997, 446);
            this.chrCmpDst.TabIndex = 16;
            this.chrCmpDst.Text = "Chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "AÑO 2";
            // 
            // cbAños2
            // 
            this.cbAños2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAños2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbAños2.FormattingEnabled = true;
            this.cbAños2.Location = new System.Drawing.Point(323, 10);
            this.cbAños2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAños2.Name = "cbAños2";
            this.cbAños2.Size = new System.Drawing.Size(108, 25);
            this.cbAños2.TabIndex = 14;
            this.cbAños2.SelectionChangeCommitted += new System.EventHandler(this.cbAños2_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "AÑO 1";
            // 
            // cbAños1
            // 
            this.cbAños1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAños1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbAños1.FormattingEnabled = true;
            this.cbAños1.Location = new System.Drawing.Point(99, 10);
            this.cbAños1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAños1.Name = "cbAños1";
            this.cbAños1.Size = new System.Drawing.Size(108, 25);
            this.cbAños1.TabIndex = 12;
            this.cbAños1.SelectionChangeCommitted += new System.EventHandler(this.cbAños1_SelectionChangeCommitted);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(621, 10);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(100, 28);
            this.btSalir.TabIndex = 18;
            this.btSalir.Text = "VOLVER";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // frm_cmpdstacu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 655);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.grdCmpDst);
            this.Controls.Add(this.chrCmpDst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAños2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbAños1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frm_cmpdstacu";
            this.Text = "Compara distancia acumulada";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_cmpdstacu_FormClosed);
            this.Load += new System.EventHandler(this.frm_cmpdstacu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCmpDst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrCmpDst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCmpDst;
        internal System.Windows.Forms.DataVisualization.Charting.Chart chrCmpDst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAños2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbAños1;
        private System.Windows.Forms.Button btSalir;
    }
}