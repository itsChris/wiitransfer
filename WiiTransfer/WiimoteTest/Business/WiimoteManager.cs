using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WiimoteLib;
using System.Windows.Forms;
using System.Windows.Threading;

namespace WiimoteTest
{
    public class WiimoteUpdatedEventArgs : EventArgs
    {
        public WiimoteUpdatedEventArgs(SignalSample sample)
        {
            SignalSample = sample;
        }
        public SignalSample SignalSample { get; set; }
    }
    class WiimoteManager
    {
        WiimoteState wms;
        WiimoteCollection mWC;
        Dictionary<Guid, int> mWiimoteMap = new Dictionary<Guid, int>();
        
        public event EventHandler<WiimoteUpdatedEventArgs> WiimoteUpdated;

        public WiimoteManager()
        {

        }

        public void DisconnectWiimotes()
        {
            foreach (Wiimote wm in mWC)
                wm.Disconnect();
        }

        public Dictionary<Guid, int> ConnectWiimotes()
        {
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
                    wm.WiimoteChanged += UpdateWiimoteChanged;
                    wm.WiimoteExtensionChanged += OnWiiMoteAddExtension;
                    wm.Connect();
                    wm.SetReportType(InputReport.IRAccel, true);
                    switch (index)
                    {
                        case 1: break;//wiimote 1 connected
                        case 2: break;//wiimote 2 connected
                    }
                    wm.SetLEDs(index++);
                }
                catch
                {
                }

            }
            return mWiimoteMap;
        }

        void OnWiiMoteAddExtension(object sender, WiimoteExtensionChangedEventArgs e)
        {

        }

        private void UpdateWiimoteChanged(object sender, WiimoteChangedEventArgs args)
        {
            int currentWiiMote = mWiimoteMap[((Wiimote)sender).ID];
            WiimoteState state = args.WiimoteState;

            if (WiimoteUpdated != null) WiimoteUpdated(this, new WiimoteUpdatedEventArgs(new SignalSample
            {
                Sample = state.AccelState.RawValues,
                Source = currentWiiMote,
                TimeStamp = DateTime.Now
            }
            ));
        }
    }
}
