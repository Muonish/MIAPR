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
        const int DiapasonColorMax = 200;
        const int DiapasonColorMin = 20;

        private FormMain parent;

        public struct PointInfo
        {
            public Point coord;
            public int father;
            public Color color;
            public bool isChanged;
        }

        public static int Npoint;
        public static bool сentersIsChanged;
        PointInfo[] vectorPoint;
        List<int> vectorKernel;

        public ClassMaximin(int npoint, FormMain p)
        {
            parent = p;
            Npoint = npoint;
            vectorPoint = new PointInfo[Npoint];
            RandomPoint();
            Processing();
        }
        private void Processing()
        {
            Classify();
            Paint();
            CalculateNumberOfClasses();
            Classify();
            Paint();
            //while (CentersIsChanged())
            //{
            //    Classify();
            //    Paint();
            //}
            StatusMessage("Finish.");
        }

        private void RandomPoint()
        {
            var RandomNumber = new Random();

            vectorKernel = new List<int>();
            vectorKernel.Add(RandomNumber.Next(0, Npoint - 1));

            for (int i = 0; i < Npoint; i++)
            {
                vectorPoint[i].coord = new Point(RandomNumber.Next(1, parent.panelHolst.Width),
                                                 RandomNumber.Next(1, parent.panelHolst.Height));
                vectorPoint[i].color = Color.FromArgb(200, 200, 200);
                if (vectorKernel.Contains(i))
                {
                    vectorPoint[i].father = -1;
                    vectorPoint[i].color = SetRandomColor();
                    vectorPoint[i].isChanged = true;
                }

            }
        }

        private void Paint()
        {
            StatusMessage("Painting...");
            var pen = new Pen(Color.Black);
            var brush = new SolidBrush(Color.Black);
            Graphics GpanelHolst = parent.panelHolst.CreateGraphics();
            for (int i = 0; i < Npoint; i++)
            {
                //if (vectorPoint[i].isChanged)
                //{
                    pen.Color = vectorPoint[i].color;
                    brush.Color = pen.Color;
                    GpanelHolst.FillRectangle(brush, vectorPoint[i].coord.X,
                                                     vectorPoint[i].coord.Y, 5, 5);

                    vectorPoint[i].isChanged = false;
                //}
            }
        }
        private void Classify()
        {
            double minway = double.MaxValue;
            double way = 0;
            int nearestKernel = 0;
            int oldKernel = 0;

            StatusMessage("Classify...");
            for (int i = 0; i < Npoint; i++)
            {
                minway = double.MaxValue;
                if (vectorPoint[i].father == -1)
                {
                }
                else
                {
                    oldKernel = vectorPoint[i].father;
                    for (int j = 0; j < vectorKernel.Count; j++)
                    {
                        way = Math.Sqrt(Math.Pow((vectorPoint[vectorKernel[j]].coord.X - vectorPoint[i].coord.X), 2) +
                                        Math.Pow((vectorPoint[vectorKernel[j]].coord.Y - vectorPoint[i].coord.Y), 2));
                        if (way < minway)
                        {
                            minway = way;
                            nearestKernel = vectorKernel[j];
                        }
                    }
                    vectorPoint[i].father = nearestKernel;
                    vectorPoint[i].color = vectorPoint[nearestKernel].color;
                    if (oldKernel != nearestKernel)
                        vectorPoint[i].isChanged = true;
                }
            }
        }
        private void StatusMessage(String message)
        {
            parent.labelStatus.Text = message;
            parent.labelStatus.Refresh();
            
        }
        private Color SetRandomColor()
        {
            var RandomNumber = new Random();
            return Color.FromArgb(RandomNumber.Next(DiapasonColorMin, DiapasonColorMax),
                                  RandomNumber.Next(DiapasonColorMin, DiapasonColorMax),
                                  RandomNumber.Next(DiapasonColorMin, DiapasonColorMax));
        }

        private void CalculateNumberOfClasses()
        {
            double maxway = 0;
            double maxwayclass;
            int possibleNewKernel = 0;
            int ipoint = 0;
            for (int i = 0; i < vectorKernel.Count; i++)
            {
                if ((maxwayclass = MaximumWayInClass(ref ipoint, i)) > maxway)
                {
                    possibleNewKernel = ipoint; 
                    maxway = maxwayclass;
                }
            }
            vectorKernel.Add(possibleNewKernel);
            vectorPoint[possibleNewKernel].father = -1;
            vectorPoint[possibleNewKernel].color = SetRandomColor();
        }

        private double MaximumWayInClass(ref int possibleNewKernel, int kernel)
        {
            double maxway = 0;
            double way;
            for (int i = 0; i < Npoint; i++)
            {
                if ((way = Way(kernel, i)) > maxway)
                {
                    maxway = way;
                }
            }
            return maxway;
        }
        private double Way(int a, int b)
        {
            return Math.Sqrt(Math.Pow((vectorPoint[b].coord.X - vectorPoint[a].coord.X), 2) +
                             Math.Pow((vectorPoint[b].coord.Y - vectorPoint[a].coord.Y), 2));
        }

    }
}
