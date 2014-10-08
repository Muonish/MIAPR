using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WFAppMax_Min
{
    public class ThreadRecalculation
    {
        private Classification.PointInfo[] vectorPoint;
        private List<int> vectorKernel;
        private int kernel;
        private ManualResetEvent doneEvent;

        public ThreadRecalculation(Classification.PointInfo[] vp, List<int> vk, int i, ManualResetEvent de)
        {
            vectorPoint = vp;
            vectorKernel = vk;
            kernel = i;
            doneEvent = de;
        }


        public void Recalculation(Object threadContext)
        {
            double averageDistance = 0;
            double minAverageDistance = double.MaxValue;
            int possibleKernel;

            minAverageDistance = double.MaxValue;
            possibleKernel = vectorKernel[kernel];
            for (int j = 0; j < vectorPoint.Length; j++)
            {
                if (vectorPoint[j].father == vectorKernel[kernel] || j == vectorKernel[kernel])
                {
                    averageDistance = 0;
                    for (int k = 0; k < vectorPoint.Length; k++)
                    {
                        if ((vectorPoint[k].father == vectorKernel[kernel] || k == vectorKernel[kernel]) && (k != j))
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
            if (vectorKernel[kernel] == possibleKernel)
            {
            }
            else
            {
                vectorPoint[vectorKernel[kernel]].father = 0;
                vectorKernel[kernel] = possibleKernel;
                vectorPoint[possibleKernel].father = -1;
                ClassKmeans.сentersIsChanged = true;
            }

            doneEvent.Set();
        }
    }
}
