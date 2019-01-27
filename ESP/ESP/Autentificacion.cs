using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESP
{
    class Autentificacion
    {
        private String[] archivos = { "logEst.txt", "logDoc.txt", "logCor.txt", "logPro.txt" };
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
            int tipoCuenta = devuelveTipo(tipo);
            Boolean ban = false;
            String line = "";
            ArrayList arrText = cargarArchivo(archivos[tipoCuenta]);
            for (int i = 0; i < arrText.Count; i++)
            {
                line = (string)arrText[i];
                String[] aux = line.Split(';');
                if (usuario.CompareTo(aux[0]) == 0)
                {
                    line = aux[1];
                    Console.WriteLine("lola");
                    break;
                }
            }
            return line.CompareTo(contrasena) == 0;
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
