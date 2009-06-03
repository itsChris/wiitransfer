﻿using System;
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
        WiimoteState wms;

        WiiService.WiiTransferClient client = null;

        WiimoteCollection mWC;
        Dictionary<Guid, int> mWiimoteMap = new Dictionary<Guid, int>();
        private delegate void UpdateWiimoteStateDelegate(object sender, WiimoteChangedEventArgs args);
     
        List<SignalSample> wiimote1 = new List<SignalSample>();
        List<SignalSample> wiimote2 = new List<SignalSample>();
        public static List<SignalSample> wiimote3 = new List<SignalSample>();
        List<string> log = new List<string>();
        int valori;

        int[] changesx = new int[256];
        int[] changesy = new int[256];
        int[] changesz = new int[256];
        double max = 0;
        int limit = 0;

        SignalSample lastwiimote1, lastwiimote2;
        Form1 f = new Form1();
        DateTime DrawStart = DateTime.Now;

        bool redundancyMode = true;
        bool compareMode = true;

        public Window1()
        {
            InitializeComponent();
            DispatcherTimer t = new DispatcherTimer();
            t.Interval = TimeSpan.FromMilliseconds(1);
            t.Tick += new EventHandler(UpdateGraphs);
            t.Start();
            checkBox1.IsEnabled = false;

            canvas1.RenderTransformOrigin = new System.Windows.Point(canvas1.RenderSize.Width / 2, canvas1.RenderSize.Height / 2);
            UpdateLabels();
            //f.Show();
            int wiimote1OldCount = 0;

            
            
            new DispatcherTimer() { Interval=TimeSpan.FromSeconds(0.2), IsEnabled=true }
                .Tick += (s, e) =>
                {
                    
                    double proc = 0;
                    limit = wiimote1.Count - wiimote1OldCount;
                    wiimote1OldCount = wiimote1.Count;
                    if (wiimote1.Count > limit && wiimote2.Count > limit)
                        proc = GetSeriesMatchPercentage(wiimote1, wiimote2, epsilonMax, limit);
                    //if(proc==0) Debugger.Break();
                    //mark the moment
                    //scroll.ScrollToHorizontalOffset((wiimote1.Last().sampleTimeStamp - DrawStart).TotalMilliseconds / 10 - scroll.ActualWidth / 2);
                    //canvas1.Children.Add(new Line { X1 = (wiimote1.Last().sampleTimeStamp - DrawStart).TotalMilliseconds / 10,
                    //                                X2 = (wiimote1.Last().sampleTimeStamp - DrawStart).TotalMilliseconds / 10, 
                    //                                Y1 = 0, 
                    //                                Y2 = 100,
                    //                                Stroke = new SolidColorBrush(Colors.Firebrick), 
                    //                                StrokeThickness = 1 });
                    //TextBlock tb = new TextBlock { Text = proc.ToString("N0") + "%" }; 
                    //                               Canvas.SetTop(tb, 0);
                    //                               Canvas.SetLeft(tb, (wiimote1.Last().sampleTimeStamp - DrawStart).TotalMilliseconds / 10 - 40);
                    //canvas1.Children.Add(tb);

                    lblMedDif.Content = proc.ToString("N0") + "%";
                    
                };

        }

        void UpdateLabels()
        {
            if (lblSignalAdjustment != null)
                lblSignalAdjustment.Content = sliderSignalAdjustment.Value;
            if (lblEpsilonMax != null)
                lblEpsilonMax.Content = slideEpsilonMax.Value;
            if (lblScaleAdjustment != null)
                lblScaleAdjustment.Content = slider1.Value;

        }

        void UpdateGraphs(object sender, EventArgs e)
        {
            //wiimote2.Add(lastwiimote2);
            //wiimote1.Add(lastwiimote1);


            if (running)
            {
                if (redundancyMode)
                {
                    //DrawBars(changesx, canvas1);
                    //DrawBars(changesy, canvas2);
                    //DrawBars(changesz, canvas3);
                }

                if (compareMode)
                {
                    //wiimoteDiff.Add(Convert.ToByte(Math.Abs((lastXwiimote2 - lastXwiimote1))));

                    //label8.Content = "w1: " + wiimote1.Count + " w2: " + wiimote2.Count;
                    //DrawGraph(wiimoteDiff, canvas3, Brushes.OrangeRed,1);
                    //DrawGraph(wiimote2, canvas1, Brushes.Red, 1);
                    DrawGraph(wiimote3, canvas1, Brushes.RoyalBlue, 1);

                }
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
                
                List<WiiService.SignalSample> sendseries = new List<WiiService.SignalSample>();
                foreach (SignalSample s in series2) sendseries.Add(new WiimoteTest.WiiService.SignalSample() { sample = s.sample, sampleTimeStamp = s.sampleTimeStamp });
                if (client != null)
                    client.SendWiimoteDataAsync(sendseries);

                
                for (int i = 0; i < series1.Count; i++)
                {
                    if (Math.Abs(series1[i].sample.X - series2[i].sample.X) < epsilonMax) matches++;
                }
            }

            return 100 * (double)matches / series1.Count ;
        }

        int adjustment;
        double scaleAdjustment;
        int epsilonMax;




        void DrawGraph(List<SignalSample> record, Canvas canvas, Brush brush, double thickness)
        {
            if (record.Count > 2)
            {
                canvas.Children.Clear();



                for (int i = 0; i < record.Count; i++)
                {
                    SignalSample sig = record[i];
                    Line ln = new Line();
                    ln.X1 = (record.IndexOf(sig));
                    ln.Y1 = sig.sample.X * signalzoom.Value;

                    ln.X2 = (record.IndexOf(sig)) + 1;
                    ln.Y2 = sig.sample.X * signalzoom.Value;

                    ln.Stroke = brush;
                    ln.StrokeThickness = thickness;
                    canvas.Children.Add(ln);
                }
                
            }
        }



        void DrawBars(int[] values, Canvas canvas)
        {
            valori = 0;
            canvas.Children.Clear();
            int i = 0;
            foreach (int y in values)
            {
                i++;
                if (y != 0)
                {
                    valori++;
                    Line ln = new Line();
                    ln.X1 = i;
                    ln.X2 = i;
                    ln.Y1 = 0;
                    ln.Y2 = y;
                    ln.Stroke = Brushes.OrangeRed;
                    ln.StrokeThickness = 1;
                    canvas.Children.Add(ln);
                }
            }
            label9.Content = valori;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            label1.Content = "";
            ConnectWiiMotes();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (Wiimote wm in mWC)
                wm.Disconnect();

            //string path = @"C:\Wiimote\" + DateTime.Now.ToString("hh_mm_ss") + ".txt";
            //StreamWriter sw = new StreamWriter(path);
            //foreach (string s in log) sw.WriteLine(s);
            //sw.Close();
        }
        #region CheckBoxes and RadioButtons
        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            redundancyMode = false;
            compareMode = true;
            //checkBox1.IsEnabled = true;
        }
        private void radioButton2_Unchecked(object sender, RoutedEventArgs e)
        {
            checkBox1.IsEnabled = false;
        }
        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            redundancyMode = true;
            compareMode = false;
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            canvas2.Margin = canvas1.Margin;
        }

        private void checkBox1_Unchecked(object sender, RoutedEventArgs e)
        {
            Thickness thick = new Thickness();
            thick = canvas2.Margin;
            thick.Top += +canvas2.Height + 20;
            canvas3.Margin = thick;
        }
        #endregion

        bool running = true;
        private void OnStartStop(object sender, RoutedEventArgs e)
        {
            running = !running;

            if (running) { button1.Content = "Stop"; }
            else
            {
                button1.Content = "Start";
            }

        }

        private void OnClear(object sender, RoutedEventArgs e)
        {
            limit = 0;
            if (compareMode)
            {
                wiimote1.Clear();
                wiimote2.Clear();
              
                canvas1.Children.Clear();
                canvas2.Children.Clear();
                canvas3.Children.Clear();
            }
            if (redundancyMode)
            {
                changesx = new int[256];
                changesy = new int[256];
                changesz = new int[256];
            }
        }

        private void OnConnectWiimotes(object sender, RoutedEventArgs e)
        {
            ConnectWiiMotes();
        }

        void ConnectWiiMotes()
        {
            label6.Content = "Not Connected";
            label7.Content = "Not Connected";
            mWC = new WiimoteCollection();
            int index = 1;
            try
            {
                mWC.FindAllWiimotes();
            }
            catch (WiimoteNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Wiimote not found error");
            }
            catch (WiimoteException ex)
            {
                MessageBox.Show(ex.Message, "Wiimote error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unknown error");
            }
            foreach (Wiimote wm in mWC)
            {
                try
                {
                    mWiimoteMap[wm.ID] = index;
                    wm.WiimoteChanged += OnWiiMoteChanged;
                    wm.WiimoteExtensionChanged += OnWiiMoteAddExtension;
                    wm.Connect();
                    wm.SetReportType(InputReport.IRAccel, true);
                    switch (index)
                    {
                        case 1: label6.Content = "Connected"; break;
                        case 2: label7.Content = "Connected"; break;
                    }
                    wm.SetLEDs(index++);
                }
                catch
                {
                }

            }
        }

        void OnWiiMoteAddExtension(object sender, WiimoteExtensionChangedEventArgs e)
        {

        }

        void OnWiiMoteChanged(object sender, WiimoteChangedEventArgs e)
        {
            Dispatcher.BeginInvoke(DispatcherPriority.Normal, new UpdateWiimoteStateDelegate(UpdateWiimoteChanged), sender, e);
        }

        private void UpdateWiimoteChanged(object sender, WiimoteChangedEventArgs args)
        {
            int currentWiiMote = mWiimoteMap[((Wiimote)sender).ID];
            WiimoteState state = args.WiimoteState;

            switch (currentWiiMote)
            {
                case 1: label2.Content = state.AccelState.RawValues.X.ToString("N2");
                    lastwiimote1 = new SignalSample();
                    lastwiimote1.sample = state.AccelState.RawValues;
                    lastwiimote1.sampleTimeStamp = DateTime.Now;
                    wiimote1.Add(lastwiimote1);
                    //log.Add(lastXwiimote1.ToString()+" ");

                    if (running && redundancyMode)
                    {
                        if (state.AccelState.Values.X > max) max = state.AccelState.Values.X;
                        int x = state.AccelState.RawValues.X;
                        int y = state.AccelState.RawValues.Y;
                        int z = state.AccelState.RawValues.Z;

                        changesx[x]++;
                        changesy[y]++;
                        changesz[z]++;
                    }
                    break;
                case 2: label3.Content = state.AccelState.RawValues.X.ToString("N2");
                    lastwiimote2 = new SignalSample();
                    Point3 p = state.AccelState.RawValues;
                    p.X = (byte)(p.X * scaleAdjustment + adjustment);
                    lastwiimote2.sample = p;
                    lastwiimote2.sampleTimeStamp = DateTime.Now;
                    wiimote2.Add(lastwiimote2);
                    WiiService.SignalSample sample = new WiimoteTest.WiiService.SignalSample() { sample = lastwiimote1.sample, sampleTimeStamp = lastwiimote1.sampleTimeStamp };
                    
                    //lastwiimote2.sample.X = (byte)(lastwiimote2.sample.X * scaleAdjustment + adjustment);
                    //if (f.sendData) f.SendByte((byte)state.AccelState.RawValues.X);
                    //wiimote2.Add(lastXwiimote2);
                    break;

            }

           

            //label1.Content = Math.Abs((lastwiimote2.sample.X - lastwiimote1.sample.X)).ToString("N2");

        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            scaleAdjustment = Convert.ToInt32(e.NewValue);
            UpdateLabels();

        }

        private void sliderSignalAdjustment_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            adjustment = Convert.ToInt32(e.NewValue);
            UpdateLabels();

        }

        private void slideEpsilonMax_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            epsilonMax = Convert.ToInt32(e.NewValue);
            UpdateLabels();

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
