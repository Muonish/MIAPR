using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;

namespace WFAppK_srednih
{
    public class ClassKmeans
    {
        const int DiapasonColorMax = 200;
        const int DiapasonColorMin = 20;

        public struct PointInfo
        {
            public Point coord;
            public int father;
            public Color color;
            public bool isChanged;
        }

        public static int Npoint;
        public static int Nclass;
        public static bool сentersIsChanged;
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
                vectorPoint[i].isChanged = true;
            }
           
        }
        private void Paint()
        {
            label3.Text = "Painting...";
            label3.Refresh();
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.Black);
            Graphics GpanelHolst;
            GpanelHolst = panelHolst.CreateGraphics();
            for (int i = 0; i < Npoint; i++)
            {
                if (vectorPoint[i].isChanged)
                {
                    pen.Color = vectorPoint[i].color;
                    brush.Color = pen.Color;
                    GpanelHolst.FillRectangle(brush, vectorPoint[i].coord.X,
                                                     vectorPoint[i].coord.Y, 5, 5);

                    vectorPoint[i].isChanged = false;
                }
            }
        }
        private void Classify()
        {
            double minway = double.MaxValue;
            double way = 0;
            int nearestKernel = 0;
            int oldKernel = 0;

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
                    oldKernel = vectorPoint[i].father;
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
                    if (oldKernel != nearestKernel) 
                        vectorPoint[i].isChanged = true;
                }
            }
        }

        private bool CentersIsChanged()
        {
            
            сentersIsChanged = false;

            ManualResetEvent[] doneEvents = new ManualResetEvent[Nclass];
            //ThreadPool.SetMaxThreads(100,100);

            label3.Text = "Recalculation...";
            label3.Refresh();
            for (int i = 0; i < Nclass; i++)
            {
                doneEvents[i] = new ManualResetEvent(false);
                ThreadRecalculation threadRecalculation = new ThreadRecalculation(vectorPoint, vectorKernel, i, doneEvents[i]);
                ThreadPool.QueueUserWorkItem(threadRecalculation.Recalculation);
            }

            WaitHandle.WaitAll(doneEvents);
            return сentersIsChanged;
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
