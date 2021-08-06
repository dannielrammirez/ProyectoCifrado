using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FormCifrado
{
    public partial class FormCifrar : Form
    {
        Procesa objProcesa;
        string textoClave;
        string textoOriginal;
        string textoCifrado;
        string[,] matriz;
        public FormCifrar()
        {
            InitializeComponent();
        }

        private void btnCifrar_Click(object sender, EventArgs e)
        {
            textoClave = textBoxTextClave.Text;
            textoOriginal = textBoxTextOriginial.Text;

            if (string.IsNullOrEmpty(textoClave) || string.IsNullOrEmpty(textoOriginal))
            {
                labelErrores.Text = "Favor de dilgenciar los campos";
                return;
            }
            objProcesa = new Procesa(textoClave, textoOriginal);
            matriz = objProcesa.opera();
            textoCifrado = objProcesa.getPalabraCifrada();
            textBoxTextoCifrado.Text = textoCifrado;

            mostrarEnForms(matriz, textoOriginal, textoCifrado);
        }

        private void mostrarEnForms(string[,] matriz, string textoOriginal, string textoCifrado)
        {
            dgMatriz.Rows.Clear();
            dgMatriz.ColumnCount = matriz.GetLength(1);
            bool editHeader = false;

            int numRows = matriz.GetLength(0);
            int numColumns = matriz.GetLength(1);
            int withCalculado = dgMatriz.Width / numColumns;
            int heiggtCalculado = dgMatriz.Height / numRows;

            for (int i = 0; i < numRows; i++)
            {
                ArrayList row = new ArrayList();
                for (int j = 0; j < numColumns; j++)
                {
                    dgMatriz.Columns[j].Width = withCalculado;

                    if (!editHeader) changeHead(j, matriz[i, j]);
                    row.Add(matriz[i, j]);
                }
                editHeader = true;
                dgMatriz.Rows.Add(row.ToArray());
            }

            foreach (var item in matriz)
            {
                //string[] row = new item
                //dgMatriz.Rows.Add();
            }

        }

        private void changeHead(int pos, string nombre)
        {
            char[] arrayChars = textoClave.ToCharArray();
            var arrayMod = arrayChars.OrderBy(x=>x.ToString()).ToArray();

            dgMatriz.Columns[pos].Name = arrayMod[pos].ToString();
        }
    }
}
