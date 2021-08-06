using System;
using System.Windows.Forms;

namespace ConsolaCifrado
{
    class Program
    {
        static void Main(string[] args)
        {
           string openForm = System.Configuration.ConfigurationManager.AppSettings["openForm"];
            
            if(openForm == "true")
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormCifrar());
            }
            else
            {
                gestionaConsola();
            }
        }

        public static void gestionaConsola()
        {
            string textoClave = string.Empty, textoOriginal = string.Empty, textoCifrado;
            string[,] matriz;
            Procesa objProcesa;

            while (string.IsNullOrEmpty(textoOriginal))
            {
                Console.Write("Ingrese Palabra a Cifrar: ");
                textoOriginal = Console.ReadLine().ToUpper();
            }

            while (string.IsNullOrEmpty(textoClave))
            {
                Console.Write("Ingrese una Palabra Clave: ");
                textoClave = Console.ReadLine().ToUpper();
            }

            objProcesa = new Procesa(textoClave, textoOriginal);
            matriz = objProcesa.opera();
            textoCifrado = objProcesa.getPalabraCifrada();

            mostrarEnConsola(matriz, textoOriginal, textoCifrado);
            Console.ReadKey();
        }

        private static void mostrarEnConsola(string[,] matriz, string textoOriginal, string textoCifrado)
        {
            Console.WriteLine("\nLa palabra a cifrar es es: {0} \n", textoOriginal);
            string msg = string.Empty;
            int filas = matriz.GetLength(0), colunm = matriz.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < colunm; j++)
                {
                    msg = msg != null ? matriz[i, j] : String.Empty.PadRight(2);
                    Console.Write(String.Format(" {0} ", msg));
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nLa palabra cifrada es: {0}", textoCifrado);
        }
    }
}
