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
        int Npoint;
        int Nclass;
        System.Windows.Forms.Panel panelHolst;

        public struct PointInfo
        {
            public Point coord;  
            public int father;
        }

        public ClassKmeans(int npoint, int nclass, System.Windows.Forms.Panel panel)
        {
            Npoint = npoint;
            Nclass = nclass;
            panelHolst = panel;
            RandomPoint();
        }

        private void RandomPoint()
        {
            Random RandomNumber = new Random();
            PointInfo[] vectorPoint = new PointInfo[Npoint];
            int[] vectorKernel = new int[Nclass];
            int j;
            int i;
            int WIDTH = panelHolst.Width;
            int HEIGHT = panelHolst.Height;

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
                vectorPoint[i].father = RandomNumber.Next(0, Nclass - 1);
                for (j = 0; j < Nclass; j++)
                    if (i == vectorKernel[j]) 
                        vectorPoint[i].father = -1; 
            }

            MessageBox.Show(vectorKernel[0].ToString() + " "+
                            vectorKernel[1].ToString() + " " +
                            vectorKernel[2].ToString() + " " +
                            vectorKernel[3].ToString() + " " +
                            vectorKernel[4].ToString() + " ");
            MessageBox.Show(vectorPoint[0].father.ToString() + " " +
                            vectorPoint[1].father.ToString() + " " +
                            vectorPoint[2].father.ToString() + " " +
                            vectorPoint[3].father.ToString() + " " +
                            vectorPoint[4].father.ToString() + " " +
                            vectorPoint[5].father.ToString() + " " +
                            vectorPoint[6].father.ToString() + " " +
                            vectorPoint[7].father.ToString() + " " +
                            vectorPoint[8].father.ToString() + " " +
                            vectorPoint[9].father.ToString() + " " +
                            vectorPoint[10].father.ToString() + " " +
                            vectorPoint[11].father.ToString() + " ");

            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.Black);
            Graphics GpanelHolst;
            GpanelHolst = panelHolst.CreateGraphics();
            for (i = 0; i < Npoint; i++)
            {
                GpanelHolst.DrawEllipse(pen, vectorPoint[i].coord.X, 
                                             vectorPoint[i].coord.Y, 3, 3);
                GpanelHolst.FillEllipse(brush, vectorPoint[i].coord.X,
                                             vectorPoint[i].coord.Y, 3, 3);
            }
        }
    }

}
