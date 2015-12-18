using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4_AI
{
    public partial class Form1 : Form
    {
        private Controller controller;

        public Form1()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> inputDatas = new List<string>();
            if (A.Checked)
                inputDatas.Add("A");
            if (M.Checked)
                inputDatas.Add("M");
            if (N.Checked)
                inputDatas.Add("N");
            if (E.Checked)
                inputDatas.Add("E");
            if (D.Checked)
                inputDatas.Add("D");
            if (P.Checked)
                inputDatas.Add("P");
            if (G.Checked)
                inputDatas.Add("G");
            if (I.Checked)
                inputDatas.Add("I");
            if (C.Checked)
                inputDatas.Add("C");
            if (K.Checked)
                inputDatas.Add("K");

            lblRezultat.Text = "Rezultat: " + controller.calculateResult(inputDatas);
        }
    }
}
