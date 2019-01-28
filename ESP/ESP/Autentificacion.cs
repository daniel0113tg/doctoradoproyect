using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESP
{
    class Autentificacion
    {
        public Autentificacion()
        {
        }
        public int devuelveTipo(String tipo)
        {
            int i = 0;
            switch (tipo) {
                case "ESTUDIANTE":
                    i = 0;
                    break;
                case "DIRECTOR":
                    i = 1;
                    break;
                case "COORDINADOR":
                    i = 2;
                    break;
                case "PROFESOR":
                    i = 3;
                    break;

            }
            return i;
        }

            public Boolean verificarContrasena(String tipo, String usuario, String contrasena)
            {
                Boolean ban = false;
                String line = "";
                SqlConnection cn = new Conexion().abrirConexion();
                string cadena = "SELECT CEDULA FROM " + tipo + " WHERE CEDULA ='" + usuario + "'";
                SqlCommand cmd = new SqlCommand(cadena, cn);
                SqlDataReader leer = cmd.ExecuteReader();
            try
            {
                if (leer.Read() == true)
                {
                    ban = true;
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ban;
            }
        

        private ArrayList cargarArchivo(String file)
        {
            ArrayList arrText = new ArrayList();
            try
            {
                StreamReader objReader = new StreamReader(@file);
                string sLine = "";
                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null)
                        arrText.Add(sLine);
                }
                objReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("err msg {0}", e);
                throw;
            }
            return arrText;
        }
    }
}
