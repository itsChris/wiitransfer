using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Configuration;
using WiimoteTest.Service;

namespace WiimoteTest
{
    class ServiceCreator
    {
        static Uri baseAddress = new Uri("http://192.168.1.105:8000/Service");

        public ServiceCreator()
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerAsync();
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            ServiceHost selfHost = new ServiceHost(typeof(WiiService));

            try
            {
             
                //selfHost.AddServiceEndpoint(typeof(IWiiTransfer), 
                //                            new WSHttpBinding() { MaxReceivedMessageSize=2147483647, MaxBufferPoolSize=2147483647}, 
                //                           "WiiService");

                //selfHost.Authorization.PrincipalPermissionMode = PrincipalPermissionMode.None;
                //ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                //smb.HttpGetEnabled = true;
                //selfHost.Description.Behaviors.Add(smb);

                selfHost.Open();

            }

            catch (CommunicationException)
            {
                selfHost.Abort();
            }
        }
    }
}
