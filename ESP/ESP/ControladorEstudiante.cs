/*
 * Created by SharpDevelop.
 * User: Lenovo
 * Date: 2019-01-16
 * Time: 18:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Windows.Forms;

namespace ESP
{
	/// <summary>
	/// Description of Control.
	/// </summary>
	public class ControladorEstudiante
	{
        private Estudiante estudiante = null; 
        public ControladorEstudiante(String id_Estudiante)
        {

            estudiante = new Estudiante(id_Estudiante);
        }
        public DataTable obtenerRevistas()
        {
            DataTable dt = new DataTable();
            estudiante.visualizarRevistas().Fill(dt);
            return dt;
        }
        public DataTable obtenerConferencias()
        {
            DataTable dt = new DataTable();
            estudiante.visualizarConferencias().Fill(dt);
            return dt;
        }
        public DataTable obtenerFormatos()
        {
            DataTable dt = new DataTable();
            estudiante.visualizarFormatos().Fill(dt);
            return dt;
        }

        public String[] obtenerDatosEstudiante()
        {
            return estudiante.visualizarEstudiante();

        }
        
        public void enviadatosPRevista(String[] param) {
            estudiante.insertaPRevista(param);
        }
        public void enviadatosPConferencia(String[] param)
        {
            estudiante.insertaPConferencia(param);
        }
        public void enviadatosFormato(String[] param)
        {
            estudiante.insertaFormato(param);
        }

    }
}
