using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_DCOMApplicationSetting : WMIBase
    {
        
        private string m_AppID;
        
        private uint m_AuthenticationLevel;
        
        private string m_Caption;
        
        private string m_CustomSurrogate;
        
        private string m_Description;
        
        private bool m_EnableAtStorageActivation;
        
        private string m_LocalService;
        
        private string m_RemoteServerName;
        
        private string m_RunAsUser;
        
        private string m_ServiceParameters;
        
        private string m_SettingID;
        
        private bool m_UseSurrogate;
        
        private string m_MyPath;
        
        public Win32_DCOMApplicationSetting()
        {
        }
        
        public string AppID
        {
            get
            {
                return this.m_AppID;
            }
            set
            {
                this.m_AppID = value;
            }
        }
        
        public uint AuthenticationLevel
        {
            get
            {
                return this.m_AuthenticationLevel;
            }
            set
            {
                this.m_AuthenticationLevel = value;
            }
        }
        
        public string Caption
        {
            get
            {
                return this.m_Caption;
            }
            set
            {
                this.m_Caption = value;
            }
        }
        
        public string CustomSurrogate
        {
            get
            {
                return this.m_CustomSurrogate;
            }
            set
            {
                this.m_CustomSurrogate = value;
            }
        }
        
        public string Description
        {
            get
            {
                return this.m_Description;
            }
            set
            {
                this.m_Description = value;
            }
        }
        
        public bool EnableAtStorageActivation
        {
            get
            {
                return this.m_EnableAtStorageActivation;
            }
            set
            {
                this.m_EnableAtStorageActivation = value;
            }
        }
        
        public string LocalService
        {
            get
            {
                return this.m_LocalService;
            }
            set
            {
                this.m_LocalService = value;
            }
        }
        
        public string RemoteServerName
        {
            get
            {
                return this.m_RemoteServerName;
            }
            set
            {
                this.m_RemoteServerName = value;
            }
        }
        
        public string RunAsUser
        {
            get
            {
                return this.m_RunAsUser;
            }
            set
            {
                this.m_RunAsUser = value;
            }
        }
        
        public string ServiceParameters
        {
            get
            {
                return this.m_ServiceParameters;
            }
            set
            {
                this.m_ServiceParameters = value;
            }
        }
        
        public string SettingID
        {
            get
            {
                return this.m_SettingID;
            }
            set
            {
                this.m_SettingID = value;
            }
        }
        
        public bool UseSurrogate
        {
            get
            {
                return this.m_UseSurrogate;
            }
            set
            {
                this.m_UseSurrogate = value;
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
        
        public Int32 GetLaunchSecurityDescriptor(out object Descriptor)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "GetLaunchSecurityDescriptor", InParams, Options);
Descriptor = (Object)OutParams["Descriptor"];

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetLaunchSecurityDescriptor(object Descriptor)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_DCOMApplicationSetting");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetLaunchSecurityDescriptor");
InParams["Descriptor"] = Descriptor;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetLaunchSecurityDescriptor", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 GetAccessSecurityDescriptor(out object Descriptor)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "GetAccessSecurityDescriptor", InParams, Options);
Descriptor = (Object)OutParams["Descriptor"];

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetAccessSecurityDescriptor(object Descriptor)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_DCOMApplicationSetting");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetAccessSecurityDescriptor");
InParams["Descriptor"] = Descriptor;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetAccessSecurityDescriptor", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 GetConfigurationSecurityDescriptor(out object Descriptor)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "GetConfigurationSecurityDescriptor", InParams, Options);
Descriptor = (Object)OutParams["Descriptor"];

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetConfigurationSecurityDescriptor(object Descriptor)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_DCOMApplicationSetting");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetConfigurationSecurityDescriptor");
InParams["Descriptor"] = Descriptor;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetConfigurationSecurityDescriptor", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
    }
}
