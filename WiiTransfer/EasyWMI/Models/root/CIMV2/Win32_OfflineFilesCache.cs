using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_OfflineFilesCache : WMIBase
    {
        
        private bool m_Active;
        
        private bool m_Enabled;
        
        private string m_Location;
        
        private string m_MyPath;
        
        public Win32_OfflineFilesCache()
        {
        }
        
        public bool Active
        {
            get
            {
                return this.m_Active;
            }
            set
            {
                this.m_Active = value;
            }
        }
        
        public bool Enabled
        {
            get
            {
                return this.m_Enabled;
            }
            set
            {
                this.m_Enabled = value;
            }
        }
        
        public string Location
        {
            get
            {
                return this.m_Location;
            }
            set
            {
                this.m_Location = value;
            }
        }
        
        public string MyPath
        {
            get
            {
                return this.m_MyPath;
            }
            set
            {
                this.m_MyPath = value;
            }
        }
        
        public Int32 Enable(bool Enable, out bool RebootRequired)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_OfflineFilesCache");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("Enable");
InParams["Enable"] = Enable;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Enable", InParams, Options);
RebootRequired = (Boolean)OutParams["RebootRequired"];

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 RenameItem(string NewPath, string OriginalPath, bool ReplaceIfExists)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_OfflineFilesCache");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("RenameItem");
InParams["NewPath"] = NewPath;
InParams["OriginalPath"] = OriginalPath;
InParams["ReplaceIfExists"] = ReplaceIfExists;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "RenameItem", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Synchronize(uint Flags, string [] Paths)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_OfflineFilesCache");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("Synchronize");
InParams["Flags"] = Flags;
InParams["Paths"] = Paths;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Synchronize", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Pin(bool Deep, uint Flags, string [] Paths)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_OfflineFilesCache");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("Pin");
InParams["Deep"] = Deep;
InParams["Flags"] = Flags;
InParams["Paths"] = Paths;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Pin", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Unpin(bool Deep, uint Flags, string [] Paths)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_OfflineFilesCache");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("Unpin");
InParams["Deep"] = Deep;
InParams["Flags"] = Flags;
InParams["Paths"] = Paths;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Unpin", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 DeleteItems(uint Flags, string [] Paths)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_OfflineFilesCache");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("DeleteItems");
InParams["Flags"] = Flags;
InParams["Paths"] = Paths;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "DeleteItems", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Encrypt(bool Encrypt, uint Flags)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_OfflineFilesCache");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("Encrypt");
InParams["Encrypt"] = Encrypt;
InParams["Flags"] = Flags;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Encrypt", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SuspendRoot(string Path, bool Suspend)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_OfflineFilesCache");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SuspendRoot");
InParams["Path"] = Path;
InParams["Suspend"] = Suspend;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SuspendRoot", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 TransitionOffline(uint Flags, bool Force, string Path, out bool OpenFiles)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_OfflineFilesCache");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("TransitionOffline");
InParams["Flags"] = Flags;
InParams["Force"] = Force;
InParams["Path"] = Path;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "TransitionOffline", InParams, Options);
OpenFiles = (Boolean)OutParams["OpenFiles"];

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 TransitionOnline(uint Flags, string Path)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_OfflineFilesCache");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("TransitionOnline");
InParams["Flags"] = Flags;
InParams["Path"] = Path;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "TransitionOnline", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
    }
}
