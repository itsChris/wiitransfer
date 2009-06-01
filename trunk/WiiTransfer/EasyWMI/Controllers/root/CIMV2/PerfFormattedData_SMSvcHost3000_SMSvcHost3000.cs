using System;
using System.Management;
using EasyWMI.Interfaces;
using EasyWMI.Models.root.CIMV2;
using EasyWMI.Controllers;
using System.Reflection;
using System.Diagnostics;
namespace EasyWMI.Controllers.root.CIMV2
{
    
    
    public class PerfFormattedData_SMSvcHost3000_SMSvcHost3000 : WMIBase, IWMIObject<Win32_PerfFormattedData_SMSvcHost3000_SMSvcHost3000>
    {
        
        public PerfFormattedData_SMSvcHost3000_SMSvcHost3000() : 
                base()
        {
        }
        
        public PerfFormattedData_SMSvcHost3000_SMSvcHost3000(string ComputerName) : 
                base(ComputerName)
        {
        }
        
        public PerfFormattedData_SMSvcHost3000_SMSvcHost3000(System.Net.IPAddress IPAddress) : 
                base(IPAddress)
        {
        }
        
        public PerfFormattedData_SMSvcHost3000_SMSvcHost3000(string Username, string Password, string ComputerName) : 
                base(Username, Password, ComputerName)
        {
        }
        
        public PerfFormattedData_SMSvcHost3000_SMSvcHost3000(string Username, string Password, System.Net.IPAddress IPAddress) : 
                base(Username, Password, IPAddress)
        {
        }
        
        public System.Collections.Generic.IList<Win32_PerfFormattedData_SMSvcHost3000_SMSvcHost3000> SelectAll()
        {
            ManagementObjectCollection oReturnCollection = null;
            System.Collections.Generic.IList<Win32_PerfFormattedData_SMSvcHost3000_SMSvcHost3000> List = new System.Collections.Generic.List<Win32_PerfFormattedData_SMSvcHost3000_SMSvcHost3000>();
            try
            {
                oReturnCollection = GetObjectCollection("Win32_PerfFormattedData_SMSvcHost3000_SMSvcHost3000");
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
                Win32_PerfFormattedData_SMSvcHost3000_SMSvcHost3000 WMIObject = new Win32_PerfFormattedData_SMSvcHost3000_SMSvcHost3000();
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
                            p = typeof(Win32_PerfFormattedData_SMSvcHost3000_SMSvcHost3000).GetProperty(pi.Name);
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
PropertyInfo ppath = typeof(Win32_PerfFormattedData_SMSvcHost3000_SMSvcHost3000).GetProperty("MyPath");
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
