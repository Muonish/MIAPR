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
        int WIDTH;
        int HEIGHT;
        PointInfo[] vectorPoint;
        int[] vectorKernel;

        public ClassKmeans(int npoint, int nclass, System.Windows.Forms.Panel panel)
        {
            Npoint = npoint;
            Nclass = nclass;
            panelHolst = panel;
            WIDTH = panelHolst.Width;
            HEIGHT = panelHolst.Height;
            vectorPoint = new PointInfo[Npoint];
            vectorKernel = new int[Nclass];
            RandomPoint();
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
            Pen pen = new Pen(Color.White);
            SolidBrush brush = new SolidBrush(Color.White);
            Graphics GpanelHolst;
            GpanelHolst = panelHolst.CreateGraphics();
            for (int i = 0; i < Npoint; i++)
            {
                if (vectorPoint[i].father == -1)
                {
                    pen.Color = vectorPoint[i].color;
                    brush.Color = pen.Color;
                }
                GpanelHolst.DrawEllipse(pen, vectorPoint[i].coord.X,
                                             vectorPoint[i].coord.Y, 3, 3);
                GpanelHolst.FillEllipse(brush, vectorPoint[i].coord.X,
                                             vectorPoint[i].coord.Y, 3, 3);
                pen.Color = Color.White;
                brush.Color = pen.Color;
            }
        }
    }

}
