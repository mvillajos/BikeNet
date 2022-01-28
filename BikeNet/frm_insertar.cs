using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BikeNet
{
    public partial class frm_insertar : Form
    {

        private SQLiteConnection bikedb;
        //private SQLiteDataAdapter db; 
        private DataSet ds = new DataSet(); 
        private DataTable dt = new DataTable(); 
        private int idWorkout ;

        clsBBDD miclase;

        public frm_insertar()
        {
            InitializeComponent();
        }


        //****************************************//
        private void RellenarGrid(int año, int mes)
        {
            string strsql;

            strsql = "Select id, dtfecha as fecha, distancia " +
            ", velocidad, duracion_hms as duracion " +
            ", thoras, tmin, tsec " +
            " From Vst_Salidas " +
           " Where cast(anio as int)=" + año.ToString() + 
           " and cast(mes as int)=" + mes.ToString() ;

            ds = miclase.FillDataset(strsql, bikedb);

            //Asigna al DataTable la primer tabla del DataSet
            dt = ds.Tables[0];
            dgvDatos.DataSource = dt;
            dgvDatos.Columns[0].Visible = false;
            dgvDatos.Columns["thoras"].Visible = false;
            dgvDatos.Columns["tmin"].Visible = false;
            dgvDatos.Columns["tsec"].Visible = false;
        
        }


        //****************************************//
        private void frm_insertar_Load(object sender, EventArgs e)
        {

            //bikedb = new SQLiteConnection();
            miclase = new clsBBDD();
            this.idWorkout = -1;

            try
            {
                miclase.OpenSqliteDb(ref bikedb, Application.StartupPath);
            }
            catch (SQLiteException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            ResetearCampos();
            RellenarGrid(this.dtFecha.Value.Year, this.dtFecha.Value.Month);
           

        }


        //****************************************//
        private void frm_insertar_FormClosed(object sender, FormClosedEventArgs e)
        {


            miclase.CloseSqliteDb(ref bikedb);
          
            this.Owner.Show();
           
        }


        //****************************************//
        private void BtVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //****************************************//
        private void ResetearCampos()
        {
            this.dtFecha.Value = DateTime.Today;
            this.mskTiempo.Text = "00:00:00";
            this.txtDistancia.Text = "";
            this.txtAcumulado.Text = "";
            this.txtVelocidad.Text = "";

            this.idWorkout = -1;
        
        }

        //****************************************//
        private void BtResetear_Click(object sender, EventArgs e)
        {

            ResetearCampos();
            this.BtInsertar.Enabled = true;

        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            RellenarGrid(this.dtFecha.Value.Year, this.dtFecha.Value.Month);
           
        }


        private void Actualizar()
        {
            string strsql;
            SQLiteCommand comando;
            Single tiempoHoras;
            Single dstactual;
            Double velocidad;

            if (this.idWorkout<=0) 
            {
                MessageBox.Show("Error, idWorkout no es válido");
            }
            else
            {

                tiempoHoras = miApi.converthhmmss_secs(mskTiempo.Text);
                dstactual = Single.Parse(this.txtDistancia.Text.Replace(".", ","));
                velocidad = (dstactual / tiempoHoras) * 3600;
                velocidad = Math.Round(velocidad, 2);
                this.txtVelocidad.Text = velocidad.ToString();

                comando = new SQLiteCommand(bikedb);

                strsql = "UPDATE tbl_workout " +
                " SET intmes=" + dtFecha.Value.Month +
                ", intanyo=" + dtFecha.Value.Year +
                ", dtfecha='" + miApi.SetAnsiFecha(dtFecha.Value) + "'" +
                ", duracion=" + tiempoHoras.ToString() +
                ", distancia=" + dstactual.ToString().Replace(",",".") +
                ", velocidad=" + velocidad.ToString().Replace(",",".") +
                " WHERE ID=" + this.idWorkout;
                comando.CommandText = strsql;
                comando.ExecuteNonQuery();

                RellenarGrid(this.dtFecha.Value.Year, this.dtFecha.Value.Month);

            }

        }


        private void Borrar()
        {
            string strsql;
            SQLiteCommand comando;
           

            if (this.idWorkout <= 0)
            {
                MessageBox.Show("Error, idWorkout no es válido");
            }
            else
            {

                comando = new SQLiteCommand(bikedb);

                strsql = "Delete From tbl_workout " +
                " WHERE ID=" + this.idWorkout;
                comando.CommandText = strsql;
                comando.ExecuteNonQuery();

                RellenarGrid(this.dtFecha.Value.Year, this.dtFecha.Value.Month);
                ResetearCampos();

            }

        }




        private void Insertar()
        {
            string strsql;
            DataSet mids;
            Single totaldst, dstactual ;
            Double velocidad;
            Single tiempoHoras ;
            //DataRow mifila;
            //DataColumn micol;
            SQLiteCommand comando;


            strsql = "Select sum(distancia) " +
            " From Vst_Salidas " +
            " Where cast(anio as int)=" + this.dtFecha.Value.Year;
            mids = miclase.FillDataset(strsql, bikedb);

            dstactual=Single.Parse(this.txtDistancia.Text.Replace(".",","));
            
            
            Object o = mids.Tables[0].Rows[0][0];

            if (o.ToString()=="")
            {
                totaldst = dstactual;
            }
            else
            {
                totaldst = dstactual + Single.Parse(o.ToString());
            }

            tiempoHoras=miApi.converthhmmss_secs(this.mskTiempo.Text);
            this.txtAcumulado.Text = totaldst.ToString();
            velocidad=(dstactual/tiempoHoras)*3600;
            velocidad = Math.Round(velocidad , 2);
            this.txtVelocidad.Text = velocidad.ToString();

            comando = new SQLiteCommand(bikedb);
            strsql = "Insert Into Tbl_WorkOut " +
                " (tipoactividad, dtfecha, duracion, distancia, velocidad, intmes, intanyo)" +
                " VALUES (" +
                "2" +
                ", '" + miApi.SetAnsiFecha(dtFecha.Value) + "'" +
                "," + tiempoHoras.ToString() +
                "," + dstactual.ToString().Replace(",",".") +
                "," + velocidad.ToString().Replace(",",".") +
                "," + dtFecha.Value.Month +
                "," + dtFecha.Value.Year +
                ")" ;
            comando.CommandText=strsql;
            comando.ExecuteNonQuery();

            RellenarGrid(this.dtFecha.Value.Year, this.dtFecha.Value.Month);
        
        }

        private void BtInsertar_Click(object sender, EventArgs e)
        {
            Insertar();
            this.BtInsertar.Enabled = false;

        }


        private void SetVelocidad(string distancia, string tiempo)
        {
            double dst;
            double velocidad, tsecs;
            string txtdst;

            txtdst = distancia;
            txtdst = txtdst.Replace(".", ",");
            if (double.TryParse(txtdst, out dst))
            {
                tsecs = miApi.converthhmmss_secs(tiempo);
                if (tsecs > 0)
                {
                    velocidad = (dst / tsecs)*3600;
                    velocidad = Math.Round(velocidad, 2);
                    this.txtVelocidad.Text = velocidad.ToString();
                }
                else
                {
                    this.txtVelocidad.Text = "";
                }

            }
            else
            {
                this.txtVelocidad.Text = "";
            }
        
        
        }


        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {

           SetVelocidad(this.txtDistancia.Text, this.mskTiempo.Text);

        }


        private void mskTiempo_TextChanged(object sender, EventArgs e)
        {

            SetVelocidad(this.txtDistancia.Text, this.mskTiempo.Text);
        
        }

      

        private void dgvDatos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;
            int horas, min, sec;
            TimeSpan tiempo;

            fila = dgvDatos.CurrentRow.Index;
            this.idWorkout = -1;

            if (dgvDatos.Rows.Count>=1) 
            {
                this.idWorkout=int.Parse(dgvDatos.Rows[fila].Cells["id"].Value.ToString());
              
                dtFecha.Value=DateTime.Parse(dgvDatos.Rows[fila].Cells["fecha"].Value.ToString());
                
                horas =int.Parse(dgvDatos.Rows[fila].Cells["thoras"].Value.ToString());
                min= int.Parse(dgvDatos.Rows[fila].Cells["tmin"].Value.ToString());
                sec = int.Parse(dgvDatos.Rows[fila].Cells["tsec"].Value.ToString());
                tiempo = new TimeSpan(horas, min, sec);
                mskTiempo.Text = tiempo.ToString(); 
                txtDistancia.Text =dgvDatos.Rows[fila].Cells["distancia"].Value.ToString();

//txtAcumulado

            }

           
        }


        private void BtGuardar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void BtBorrar_Click(object sender, EventArgs e)
        {
            Borrar();
        }

       
      

      
        


    }
}
