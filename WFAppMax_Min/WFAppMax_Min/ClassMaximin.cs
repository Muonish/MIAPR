using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;
using System.Collections;

namespace WFAppMax_Min
{
    class ClassMaximin
    {
        private FormMain parent;

        Classification.PointInfo[] vectorPoint;
        List<int> vectorKernel;

        public ClassMaximin(FormMain p, Classification.PointInfo[] vp, List<int> vk)
        {
            parent = p;
            vectorPoint = vp;
            vectorKernel = vk;
            Paint();
            CalculateNumberOfClasses();
        }

        private void Paint()
        {
            Classification.StatusMessage(parent, "Painting...");
            var pen = new Pen(Color.Black);
            var brush = new SolidBrush(Color.Black);
            Graphics GpanelHolst = parent.panelHolst.CreateGraphics();
            for (int i = 0; i < vectorPoint.Length; i++)
            {
                pen.Color = vectorPoint[i].color;
                brush.Color = pen.Color;
                GpanelHolst.FillRectangle(brush, vectorPoint[i].coord.X,
                                                    vectorPoint[i].coord.Y, 7, 7);

                vectorPoint[i].isChanged = false;
            }
        }

        private void CalculateNumberOfClasses()
        {
            double maxway;
            double maxwayclass;
            int possibleNewKernel;
            int ipoint;
            int numOfWays;
            bool endOfCalculation = false;

            Classification.StatusMessage(parent, "Calculate number of classes...");
            while (!endOfCalculation)
            {
                maxway = 0;
                ipoint = 0;
                possibleNewKernel = 0;
                for (int i = 0; i < vectorKernel.Count; i++)
                {
                    if ((maxwayclass = MaximumWayInClass(ref ipoint, vectorKernel[i])) > maxway)
                    {
                        possibleNewKernel = ipoint;
                        maxway = maxwayclass;
                    }
                }
                numOfWays = 0;
                if (maxway > (SumOfWaysBetweenClasses(ref numOfWays) / (2 * numOfWays)))
                {
                    vectorKernel.Add(possibleNewKernel);
                    vectorPoint[possibleNewKernel].father = -1;
                    vectorPoint[possibleNewKernel].color = Classification.SetRandomColor();
                    Classification.Classify(parent, ref vectorPoint, ref vectorKernel);
                    Paint();
                }
                else
                {
                    endOfCalculation = true;
                }
            }
        }

        private double MaximumWayInClass(ref int possibleNewKernel, int kernel)
        {
            double maxway = 0;
            double way;
            for (int i = 0; i < vectorPoint.Length; i++)
            {
                if (vectorPoint[i].father == kernel)
                {
                    if ((way = Way(kernel, i)) > maxway)
                    {
                        maxway = way;
                        possibleNewKernel = i;
                    }
                }
            }
            return maxway;
        }
        private double Way(int a, int b)
        {
            return Math.Sqrt(Math.Pow((vectorPoint[b].coord.X - vectorPoint[a].coord.X), 2) +
                             Math.Pow((vectorPoint[b].coord.Y - vectorPoint[a].coord.Y), 2));
        }
        private double SumOfWaysBetweenClasses(ref int numOfWays)
        {
            double waysum = 0;
            for (int i = 0; i < vectorKernel.Count; i++)
            {
                for (int j = 0; j < vectorKernel.Count; j++)
                {
                    waysum += Way(vectorKernel[i], vectorKernel[j]);
                    numOfWays++;
                }
                numOfWays--;
            }
            if (numOfWays == 0)
            {
                numOfWays = 1;
            }
            return waysum;
        }
    }
}
