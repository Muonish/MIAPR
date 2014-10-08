using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;

namespace WFAppMax_Min
{
    public class ClassKmeans
    {
        private FormMain parent;

        public static bool сentersIsChanged;
        public static Classification.PointInfo[] vectorPoint;
        List<int> vectorKernel;

        public ClassKmeans(FormMain p, Classification.PointInfo[] vp, List<int> vk)
        {
            parent = p;
            vectorPoint = vp;
            vectorKernel = vk;
            Processing();
        }
 
        private void Paint()
        {
            Classification.StatusMessage(parent, "Painting...");
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.Black);
            Graphics GpanelHolst = parent.panelHolst.CreateGraphics();
            for (int i = 0; i < vectorPoint.Length; i++)
            {
                if (vectorPoint[i].isChanged)
                {
                    pen.Color = vectorPoint[i].color;
                    brush.Color = pen.Color;
                    GpanelHolst.FillRectangle(brush, vectorPoint[i].coord.X,
                                                     vectorPoint[i].coord.Y, 7, 7);

                    vectorPoint[i].isChanged = false;
                }
            }
        }
       
        private bool CentersIsChanged()
        {
            сentersIsChanged = false;
            ManualResetEvent[] doneEvents = new ManualResetEvent[vectorKernel.Count];

            Classification.StatusMessage(parent,"Recalculation...");
            for (int i = 0; i < vectorKernel.Count; i++)
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
            Classification.Classify(parent, ref vectorPoint, ref vectorKernel);
            Paint();
            while (CentersIsChanged())
            {
                Classification.Classify(parent, ref vectorPoint, ref vectorKernel);
                Paint();
            }
            Classification.StatusMessage(parent,"Finish.");
        }
    }
}
