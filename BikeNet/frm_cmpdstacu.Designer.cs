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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightCyan;
            this.grdCmpDst.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grdCmpDst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdCmpDst.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grdCmpDst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCmpDst.DefaultCellStyle = dataGridViewCellStyle11;
            this.grdCmpDst.Location = new System.Drawing.Point(7, 417);
            this.grdCmpDst.Name = "grdCmpDst";
            this.grdCmpDst.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCmpDst.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grdCmpDst.Size = new System.Drawing.Size(700, 109);
            this.grdCmpDst.TabIndex = 17;
            // 
            // chrCmpDst
            // 
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Angle = 45;
            chartArea3.AxisX.LabelStyle.Interval = 1D;
            chartArea3.AxisX.MajorGrid.Interval = 1D;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisX.MajorTickMark.Interval = 1D;
            chartArea3.AxisX.MajorTickMark.Size = 2F;
            chartArea3.AxisX.MaximumAutoSize = 90F;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.BackColor = System.Drawing.Color.MistyRose;
            chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            chartArea3.Name = "ChartArea1";
            this.chrCmpDst.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "Legend1";
            this.chrCmpDst.Legends.Add(legend3);
            this.chrCmpDst.Location = new System.Drawing.Point(7, 40);
            this.chrCmpDst.Name = "chrCmpDst";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.RoyalBlue;
            series5.CustomProperties = "DrawingStyle=Cylinder, EmptyPointValue=Zero, PointWidth=0.6";
            series5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series5.LabelFormat = "{0}";
            series5.Legend = "Legend1";
            series5.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series5.MarkerColor = System.Drawing.Color.RoyalBlue;
            series5.MarkerSize = 7;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series5.Name = "dstAnyo1";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.ForestGreen;
            series6.CustomProperties = "DrawingStyle=Cylinder, EmptyPointValue=Zero, PointWidth=0.6";
            series6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series6.LabelFormat = "{0}";
            series6.Legend = "Legend1";
            series6.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series6.MarkerColor = System.Drawing.Color.ForestGreen;
            series6.MarkerSize = 7;
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series6.Name = "dstAnyo2";
            this.chrCmpDst.Series.Add(series5);
            this.chrCmpDst.Series.Add(series6);
            this.chrCmpDst.Size = new System.Drawing.Size(682, 362);
            this.chrCmpDst.TabIndex = 16;
            this.chrCmpDst.Text = "Chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "AÑO 2";
            // 
            // cbAños2
            // 
            this.cbAños2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAños2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbAños2.FormattingEnabled = true;
            this.cbAños2.Location = new System.Drawing.Point(242, 8);
            this.cbAños2.Name = "cbAños2";
            this.cbAños2.Size = new System.Drawing.Size(82, 21);
            this.cbAños2.TabIndex = 14;
            this.cbAños2.SelectionChangeCommitted += new System.EventHandler(this.cbAños2_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "AÑO 1";
            // 
            // cbAños1
            // 
            this.cbAños1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAños1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbAños1.FormattingEnabled = true;
            this.cbAños1.Location = new System.Drawing.Point(74, 8);
            this.cbAños1.Name = "cbAños1";
            this.cbAños1.Size = new System.Drawing.Size(82, 21);
            this.cbAños1.TabIndex = 12;
            this.cbAños1.SelectionChangeCommitted += new System.EventHandler(this.cbAños1_SelectionChangeCommitted);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(466, 8);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 18;
            this.btSalir.Text = "VOLVER";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // frm_cmpdstacu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 532);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.grdCmpDst);
            this.Controls.Add(this.chrCmpDst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAños2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbAños1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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