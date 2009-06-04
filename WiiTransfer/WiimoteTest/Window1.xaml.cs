using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WiimoteLib;
using System.Threading;
using System.Windows.Threading;
using System.IO;
using System.Diagnostics;
using System.ServiceModel;
namespace WiimoteTest
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        WiiService.WiiTransferClient client = null;
        EnvironmentVariables variables = new EnvironmentVariables();
        WiimoteManager wiimoteManager = new WiimoteManager();
        private delegate void UpdateWiimoteStateDelegate(object sender, WiimoteUpdatedEventArgs args);


        List<SignalSample> wiimote1 = new List<SignalSample>();
        List<SignalSample> wiimote2 = new List<SignalSample>();
        public static List<SignalSample> wiimote3 = new List<SignalSample>();

        List<string> log = new List<string>();

        double max = 0;
        int limit = 0;

        SignalSample oldSample1 = new SignalSample();
        SignalSample oldSample2 = new SignalSample();
        DateTime DrawStart = DateTime.Now;

        bool redundancyMode = true;
        bool compareMode = true;

        public Window1()
        {
            InitializeComponent();
            LayoutRoot.DataContext = variables;
            wiimoteManager.WiimoteUpdated += new EventHandler<WiimoteUpdatedEventArgs>(OnWiimoteUpdated);
            canvas1.RenderTransformOrigin = new System.Windows.Point(canvas1.RenderSize.Width / 2, canvas1.RenderSize.Height / 2);


            new DispatcherTimer() { Interval = TimeSpan.FromSeconds(1.5), IsEnabled = false }
                .Tick += (s, e) =>
                {

                    //double proc = 0;
                    //limit = wiimote1.Count - wiimote1OldCount;
                    //wiimote1OldCount = wiimote1.Count;
                    //if (wiimote1.Count > limit && wiimote2.Count > limit)
                    //    proc = GetSeriesMatchPercentage(wiimote1, wiimote2, variables.EpsilonMaxim, limit);
                    //if(proc==0) Debugger.Break();
                    //mark the moment
                    //scroll.ScrollToHorizontalOffset((wiimote1.Last().TimeStamp - DrawStart).TotalMilliseconds / 10 - scroll.ActualWidth / 2);
                    //canvas1.Children.Add(new Line
                    //{
                    //    X1 = (wiimote1.Last().TimeStamp - DrawStart).TotalMilliseconds / 10,
                    //    X2 = (wiimote1.Last().TimeStamp - DrawStart).TotalMilliseconds / 10,
                    //    Y1 = 0,
                    //    Y2 = 100,
                    //    Stroke = new SolidColorBrush(Colors.Firebrick),
                    //    StrokeThickness = 1
                    //});
                    //TextBlock tb = new TextBlock { Text = proc.ToString("N0") + "%" }; 
                    //                               Canvas.SetTop(tb, 0);
                    //                               Canvas.SetLeft(tb, (wiimote1.Last().sampleTimeStamp - DrawStart).TotalMilliseconds / 10 - 40);
                    //canvas1.Children.Add(tb);

                    //lblMedDif.Content = proc.ToString("N0") + "%";

                };

        }

        void OnWiimoteUpdated(object sender, WiimoteUpdatedEventArgs e)
        {
            Dispatcher.BeginInvoke(DispatcherPriority.Normal, new UpdateWiimoteStateDelegate(WiimoteUpdated), sender, e);
           
        }

        void WiimoteUpdated(object sender, WiimoteUpdatedEventArgs e)
        {
             switch (e.SignalSample.Source)
            {
                case 1: DrawGraph(e.SignalSample, oldSample1, canvas1, Brushes.Blue, 1);
                    oldSample1 = e.SignalSample;
                    break;

                case 2: DrawGraph(e.SignalSample, oldSample2, canvas1, Brushes.Orange, 1);
                    oldSample2 = e.SignalSample;
                    break;
            }
        }



        private double GetSeriesMatchPercentage(List<SignalSample> series1, List<SignalSample> series2, int epsilonMax, int values)
        {
            int matches = 0;


            if (series1.Count > 99 && series2.Count > 99)
            {

                series1.Reverse();
                series1 = series1.Take(values).ToList();

                series2.Reverse();
                series2 = series2.Take(values).ToList();

                if (client != null)
                {
                    List<WiiService.SignalSample> sendseries = new List<WiiService.SignalSample>();
                    foreach (SignalSample s in series2) sendseries.Add(new WiimoteTest.WiiService.SignalSample() { sample = s.Sample, sampleTimeStamp = s.TimeStamp });
                    client.SendWiimoteDataAsync(sendseries);
                }


                for (int i = 0; i < series1.Count; i++)
                {
                    if (Math.Abs(series1[i].Sample.X - series2[i].Sample.X) < epsilonMax) matches++;
                }
            }

            return 100 * (double)matches / series1.Count;
        }

        void DrawGraph(SignalSample newRecord, SignalSample oldRecord, Canvas canvas, Brush brush, double thickness)
        {

            Line ln = new Line();
            ln.X1 = (newRecord.TimeStamp - DrawStart).TotalSeconds*50;
            ln.Y1 = newRecord.Sample.X;

            ln.X2 = (oldRecord.TimeStamp - DrawStart).TotalSeconds*50;
            ln.Y2 = oldRecord.Sample.X;

            ln.Stroke = brush;
            ln.StrokeThickness = thickness;
            canvas.Children.Add(ln);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            wiimoteManager.ConnectWiimotes();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            wiimoteManager.DisconnectWiimotes();

            //string path = @"C:\Wiimote\" + DateTime.Now.ToString("hh_mm_ss") + ".txt";
            //StreamWriter sw = new StreamWriter(path);
            //foreach (string s in log) sw.WriteLine(s);
            //sw.Close();
        }



        private void OnConnectWiimotes(object sender, RoutedEventArgs e)
        {
            wiimoteManager.ConnectWiimotes();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ServiceCreator c = new ServiceCreator();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            client = new WiimoteTest.WiiService.WiiTransferClient();
        }



    }
}
