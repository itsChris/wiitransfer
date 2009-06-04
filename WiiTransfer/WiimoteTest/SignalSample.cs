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
            TimeStamp = DateTime.Now;
            Sample = new Point3 { X = 0, Y = 0, Z = 0 };
            Source = 0;
        }
       
        public DateTime TimeStamp
        {
            get;
            set;
        }

        
        public Point3 Sample
        {
            get;
            set;
        }

        public int Source
        {
            get;
            set;
        }
    }
}
