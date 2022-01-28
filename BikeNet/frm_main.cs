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
    public partial class frm_main : Form
    {

       

        public frm_main()
        {
            InitializeComponent();
           
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
           
           

        }

       

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            this.Close();
          
        }

        private void frm_main_close(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Cerrado");
            Application.Exit();    
        }

    
      
        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frm_insertar frm = new frm_insertar();
            frm.Show(this);
            
        }

      

        private void resumenMensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_infosalidas frm = new frm_infosalidas();
            frm.Show(this);
        }

        private void distanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_cmpdst frm = new frm_cmpdst();
            frm.Show(this);
        }

        private void distanciaAcumuladaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frm_cmpdstacu frm = new frm_cmpdstacu();
            frm.Show(this);
        }

        private void importarExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_importar frm = new frm_importar();
            frm.Show(this);
        }




    }
}
