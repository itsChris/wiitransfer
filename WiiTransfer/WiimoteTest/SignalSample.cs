using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using WiimoteLib;

namespace WiimoteTest
{
    public class SignalSample
    {
        public SignalSample()
        {
        }
       
        public DateTime sampleTimeStamp
        {
            get;
            set;
        }

        
        public Point3 sample
        {
            get;
            set;
        }
    }
}
