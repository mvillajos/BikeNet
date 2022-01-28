namespace BikeNet
{
    partial class frm_insertar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtAcumulado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskTiempo = new System.Windows.Forms.MaskedTextBox();
            this.BtVolver = new System.Windows.Forms.Button();
            this.BtResetear = new System.Windows.Forms.Button();
            this.BtInsertar = new System.Windows.Forms.Button();
            //this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            //this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.BtGuardar = new System.Windows.Forms.Button();
            this.BtBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightCyan;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDatos.Location = new System.Drawing.Point(32, 241);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDatos.Size = new System.Drawing.Size(499, 186);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDatos_RowHeaderMouseClick);
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(125, 13);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 1;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "FECHA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DISTANCIA";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(125, 48);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(59, 20);
            this.txtDistancia.TabIndex = 2;
            this.txtDistancia.TextChanged += new System.EventHandler(this.txtDistancia_TextChanged);
            // 
            // txtAcumulado
            // 
            this.txtAcumulado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAcumulado.Location = new System.Drawing.Point(125, 150);
            this.txtAcumulado.Name = "txtAcumulado";
            this.txtAcumulado.ReadOnly = true;
            this.txtAcumulado.Size = new System.Drawing.Size(59, 20);
            this.txtAcumulado.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(47, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ACUMULADO";
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtVelocidad.Location = new System.Drawing.Point(125, 114);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.ReadOnly = true;
            this.txtVelocidad.Size = new System.Drawing.Size(59, 20);
            this.txtVelocidad.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "VELOCIDAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "TIEMPO";
            // 
            // mskTiempo
            // 
            this.mskTiempo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mskTiempo.Location = new System.Drawing.Point(127, 81);
            this.mskTiempo.Mask = "##:##:##";
            this.mskTiempo.Name = "mskTiempo";
            this.mskTiempo.Size = new System.Drawing.Size(59, 20);
            this.mskTiempo.TabIndex = 3;
            this.mskTiempo.TextChanged += new System.EventHandler(this.mskTiempo_TextChanged);
            // 
            // BtVolver
            // 
            this.BtVolver.Location = new System.Drawing.Point(436, 195);
            this.BtVolver.Name = "BtVolver";
            this.BtVolver.Size = new System.Drawing.Size(75, 23);
            this.BtVolver.TabIndex = 11;
            this.BtVolver.Text = "VOLVER";
            this.BtVolver.UseVisualStyleBackColor = true;
            this.BtVolver.Click += new System.EventHandler(this.BtVolver_Click);
            // 
            // BtResetear
            // 
            this.BtResetear.Location = new System.Drawing.Point(50, 195);
            this.BtResetear.Name = "BtResetear";
            this.BtResetear.Size = new System.Drawing.Size(75, 23);
            this.BtResetear.TabIndex = 7;
            this.BtResetear.Text = "RESETEAR";
            this.BtResetear.UseVisualStyleBackColor = true;
            this.BtResetear.Click += new System.EventHandler(this.BtResetear_Click);
            // 
            // BtInsertar
            // 
            this.BtInsertar.Location = new System.Drawing.Point(144, 195);
            this.BtInsertar.Name = "BtInsertar";
            this.BtInsertar.Size = new System.Drawing.Size(75, 23);
            this.BtInsertar.TabIndex = 8;
            this.BtInsertar.Text = "INSERTAR";
            this.BtInsertar.UseVisualStyleBackColor = true;
            this.BtInsertar.Click += new System.EventHandler(this.BtInsertar_Click);
            // 
            // shapeContainer1
            // 
            //this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            //this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            //this.shapeContainer1.Name = "shapeContainer1";
            //this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            //this.lineShape1});
            //this.shapeContainer1.Size = new System.Drawing.Size(557, 450);
            //this.shapeContainer1.TabIndex = 14;
            //this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            //this.lineShape1.BorderColor = System.Drawing.Color.SaddleBrown;
            //this.lineShape1.BorderWidth = 2;
            //this.lineShape1.Name = "lineShape1";
            //this.lineShape1.X1 = 16;
            //this.lineShape1.X2 = 550;
            //this.lineShape1.Y1 = 228;
            //this.lineShape1.Y2 = 228;
            // 
            // BtGuardar
            // 
            this.BtGuardar.Location = new System.Drawing.Point(237, 195);
            this.BtGuardar.Name = "BtGuardar";
            this.BtGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtGuardar.TabIndex = 9;
            this.BtGuardar.Text = "GUARDAR";
            this.BtGuardar.UseVisualStyleBackColor = true;
            this.BtGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // BtBorrar
            // 
            this.BtBorrar.Location = new System.Drawing.Point(339, 195);
            this.BtBorrar.Name = "BtBorrar";
            this.BtBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtBorrar.TabIndex = 10;
            this.BtBorrar.Text = "BORRAR";
            this.BtBorrar.UseVisualStyleBackColor = true;
            this.BtBorrar.Click += new System.EventHandler(this.BtBorrar_Click);
            // 
            // frm_insertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.BtBorrar);
            this.Controls.Add(this.BtGuardar);
            this.Controls.Add(this.BtInsertar);
            this.Controls.Add(this.BtResetear);
            this.Controls.Add(this.BtVolver);
            this.Controls.Add(this.mskTiempo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVelocidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAcumulado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.dgvDatos);
            //this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_insertar";
            this.Text = "INSERTAR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_insertar_FormClosed);
            this.Load += new System.EventHandler(this.frm_insertar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtAcumulado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVelocidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTiempo;
        private System.Windows.Forms.Button BtVolver;
        private System.Windows.Forms.Button BtResetear;
        private System.Windows.Forms.Button BtInsertar;
        //private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        //private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button BtGuardar;
        private System.Windows.Forms.Button BtBorrar;

    }
}