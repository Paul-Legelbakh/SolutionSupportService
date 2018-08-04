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
    public partial class AnalyticPage : ContentPage
	{
        internal static Stopwatch stopWatch = new Stopwatch();
        Core core = new Core();
        private static List<TablePoint> points = new List<TablePoint>();

        public AnalyticPage()
		{
            InitializeComponent();
            points = core.GetButtons(controlGrid);
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            if (!stopWatch.IsRunning) stopWatch.Start();
            Button point = sender as Button;

            try
            {
                points.Single(pt => pt.ButtonObject == point).Time = stopWatch.ElapsedMilliseconds;
            }
            catch(Exception w)
            {
                Console.WriteLine(w.Message + " || AnaliticPage.xaml.cs from line 30");
            }

            Button btn = new Button();
            btn = sender as Button;
            btn.Text = points.Single(pt => pt.ButtonObject == btn).Time.ToString();
        }

        private void DoneButton_Clicked(object sender, EventArgs e)
        {
            if (stopWatch.IsRunning) stopWatch.Stop();
        }
    }
}
