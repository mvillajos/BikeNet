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
using System.Configuration;
using OfficeOpenXml;

namespace BikeNet
{ 

    static class miApi
    {



        public static string ReadVarAppConfig(string nombreVar)
        {
            //leer una variable de app.config
            string resultado = null;
            try
            {
                resultado = ConfigurationManager.AppSettings[nombreVar];
            }
            catch (Exception ex)
            {
                resultado = null;
            }
            return resultado;
        }


     public static void setRowHeader(DataGridView grd, int numRow, string titulo )
        {
            grd.Rows[numRow].HeaderCell.Value = titulo;
            grd.Rows[numRow].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grd.Columns[numRow].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }


       public static void setColHeader(DataGridView grd, int numCol, 
        string titulo , int ancho , Boolean  Ocultar = false)
       {
            grd.Columns[numCol].HeaderText = titulo;
            grd.Columns[numCol].Name = titulo;
            if (Ocultar==true) 
                grd.Columns[numCol].Visible = false;
            else
            {
                grd.Columns[numCol].Width = ancho;
                grd.Columns[numCol].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grd.Columns[numCol].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
       }



         public static void SetGrdReadOnly(DataGridView grd)
         {
            grd.AllowUserToAddRows = false;
            grd.AllowUserToDeleteRows = false;
            grd.ReadOnly = true;
         }



         public static void cambiarDatasetNMesStrMes(DataSet mids, string nomcolumna)
         {
             int numregs, nfila, nmes;
             string strmes;

             numregs = mids.Tables[0].Rows.Count;

             for (nfila = 0; nfila <= numregs - 1; nfila++)
             {
                 nmes = int.Parse(mids.Tables[0].Rows[nfila][nomcolumna].ToString());
                 strmes = Microsoft.VisualBasic.DateAndTime.MonthName(nmes, true);
                 strmes = strmes.ToUpper();
                 mids.Tables[0].Rows[nfila][nomcolumna] = strmes;

             }

         }


         public static void cambiarDataSetDstAcumula(DataSet mids, string colDistancia, string colAcumula)
         {
             int numregs, nfila;
             double dstSumar, dstTotal;

             numregs = mids.Tables[0].Rows.Count;
             dstTotal = 0;

             for (nfila = 0; nfila <= numregs - 1; nfila++)
             {
                 dstSumar = double.Parse(mids.Tables[0].Rows[nfila][colDistancia].ToString());
                 dstTotal = dstTotal + dstSumar;
                 mids.Tables[0].Rows[nfila][colAcumula] = dstTotal;

             }
         
         }


         public static void cambiarDataSetTimeAcumula(DataSet mids, string colTime, string colAcumula)
         {
             int numregs, nfila;
             double timeSumar, timeTotal;

             numregs = mids.Tables[0].Rows.Count;
             timeTotal = 0;

             for (nfila = 0; nfila <= numregs - 1; nfila++)
             {
                 timeSumar = double.Parse(mids.Tables[0].Rows[nfila][colTime].ToString());
                 timeTotal = timeTotal + timeSumar;
                 mids.Tables[0].Rows[nfila][colAcumula] = timeTotal;

             }

         }


         public static void cambiarDatasetSecsToHhmmss(DataSet mids, string nomcolumna)
         {
             int numregs, nfila;
             long durasecs;
             string durahhmmss;

             try
             {

                 numregs = mids.Tables[0].Rows.Count;
                 //mids.Tables[0].Columns[nomcolumna].DataType = System.Type.GetType("System.String");
                 for (nfila = 0; nfila <= numregs - 1; nfila++)
                 {
                     durasecs = int.Parse(mids.Tables[0].Rows[nfila][nomcolumna].ToString());
                     durahhmmss =convertsecs_hhmmss(durasecs);
                     mids.Tables[0].Rows[nfila][nomcolumna] = durahhmmss;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }

         }



         public static int converthhmmss_secs(string strtiempo)
         {
             int hh, mm, ss;
             DateTime dttiempo;
             int resul;

             if (strtiempo.IndexOf("_") > 0)
                 resul = -1;
             else
             {
                 dttiempo = DateTime.Parse(strtiempo);

                 hh = dttiempo.Hour;
                 mm = dttiempo.Minute;
                 ss = dttiempo.Second;

                 resul = hh * 3600 + mm * 60 + ss;
             }

             return resul;

         }


         public static double converthhmmss_hours(string strtiempo)
         {
             Single hh, mm, ss;
             DateTime dttiempo;
             double resul;

             //if (strtiempo == "__:__:__")
             if (strtiempo.IndexOf("_") > 0)
                 resul = -1;
             else
             {
                 dttiempo = DateTime.Parse(strtiempo);

                 hh = dttiempo.Hour;
                 mm = dttiempo.Minute;
                 ss = dttiempo.Second;

                 resul = hh + mm / 60 + ss / 3600;
                 resul = Math.Round(resul, 2);
             }

             return resul;

         }


         public static string convertsecs_hhmmss(long tsecs)
         {
             int hh, mm, ss;
             string resul;

             if (tsecs > 0)
             {
                 hh = (int)tsecs / 3600;
                 mm = (int)(tsecs % 3600) / 60;
                 ss = (int)tsecs % 60;

                 resul = hh.ToString() + "h " + mm.ToString() + "m " + ss.ToString() + "s ";
             }
             else
             {
                 resul = "0h 0m 0s";

             }

             return resul;

         }


         public static string SetAnsiFecha(DateTime strfecha)
         {
             string resul = "";

             resul = strfecha.ToString("yyyy-MM-dd");

             return resul;
         }


         public static string SetAnsiFechaTiempo(DateTime strfecha)
         {
             string resul = "";

             resul = strfecha.ToString("yyyy-MM-dd HH:mm:ss");

             return resul;
         }

         public static void setScaleY(double maxvalor, int basemaxvalor, int numdivisions, ref Chart migrafico, ref Axis miejeY)
         {
             double intervalo2;

             //aumentar maxvalor hasta que al dividir por basemaxvalor de 0
             while (maxvalor % basemaxvalor != 0)
             {
                 maxvalor++;
             }

             miejeY.Minimum = 0;
             miejeY.Maximum = maxvalor;

             intervalo2 = Math.Floor(maxvalor / numdivisions);
             while (intervalo2 % 10 != 0)
             {
                 intervalo2++;
             }

             miejeY.Interval = intervalo2;
             miejeY.MajorGrid.Interval = intervalo2;
             miejeY.MajorTickMark.Interval = intervalo2;

             miejeY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
             migrafico.ChartAreas[0].RecalculateAxesScale();

         }


        public static bool IsNull(object T)
        {
            return T == null;
        }

        public static string GetXlsCellContent(int nfila, int ncol, ExcelWorksheet xlWorksheet)
        {
            object celda_value = xlWorksheet.Cells[nfila, ncol].Value ?? "";
            string celda_strval = celda_value.ToString();

            return celda_strval;
        }


        public static void addGapRowGrid(DataGridView grd, int año1, int año2)
        {
            if (grd.Rows.Count == 2)
            {
                grd.Rows.Add();
                int nrow = grd.Rows.Count - 1;
                int currentMonth = DateTime.Now.Month;
                int currentYear = DateTime.Now.Year;

                grd.Rows[nrow].Cells[0].Value = "GAP";

                for (int ncol = 1; ncol < grd.Columns.Count; ncol++)
                {

                    if (año1 == currentYear || año2 == currentYear)
                        if (ncol <= currentMonth)
                            break;

                    string dstCurYear = "0";
                    string dstPrevYear = "0";

                    if (!miApi.IsNull(grd.Rows[0].Cells[ncol].Value))
                        dstCurYear = grd.Rows[0].Cells[ncol].Value.ToString();

                    if (!miApi.IsNull(grd.Rows[1].Cells[ncol].Value))
                        dstPrevYear = grd.Rows[1].Cells[ncol].Value.ToString();

                    if (dstCurYear != "0" || dstPrevYear != "0")
                    {
                        double valDstCur, valDstPrev, valGap;
                        double.TryParse(dstCurYear, out valDstCur);
                        double.TryParse(dstPrevYear, out valDstPrev);
                        valGap = valDstCur - valDstPrev;
                        grd.Rows[nrow].Cells[ncol].Value = valGap;
                    }
                }

            }

        }


    }



}