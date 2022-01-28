using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;
using System.Data.SQLite;
using System.Configuration;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using System.Globalization;

namespace BikeNet
{
    public partial class frm_importar : Form
    {
        private const int maxRegistrosExcel= 120;

        private enum colXls
        {
            fecha=1,
            dst,
            time,
            velo,
            inserted
        }

        private SQLiteConnection bikedb;
        clsBBDD miclase;

        public frm_importar()
        {
            InitializeComponent();
        }


        //private void ImportarToBd()
        //{
        //    Microsoft.Office.Interop.Excel.Application objexcel;
        //    Workbook objLibro;
        //    Worksheet objHoja;
        //    Range objRango;
        //    int nfila, nrowgrid, nreg;
        //    Boolean continuar;
        //    string ficheroxls;
        //    string dstexcel, veloexcel;
        //    string strfecha, strtiempo;
        //    string strsql;
        //    string strnumfila;
        //    double dblColorFondo;
        //    double fechaexcel, tiempoexcel;
        //    DateTime dtconversion;
        //    Single duracionsecs;
        //    SQLiteCommand comando;


        //    ficheroxls = miApi.ReadVarAppConfig("ruta_xls");

        //    objexcel = new Microsoft.Office.Interop.Excel.Application();
        //    objLibro = objexcel.Workbooks.Open(ficheroxls);
        //    objHoja = objLibro.Worksheets.get_Item(1);
        //    objexcel.Visible = true;

        //}


        //private void LeerCeldaXls(int nfila, colXls ncol, Range objRango, ref string resul)
        //{
        //    object aux;

        //    aux=objRango.Cells[nfila, ncol].Value2;

        //    if (aux != null)
        //        resul = aux.ToString();

        //}

        const string sheetName = @"2021";

        private void ImportarToBd_v2()
        {
            int nfila, nrowgrid;
            string strfila;
            string ficheroxls;
            string strfecha, strtiempo;
            string strsql;
            int nreg;
            
            DateTime dtconversion;
            Single duracionsecs;
            SQLiteCommand comando;

            comando = new SQLiteCommand(bikedb);

            nrowgrid = 0;

            ficheroxls = miApi.ReadVarAppConfig("ruta_xls");
            //ficheroxls = @"C:\temp\salidas_2018.xlsx";
            FileInfo newFile = new FileInfo(ficheroxls);

            CultureInfo enUS = new CultureInfo("en-US");
            bool errorCamposExcel=false;

            using (ExcelPackage xlPackage = new ExcelPackage(newFile)) // create the xlsx file
            {

                // use LINQ to query collection of worksheets
                ExcelWorksheet xlWorksheet = xlPackage.Workbook.Worksheets.SingleOrDefault(ws => ws.Name == sheetName);
                if (xlWorksheet != null)
                {

                    object celda_fecha, celda_dst, celda_time, celda_velo, celda_inserted;
                    string fecha, dst, time_hms, velo;

                    for ( nfila = 2; nfila < maxRegistrosExcel; nfila++)
                    {
                        strfila = nfila.ToString();

                        celda_fecha = xlWorksheet.Cells["A" + strfila].Value;
                        celda_dst = xlWorksheet.Cells["B" + strfila].Value;
                        celda_time = xlWorksheet.Cells["C" + strfila].Value;
                        celda_velo = xlWorksheet.Cells["D" + strfila].Value;
                        celda_inserted = xlWorksheet.Cells["E" + strfila].Value;

                        if (celda_fecha != null && celda_dst!=null && celda_time!=null && celda_velo!=null && celda_inserted != null)
                        {
                            

                            if (celda_inserted.ToString() == "N")
                            {
                                errorCamposExcel = false;
                                strfecha = "";
                                strtiempo = "";
                                duracionsecs = -1;

                                fecha = celda_fecha.ToString();

                                dst = celda_dst.ToString();
                               
                                time_hms = celda_time.ToString();
                                time_hms = time_hms.Replace(".", ":");
                              
                                velo = celda_velo.ToString();
                                
                                dgvImport.Rows.Add();

                                //dtconversion = DateTime.FromOADate(double.Parse(fecha));
                                if (DateTime.TryParseExact(fecha, "yyyyMMdd", enUS, DateTimeStyles.None, out dtconversion))
                                {
                                    strfecha = dtconversion.Date.ToShortDateString();
                                    dgvImport.Rows[nrowgrid].Cells[0].Value = strfecha;
                                }
                                else
                                    errorCamposExcel = true;

                                dgvImport.Rows[nrowgrid].Cells[1].Value = dst;

                                //dtconversion = DateTime.FromOADate(double.Parse(time_hms));
                                if (DateTime.TryParseExact(time_hms, "h:mm:ss", enUS, DateTimeStyles.None, out dtconversion))
                                {
                                    strtiempo = dtconversion.ToLongTimeString();
                                    dgvImport.Rows[nrowgrid].Cells[2].Value = strtiempo;
                                    duracionsecs = miApi.converthhmmss_secs(strtiempo);
                                }
                                else
                                    errorCamposExcel=true;

                                dgvImport.Rows[nrowgrid].Cells[3].Value = velo;

                                if (!errorCamposExcel)
                                {
                                    strsql = "Insert Into tbl_workout " +
                                    " (tipoactividad, intanyo, intmes, dtfecha " +
                                    ", duracion, distancia, velocidad, dtimported) " +
                                    " Values (2, " + DateTime.Parse(strfecha).Year +
                                    ", " + DateTime.Parse(strfecha).Month +
                                    ", '" + miApi.SetAnsiFecha(DateTime.Parse(strfecha)) + "'" +
                                    ", " + duracionsecs +
                                    ", " + dst.Replace(",", ".") +
                                    ", " + velo.Replace(",", ".") +
                                    ", '" + miApi.SetAnsiFechaTiempo(DateTime.Now) + "')";

                                    comando.CommandText = strsql;
                                    nreg = comando.ExecuteNonQuery();
                                    //nreg = 0;

                                    if (nreg > 0)
                                    {
                                        //objHoja.get_Range("A" + strnumfila + ":" + "E" + strnumfila).Interior.Color = colorref;
                                        //objHoja.get_Range("E" + strnumfila).Value2 = "S";

                                        xlWorksheet.Cells["E" + strfila].Value = "S";
                                        this.txtLogSql.AppendText(strsql + "\n");
                                        xlPackage.Save();
                                    }

                                }
                                else
                                {
                                    this.txtLogSql.AppendText("Error procesando fila " + nfila + "\n");
                                }

                                nrowgrid++;

                                
                            }


                        }

                    }

                }

                //xlPackage.Save();

            }

        }

