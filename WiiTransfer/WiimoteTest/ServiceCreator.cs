using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Configuration;

namespace WiimoteTest
{
    class ServiceCreator
    {
        static Uri baseAddress = new Uri("http://localhost:8000/Service");

        public ServiceCreator()
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerAsync();
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
             ServiceHost selfHost = new ServiceHost(typeof(WiiTransfer), baseAddress);

            try
            {
             
                selfHost.AddServiceEndpoint(typeof(IWiiTransfer), 
                                            new WSHttpBinding() { MaxReceivedMessageSize=2147483647, MaxBufferPoolSize=2147483647}, 
                                            "WiiService");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                selfHost.Open();

            }

            catch (CommunicationException)
            {
                selfHost.Abort();
            }
        }
    }
}
