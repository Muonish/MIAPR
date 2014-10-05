using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace WFAppK_srednih
{
    class ClassKmeans
    {
        const int DiapasonColorMax = 200;
        const int DiapasonColorMin = 20;

        public struct PointInfo
        {
            public Point coord;
            public int father;
            public Color color;
        }

        static int Npoint;
        static int Nclass;
        System.Windows.Forms.Panel panelHolst;
        System.Windows.Forms.Label label3;
        int WIDTH;
        int HEIGHT;
        PointInfo[] vectorPoint;
        int[] vectorKernel;

        public ClassKmeans(int npoint, int nclass, System.Windows.Forms.Panel panel, System.Windows.Forms.Label label)
        {
            Npoint = npoint;
            Nclass = nclass;
            panelHolst = panel;
            label3 = label;
            WIDTH = panelHolst.Width;
            HEIGHT = panelHolst.Height;
            vectorPoint = new PointInfo[Npoint];
            vectorKernel = new int[Nclass];
            RandomPoint();
            Processing();
        }

        private void RandomPoint()
        {
            Random RandomNumber = new Random();
            int j;
            int i;

            i = 0;
            while (i < Nclass)
            {
                vectorKernel[i] = RandomNumber.Next(0, Npoint - 1);
                for (j = 0; j < i; j++)
                {
                    if (vectorKernel[i] == vectorKernel[j])
                        i--;
                }
                i++;
            }
          
            for (i = 0; i < Npoint; i++)
            {
                vectorPoint[i].coord = new Point(RandomNumber.Next(1, WIDTH),
                                                 RandomNumber.Next(1, HEIGHT));
                vectorPoint[i].color = Color.FromArgb(200, 200, 200);
                for (j = 0; j < Nclass; j++)
                    if (i == vectorKernel[j])
                    {
                        vectorPoint[i].father = -1;
                        vectorPoint[i].color = Color.FromArgb(RandomNumber.Next(DiapasonColorMin, DiapasonColorMax),
                                                              RandomNumber.Next(DiapasonColorMin, DiapasonColorMax),
                                                              RandomNumber.Next(DiapasonColorMin, DiapasonColorMax));
                    }
            }
            
            Paint();
        }
        private void Paint()
        {
            label3.Text = "Painting...";
            label3.Refresh();
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.Black);
            Graphics GpanelHolst;
            GpanelHolst = panelHolst.CreateGraphics();
            //panelHolst.Refresh();
            for (int i = 0; i < Npoint; i++)
            {
                if (vectorPoint[i].father == -1)
                {
                    pen.Color = Color.Red;
                    brush.Color = Color.Red;
                    GpanelHolst.DrawEllipse(pen, vectorPoint[i].coord.X,
                                             vectorPoint[i].coord.Y, 3, 3);
                    GpanelHolst.FillEllipse(brush, vectorPoint[i].coord.X,
                                                 vectorPoint[i].coord.Y, 3, 3);
                }
                else
                {
                    pen.Color = vectorPoint[i].color;
                    brush.Color = pen.Color;
                    GpanelHolst.DrawEllipse(pen, vectorPoint[i].coord.X,
                                                 vectorPoint[i].coord.Y, 3, 3);
                    GpanelHolst.FillEllipse(brush, vectorPoint[i].coord.X,
                                                 vectorPoint[i].coord.Y, 3, 3);
                }
            }
        }
        private void Classify()
        {
            double minway = double.MaxValue;
            double way = 0;
            int nearestKernel = 0;

            label3.Text = "Classify...";
            label3.Refresh();
            for (int i = 0; i < Npoint; i++)
            {
                minway = double.MaxValue;
                if (vectorPoint[i].father == -1)
                {
                } 
                else
                {
                    for (int j = 0; j < Nclass; j++)
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
                }
            }
        }

        private bool CentersIsChanged()
        {
            double averageDistance = 0;
            double minAverageDistance = double.MaxValue;
            int NmemberClass = 0;
            int possibleKernel;
            bool flag = false;

            label3.Text = "Recalculation...";
            label3.Refresh();
            for (int i = 0; i < Nclass; i++)
            {
                minAverageDistance = double.MaxValue;
                possibleKernel = vectorKernel[i];
                for(int j = 0; j < Npoint; j++)
                {
                    if (vectorPoint[j].father == vectorKernel[i] || j == vectorKernel[i])
                    {   NmemberClass = 0;
                        averageDistance = 0;
                        for (int k = 0; k < Npoint; k++)
                        {
                            if ((vectorPoint[k].father == vectorKernel[i] || k == vectorKernel[i]) && (k != j))
                            {
                                averageDistance += Math.Sqrt(Math.Pow((vectorPoint[k].coord.X - vectorPoint[j].coord.X), 2) +
                                                             Math.Pow((vectorPoint[k].coord.Y - vectorPoint[j].coord.Y), 2));
                                NmemberClass++;
                            }
                        }
                        averageDistance /= NmemberClass;
                        if (averageDistance < minAverageDistance)
                        {
                            minAverageDistance = averageDistance;
                            possibleKernel = j;
                        }
                    }
                }
                if (vectorKernel[i] == possibleKernel)
                {
                    flag = false;
                }
                else
                {
                    vectorPoint[vectorKernel[i]].father = 0;
                    vectorKernel[i] = possibleKernel;
                    vectorPoint[possibleKernel].father = -1;
                    flag = true;
                }
            }
                return flag;
        }
        private void Processing()
        {
            Classify();
            Paint();
            while(CentersIsChanged())
            {
                Classify();
                Paint();
            }
            label3.Text = "Finish...";
            label3.Refresh();
        }
    }
}
