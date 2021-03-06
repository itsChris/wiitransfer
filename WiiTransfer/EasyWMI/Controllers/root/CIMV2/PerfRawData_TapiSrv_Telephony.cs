using System;
using System.Management;
using EasyWMI.Interfaces;
using EasyWMI.Models.root.CIMV2;
using EasyWMI.Controllers;
using System.Reflection;
using System.Diagnostics;
namespace EasyWMI.Controllers.root.CIMV2
{
    
    
    public class PerfRawData_TapiSrv_Telephony : WMIBase, IWMIObject<Win32_PerfRawData_TapiSrv_Telephony>
    {
        
        public PerfRawData_TapiSrv_Telephony() : 
                base()
        {
        }
        
        public PerfRawData_TapiSrv_Telephony(string ComputerName) : 
                base(ComputerName)
        {
        }
        
        public PerfRawData_TapiSrv_Telephony(System.Net.IPAddress IPAddress) : 
                base(IPAddress)
        {
        }
        
        public PerfRawData_TapiSrv_Telephony(string Username, string Password, string ComputerName) : 
                base(Username, Password, ComputerName)
        {
        }
        
        public PerfRawData_TapiSrv_Telephony(string Username, string Password, System.Net.IPAddress IPAddress) : 
                base(Username, Password, IPAddress)
        {
        }
        
        public System.Collections.Generic.IList<Win32_PerfRawData_TapiSrv_Telephony> SelectAll()
        {
            ManagementObjectCollection oReturnCollection = null;
            System.Collections.Generic.IList<Win32_PerfRawData_TapiSrv_Telephony> List = new System.Collections.Generic.List<Win32_PerfRawData_TapiSrv_Telephony>();
            try
            {
                oReturnCollection = GetObjectCollection("Win32_PerfRawData_TapiSrv_Telephony");
            }
            catch (System.Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            int x = 0;
            ManagementObjectCollection.ManagementObjectEnumerator CollectionEnumerator = oReturnCollection.GetEnumerator();
            int i = 0;
            for (i = 0; (i < oReturnCollection.Count); i = (i + 1))
            {
                Win32_PerfRawData_TapiSrv_Telephony WMIObject = new Win32_PerfRawData_TapiSrv_Telephony();
CollectionEnumerator.MoveNext();
ManagementObject newWMIObject = (ManagementObject)CollectionEnumerator.Current;
PropertyDataCollection t = newWMIObject.Properties;
                if (t != null)
                {
PropertyDataCollection.PropertyDataEnumerator PropertyCollectionEnumerator = t.GetEnumerator();
                    for (x = 0; (x < t.Count); x = (x + 1))
                    {
PropertyInfo p = null;
PropertyData pi = null;
                        try
                        {
                            PropertyCollectionEnumerator.MoveNext();
                            pi = (PropertyData)PropertyCollectionEnumerator.Current;
                            p = typeof(Win32_PerfRawData_TapiSrv_Telephony).GetProperty(pi.Name);
                        }
                        catch (System.Exception ex)
                        {
                            Debug.WriteLine(ex.Message);
                        }
                        try
                        {
                            if (p != null && pi.Value != null)
                            {
p.SetValue(WMIObject, pi.Value, null);
PropertyInfo ppath = typeof(Win32_PerfRawData_TapiSrv_Telephony).GetProperty("MyPath");
ppath.SetValue(WMIObject, newWMIObject.Path.ToString(), null);
                            }
                        }
                        catch (System.Exception ex)
                        {
Debug.WriteLine(ex.Message);
                        }
                    }
                }
List.Add(WMIObject);
            }
            return List;
        }
    }
}
