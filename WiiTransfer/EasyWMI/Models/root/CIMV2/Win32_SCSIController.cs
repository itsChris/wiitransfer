using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_SCSIController : WMIBase
    {
        
        private ushort m_Availability;
        
        private string m_Caption;
        
        private uint m_ConfigManagerErrorCode;
        
        private bool m_ConfigManagerUserConfig;
        
        private uint m_ControllerTimeouts;
        
        private string m_CreationClassName;
        
        private string m_Description;
        
        private string m_DeviceID;
        
        private string m_DeviceMap;
        
        private string m_DriverName;
        
        private bool m_ErrorCleared;
        
        private string m_ErrorDescription;
        
        private string m_HardwareVersion;
        
        private uint m_Index;
        
        private string m_InstallDate;
        
        private uint m_LastErrorCode;
        
        private string m_Manufacturer;
        
        private uint m_MaxDataWidth;
        
        private uint m_MaxNumberControlled;
        
        private ulong m_MaxTransferRate;
        
        private string m_Name;
        
        private string m_PNPDeviceID;
        
        private ushort [] m_PowerManagementCapabilities;
        
        private bool m_PowerManagementSupported;
        
        private ushort m_ProtectionManagement;
        
        private ushort m_ProtocolSupported;
        
        private string m_Status;
        
        private ushort m_StatusInfo;
        
        private string m_SystemCreationClassName;
        
        private string m_SystemName;
        
        private string m_TimeOfLastReset;
        
        private string m_MyPath;
        
        public Win32_SCSIController()
        {
        }
        
        public ushort Availability
        {
            get
            {
                return this.m_Availability;
            }
            set
            {
                this.m_Availability = value;
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
        
        public uint ConfigManagerErrorCode
        {
            get
            {
                return this.m_ConfigManagerErrorCode;
            }
            set
            {
                this.m_ConfigManagerErrorCode = value;
            }
        }
        
        public bool ConfigManagerUserConfig
        {
            get
            {
                return this.m_ConfigManagerUserConfig;
            }
            set
            {
                this.m_ConfigManagerUserConfig = value;
            }
        }
        
        public uint ControllerTimeouts
        {
            get
            {
                return this.m_ControllerTimeouts;
            }
            set
            {
                this.m_ControllerTimeouts = value;
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
        
        public string DeviceMap
        {
            get
            {
                return this.m_DeviceMap;
            }
            set
            {
                this.m_DeviceMap = value;
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
        
        public bool ErrorCleared
        {
            get
            {
                return this.m_ErrorCleared;
            }
            set
            {
                this.m_ErrorCleared = value;
            }
        }
        
        public string ErrorDescription
        {
            get
            {
                return this.m_ErrorDescription;
            }
            set
            {
                this.m_ErrorDescription = value;
            }
        }
        
        public string HardwareVersion
        {
            get
            {
                return this.m_HardwareVersion;
            }
            set
            {
                this.m_HardwareVersion = value;
            }
        }
        
        public uint Index
        {
            get
            {
                return this.m_Index;
            }
            set
            {
                this.m_Index = value;
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
        
        public uint LastErrorCode
        {
            get
            {
                return this.m_LastErrorCode;
            }
            set
            {
                this.m_LastErrorCode = value;
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
        
        public uint MaxDataWidth
        {
            get
            {
                return this.m_MaxDataWidth;
            }
            set
            {
                this.m_MaxDataWidth = value;
            }
        }
        
        public uint MaxNumberControlled
        {
            get
            {
                return this.m_MaxNumberControlled;
            }
            set
            {
                this.m_MaxNumberControlled = value;
            }
        }
        
        public ulong MaxTransferRate
        {
            get
            {
                return this.m_MaxTransferRate;
            }
            set
            {
                this.m_MaxTransferRate = value;
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
        
        public string PNPDeviceID
        {
            get
            {
                return this.m_PNPDeviceID;
            }
            set
            {
                this.m_PNPDeviceID = value;
            }
        }
        
        public ushort [] PowerManagementCapabilities
        {
            get
            {
                return this.m_PowerManagementCapabilities;
            }
            set
            {
                this.m_PowerManagementCapabilities = value;
            }
        }
        
        public bool PowerManagementSupported
        {
            get
            {
                return this.m_PowerManagementSupported;
            }
            set
            {
                this.m_PowerManagementSupported = value;
            }
        }
        
        public ushort ProtectionManagement
        {
            get
            {
                return this.m_ProtectionManagement;
            }
            set
            {
                this.m_ProtectionManagement = value;
            }
        }
        
        public ushort ProtocolSupported
        {
            get
            {
                return this.m_ProtocolSupported;
            }
            set
            {
                this.m_ProtocolSupported = value;
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
        
        public ushort StatusInfo
        {
            get
            {
                return this.m_StatusInfo;
            }
            set
            {
                this.m_StatusInfo = value;
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
        
        public string TimeOfLastReset
        {
            get
            {
                return this.m_TimeOfLastReset;
            }
            set
            {
                this.m_TimeOfLastReset = value;
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
        
        public Int32 SetPowerState(ushort PowerState, string Time)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_SCSIController");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetPowerState");
InParams["PowerState"] = PowerState;
InParams["Time"] = Time;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetPowerState", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Reset()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Reset", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
    }
}
