using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PnPSignedDriver : WMIBase
    {
        
        private string m_Caption;
        
        private string m_ClassGuid;
        
        private string m_CompatID;
        
        private string m_CreationClassName;
        
        private string m_Description;
        
        private string m_DeviceClass;
        
        private string m_DeviceID;
        
        private string m_DeviceName;
        
        private string m_DevLoader;
        
        private string m_DriverDate;
        
        private string m_DriverName;
        
        private string m_DriverProviderName;
        
        private string m_DriverVersion;
        
        private string m_FriendlyName;
        
        private string m_HardWareID;
        
        private string m_InfName;
        
        private string m_InstallDate;
        
        private bool m_IsSigned;
        
        private string m_Location;
        
        private string m_Manufacturer;
        
        private string m_Name;
        
        private string m_PDO;
        
        private string m_Signer;
        
        private bool m_Started;
        
        private string m_StartMode;
        
        private string m_Status;
        
        private string m_SystemCreationClassName;
        
        private string m_SystemName;
        
        private string m_MyPath;
        
        public Win32_PnPSignedDriver()
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
        
        public string ClassGuid
        {
            get
            {
                return this.m_ClassGuid;
            }
            set
            {
                this.m_ClassGuid = value;
            }
        }
        
        public string CompatID
        {
            get
            {
                return this.m_CompatID;
            }
            set
            {
                this.m_CompatID = value;
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
        
        public string DeviceClass
        {
            get
            {
                return this.m_DeviceClass;
            }
            set
            {
                this.m_DeviceClass = value;
            }
        }
        
        public string DeviceID
        {
            get
            {
                return this.m_DeviceID;
            }
            set
            {
                this.m_DeviceID = value;
            }
        }
        
        public string DeviceName
        {
            get
            {
                return this.m_DeviceName;
            }
            set
            {
                this.m_DeviceName = value;
            }
        }
        
        public string DevLoader
        {
            get
            {
                return this.m_DevLoader;
            }
            set
            {
                this.m_DevLoader = value;
            }
        }
        
        public string DriverDate
        {
            get
            {
                return this.m_DriverDate;
            }
            set
            {
                this.m_DriverDate = value;
            }
        }
        
        public string DriverName
        {
            get
            {
                return this.m_DriverName;
            }
            set
            {
                this.m_DriverName = value;
            }
        }
        
        public string DriverProviderName
        {
            get
            {
                return this.m_DriverProviderName;
            }
            set
            {
                this.m_DriverProviderName = value;
            }
        }
        
        public string DriverVersion
        {
            get
            {
                return this.m_DriverVersion;
            }
            set
            {
                this.m_DriverVersion = value;
            }
        }
        
        public string FriendlyName
        {
            get
            {
                return this.m_FriendlyName;
            }
            set
            {
                this.m_FriendlyName = value;
            }
        }
        
        public string HardWareID
        {
            get
            {
                return this.m_HardWareID;
            }
            set
            {
                this.m_HardWareID = value;
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
        
        public bool IsSigned
        {
            get
            {
                return this.m_IsSigned;
            }
            set
            {
                this.m_IsSigned = value;
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
        
        public string Manufacturer
        {
            get
            {
                return this.m_Manufacturer;
            }
            set
            {
                this.m_Manufacturer = value;
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
        
        public string PDO
        {
            get
            {
                return this.m_PDO;
            }
            set
            {
                this.m_PDO = value;
            }
        }
        
        public string Signer
        {
            get
            {
                return this.m_Signer;
            }
            set
            {
                this.m_Signer = value;
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
    }
}
