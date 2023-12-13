using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBebe
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        public static List<string> nombre = new List<string>();  
        public static List<string> foto = new List<string>();
        public static List<string> nacimiento = new List<string>();
        public static int indice = 0; 

        public static List<string> titulo = new List<string>();
        public static List<string> fecha = new List<string>();
        public static List<string> album = new List<string>();
        public static int i = 0;

        public static List<string> fechadiario = new List<string>();
        public static List<string> nota = new List<string>();
        public static int iman = 0;

        public static List<string> fechapanel = new List<string>();
        public static List<string> especialidad = new List<string>();
        public static List<string> extra = new List<string>();
        public static int iglu = 0;

        public static string id;
        public static string idBBregistro;
        public static string rutaFoto; 

        [STAThread]
        static void Main()
        {
            // Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); 
        }

    }
}