        //funcion que abre el fichero Excel
        //lee cada fila no sombreada en gris, la vuelca a la bd y al grid
        //private void ImportarToBd()
        //{
        //    Microsoft.Office.Interop.Excel.Application objexcel;
        //    Workbook objLibro;
        //    Worksheet objHoja;
        //    Range objRango;
            
        //    int nfila, nrowgrid, nreg;
        //    Boolean continuar;
        //    string ficheroxls;
        //    string dstexcel, veloexcel;
        //    string strfecha, strtiempo;
        //    string strsql;
        //    string strnumfila;
        //    string filavolcadabd;
        //    double dblColorFondo;
        //    string fechaexcel, tiempoexcel;
        //    DateTime dtconversion;
        //    Single duracionsecs;
        //    SQLiteCommand comando;
           


        //    ficheroxls = miApi.ReadVarAppConfig("ruta_xls");

        //    objexcel = new Microsoft.Office.Interop.Excel.Application();
        //    objLibro = objexcel.Workbooks.Open(ficheroxls);
        //    objHoja = objLibro.Worksheets.get_Item(1);
        //    objRango = objHoja.UsedRange;
        //    objexcel.Visible = true;

        //    nfila = 2;
        //    continuar = true;
        //    nrowgrid = 0;

        //    Color colorref = System.Drawing.Color.FromArgb(214, 214, 214);

        //    comando = new SQLiteCommand(bikedb);

        //    while (nfila < maxRegistrosExcel && continuar)
        //    {
               
        //        strnumfila = nfila.ToString();

        //        dblColorFondo = objHoja.get_Range("A" + strnumfila).Interior.Color;

        //        //Color colorcelda = System.Drawing.ColorTranslator.FromOle((int)dblColorFondo);
                
        //        fechaexcel = "0";
        //        dstexcel = "";
        //        tiempoexcel = "0";
        //        veloexcel = "";
        //        filavolcadabd = "";

        //        LeerCeldaXls(nfila, colXls.inserted, objRango, ref filavolcadabd);

        //        //si la celda no está coloreada en gris es que no está volcada
        //        //if (colorcelda.Name != colorref.Name)
        //        //Si la fila no ha sido ya volcada a la bbdd
        //        if (filavolcadabd.ToUpper()=="N")
        //        {

        //            //Fecha
        //            LeerCeldaXls(nfila, colXls.fecha, objRango, ref fechaexcel);

        //            //Distancia
        //            LeerCeldaXls(nfila, colXls.dst, objRango, ref dstexcel);

        //            //Tiempo
        //            LeerCeldaXls(nfila, colXls.time, objRango, ref tiempoexcel);

        //            //Velocidad
        //            LeerCeldaXls(nfila, colXls.velo, objRango, ref veloexcel);
                  

        //            if (fechaexcel != "0" && tiempoexcel != "0" && dstexcel != "")
        //            {

