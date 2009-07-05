using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WiimoteTest.Service
{
    // NOTE: If you change the class name "WiiService" here, you must also update the reference to "WiiService" in App.config.
    public class WiiService : IWiiService
    {
        public void SendWiimoteData(List<SignalSample> wiidata)
        {
            App.window.ReceiveSampleList(wiidata);
        }

        public DateTime GetServerTime()
        {
            return DateTime.Now - TimeSpan.FromMilliseconds(-20);
        }
    }
}
