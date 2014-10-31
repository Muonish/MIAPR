using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace WFAppPotentials
{
    public partial class FormMain : Form
    {
        public const int MAXPOINTS = 10000;
        public static GraphPane pane;

        public FormMain()
        {
            InitializeComponent();
            pane = zedGraphControl.GraphPane;
            pane.Title.Text = "";
            pane.XAxis.Title.Text = "X";
            pane.YAxis.Title.Text = "P";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                if (e.KeyChar != 8)
                    if (e.KeyChar != ',')
                        e.KeyChar = '\0';
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Random RandomNumber = new Random();
            double falseError, missError, sumError;
            double p1, p2, pc1, pc2, x;
            double sigm1, sigm2; 
            double expectedValue1, expectedValue2;
            double[] randomExperience1 = new double[MAXPOINTS];
            double[] randomExperience2 = new double[MAXPOINTS];
            double[] arrx = new double[500];
            double[] y1 = new double[500]; 
            double[] y2 = new double[500];
            double[] linex = new double[500];
            double[] liney = new double[500];
            int i;

            pane.CurveList.Clear();
            if (textBox1.Text == String.Empty)
            {
                if (textBox2.Text == String.Empty)
                {
                    MessageBox.Show("Enter the probability!");
                    return;
                }
                else
                {
                    pc2 = double.Parse(textBox2.Text);
                    pc1 = 1 - pc2;
                    textBox1.Text = pc1.ToString();
                }
            }
            else
            {
                if (textBox2.Text == String.Empty)
                {
                    pc1 = double.Parse(textBox1.Text);
                    pc2 = 1 - pc1;
                    textBox2.Text = pc2.ToString();
                }
                else
                {
                    pc1 = double.Parse(textBox1.Text);
                    pc2 = double.Parse(textBox2.Text);
                    if ((pc1 + pc2) != 1)
                    {
                        MessageBox.Show("Sum of probabilities must be equal to 1!");
                        return;
                    }
                }
            }

            for (i = 0; i < MAXPOINTS; i++) 
            {
                randomExperience1[i] = RandomNumber.Next(0, 500) - 100;
                randomExperience2[i] = RandomNumber.Next(0, 500) + 100;
            }
            expectedValue1 = 0;
            expectedValue2 = 0;
            for (i = 0; i < MAXPOINTS; i++) 
            {
                expectedValue1 = expectedValue1 + randomExperience1[i];
                expectedValue2 = expectedValue2 + randomExperience2[i];
            }
            expectedValue1 /= MAXPOINTS;
            expectedValue2 /= MAXPOINTS;
            sigm1 = 0;
            sigm2 = 0;
            for (i = 0; i < MAXPOINTS; i++) 
            {
                sigm1 = sigm1 + Math.Pow(randomExperience1[i] - expectedValue1, 2); //сигма
                sigm2 = sigm2 + Math.Pow(randomExperience2[i] - expectedValue2, 2);
            }
            sigm1 = Math.Sqrt(sigm1/MAXPOINTS);
            sigm2 = Math.Sqrt(sigm2/MAXPOINTS);
            for (i = 0; i < 500; i++) 
            {
                y1[i] = 100000*pc1 * (Math.Exp(-0.5*Math.Pow((i-expectedValue1)/sigm1, 2)))/(sigm1*Math.Sqrt(2*3.14));
                y2[i] = 100000*pc2 * (Math.Exp(-0.5*Math.Pow((i-expectedValue2)/sigm2, 2)))/(sigm2*Math.Sqrt(2*3.14));
                arrx[i] = i;
            }
            x = -100;
            p1 = 1;
            p2 = 0;

            falseError = 0;
            if (pc2 != 0)
                while (p2 < p1) 
                {
                    p1 = pc1 * (Math.Exp(-0.5*Math.Pow((x-expectedValue1)/sigm1, 2)))/(sigm1*Math.Sqrt(2*3.14));
                    p2 = pc2 * (Math.Exp(-0.5*Math.Pow((x-expectedValue2)/sigm2, 2)))/(sigm1*Math.Sqrt(2*3.14));
                    falseError += p2*0.001;
                    x += 0.001;
                }
            PointPairList listLine = new PointPairList();
            if (x > 0 && x < 250) 
            {
                for (i = 0; i < 250; i++) 
                    listLine.Add(x, i);
            }
            LineItem line = pane.AddCurve("", listLine, Color.Blue, SymbolType.None);


            missError = 0;
            while(x < 1000) 
            {
                p1 = (Math.Exp(-0.5*Math.Pow((x-expectedValue1)/sigm1, 2)))/(sigm1*Math.Sqrt(2*3.14));
                p2 = (Math.Exp(-0.5*Math.Pow((x-expectedValue2)/sigm2, 2)))/(sigm1*Math.Sqrt(2*3.14));
                missError += p1 * 0.001 * pc1;
                x += 0.001;
            }
            if (pc1 == 0) 
            {
                falseError = 1;
                missError = 0;
                sumError = 1;
            }
            if (pc2 == 0) 
            {
                falseError = 0;
                missError = 0;
                sumError = 0;
            }
            else 
            {
                falseError /= pc1;
                missError /= pc1;
            }
            sumError = falseError + missError;
            textBoxFalseAlarm.Text = falseError.ToString();
            textBoxMissingError.Text = missError.ToString();
            textBoxTotalError.Text = sumError.ToString();

            PointPairList listCurve1 = new PointPairList();
            for (i = 0; i < 500; i++)
                listCurve1.Add(arrx[i], y2[i]);
            LineItem curve1 = pane.AddCurve("", listCurve1, Color.Black, SymbolType.None);

            PointPairList listCurve2 = new PointPairList();
            for (i = 0; i < 500; i++)
                listCurve2.Add(arrx[i], y1[i]);
            LineItem curve2 = pane.AddCurve("", listCurve2, Color.Black, SymbolType.None);

            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
        }
    }
}
