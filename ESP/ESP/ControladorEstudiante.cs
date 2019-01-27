/*
 * Created by SharpDevelop.
 * User: Lenovo
 * Date: 2019-01-16
 * Time: 18:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace ESP
{
	/// <summary>
	/// Description of Control.
	/// </summary>
	public class ControladorEstudiante
	{
        private Estudiante estudiante; //a partir de esta instancia se acceden a las diferentes clases
        String userName;
        int rol;
        public ControladorEstudiante()
        {
        }
        public int iniciarControlador()
        {
            //aqui se debe inicializar el login
            //las respuestas del login se las puede almacenar en variables, o directamente, 

            /*
			if(iniciarSesion(loginValues)){//String de 3 posiciones con valores de login
				//metodos de la clase usuario que continue el proceso
		 	}else{
		 		//msg de error ya que no inicio sesion
			}
			*/
            return 0;
        }

        public bool iniciarSesion(String[] loginValues)
        {
            bool existe = false;
            // loginValues igual a: tipo de cuenta(entero de 0 a 3 para estudiante, doctor, coordinador y profesor respectivamente)
            //usuario y contrasena, se obtiene de la interfaz de login
            Autentificacion autentificacion = new Autentificacion();
            if (autentificacion.verificarContrasena(loginValues[0], loginValues[1], loginValues[2]))
            {
                existe = true;
                userName = loginValues[1];
                rol = autentificacion.devuelveTipo(loginValues[0]);
            }
            else
            {
                MessageBox.Show("USUARIO O CONTRASENA INCORRECTOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return existe;
        }

        public void abrirFormRol()
        {
            switch (Convert.ToInt32(rol))
            {
                case 0:
                    EstudianteForm estudianteForm = new EstudianteForm(userName,this);
                    estudiante = new Estudiante(userName);
                    estudianteForm.Show();
                    break;
                case 1:
                    //Presentacion presentacion = new Presentacion();
                    //presentacion.Show();
                    //director = new Director();
                    break;
                case 2:
                    //PrincipalCoordinador coorp = new PrincipalCoordinador();
                    //coorp.Show();
                    //coordinador = new Coordinador();
                    break;
                case 3:
                    //Principal principal = new Principal();
                    //profesor = new Profesor();
                    //principal.Show();
                    break;
            }
        }
        public void enviaFormularioAEstudiante(String[] param) {
            estudiante.GuardaPublicacion(param);
        }

    }
}
