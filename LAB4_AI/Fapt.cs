using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_AI
{
    public class Fapt
    {
        private String cod;
        public String Cod
        {
            get { return cod; }
            set { cod = value; }
        }
        
        private String text;
        public String Text
        {
            get { return text; }
            set { text = value; }
        }

        private string caz;
        public string Caz
        {
            get { return caz; }
            set { caz = value; }
        }


        public Fapt(string cod, string text, string caz)
        {
            // TODO: Complete member initialization
            this.cod = cod;
            this.text = text;
            this.caz = caz;
        }
    }
}
