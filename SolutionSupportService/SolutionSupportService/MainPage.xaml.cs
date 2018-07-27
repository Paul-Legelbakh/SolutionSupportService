using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SolutionSupportService
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
	{
        internal static Stopwatch stopWatch = new Stopwatch();
        Core core = new Core();
        private static List<TablePoint> points = new List<TablePoint>();

        public MainPage()
		{
            InitializeComponent();
            points = core.GetButtons(controlGrid);
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            if (!stopWatch.IsRunning) stopWatch.Start();
            TablePoint point = (TablePoint)sender;

            foreach(TablePoint pt in points)
            {
                if(pt == point)
                {
                    pt.Time = stopWatch.ElapsedMilliseconds;
                }
            }
        }
    }
}
