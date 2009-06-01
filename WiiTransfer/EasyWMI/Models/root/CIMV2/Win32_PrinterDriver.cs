using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PrinterDriver : WMIBase
    {
        
        private string m_Caption;
        
        private string m_ConfigFile;
        
        private string m_CreationClassName;
        
        private string m_DataFile;
        
        private string m_DefaultDataType;
        
        private string [] m_DependentFiles;
        
        private string m_Description;
        
        private string m_DriverPath;
        
        private string m_FilePath;
        
        private string m_HelpFile;
        
        private string m_InfName;
        
        private string m_InstallDate;
        
        private string m_MonitorName;
        
        private string m_Name;
        
        private string m_OEMUrl;
        
        private bool m_Started;
        
        private string m_StartMode;
        
        private string m_Status;
        
        private string m_SupportedPlatform;
        
        private string m_SystemCreationClassName;
        
        private string m_SystemName;
        
        private ushort m_Version;
        
        private string m_MyPath;
        
        public Win32_PrinterDriver()
        {
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
        
        public string ConfigFile
        {
            get
            {
                return this.m_ConfigFile;
            }
            set
            {
                this.m_ConfigFile = value;
            }
        }
        
        public string CreationClassName
        {
            get
            {
                return this.m_CreationClassName;
            }
            set
            {
                this.m_CreationClassName = value;
            }
        }
        
        public string DataFile
        {
            get
            {
                return this.m_DataFile;
            }
            set
            {
                this.m_DataFile = value;
            }
        }
        
        public string DefaultDataType
        {
            get
            {
                return this.m_DefaultDataType;
            }
            set
            {
                this.m_DefaultDataType = value;
            }
        }
        
        public string [] DependentFiles
        {
            get
            {
                return this.m_DependentFiles;
            }
            set
            {
                this.m_DependentFiles = value;
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
        
        public string DriverPath
        {
            get
            {
                return this.m_DriverPath;
            }
            set
            {
                this.m_DriverPath = value;
            }
        }
        
        public string FilePath
        {
            get
            {
                return this.m_FilePath;
            }
            set
            {
                this.m_FilePath = value;
            }
        }
        
        public string HelpFile
        {
            get
            {
                return this.m_HelpFile;
            }
            set
            {
                this.m_HelpFile = value;
            }
        }
        
        public string InfName
        {
            get
            {
                return this.m_InfName;
            }
            set
            {
                this.m_InfName = value;
            }
        }
        
        public string InstallDate
        {
            get
            {
                return this.m_InstallDate;
            }
            set
            {
                this.m_InstallDate = value;
            }
        }
        
        public string MonitorName
        {
            get
            {
                return this.m_MonitorName;
            }
            set
            {
                this.m_MonitorName = value;
            }
        }
        
        public string Name
        {
            get
            {
                return this.m_Name;
            }
            set
            {
                this.m_Name = value;
            }
        }
        
        public string OEMUrl
        {
            get
            {
                return this.m_OEMUrl;
            }
            set
            {
                this.m_OEMUrl = value;
            }
        }
        
        public bool Started
        {
            get
            {
                return this.m_Started;
            }
            set
            {
                this.m_Started = value;
            }
        }
        
        public string StartMode
        {
            get
            {
                return this.m_StartMode;
            }
            set
            {
                this.m_StartMode = value;
            }
        }
        
        public string Status
        {
            get
            {
                return this.m_Status;
            }
            set
            {
                this.m_Status = value;
            }
        }
        
        public string SupportedPlatform
        {
            get
            {
                return this.m_SupportedPlatform;
            }
            set
            {
                this.m_SupportedPlatform = value;
            }
        }
        
        public string SystemCreationClassName
        {
            get
            {
                return this.m_SystemCreationClassName;
            }
            set
            {
                this.m_SystemCreationClassName = value;
            }
        }
        
        public string SystemName
        {
            get
            {
                return this.m_SystemName;
            }
            set
            {
                this.m_SystemName = value;
            }
        }
        
        public ushort Version
        {
            get
            {
                return this.m_Version;
            }
            set
            {
                this.m_Version = value;
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
        
        public Int32 StartService()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "StartService", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 StopService()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "StopService", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 AddPrinterDriver(object DriverInfo)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_PrinterDriver");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("AddPrinterDriver");
InParams["DriverInfo"] = DriverInfo;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "AddPrinterDriver", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
    }
}
