using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WiimoteLib;

namespace WiimoteTest
{
    class WiiTransfer:IWiiTransfer
    {
        public void SendWiimoteData(Point3 wiidata)
        {
            Window1.wiimote3.Add(wiidata);
        }
    }
}
