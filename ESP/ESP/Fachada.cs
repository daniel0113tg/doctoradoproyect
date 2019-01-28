using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESP
{
    class Fachada
    {
        String userName;
        int rol;
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
                    EstudianteForm estudianteForm = new EstudianteForm(userName);
                    estudianteForm.Show();
                    break;
                case 1:

                    //director 
                    break;
                case 2:

                    Cordinador cordinador = new Cordinador();
                    cordinador.Show();
                    break;
                case 3:
                   
                    //profesor 
                  
                    break;
            }
        }
    }
}
