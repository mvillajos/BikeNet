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
    public partial class frm_infosalidas : Form
    {

        clsBBDD miclaseBD;
        private SQLiteConnection bikedb;
        //private SQLiteDataAdapter db;
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable(); 

        public frm_infosalidas()
        {
            InitializeComponent();
        }


        private void cargarDatosForm()
        {
            int año;

            año = int.Parse(cbAños.SelectedItem.ToString());

            CargarDatosGroupBoxTotales(año);
            CargarDatosGroupBoxMax(año);
            CargarDatosGroupBoxAvg(año);

            cargarDatosAvgMes(año);
            //setColHeaderGrdDatosAvgMes(this.grdDatosAvgMes);

            cargarDatosMaxMinMes(año);
            //setColHeaderGrdDatosMaxMinMes(this.grdDatosMaxMinMes);

            cargarTodosDatos(año);
        
        }


        private void frm_infosalidas_Load(object sender, EventArgs e)
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
                cbAños.Items.Add(i);
            }

            cbAños.SelectedIndex = 0;
            cargarDatosForm();

       
        }


        private void CargarDatosGroupBoxTotales(int AñoSelect)
        { 
            string mysql;
            DataSet mids;
            DataRow mifila;
            int timetotal;

            mysql = "SELECT count(tipoactividad) as num_salidas " + 
            " ,sum(distancia) as kmTotal " + 
            " ,(sum(distancia)/sum(duracion))*3600 as VeloTotal " + 
            " ,sum(duracion) as TimeTotal" + 
            " From tbl_workout" +
            " Where tipoactividad=2 " +
            " and strftime('%Y',dtfecha)='" + AñoSelect.ToString() + "'";

            try
            {
                mids = miclaseBD.FillDataset(mysql, bikedb);
                if (mids.Tables[0].Rows.Count > 0)
                {
                    mifila = mids.Tables[0].Rows[0];
                    txtNumSalidas.Text = mifila["num_salidas"].ToString();
                    txtDstTotal.Text = miclaseBD.ValNulo(mifila["kmTotal"], "NUM");
                    timetotal =int.Parse(miclaseBD.ValNulo(mifila["timeTotal"], "NUM"));

                    txtTimeTotal.Text = miApi.convertsecs_hhmmss(timetotal);

                    txtVeloGlobal.Text = miclaseBD.ValNulo(mifila["VeloTotal"], "NUM");

                }
                mifila = null;
                mids.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            
            }

        }



        private void CargarDatosGroupBoxMax(int AñoSelect)
        {
            string mysql;
            DataSet mids;
            DataRow mifila;
            int timetotal;

            mysql = "SELECT max(distancia) as MaxDst " +
            " ,max(velocidad) as MaxVelo " +
            " ,max(duracion) as MaxTime" +
            " From tbl_workout" +
            " Where tipoactividad=2 " +
            " and strftime('%Y',dtfecha)='" + AñoSelect.ToString() + "'";

            try
            {
                mids = miclaseBD.FillDataset(mysql, bikedb);
                if (mids.Tables[0].Rows.Count > 0)
                {
                    mifila = mids.Tables[0].Rows[0];
                    txtDstMax.Text = miclaseBD.ValNulo(mifila["MaxDst"], "NUM");
                    timetotal = int.Parse(miclaseBD.ValNulo(mifila["MaxTime"], "NUM"));

                    txtTimeMax.Text = miApi.convertsecs_hhmmss(timetotal);

                    txtVeloMax.Text = miclaseBD.ValNulo(mifila["MaxVelo"], "NUM");

                }
                mifila = null;
                mids.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);

            }
        }


        private void CargarDatosGroupBoxAvg(int AñoSelect)
        {
            string mysql;
            DataSet mids;
            DataRow mifila;
            double timetotal;

            mysql = "SELECT avg(distancia) as AvgDst " +
            " ,avg(velocidad) as AvgVelo " +
            " ,avg(duracion) as AvgTime" +
            " From tbl_workout" +
            " Where tipoactividad=2 " +
            " and strftime('%Y',dtfecha)='" + AñoSelect.ToString() + "'";

            try
            {
                mids = miclaseBD.FillDataset(mysql, bikedb);
                if (mids.Tables[0].Rows.Count > 0)
                {
                    mifila = mids.Tables[0].Rows[0];
                    txtDstMedia.Text = miclaseBD.ValNulo(mifila["AvgDst"], "NUM");
                    timetotal = double.Parse(miclaseBD.ValNulo(mifila["AvgTime"], "NUM"));
                    
                    txtTimeMedio.Text = miApi.convertsecs_hhmmss((int)Math.Truncate(timetotal));

                    txtVeloMedia.Text = miclaseBD.ValNulo(mifila["AvgVelo"], "NUM");

                }
                mifila = null;
                mids.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);

            }
        }



        private void setColHeaderGrdDatosAvgMes(DataGridView grd)
        {
                miApi.SetGrdReadOnly(grd);
                grd.ColumnCount = 10;
                miApi.setColHeader(grd, 0, "Mes", 45);
                miApi.setColHeader(grd, 1, "Dst", 50);
                miApi.setColHeader(grd, 2, "% Dst", 65);
                miApi.setColHeader(grd, 3, "Time", 80);
                miApi.setColHeader(grd, 4, "Num", 45);
                miApi.setColHeader(grd, 5, "DstAcu", 75);
                miApi.setColHeader(grd, 6, "TimeAcu", 85);
                miApi.setColHeader(grd, 7, "DstAvg", 70);
                miApi.setColHeader(grd, 8, "VelAvg", 65);
                miApi.setColHeader(grd, 9, "TimeAvg", 80);
        }


        private void setColHeaderGrdDatosMaxMinMes(DataGridView grd)
        {
            miApi.SetGrdReadOnly(grd);
         
            miApi.setColHeader(grd, 0, "Mes", 45);
            miApi.setColHeader(grd, 1, "DstMax", 65);
            miApi.setColHeader(grd, 2, "DstMin", 65);
            miApi.setColHeader(grd, 3, "VelMax", 70);
            miApi.setColHeader(grd, 4, "VelMin", 70);
            miApi.setColHeader(grd, 5, "TimeMax", 80);
            miApi.setColHeader(grd, 6, "TimeMin", 80);
        }

        private void setColHeaderGrdDatosTodos(DataGridView grd)
        {
            miApi.SetGrdReadOnly(grd);
          
            miApi.setColHeader(grd, 0, "Mes", 45);
            miApi.setColHeader(grd, 1, "Fecha", 90);
            miApi.setColHeader(grd, 2, "Dst", 65);
            miApi.setColHeader(grd, 3, "Vel", 65);
            miApi.setColHeader(grd, 4, "Time", 80);
            miApi.setColHeader(grd, 5, "DstAcu", 70);
            miApi.setColHeader(grd, 6, "TimeAcu", 80);
        }

        //private void setScaleY(double maxvalor, int intervalo, int basemaxvalor, ref Chart migrafico, ref Axis miejeY)
        //{
        //    //int intervalo;

        //    //aumentar maxvalor hasta que al dividir por basemaxvalor de 0
        //    while (maxvalor % basemaxvalor != 0)
        //    {
        //        maxvalor++;
        //    }

        //    miejeY.Minimum = 0;
        //    miejeY.Maximum = maxvalor;

        //    miejeY.Interval = intervalo;
        //    miejeY.MajorGrid.Interval = intervalo;
        //    miejeY.MajorTickMark.Interval = intervalo;

        //    miejeY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
        //    migrafico.ChartAreas[0].RecalculateAxesScale();
        
        //}


      
        private void cargarDatosMaxMinMes(int añoselect)
        {
            string mysql;
            DataSet mids;
         

            try
            {

                mysql = "SELECT strftime('%m',dtfecha) as MES " +
                " , max(distancia) AS [DST MAX] " +
                " , min(distancia) as [DST MIN] " +
                " , max(velocidad) AS [VEL MAX] " +
                " , min(velocidad) as [VEL MIN] " +
                " , cast(max(duracion) as varchar(6)) as [TIME MAX] " +
                " , cast(min(duracion) as varchar(6)) as [TIME MIN] " +
                " FROM tbl_workout " +
                " WHERE tipoactividad=2 " +
                " and strftime('%Y',dtfecha)='" + añoselect.ToString() + "'" +
                " GROUP BY strftime('%m',dtfecha) " +
                " ORDER BY strftime('%m',dtfecha) ";

                mids = miclaseBD.FillDataset(mysql, bikedb);
                miApi.cambiarDatasetNMesStrMes(mids, "MES");
                miApi.cambiarDatasetSecsToHhmmss(mids, "TIME MAX");
                miApi.cambiarDatasetSecsToHhmmss(mids, "TIME MIN");
                this.grdDatosMaxMinMes.DataSource = mids.Tables[0];
                setColHeaderGrdDatosMaxMinMes(grdDatosMaxMinMes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }



        private void cargarTodosDatos(int añoselect)
        {
            string mysql;
            DataSet mids;


            try
            {

                mysql = "SELECT strftime('%m',dtfecha) as MES " +
                " , dtfecha as FECHA " +
                " , distancia AS DST " +
                " , velocidad AS VELO " +
                " , cast(duracion as varchar(6)) as TIME " +
                " , '' AS [DST ACUM] " +
                " , '' AS [TIME ACUM] " +
                " FROM tbl_workout " +
                " WHERE tipoactividad=2 " +
                " and strftime('%Y',dtfecha)='" + añoselect.ToString() + "'" +
                " ORDER BY dtfecha ";

                mids = miclaseBD.FillDataset(mysql, bikedb);
                miApi.cambiarDatasetNMesStrMes(mids, "MES");
                
                //miApi.cambiarDatasetSecsToHhmmss(mids, "TIME MIN");
                miApi.cambiarDataSetDstAcumula(mids, "DST", "DST ACUM");
                miApi.cambiarDataSetTimeAcumula(mids, "TIME", "TIME ACUM");
                miApi.cambiarDatasetSecsToHhmmss(mids, "TIME");
                miApi.cambiarDatasetSecsToHhmmss(mids, "TIME ACUM");

                this.grdTodasSalidas.DataSource = mids.Tables[0];
                setColHeaderGrdDatosTodos(grdTodasSalidas);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }



        private void cargarDatasetsAvgMes(int añoselect, ref DataSet dsdatosmes, ref DataSet dsdatosaño, ref DataSet dsdatosmaxmin)
        {
            string mysql;

            mysql = "SELECT sum(distancia) As Max_dst " +
          " FROM tbl_workout " +
          " WHERE  tipoactividad=2 " +
          " and strftime('%Y',dtfecha)='" + añoselect.ToString() + "'" +
          " GROUP BY strftime('%m',dtfecha) " +
          " Order By sum(distancia) desc " +
          " Limit 1 ";
            dsdatosmaxmin = miclaseBD.FillDataset(mysql, bikedb);


            mysql = "SELECT strftime('%m',dtfecha) as Mes" +
            ",sum(distancia) AS dst_mes " +
            ",sum(duracion) as time_mes " +
            ",count(distancia) AS salidas" +
            ",sum(distancia)/count(distancia) AS dst_salida " +
            ",sum(velocidad)/count(distancia) AS velo_salida " +
            ",sum(duracion)/count(distancia) AS time_salida " +
            " FROM tbl_workout" +
            " WHERE  tipoactividad=2 " +
            " and strftime('%Y',dtfecha)='" + añoselect + "'" +
            " GROUP BY strftime('%m',dtfecha)" +
            " ORDER BY strftime('%m',dtfecha) ";
            dsdatosmes = miclaseBD.FillDataset(mysql, bikedb);

            mysql = "SELECT sum(distancia) AS Tot_dst " +
            ", sum(duracion) as Tot_time " +
            ", count(distancia) AS Tot_Salidas" +
            " FROM tbl_workout" +
            " WHERE  tipoactividad=2 " +
            " and strftime('%Y',dtfecha)='" + añoselect + "'" +
            " GROUP BY strftime('%Y',dtfecha)";
            dsdatosaño = miclaseBD.FillDataset(mysql, bikedb);
        
        }


        private void InitGraficosDistancia(DataSet dsdatosmaxmin, DataSet dsdatosaño, double dstaño)
        {
            DataRow mifila;
            double maxvalor;

           

            if (dsdatosmaxmin.Tables[0].Rows.Count > 0)
            {
                mifila = dsdatosmaxmin.Tables[0].Rows[0];
                maxvalor = Math.Floor((double)mifila["Max_dst"] * 1.1);
                miApi.setScaleY(maxvalor, 10, 10, ref this.chrDistancia, ref chrDistancia.ChartAreas[0].Axes[1]);
                miApi.setScaleY(maxvalor, 10, 10, ref this.chrDistancia, ref chrDistancia.ChartAreas[0].Axes[3]);

            }

            if (dsdatosaño.Tables[0].Rows.Count > 0)
            {
                mifila = dsdatosaño.Tables[0].Rows[0];
                dstaño = (double)mifila["Tot_dst"];
                maxvalor = Math.Floor(dstaño * 1.1);
                miApi.setScaleY(maxvalor, 100, 10, ref this.chrDistanciaAcu, ref chrDistanciaAcu.ChartAreas[0].Axes[1]);
                miApi.setScaleY(maxvalor, 100, 10, ref this.chrDistanciaAcu, ref chrDistanciaAcu.ChartAreas[0].Axes[3]);
            }

        
        }




        private void cargarDatosAvgMes(int añoselect)
        { 
       
           
            int i,j;
            DataSet dsdatosmes, dsdatosaño, dsdatosmaxmin;
            DataRow filadatmes;
            string strmes;
            int nmes;
            int numfila;
            double dstacumula=0, dstaño=0;
            long timeacumula = 0;

            dsdatosmes=new DataSet();
            dsdatosaño=new DataSet();
            dsdatosmaxmin=new DataSet();
            
            this.chrDistancia.Series[0].Points.Clear();
            this.chrDistanciaAcu.Series[0].Points.Clear();

            setColHeaderGrdDatosAvgMes(this.grdDatosAvgMes);

            cargarDatasetsAvgMes(añoselect, ref dsdatosmes,ref dsdatosaño, ref dsdatosmaxmin);

            numfila = 0;
            grdDatosAvgMes.Rows.Clear();
            for (j = 1; j <= 12; j++)
            {

                strmes = Microsoft.VisualBasic.DateAndTime.MonthName(j, true);
                strmes = strmes.ToUpper();

                if (dsdatosmes.Tables[0].Rows.Count > 0)
                {
                    grdDatosAvgMes.Rows.Add();
                    grdDatosAvgMes.Rows[numfila].Cells["MES"].Value = strmes;
                }

                numfila++;
            }


            if (dsdatosmes.Tables[0].Rows.Count > 0)
            {

                if (dsdatosaño.Tables[0].Rows.Count > 0)
                {
                    dstaño = (double)dsdatosaño.Tables[0].Rows[0]["Tot_dst"];
                }

                InitGraficosDistancia(dsdatosmaxmin, dsdatosaño, dstaño);

                cargarGraficos(añoselect, dsdatosmes, dsdatosaño, dsdatosmaxmin); 


                numfila = 0;
                //for (i = 0; i < dsdatosmes.Tables[0].Rows.Count; i++)
                i = 0;
                for (j=1; j<=12;j++)
                {
                    

                    if (i<dsdatosmes.Tables[0].Rows.Count)
                    {

                        filadatmes = dsdatosmes.Tables[0].Rows[i];
                        
                        
                        nmes = int.Parse(filadatmes["Mes"].ToString());
                        /*
                        strmes = Microsoft.VisualBasic.DateAndTime.MonthName(nmes, true);
                        strmes = strmes.ToUpper();
                        */
                        if (j == nmes)
                        {
                            dstacumula = dstacumula + (double)filadatmes["dst_mes"];
                            timeacumula = timeacumula + (long)filadatmes["time_mes"];             

                            //Cargar datos en el datagrid de medias Mes

                            //grdDatosAvgMes.Rows.Add();

                            //grdDatosAvgMes.Rows[numfila].Cells["MES"].Value = strmes;
                            grdDatosAvgMes.Rows[numfila].Cells["DST"].Value = (double)filadatmes["dst_mes"];
                            grdDatosAvgMes.Rows[numfila].Cells["% DST"].Value = Math.Round(((double)filadatmes["dst_mes"] / dstaño) * 100, 2);

                            grdDatosAvgMes.Rows[numfila].Cells["TIME"].Value = miApi.convertsecs_hhmmss((long)filadatmes["time_mes"]);
                            grdDatosAvgMes.Rows[numfila].Cells["NUM"].Value = filadatmes["salidas"];
                            grdDatosAvgMes.Rows[numfila].Cells["DSTACU"].Value = dstacumula;
                            grdDatosAvgMes.Rows[numfila].Cells["TIMEACU"].Value = miApi.convertsecs_hhmmss((long)timeacumula);
                            grdDatosAvgMes.Rows[numfila].Cells["DSTAVG"].Value = Math.Round((double)filadatmes["dst_salida"], 2);
                            grdDatosAvgMes.Rows[numfila].Cells["VELAVG"].Value = Math.Round((double)filadatmes["velo_salida"], 2);
                            grdDatosAvgMes.Rows[numfila].Cells["TIMEAVG"].Value = miApi.convertsecs_hhmmss((long)filadatmes["time_salida"]);
                            i++;
                        } //if (j == nmes)
                    }
                    //else
                    //{
                    //    //grdDatosAvgMes.Rows.Add();
                    //    //grdDatosAvgMes.Rows[numfila].Cells["MES"].Value = strmes.ToUpper();
                    //     grdDatosAvgMes.Rows[numfila].Cells["DSTACU"].Value = dstacumula;
                    //    grdDatosAvgMes.Rows[numfila].Cells["TIMEACU"].Value = miApi.convertsecs_hhmmss((long)timeacumula);

                   
                    //} // if (i<dsdatosmes.Tables[0].Rows.Count)

                    
                    numfila++;

                } // for (j=1; j<=12;j++)
               
            } //if (dsdatosmes.Tables[0].Rows.Count > 0)

            dsdatosmes.Dispose();
            dsdatosaño.Dispose();
            dsdatosmaxmin.Dispose();
        
        }



        private void cargarGraficos(int añoselect, DataSet dsdatosmes
        , DataSet dsdatosaño, DataSet dsdatosmaxmin)
        {

            int i, j;
            DataRow filadatmes;
            string strmes;
            int nmes;
            double dstacumula = 0, dstaño = 0;
          
            this.chrDistancia.Series[0].Points.Clear();
            this.chrDistanciaAcu.Series[0].Points.Clear();

          
            for (j = 1; j <= 12; j++)
            {

                strmes = Microsoft.VisualBasic.DateAndTime.MonthName(j, true);
                strmes = strmes.ToUpper();

                chrDistancia.Series[0].Points.AddXY(strmes, 0);
                chrDistancia.Update();

                chrDistanciaAcu.Series[0].Points.AddXY(strmes, 0);
                chrDistanciaAcu.Update();
            }



            if (dsdatosmes.Tables[0].Rows.Count > 0)
            {

                if (dsdatosaño.Tables[0].Rows.Count > 0)
                {
                    dstaño = (double)dsdatosaño.Tables[0].Rows[0]["Tot_dst"];
                }

                InitGraficosDistancia(dsdatosmaxmin, dsdatosaño, dstaño);

                i = 0;
                for (j = 1; j <= 12; j++)
                {

                    if (i < dsdatosmes.Tables[0].Rows.Count)
                    {

                        filadatmes = dsdatosmes.Tables[0].Rows[i];
                        nmes = int.Parse(filadatmes["Mes"].ToString());
                    
                        if (j == nmes)
                        {
                            dstacumula = dstacumula + (double)filadatmes["dst_mes"];              

                            //Añadir puntos a los graficos de distancia y distanciaAcum
                          
                            chrDistancia.Series[0].Points[j - 1].SetValueY(Math.Round((double)filadatmes["dst_mes"], 1));
                            chrDistancia.Update();

                            //chrDistanciaAcu.Series[0].Points[j - 1].SetValueY(dstacumula);
                            //chrDistanciaAcu.Update();

                            i++;
                        } //if (j == nmes)
                    }
                    //else
                    //{
                    //    chrDistanciaAcu.Series[0].Points[j - 1].SetValueY(dstacumula);
                    //    chrDistanciaAcu.Update();
                    //} // if (i<dsdatosmes.Tables[0].Rows.Count)

                    chrDistanciaAcu.Series[0].Points[j - 1].SetValueY(dstacumula);
                    chrDistanciaAcu.Update();

                } // for (j=1; j<=12;j++)


                chrDistancia.Refresh();
                chrDistanciaAcu.Refresh();

            } //if (dsdatosmes.Tables[0].Rows.Count > 0)

        }



        private void frm_infosalidas_FormClosed(object sender, FormClosedEventArgs e)
        {

            miclaseBD.CloseSqliteDb(ref bikedb);

            this.Owner.Show();

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbAños_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarDatosForm();
        }

       
    }
}
