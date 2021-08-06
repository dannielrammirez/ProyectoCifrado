using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsolaCifrado
{
    public class Procesa
    {
        string textoClave;
        string textoOriginal;
        string textoCifrado;
        int numLines;
        char[] arrayKey;
        string[,] arrayMulti;
        List<TuplaMatriz> dicTuplas = new List<TuplaMatriz>();

        const string arrayAbc = "abcderghijklmnopqrstuvwxyxABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890 ";
        public Procesa(string _textoClave, string _textoOriginal)
        {
            textoClave = _textoClave;
            textoOriginal = _textoOriginal;
            arrayKey = textoClave.ToCharArray();
            numLines = 1;
        }

        public string getPalabraCifrada()
        {
            return textoCifrado;
        }

        public string[,] opera()
        {
            createTuplas();
            setTuplas();
            setArrayMult();

            return arrayMulti;
        }
        private void createTuplas()
        {
            foreach (char letra in arrayKey)
            {
                dicTuplas.Add(new TuplaMatriz() { id= setPosicionAbc(letra), lstCaracters = new List<char>() });
            }
        }
        private void setTuplas()
        {
            char[] arrayOriginal = textoOriginal.ToCharArray();
            
            int count_x = 0, count_y = 0;

            foreach (var item0 in arrayOriginal)
            {
                count_x++;
                foreach (var item in arrayKey)
                {
                    count_y++;
                    if (count_y == count_x)
                    {
                        dicTuplas[(count_y - 1)].lstCaracters.Add(item0);
                        break;
                    }
                }
                count_y = 0;
                if (count_x == arrayKey.Length)
                {
                    numLines++;
                    count_x = 0;
                }
            }
        }

        private void setArrayMult()
        {
            var tupleTmp = dicTuplas.OrderBy(t => t.id);
            arrayMulti = new string[numLines, arrayKey.Length];
            int i = 0, j = 0;

            foreach (var list in tupleTmp)
            {
                foreach (var item in list.lstCaracters)
                {
                    arrayMulti[j, i] = item.ToString();
                    textoCifrado = String.Concat(textoCifrado, item.ToString());
                    j++;
                }
                i++;
                j = 0;
            }
        }

        public int setPosicionAbc(char letra)
        {
            return arrayAbc.IndexOf(letra) + 1;
        }
    }
}
