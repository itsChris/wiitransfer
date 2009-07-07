using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Security.Cryptography;

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

        public bool CheckWiimoteDataHash(byte[] data)
        {
            byte[] localdata = Encoding.ASCII.GetBytes(App.window.KeyCode.Substring(0,10));
            byte[] localhash = new MD5CryptoServiceProvider().ComputeHash(localdata);
            App.window.LastAcceptedPassword = App.window.KeyCode.Substring(0, 10);
            App.window.ClearCount();

            if(CompareHashes(localhash,data))
            {
                //new WifiManager().ConnectToSecure("hello", App.window.LastAcceptedPassword);
            }
            return CompareHashes(localhash, data);
            
        }

        private bool CompareHashes(byte[] hash1, byte[] hash2)
        {
            bool isEqual = false;
            if (hash1.Length == hash2.Length)
            {
                int i = 0;
                while ((i < hash1.Length) && (hash1[i] == hash2[i]))
                {
                    i += 1;
                }
                if (i == hash1.Length)
                {
                    isEqual = true;
                }
            }

            
            return
                isEqual;


        }
    }
}
