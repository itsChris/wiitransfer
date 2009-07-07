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
using System.Security.Cryptography;
using System.ComponentModel;
namespace WiimoteTest
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public static Window currentWindow;
        WiiServiceReference.WiiServiceClient client = null;
        public EnvironmentVariables variables = new EnvironmentVariables();
        WiimoteManager wiimoteManager = new WiimoteManager();
        WifiManager wifiManager = new WifiManager();
        NetworkManager netManager = new NetworkManager();
        private delegate void UpdateWiimoteStateDelegate(object sender, WiimoteUpdatedEventArgs args);
        private delegate void UpdateGraphWithNewDataDelegate(List<SignalSample> sample);
        private delegate void UpdateStatusesDelegate();

        SignalSample oldSample1 = new SignalSample();
        SignalSample oldSample2 = new SignalSample();
        List<SignalSample> sampleList1 = new List<SignalSample>();
        List<SignalSample> adjustedSampleList1 = new List<SignalSample>();
        List<SignalSample> receivedSampleList = new List<SignalSample>();

        DateTime DrawStart = DateTime.Now;
        DateTime DateLastSignalSent = DateTime.Now;

        DispatcherTimer sendTimer = new DispatcherTimer() { Interval = TimeSpan.FromMilliseconds(1500) };
        DispatcherTimer samplerTimer = new DispatcherTimer() { Interval = TimeSpan.FromMilliseconds(200), IsEnabled = true };

        DispatcherTimer ipTimer = new DispatcherTimer() { Interval = TimeSpan.FromMilliseconds(1500), IsEnabled = true };

        int countTops = 0;
        SignalSample lastTop = new SignalSample();
        SignalSample lastBottom = new SignalSample();

        BackgroundWorker worker = new BackgroundWorker();

        DateTime lastSampleTime = DateTime.Now;
        public Window1()
        {
            currentWindow = this;
            InitializeComponent();
            LayoutRoot.DataContext = variables;
            wiimoteManager.WiimoteUpdated += new EventHandler<WiimoteUpdatedEventArgs>(OnWiimoteUpdated);
            sendTimer.Tick += (s, ev) => { SendSampleList(sampleList1); sendTimer.IsEnabled = false; };

            samplerTimer.Tick += new EventHandler(samplerTimer_Tick);
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerAsync();

        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Thread.Sleep(2000);
                variables.CurrentIP = netManager.GetIP(wifiManager.InterfaceDescription);
                variables.ConnectionStatus = wifiManager.ConnectionStatus;
                //Dispatcher.BeginInvoke(DispatcherPriority.Normal, new UpdateStatusesDelegate(UpdateStatuses)); 
            }
        }


        public void UpdateStatuses()
        {

        }

        void samplerTimer_Tick(object sender, EventArgs e)
        {
            if (countTops > 10)
            {
                //SendHash(variables.Code);
                //ClearCount();
            }

        }


        public void ClearCount()
        {
            countTops = 0;
            variables.Code = "";
        }

        void OnMatchingTimer(object sender, EventArgs e)
        {
            AddMarker(oldSample1, canvas1, "Raul");
        }

        void DisplayMatchPercentage(List<SignalSample> list1, List<SignalSample> list2)
        {

            double percentage = GetSeriesMatchPercentage(list1, list2, variables.EpsilonMaxim, 100);
            AddMarker(oldSample1, canvas1, percentage.ToString("N0") + "%");
        }

        void OnWiimoteUpdated(object sender, WiimoteUpdatedEventArgs e)
        {
            Dispatcher.BeginInvoke(DispatcherPriority.Normal, new UpdateWiimoteStateDelegate(WiimoteUpdated), sender, e);
        }

        void WiimoteUpdated(object sender, WiimoteUpdatedEventArgs e)
        {
            if (e.SignalSample.Source == currentWiimote)
            {

                SignalSample adjustedSample = AdjustSample(e.SignalSample);
                DrawGraph(adjustedSample, oldSample1, canvas1, Brushes.Blue, 1);
                oldSample1 = adjustedSample;
                sampleList1.Add(adjustedSample);
                if (sampleList1.Count > 3)
                {



                    if (sampleList1.Count > 10)
                    {
                        int n = sampleList1.Count - 1;

                        int check = 3;
                        bool topChecks = true;
                        bool bottomChecks = true;
                        for (int i = 0; i <= check; i++)
                        {
                            if (sampleList1[n - check + i].Sample.X < sampleList1[n - check].Sample.X)
                            {
                                topChecks = false;

                            }
                            if (sampleList1[n - check - i].Sample.X < sampleList1[n - check].Sample.X)
                            {
                                topChecks = false;

                            }

                            if (sampleList1[n - check + i].Sample.X > sampleList1[n - check].Sample.X)
                            {
                                bottomChecks = false;

                            }
                            if (sampleList1[n - check - i].Sample.X > sampleList1[n - check].Sample.X)
                            {
                                bottomChecks = false;

                            }
                        }
                        if (topChecks)
                        {
                            if (sampleList1[n - check].Sample.X - 125 < -25)
                            {
                                if ((sampleList1[n - check].TimeStamp - lastTop.TimeStamp).TotalMilliseconds > 300)
                                {


                                    MarkTop(sampleList1[n - check], canvas1, Brushes.Brown, countTops.ToString());
                                    variables.Code += "1";
                                    countTops++;
                                    lastTop = sampleList1[n - check];
                                }

                            }
                        }

                        if (bottomChecks)
                        {
                            if (sampleList1[n - check].Sample.X - 125 > 25)
                            {
                                if ((sampleList1[n - check].TimeStamp - lastBottom.TimeStamp).TotalMilliseconds > 300)
                                {
                                    MarkTop(sampleList1[n - check], canvas1, Brushes.BlueViolet, countTops.ToString());
                                    variables.Code += "0";
                                    countTops++;
                                    lastBottom = sampleList1[n - check];
                                }

                            }
                        }
                    }



                    if (Math.Abs(e.SignalSample.Sample.X - 124) > 25 && !sendTimer.IsEnabled)
                    {
                        sendTimer.IsEnabled = true;
                    }
                }


                if (sampleList1.Count > 1000)
                {
                    canvas1.Children.Clear();
                    DrawStart = DateTime.Now;
                    sampleList1.Clear();
                    receivedSampleList.Clear();
                }
            }
        }


        void MarkTop(SignalSample sample, Canvas camvas1, Brush b, string text)
        {
            Line ln = new Line();
            ln.X1 = (sample.TimeStamp - DrawStart).TotalSeconds * variables.TimeZoom - 2;
            ln.X2 = (sample.TimeStamp - DrawStart).TotalSeconds * variables.TimeZoom + 2;
            ln.Y1 = ln.Y2 = (sample.Sample.X * variables.SignalZoom - 110 * variables.SignalZoom + 120);
            ln.Stroke = b;
            ln.StrokeThickness = 1;
            TextBlock tb = new TextBlock();
            tb.Text = text;
            Canvas.SetLeft(tb, ln.X1 + 10);
            Canvas.SetTop(tb, ln.Y1 + 10);
            canvas1.Children.Add(tb);
            canvas1.Children.Add(ln);
        }

        public void ReceiveSampleList(List<SignalSample> sample)
        {
            receivedSampleList.AddRange(sample);
            Dispatcher.BeginInvoke(DispatcherPriority.Normal, new UpdateGraphWithNewDataDelegate(UpdateGraphWithNewData), sample);
        }

        public void UpdateGraphWithNewData(List<SignalSample> sample)
        {
            double perc = GetSeriesMatchPercentage(adjustedSampleList1, sample, variables.EpsilonMaxim, 100);
            DrawSampleListGraph(sample, canvas1, Brushes.Red, 1);
            AddMarker(sample[0], canvas1, perc.ToString("N2"));
        }

        SignalSample AdjustSample(SignalSample sample)
        {
            SignalSample adjustedSample = sample;
            adjustedSample.Sample = new Point3()
            {
                X = Convert.ToInt32(adjustedSample.Sample.X * variables.ScaleAdjustment + variables.SignalAdjustment),
                Y = adjustedSample.Sample.Y,
                Z = adjustedSample.Sample.Z
            };
            adjustedSample.TimeStamp += dateDifference;
            return adjustedSample;

        }


        void AddMarker(SignalSample record, Canvas canvas, string label)
        {
            Line ln = new Line();
            TextBlock text = new TextBlock();
            ln.X1 = ln.X2 = (record.TimeStamp - DrawStart).TotalSeconds * variables.TimeZoom;
            Canvas.SetLeft(text, ln.X1 - 40); Canvas.SetTop(text, 20);
            ln.Y1 = 0; ln.Y2 = 100;
            ln.Stroke = Brushes.Firebrick;
            ln.StrokeThickness = 1;
            text.Text = label;
            canvas.Children.Add(ln);
            canvas.Children.Add(text);
        }

        void DrawGraph(SignalSample newRecord, SignalSample oldRecord, Canvas canvas, Brush brush, double thickness)
        {

            Line ln = new Line();
            ln.X1 = (newRecord.TimeStamp - DrawStart).TotalSeconds * variables.TimeZoom;
            ln.Y1 = newRecord.Sample.X * variables.SignalZoom - 110 * variables.SignalZoom + 120;

            //ln.X2 = (newRecord.TimeStamp - DrawStart).TotalSeconds * variables.TimeZoom+1;
            //ln.Y2 = newRecord.Sample.X * variables.SignalZoom - 110 * variables.SignalZoom + 120+1;

            ln.X2 = (oldRecord.TimeStamp - DrawStart).TotalSeconds * variables.TimeZoom;
            ln.Y2 = oldRecord.Sample.X * variables.SignalZoom - 110 * variables.SignalZoom + 120;




            ln.Stroke = brush;
            ln.StrokeThickness = 1;

            canvas.Children.Add(ln);
        }

        void DrawSampleListGraph(List<SignalSample> records, Canvas canvas, Brush brush, double thickness)
        {
            int i = 1;
            while (i < records.Count)
            {
                DrawGraph(records[i], records[i - 1], canvas, brush, thickness);
                i++;
            }
        }

        private double GetSeriesMatchPercentage(List<SignalSample> series1, List<SignalSample> series2, int epsilonMax, int values)
        {
            int matches = 0;

            int counter = 0;
            int n = Math.Min(series1.Count, series2.Count) - 1;
            int decalaj = 0;

            for (int i = 0; i < n; i++)
            {
                if (series1.Count > i)
                {
                    int compare1signal = series1[series1.Count - i - 1].Sample.X;
                    int compare2signal = series2[n - i].Sample.X;
                    double compare1time = (series2[n - i].TimeStamp - DrawStart).TotalSeconds;
                    double compare2time = (series1[series1.Count - i - 1].TimeStamp - DrawStart).TotalSeconds;

                    Debug.WriteLine(compare1time - compare2time + "%");
                    if (Math.Abs(compare1signal - compare2signal) <= epsilonMax)
                    {
                        matches++;



                        Line l = new Line();
                        l.Y1 = compare1signal * variables.SignalZoom - 110 * variables.SignalZoom + 120;
                        l.X1 = compare1time * variables.TimeZoom;
                        l.Y2 = compare2signal * variables.SignalZoom - 110 * variables.SignalZoom + 120;
                        l.X2 = compare2time * variables.TimeZoom;
                        l.Stroke = Brushes.Brown;
                        l.StrokeThickness = 0.3;
                        canvas1.Children.Add(l);

                    }
                }
            }
            return 100 * (double)matches / counter;
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OnConnectWiimotes(sender, e);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            wiimoteManager.DisconnectWiimotes();
        }



        private void OnConnectWiimotes(object sender, RoutedEventArgs e)
        {
            Dictionary<Guid, int> wiimotes = wiimoteManager.ConnectWiimotes();
            foreach (var wiimote in wiimotes)
                WiimoteList.Items.Add(new ListBoxItem() { Content = "Wiimote " + wiimote.Value, Tag = wiimote.Value });
        }


        int currentWiimote = 1;
        private void WiimoteList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentWiimote = Convert.ToInt32((WiimoteList.SelectedItem as ListBoxItem).Tag);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ServiceCreator c = new ServiceCreator();
        }


        private void SendSampleList(List<SignalSample> sampleList)
        {

            if (client == null) client = new WiiServiceReference.WiiServiceClient();
            if (client != null)
            {
                List<WiiServiceReference.SignalSample> sendseries = new List<WiiServiceReference.SignalSample>();

                int count = 0;
                foreach (SignalSample s in adjustedSampleList1)
                    if (s.TimeStamp > DateTime.Now + dateDifference - sendTimer.Interval)
                    {
                        sendseries.Add(new WiiServiceReference.SignalSample() { Sample = s.Sample, TimeStamp = s.TimeStamp, Source = s.Source });
                    }
                byte[] send = new byte[sendseries.Count];
                byte[] tmpsend;
                foreach (WiiServiceReference.SignalSample s in sendseries)
                {
                    send[count] = Convert.ToByte(s.Sample.X);
                    count++;
                }
                tmpsend = new MD5CryptoServiceProvider().ComputeHash(send);
                try
                {
                    //client.SendWiimoteData(sendseries);
                    //client.SendWiimoteDataasHash(tmpsend,sendseries[0].TimeStamp,sendseries.Count);
                    DateLastSignalSent = DateTime.Now;
                    //sampleList1.Clear();
                    client.Close();
                }
                catch
                {
                }
                finally
                {
                    client = null;
                }


            }
        }

        void SendHash(string toSend)
        {
            LastSentKey = toSend;
            byte[] tmpsend;
            tmpsend = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(toSend.Substring(0, 10)));
            if (client == null)
            {
                client = new WiiServiceReference.WiiServiceClient();
                client.CheckWiimoteDataHashCompleted += new EventHandler<WiimoteTest.WiiServiceReference.CheckWiimoteDataHashCompletedEventArgs>(client_CheckWiimoteDataHashCompleted);
            }
            if (client != null)
            {
                try
                {
                    client.CheckWiimoteDataHashAsync(tmpsend);
                    DateLastSignalSent = DateTime.Now;
                    client.Close();
                }
                catch
                {
                }
                finally
                {
                    client = null;
                }
            }



        }

        string LastSentKey { get; set; }

        void client_CheckWiimoteDataHashCompleted(object sender, WiimoteTest.WiiServiceReference.CheckWiimoteDataHashCompletedEventArgs e)
        {
            if (e.Error == null)
            {

                if (e.Result == true)
                {
                    variables.CodeStatus = "Verified";
                }
                if (e.Result == false)
                {
                    variables.CodeStatus = "Not Verified";
                }
            }

        }


        private void button5_Click(object sender, RoutedEventArgs e)
        {
            SendSampleList(sampleList1);
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            canvas1.Children.Clear();
            DrawStart = DateTime.Now;
            sampleList1.Clear();
            receivedSampleList.Clear();
        }

        TimeSpan dateDifference;
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (client == null) client = new WiiServiceReference.WiiServiceClient();
            if (client != null)
            {
                try
                {
                    DateTime serverTime = client.GetServerTime();
                    dateDifference = (serverTime - DateTime.Now);
                }
                catch
                {
                }
                finally
                {
                    client = null;
                }

            }
        }

        private void btnCalibrate_Click(object sender, RoutedEventArgs e)
        {
            if (client == null) client = new WiiServiceReference.WiiServiceClient();
            if (client != null)
            {
                List<SignalSample> minSample = sampleList1.Take(100).ToList();
                List<WiiServiceReference.SignalSample> sendseries = new List<WiiServiceReference.SignalSample>();
                foreach (SignalSample s in minSample)
                {
                    //WiiServiceReference.Point3 p = new WiimoteTest.WiiServiceReference.Point3() { X = s.Sample.X, Y = s.Sample.Y, Z = s.Sample.Z };
                    sendseries.Add(new WiiServiceReference.SignalSample() { Sample = s.Sample, TimeStamp = s.TimeStamp + dateDifference, Source = s.Source });
                }
                try
                {
                    //client.Calibrate(sendseries);
                }
                catch
                {
                }
                finally
                {
                    client = null;
                }
            }
        }

        //connect
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password == "") wifiManager.Connect(lbNetworks.SelectedItem.ToString());
            else wifiManager.ConnectToSecure(lbNetworks.SelectedItem.ToString(), txtPassword.Password);
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            lbNetworks.Items.Clear();
            foreach (string n in wifiManager.getAvailableNetworks(true))
            {
                lbNetworks.Items.Add(n);
            }
        }

        private void btnDisconnect_Click(object sender, RoutedEventArgs e)
        {
            wifiManager.Disconnect();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password == "") wifiManager.CreateUnsecureAndConnect(txtNetworkName.Text);
            else wifiManager.CreateSecureAndConnect(txtNetworkName.Text, txtPassword.Password);

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            netManager.SetIP(wifiManager.InterfaceDescription, "192.168.1.1", "255.255.255.0");
        }

        private void btnClientIP_Click(object sender, RoutedEventArgs e)
        {
            netManager.SetIP(wifiManager.InterfaceDescription, "192.168.1.2", "255.255.255.0");
        }

        private void btnSerDHCP_Click(object sender, RoutedEventArgs e)
        {
            netManager.SetAutoIp(wifiManager.InterfaceDescription);
        }

        private void btnConnectUsingCode_Click(object sender, RoutedEventArgs e)
        {
            wifiManager.Disconnect();
            wifiManager.ConnectToSecure(wifiManager.CurrentlyConnectedTo, variables.LastAcceptedPassword);
        }

        private void btnClearCode_Click(object sender, RoutedEventArgs e)
        {
            this.ClearCount();
        }

    }
}
