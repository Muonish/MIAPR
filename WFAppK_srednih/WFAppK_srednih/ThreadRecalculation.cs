using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WFAppK_srednih
{
    public class ThreadRecalculation
    {
        private ClassKmeans.PointInfo[] vectorPoint;
        private int[] vectorKernel;
        private int i;
        private ManualResetEvent doneEvent;

        public ThreadRecalculation(ClassKmeans.PointInfo[] vectorPoint, int[] vectorKernel, int i, ManualResetEvent doneEvent)
        {
            this.vectorPoint = vectorPoint;
            this.vectorKernel = vectorKernel;
            this.i = i;
            this.doneEvent = doneEvent;
        }


        public void Recalculation(Object threadContext)
        {
            double averageDistance = 0;
            double minAverageDistance = double.MaxValue;
            int possibleKernel;

            minAverageDistance = double.MaxValue;
            possibleKernel = vectorKernel[i];
            for (int j = 0; j < ClassKmeans.Npoint; j++)
            {
                if (vectorPoint[j].father == vectorKernel[i] || j == vectorKernel[i])
                {
                    averageDistance = 0;
                    for (int k = 0; k < ClassKmeans.Npoint; k++)
                    {
                        if ((vectorPoint[k].father == vectorKernel[i] || k == vectorKernel[i]) && (k != j))
                        {
                            averageDistance += Math.Sqrt(Math.Pow((vectorPoint[k].coord.X - vectorPoint[j].coord.X), 2) +
                                                         Math.Pow((vectorPoint[k].coord.Y - vectorPoint[j].coord.Y), 2));
                        }
                    }
                    if (averageDistance < minAverageDistance)
                    {
                        minAverageDistance = averageDistance;
                        possibleKernel = j;
                    }
                }
            }
            if (vectorKernel[i] == possibleKernel)
            {
            }
            else
            {
                vectorPoint[vectorKernel[i]].father = 0;
                vectorKernel[i] = possibleKernel;
                vectorPoint[possibleKernel].father = -1;
                ClassKmeans.сentersIsChanged = true;
            }

            doneEvent.Set();
        }
    }
}
