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
using System.IO;

namespace ESP
{
	/// <summary>
	/// Description of Estudiante.
	/// </summary>
    /// estudiante
	public class Estudiante
	{
		public Estudiante(String username)
		{

		}

        public void GuardaPublicacion(String[] param)
        {
            String respuesta, cadena;
            cadena = param[0] + "," + param[1]+","+param[2];
            //crear o abrir el archivo 
            StreamWriter escribir = File.AppendText("formatos.txt");
                escribir.WriteLine(cadena+"\n");
            escribir.Close();
        }
	}
}
