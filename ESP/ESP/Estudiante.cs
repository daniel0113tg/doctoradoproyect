/*
 * Created by SharpDevelop.
 * User: Lenovo
 * Date: 2019-01-16
 * Time: 18:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace ESP
{
	/// <summary>
	/// Description of Estudiante.
	/// </summary>
	public class Estudiante
	{
        private SqlConnection cn = null;
        private String[] datosPersonales = new String[9];
        private String director = "";
        public Estudiante(String username)
		{
            cargaEstudiante(username);
		}

        public void cargaEstudiante(String cedula) {
            cn = new Conexion().abrirConexion();
            string cadena = "SELECT * FROM ESTUDIANTE WHERE CEDULA ='" + cedula + "'";
            SqlCommand cmd = new SqlCommand(cadena,cn);
            try {
                SqlDataReader leer = cmd.ExecuteReader();
                if (leer.Read() == true)
                {
                    datosPersonales[0] = leer["ID_ESTUDIANTE"].ToString();
                    datosPersonales[1] = leer["CEDULA"].ToString();
                    datosPersonales[2] = leer["NOMBRES"].ToString();
                    datosPersonales[3] = leer["APELLIDOS"].ToString();
                    datosPersonales[4] = leer["FECHA_NACIMIENTO"].ToString();
                    datosPersonales[5] = leer["CORREO"].ToString();
                    datosPersonales[6] = leer["DIRECCION"].ToString();
                    director = leer["ID_DIRECTOR"].ToString();
                    leer.Close();
                }
                cadena = "SELECT * FROM MATRICULA WHERE ID_ESTUDIANTE ='" + datosPersonales[0] + "'";
                cmd = new SqlCommand(cadena, cn);
                SqlDataReader leer1 = cmd.ExecuteReader();
                if (leer1.Read() == true)
                {
                    datosPersonales[7] = leer1["NIVEL"].ToString();
                    datosPersonales[8] = leer1["NUM_MATRICULA"].ToString();
                    leer1.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cn.Close();
        }
        public SqlDataAdapter visualizarRevistas()
        {
            cn = new Conexion().abrirConexion();
            SqlDataAdapter da = new SqlDataAdapter("MOSTRAR_REVISTAS" , cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id_estudiante", SqlDbType.Int).Value = Convert.ToInt32(datosPersonales[0]);
            cn.Close();
            return da;
        }
        public SqlDataAdapter visualizarConferencias()
        {
            cn = new Conexion().abrirConexion();
            SqlDataAdapter da = new SqlDataAdapter("MOSTRAR_CONFERENCIAS", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id_estudiante", SqlDbType.Int).Value = Convert.ToInt32(datosPersonales[0]);
            cn.Close();
            return da;
        }

        public SqlDataAdapter visualizarFormatos()
        {
            cn = new Conexion().abrirConexion();
            SqlDataAdapter da = new SqlDataAdapter("MOSTRAR_FORMATOS " , cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id_estudiante", SqlDbType.Int).Value = Convert.ToInt32(datosPersonales[0]);
            cn.Close();
            return da;
        }

        public String[] visualizarEstudiante()
        {
        return datosPersonales;

        }
        //insert
        public void insertaPRevista(String[] array)
        {
            cn = new Conexion().abrirConexion();
            string sql = @"insert into revista (ID_ESTUDIANTE,TIPO_FORMATO,COHORTE,ESTADO,TITULO_PUBLICACION,NOMBRE_REVISTA,NOMBRE_COAUTOR,FECHA_PUBLICACION, DOI,INDEXACION, RANKING,QUARTIL, URL)
                 values(  @ID_ESTUDIANTE, @TIPO_FORMATO,@COHORTE, @ESTADO,@TITULO_PUBLICACION, @NOMBRE_REVISTA,  @NOMBRE_COAUTOR, @FECHA_PUBLICACION , @DOI, @INDEXACION, @RANKING,@QUARTIL, @URL)";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@ID_ESTUDIANTE", datosPersonales[0]);
            cmd.Parameters.AddWithValue("@TIPO_FORMATO", "REVISTA");
            cmd.Parameters.AddWithValue("@COHORTE", array[1]);
            cmd.Parameters.AddWithValue("@ESTADO", array[2]);
            cmd.Parameters.AddWithValue("@TITULO_PUBLICACION", array[3]);
            cmd.Parameters.AddWithValue("@NOMBRE_REVISTA", array[4]);
            cmd.Parameters.AddWithValue("@NOMBRE_COAUTOR", array[5]);
            cmd.Parameters.AddWithValue("@FECHA_PUBLICACION", array[6]);
            cmd.Parameters.AddWithValue("@DOI", array[7]);
            cmd.Parameters.AddWithValue("@INDEXACION", array[8]);
            cmd.Parameters.AddWithValue("@RANKING", array[9]);
            cmd.Parameters.AddWithValue("@QUARTIL", array[10]);
            cmd.Parameters.AddWithValue("@URL", array[11]);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cn.Close();
        }
        public void insertaPConferencia(String[] array)
        {
            cn = new Conexion().abrirConexion();
            string sql = @"insert into conferencia (ID_ESTUDIANTE,TIPO_FORMATO,COHORTE,ESTADO,TITULO_PUBLICACION,NOMBRE_CONFERENCIA,NOMBRE_COAUTOR,FECHA_PUBLICACION ,LUGAR_PUBLICACION, FECHA_EXPOSICION ,   DOI,INDEXACION, RANKING, URL)
                 values(   @ID_ESTUDIANTE, @TIPO_FORMATO,@COHORTE, @ESTADO, @TITULO_PUBLICACION, @NOMBRE_CONFERENCIA,  @NOMBRE_COAUTOR,@FECHA_PUBLICACION, @LUGAR_PUBLICACION,  @FECHA_EXPOSICION , @DOI, @INDEXACION, @RANKING, @URL)";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@ID_ESTUDIANTE", datosPersonales[0]);
            cmd.Parameters.AddWithValue("@TIPO_FORMATO", "CONFERENCIA");
            cmd.Parameters.AddWithValue("@COHORTE", array[1]);
            cmd.Parameters.AddWithValue("@ESTADO", array[2]);
            cmd.Parameters.AddWithValue("@TITULO_PUBLICACION", array[3]);
            cmd.Parameters.AddWithValue("@NOMBRE_CONFERENCIA", array[4]);
            cmd.Parameters.AddWithValue("@NOMBRE_COAUTOR", array[5]);
            cmd.Parameters.AddWithValue("@FECHA_PUBLICACION", array[6]);
            cmd.Parameters.AddWithValue("@LUGAR_PUBLICACION", array[7]);
            cmd.Parameters.AddWithValue("@FECHA_EXPOSICION", array[8]);
            cmd.Parameters.AddWithValue("@DOI", array[9]);
            cmd.Parameters.AddWithValue("@INDEXACION", array[10]);
            cmd.Parameters.AddWithValue("@RANKING", array[11]);
            cmd.Parameters.AddWithValue("@URL", array[12]);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cn.Close();

        }
        public void insertaFormato(String[] array)
        {
            cn = new Conexion().abrirConexion();
            SqlCommand cmd;
            string sql = @"insert into formato (ID_ESTUDIANTE,TIPO_FORMATO,FECHA,PATH_FILE)
                 values(  @ID_ESTUDIANTE, @TIPO_FORMATO, @FECHA,@PATH_FILE)";
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@ID_ESTUDIANTE", datosPersonales[0]);
            cmd.Parameters.AddWithValue("@TIPO_FORMATO", array[0]);
            cmd.Parameters.AddWithValue("@FECHA", array[1]);
            cmd.Parameters.AddWithValue("@PATH_FILE", array[2]);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(datosPersonales[0] + "," + array[0] + "," + array[1] + "," + array[2]);
            }
            cn.Close();
        }
    }
}
