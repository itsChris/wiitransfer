using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using WiimoteLib;

namespace WiimoteTest
{

    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface IWiiTransfer
    {
        [OperationContract]
        void SendWiimoteData(List<SignalSample> wiidata);

    }
}
