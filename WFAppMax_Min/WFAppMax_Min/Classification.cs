using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WFAppMax_Min
{
    public class Classification
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
        PointInfo[] vectorPoint;
        List<int> vectorKernel;

        public Classification(int npoint, FormMain p)
        {
            parent = p;
            Npoint = npoint;
            vectorPoint = new PointInfo[Npoint];
            RandomPoint();
            Classify(parent, ref vectorPoint, ref vectorKernel);
            var maximin = new ClassMaximin(parent, vectorPoint, vectorKernel);
            MessageBox.Show("Maximin finished!");
            var kmeans = new ClassKmeans(parent, vectorPoint, vectorKernel);
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
        public static Color SetRandomColor()
        {
            var RandomNumber = new Random();
            return Color.FromArgb(RandomNumber.Next(DiapasonColorMin, DiapasonColorMax),
                                  RandomNumber.Next(DiapasonColorMin, DiapasonColorMax),
                                  RandomNumber.Next(DiapasonColorMin, DiapasonColorMax));
        }
        public static void Classify(FormMain parent, ref PointInfo[] vectorPoint, ref List<int> vectorKernel)
        {
            double minway = double.MaxValue;
            double way = 0;
            int nearestKernel = 0;
            int oldKernel = 0;

            StatusMessage(parent, "Classify...");
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
        public static void StatusMessage(FormMain parent, String message)
        {
            parent.labelStatus.Text = message;
            parent.labelStatus.Refresh();

        }
    }
}
