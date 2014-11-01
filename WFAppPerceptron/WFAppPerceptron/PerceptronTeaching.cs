using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAppPerceptron
{
    class PerceptronTeaching
    {
        int Nclasses;
        int Nobjects;
        int Nsigns;
        FormMain parent;
        int[, ,] classes;
        int[,] function;
        int[] mult;

        public PerceptronTeaching(FormMain p, int nc, int no, int ns)
        {
            Nclasses = nc;
            Nobjects = no;
            Nsigns = ns + 1;
            parent = p;
            RandomInitialData();
            Teach();
            PrintClasses();
            PrintFunctions();
        }

        private void RandomInitialData()
        {
            Random RandomNumber = new Random();
            classes = new int[Nclasses, Nobjects, Nsigns];
            function = new int[Nclasses, Nsigns];
            mult = new int[Nclasses];

            for (int i = 0; i < Nclasses; i++)
                for (int j = 0; j < Nobjects; j++)
                    for (int k = 0; k < Nsigns; k++)
                        classes[i,j,k] = RandomNumber.Next(0, 9);

            for (int i = 0; i < Nclasses; i++)
                for (int j = 0; j < Nsigns; j++)
                    function[i, j] = 0;
        }

        private void Teach()
        {
            int isPunished = int.MaxValue;

            while (isPunished > 0)
            {
                isPunished = 0;
                for (int i = 0; i < Nclasses; i++)
                {
                    for (int j = 0; j < Nobjects; j++)
                    {
                        Multiply(i, j);
                                
                        if (!isRightComposition(i))
                        {
                            Encourage(i, j);
                            isPunished++;
                        }

                        PrintFunctions();
                        parent.textBoxFunctions.Refresh();
                    }
                }
            }
        }

        private void Multiply(int numberOfClass, int numberOfObj)
        {
            for (int i = 0; i < Nclasses; i++)
                mult[i] = 0;

            for (int i = 0; i < Nclasses; i++ )
                for (int j = 0; j < Nsigns; j++)
                    mult[i] += function[i, j] * classes[numberOfClass, numberOfObj, j];
        }

        public bool isRightComposition(int numOfneedClass)
        {
            bool result = true;
            int needClass = mult[numOfneedClass];

            for (int i = 0; i < Nclasses; i++)
            {
                if (i != numOfneedClass && mult[i] >= needClass)
                    result = false;
            }

            return result;
        }

        private void Encourage(int numberOfFunc, int numberOfObj)
        {
            for (int i = 0; i < Nclasses; i++)
            {
                if (i == numberOfFunc)
                {
                    for (int j = 0; j < Nsigns; j++)
                        function[i, j] += classes[numberOfFunc, numberOfObj, j];
                }
                else
                {
                    for (int j = 0; j < Nsigns; j++)
                        function[i, j] -= classes[numberOfFunc, numberOfObj, j];
                }
            }
        }

        private void PrintClasses()
        {
            for (int i = 0; i < Nclasses; i++)
            {
                parent.textBoxClasses.Text += "class " + (i + 1).ToString();
                parent.textBoxClasses.Text += Environment.NewLine;
                for (int j = 0; j < Nobjects; j++)
                {
                    parent.textBoxClasses.Text += "     object " + (j + 1).ToString();
                    parent.textBoxClasses.Text += " ( ";
                    for (int k = 0; k < Nsigns; k++)
                        parent.textBoxClasses.Text += classes[i, j, k].ToString() + " ";
                    parent.textBoxClasses.Text += ")";
                    parent.textBoxClasses.Text += Environment.NewLine;
                }
            }
        }

        private void PrintFunctions()
        {
            for (int i = 0; i < Nclasses; i++)
            {
                parent.textBoxFunctions.Text += "d" + (i + 1).ToString() + "(x) = ";
                for (int j = 0; j < Nsigns; j++)
                {
                    if (j != Nsigns - 1)
                    {
                        parent.textBoxFunctions.Text += function[i, j].ToString() + "*" + "x" + (j + 1).ToString();
                        parent.textBoxFunctions.Text += " + ";
                    }
                    else
                        parent.textBoxFunctions.Text += function[i, j].ToString();
                }
                parent.textBoxFunctions.Text += Environment.NewLine;
            }
            parent.textBoxFunctions.Text += Environment.NewLine;
        }
    }
}
