using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace BikeNet
{
   
   
    class clsBBDD
    {

        public int AñoIni = 2000;


        //public SQLiteConnection BikeDb;
    
    
        public void OpenSqliteDb(ref SQLiteConnection midb, string ruta)
        {
            string rutabd;

            rutabd = miApi.ReadVarAppConfig("cnn_bd");
            midb = new SQLiteConnection();
            //midb.ConnectionString = @"Data Source=Bike.s3db;Pooling=true;FailIfMissing=false;"; 
            //midb.ConnectionString = @"Data Source=E:\\Desarollo_Projects\\VBNET\\BikeNet_VS2012\\Bike.s3db;Pooling=true;FailIfMissing=false;";
            midb.ConnectionString = @"Data Source=" + rutabd;
            //+ ruta + "\\Bike.s3db";
            midb.Open();

        }


        public void CloseSqliteDb(ref SQLiteConnection midb)
        {

            midb.Close();
            midb.Dispose();

        }


        public DataSet FillDataset(string strsql, SQLiteConnection midb)
        {
            SQLiteDataAdapter mida;
            DataSet mids;
            
            mida = new SQLiteDataAdapter(strsql,midb);

            //Llena el DataSet
            mids = new DataSet();
            mids.Reset();
            mida.Fill(mids);

            return mids;
        }


      

        


        public string ValNulo(object objValue, string tipoValor) 
        {


            if ( !(objValue is DBNull) )
            {
               switch (tipoValor.ToUpper())
               {
                   case "TEXT":
                        return objValue.ToString().Trim();
                        

                    case "NUM":
                        //return Math.Round(double.Parse(objValue.ToString()), 2);
                        return Math.Round(double.Parse(objValue.ToString()), 2).ToString();

                    case "BOOLEAN":
                        //return Boolean.Parse(objValue.ToString();
                        return objValue.ToString(); 

                    default:
                        return "";
                      

                }

            }
            else
            {
                switch (tipoValor.ToUpper())
                {
                    case "TEXT":
                        return "";
                    case "NUM":
                        return "0";
                    case "BOOLEAN":
                        return "0"; //false;

                    default:
                        return "";

                }


            }

        }



    }
}
