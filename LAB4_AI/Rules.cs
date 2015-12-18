using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_AI
{
    public class Rules
    {
        private String result;
        public String Result
        {
            get { return result; }
            set { result = value; }
        }

        private List<String> relation;
        public List<String> Relation
        {
            get { return relation; }
            set { relation = value; }
        }

        public Rules(string res, List<String> rela)
        {
            result = res;
            relation = rela;
        }

        public override string ToString()
        {
            return result + " <= " + String.Join(",", relation);
        }
    }
}
