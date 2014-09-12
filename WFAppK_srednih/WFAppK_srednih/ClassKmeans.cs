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
        int WIDTH;
        int HEIGHT;

        public struct PointInfo
        {
            public Point coord;  
            public int father;
        }

        public ClassKmeans(int npoint, int nclass, int width, int height)
        {
            Npoint = npoint;
            Nclass = nclass;
            WIDTH = width;
            HEIGHT = height;
        }

        private void RandomPoint()
        {
            Random RandomNumber = new Random();
            PointInfo[] vectorPoint = new PointInfo[Npoint];

            for (int i = 0; i < Npoint; i++)
            {
                vectorPoint[i].coord = new Point(RandomNumber.Next(1, WIDTH), RandomNumber.Next(1, HEIGHT));
                vectorPoint[i].father = RandomNumber.Next(0, Npoint-1);
            }
            for (int i = 0; i < Npoint; i++)
            {
                Pen pen = new Pen(Color.Black);
                Graphics GpanelHolst;
                GpanelHolst = panelHolst.CreateGraphics();
                
            }
        }
    }

}
