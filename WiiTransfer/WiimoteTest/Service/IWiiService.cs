using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WiimoteTest.Service
{
    [ServiceContract]
    public interface IWiiService
    {
        [OperationContract]
        void SendWiimoteData(List<SignalSample> wiidata);

        [OperationContract]
        DateTime GetServerTime();
    }
}
