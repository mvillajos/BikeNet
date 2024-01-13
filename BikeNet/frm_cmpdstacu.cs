using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Windows.Forms.DataVisualization.Charting;

namespace BikeNet
{
    public partial class frm_cmpdstacu : Form
    {

        clsBBDD miclaseBD;
        private SQLiteConnection bikedb;

        public frm_cmpdstacu()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_cmpdstacu_FormClosed(object sender, FormClosedEventArgs e)
        {
            miclaseBD.CloseSqliteDb(ref bikedb);
            this.Owner.Show();
        }


        private void frm_cmpdstacu_Load(object sender, EventArgs e)
        {

            miclaseBD = new clsBBDD();
            int i;

            try
            {
                miclaseBD.OpenSqliteDb(ref bikedb, Application.StartupPath);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }

            for (i = DateTime.Now.Year; i >= miclaseBD.AñoIni; i--)
            {
                cbAños1.Items.Add(i);
                cbAños2.Items.Add(i);
            }

            cbAños1.SelectedIndex = 0;
            cbAños2.SelectedIndex = 1;

         
            int año1, año2;

            año1 = int.Parse(cbAños1.SelectedItem.ToString());
            año2 = int.Parse(cbAños2.SelectedItem.ToString());

            InitGraficoDistancia(año1, año2);

            cargargrdDst(año1, ref this.chrCmpDst, año1.ToString());
            cargargrdDst(año2, ref this.chrCmpDst, año2.ToString());

            miApi.addGapRowGrid(this.grdCmpDst, año1, año2);
        }


        private void setColHeaderGrdCmpDst(DataGridView grd)
        {
            int i;
            string strmes;

            miApi.SetGrdReadOnly(grd);
            grd.ColumnCount = 13;
            miApi.setColHeader(grd, 0, "Año", 45);
            for (i = 1; i <= 12; i++)
            {
                strmes = Microsoft.VisualBasic.DateAndTime.MonthName(i, true);
                miApi.setColHeader(grd, i, strmes, 50);
            }

        }


        private void InitGraficoDistancia(int Año1, int Año2)
        {
            DataRow mifila;
            double maxvalor;
            DataSet dsdatosmaxmin;
            string strsql;

            this.chrCmpDst.Series[0].Points.Clear();
            this.chrCmpDst.Series[1].Points.Clear();
            this.chrCmpDst.Series[0].Name = Año1.ToString();
            this.chrCmpDst.Series[1].Name = Año2.ToString();
            SetEjeXGrafico(ref chrCmpDst);

            //Establecer escala Eje Y
            strsql = "SELECT strftime('%Y',dtfecha) " +
            ", sum(distancia) as dstanyo " +
            " FROM tbl_workout " + 
            " WHERE  tipoactividad=2 " +  
            " and (strftime('%Y',dtfecha)='" + Año1 + "'" +
            " or strftime('%Y',dtfecha)='" + Año2  + "')" + 
            " GROUP BY strftime('%Y',dtfecha) " +
            " Order By sum(distancia) desc  Limit 1 ; ";
               
            dsdatosmaxmin = miclaseBD.FillDataset(strsql, bikedb);

            if (dsdatosmaxmin.Tables[0].Rows.Count > 0)
            {
                mifila = dsdatosmaxmin.Tables[0].Rows[0];
                maxvalor = Math.Floor((double)mifila["dstanyo"]) + 50;
                miApi.setScaleY(maxvalor, 10, 10, ref chrCmpDst, ref chrCmpDst.ChartAreas[0].Axes[1]);
                miApi.setScaleY(maxvalor, 10, 10, ref chrCmpDst, ref chrCmpDst.ChartAreas[0].Axes[3]);

            }
        }


        private void SetEjeXGrafico(ref Chart migrafico)
        {
            int j, nseries;
            string strmes;

            for (j = 1; j <= 12; j++)
            {

                strmes = Microsoft.VisualBasic.DateAndTime.MonthName(j, true);
                strmes = strmes.ToUpper();

                for (nseries = 0; nseries < migrafico.Series.Count; nseries++)
                {
                    migrafico.Series[nseries].Points.AddXY(strmes, 0);
                    migrafico.Update();
                }

            }

        }



        private void cargargrdDst(int intanyo, ref Chart graficoDst, string nomserie)
        {
            string strsql;
            DataSet mids;
            DataRow mifila;
            int nmes, ncol, filagrd;
            double dstacumula;

            int nreg;

            dstacumula = 0;

            setColHeaderGrdCmpDst(this.grdCmpDst);

            strsql = "SELECT intmes, sum(distancia) AS dst_mes " +
            " FROM tbl_workout " +
            " WHERE tipoactividad=2 " +
            " and intanyo=" + intanyo.ToString() +
            " GROUP BY intmes " +
            " ORDER BY intmes ";
            mids = miclaseBD.FillDataset(strsql, bikedb);

            this.grdCmpDst.Rows.Add();
            filagrd = this.grdCmpDst.Rows.Count - 1;

            grdCmpDst.Rows[filagrd].Cells[0].Value = intanyo;

            if (mids.Tables[0].Rows.Count > 0)
            {
                ncol = 1;
                nreg = 0;
                //for (int i = 0; i < mids.Tables[0].Rows.Count; i++)
                for (int i = 1; i <= 12; i++)
                {
                    if (nreg<mids.Tables[0].Rows.Count) 
                    {
                        mifila = mids.Tables[0].Rows[nreg];
                        nmes = int.Parse(mifila["intmes"].ToString());
                        if (nmes == i )
                        {
                            dstacumula = dstacumula + double.Parse(mifila["dst_mes"].ToString());
                            nreg++;
                        
                        }
                       
                    }
                   
                   
                    //while (ncol < nmes & ncol <= 12)
                    //{
                    //    ncol++;
                    //}

                    
                    grdCmpDst.Rows[filagrd].Cells[ncol].Value = dstacumula;

                    graficoDst.Series[nomserie].Points[ncol - 1].SetValueY(Math.Round(dstacumula, 1));
                    graficoDst.Update();
                    
                    ncol++;

                }
                graficoDst.Refresh();

            }

        }


        private void CambioAño()
        {
            int año1, año2;

            año1 = int.Parse(cbAños1.SelectedItem.ToString());
            año2 = int.Parse(cbAños2.SelectedItem.ToString());

            if (año1 != año2)
            {
                this.grdCmpDst.Rows.Clear();

                InitGraficoDistancia(año1, año2);

                cargargrdDst(año1, ref chrCmpDst, año1.ToString());
                cargargrdDst(año2, ref chrCmpDst, año2.ToString());

                miApi.addGapRowGrid(this.grdCmpDst, año1, año2);
            }

        }


        private void cbAños1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CambioAño();

        }


        private void cbAños2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CambioAño();

        }

       

    }
}
