using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LAB4_AI
{
    class Controller
    {
        private List<Fapt> factsList;
        private List<Rules> rulesList;
        private List<String> knowedBase;
        private string facts = @"C:\Users\Lucian\SkyDrive\Documents\Visual Studio 2013\ANUL II\AI\LAB4_AI\facts.txt";
        private string relations = @"C:\Users\Lucian\SkyDrive\Documents\Visual Studio 2013\ANUL II\AI\LAB4_AI\relations.txt";

        public Controller()
        {
            factsList = new List<Fapt>();
            rulesList = new List<Rules>();
            this.readFacts();
            this.readRelations();
        }

        private void readFacts()
        {
            string[] lines = File.ReadAllLines(facts);
            foreach (string line in lines)
            {
                string cod = line.Split('-')[0];
                string text = line.Split('-')[1];
                string caz = line.Split('-')[2];
                factsList.Add(new Fapt(cod, text, caz));
            }
        }

        private void readRelations()
        {
            string[] lines = File.ReadAllLines(relations);
            foreach (string line in lines)
            {
                List<String> relation = new List<string>();
                int i = 0;
                string result = line.Split('=')[1];
                string rela = line.Split('=')[0];
                string[] elements = rela.Split('&');
                foreach (string lettr in elements)
                {
                    relation.Add(elements[i]);
                    ++i;
                }
                rulesList.Add(new Rules(result, relation));
            }
        }

        public String calculateResult(List<string> inputDatas)
        {
            knowedBase = inputDatas;
            Boolean changes = true;
            while (changes)
            {
                changes = false;
                foreach (Rules rule in rulesList)
                {
                    if (this.checkListInList(rule.Relation, knowedBase))
                    {
                        if(!knowedBase.Contains(rule.Result))
                        {
                            knowedBase.Add(rule.Result);
                            changes = true;
                        }
                    }
                }
            }
            return this.interpretateResult(knowedBase);
        }

        private string interpretateResult(List<string> knowedBase)
        {
            foreach (Fapt fapt in factsList)
                if (String.Compare(fapt.Cod, knowedBase[knowedBase.Count - 1]) == 0)
                    if (String.Compare(fapt.Caz, "o") == 0)
                        return fapt.Text;
                    else
                        return "Nu sunt destule date pentru o situatie concreta.\nAm ajuns la: " + fapt.Text;
            return String.Empty;
        }

        private Boolean checkListInList(List<String> list1, List<String> list2)
        {
            foreach (String s in list1)
                if (!list2.Contains(s))
                    return false;
            return true;
        }

    }
}