        //                dgvImport.Rows.Add();

        //                dtconversion = DateTime.FromOADate(double.Parse(fechaexcel));
        //                strfecha = dtconversion.Date.ToShortDateString();
        //                dgvImport.Rows[nrowgrid].Cells[0].Value = strfecha;

        //                dgvImport.Rows[nrowgrid].Cells[1].Value = dstexcel;

        //                dtconversion = DateTime.FromOADate(double.Parse(tiempoexcel));
        //                strtiempo = dtconversion.ToLongTimeString();
        //                dgvImport.Rows[nrowgrid].Cells[2].Value = strtiempo;

        //                dgvImport.Rows[nrowgrid].Cells[3].Value = veloexcel;

        //                duracionsecs = miApi.converthhmmss_secs(strtiempo);

        //                strsql = "Insert Into tbl_workout " +
        //                " (tipoactividad, intanyo, intmes, dtfecha " +
        //                ", duracion, distancia, velocidad, dtimported) " +
        //                " Values (2, " + DateTime.Parse(strfecha).Year +
        //                ", " + DateTime.Parse(strfecha).Month +
        //                ", '" + miApi.SetAnsiFecha(DateTime.Parse(strfecha)) + "'" +
        //                ", " + duracionsecs +
        //                ", " + dstexcel.Replace(",", ".") +
        //                ", " + veloexcel.Replace(",", ".") +
        //                ", '" + miApi.SetAnsiFechaTiempo(DateTime.Now) + "')";

        //                comando.CommandText = strsql;
        //                nreg = comando.ExecuteNonQuery();

        //                if (nreg > 0)
        //                {
        //                    objHoja.get_Range("A" + strnumfila + ":" + "E" + strnumfila).Interior.Color = colorref;
        //                    objHoja.get_Range("E" + strnumfila).Value2 = "S";
        //                    this.txtLogSql.AppendText(strsql + "\n");
        //                }

        //                nrowgrid++;

        //            } //if fechaexcel
        //            else
        //                continuar = false;

        //        } //if colorCelda

        //        nfila++;
        //    } //while

        //    objLibro.Save();
        //    objLibro.Close();
        //    objexcel.Quit();



        //}



        private void frm_importar_Load(object sender, EventArgs e)
        {

            miclase = new clsBBDD();

            try
            {
                miclase.OpenSqliteDb(ref bikedb, System.Windows.Forms.Application.StartupPath);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            dgvImport.Columns[0].Width = 90;
            dgvImport.Columns[1].Width = 60;
            dgvImport.Columns[2].Width = 70;
            dgvImport.Columns[3].Width = 60;


        } 


        private void BtVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_importar_FormClosed(object sender, FormClosedEventArgs e)
        {
            miclase.CloseSqliteDb(ref bikedb);
            this.Owner.Show();
        }

        private void BtVolcar_Click(object sender, EventArgs e)
        {
            //ImportarToBd();
            ImportarToBd_v2();
        }



        //private void BtVolcar_Click(object sender, EventArgs e)
        //{
        //    int nrowgrid, rowsgrid;
        //    String strsql;
        //    String fecha, duracion, distancia, velocidad;
        //    Single duracionsecs;
        //    SQLiteCommand comando;
        //    int nreg;

        //    this.txtLogSql.Clear();
        //    rowsgrid = dgvImport.Rows.Count;

        //    comando = new SQLiteCommand(bikedb);

        //    for (nrowgrid = 0; nrowgrid < rowsgrid; nrowgrid++)
        //    {

        //        fecha = dgvImport.Rows[nrowgrid].Cells[0].Value.ToString();
        //        distancia= dgvImport.Rows[nrowgrid].Cells[1].Value.ToString();
        //        duracion= dgvImport.Rows[nrowgrid].Cells[2].Value.ToString();
        //        velocidad= dgvImport.Rows[nrowgrid].Cells[3].Value.ToString();

        //        duracionsecs = miApi.converthhmmss_secs(duracion);

        //        strsql = "Insert Into tbl_salidas " +
        //        " (tipoactividad, intanyo, intmes, dtfecha " +
        //        ", duracion, distancia, velocidad) " +
        //        " Values (2, " + DateTime.Parse(fecha).Year +
        //        ", " + DateTime.Parse(fecha).Month +
        //        ", '" + miApi.SetAnsiFecha(DateTime.Parse(fecha)) + "'" +
        //        ", " + duracionsecs +
        //        ", " + distancia.Replace(",", ".") +
        //        ", " + velocidad.Replace(",", ".") + ")";

        //        comando.CommandText = strsql;
        //        nreg=comando.ExecuteNonQuery();

        //        if (nreg > 0)
        //        {
        //            this.txtLogSql.AppendText(strsql + "\n");
                
        //        }

        //    } //for


        //}

       

    }
}
