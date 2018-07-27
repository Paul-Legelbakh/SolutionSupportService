using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace SolutionSupportService
{
    internal class Core
    {
        internal decimal[] TableTime(List<TablePoint> points)
        {
            int n = points.Count;
            decimal[] allTime = new decimal[n];
            //-------------------------
            return allTime;
        }

        internal List<TablePoint> GetButtons(Grid controlGrid)
        {
            List<TablePoint> points = new List<TablePoint>();
            for (int i = 0; i < controlGrid.Children.Count; i++)
            {
                if (controlGrid.Children[i].GetType() == typeof(Button))
                {
                    points.Add(controlGrid.Children[i] as TablePoint);
                }
            }
            return points;
        }

        protected bool Analytics(decimal[] times)
        {

            return true;
        }
    }
}
