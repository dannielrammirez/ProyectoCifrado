using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaCifrado
{
    public class TuplaMatriz
    {
        public int id { get; set; }
        public List<char> lstCaracters { get; set; }

        public TuplaMatriz()
        {
            id = 0;
            lstCaracters = new List<char>();
        }
    }
}
