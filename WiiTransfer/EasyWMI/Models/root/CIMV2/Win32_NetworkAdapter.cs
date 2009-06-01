using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_NetworkAdapter : WMIBase
    {
        
        private string m_AdapterType;
        
        private ushort m_AdapterTypeId;
        
        private bool m_AutoSense;
        
        private ushort m_Availability;
        
        private string m_Caption;
        
        private uint m_ConfigManagerErrorCode;
        
        private bool m_ConfigManagerUserConfig;
        
        private string m_CreationClassName;
        
        private string m_Description;
        
        private string m_DeviceID;
        
        private bool m_ErrorCleared;
        
        private string m_ErrorDescription;
        
        private string m_GUID;
        
        private uint m_Index;
        
        private string m_InstallDate;
        
        private bool m_Installed;
        
        private uint m_InterfaceIndex;
        
        private uint m_LastErrorCode;
        
        private string m_MACAddress;
        
        private string m_Manufacturer;
        
        private uint m_MaxNumberControlled;
        
        private ulong m_MaxSpeed;
        
        private string m_Name;
        
        private string m_NetConnectionID;
        
        private ushort m_NetConnectionStatus;
        
        private bool m_NetEnabled;
        
        private string [] m_NetworkAddresses;
        
        private string m_PermanentAddress;
        
        private bool m_PhysicalAdapter;
        
        private string m_PNPDeviceID;
        
        private ushort [] m_PowerManagementCapabilities;
        
        private bool m_PowerManagementSupported;
        
        private string m_ProductName;
        
        private string m_ServiceName;
        
        private ulong m_Speed;
        
        private string m_Status;
        
        private ushort m_StatusInfo;
        
        private string m_SystemCreationClassName;
        
        private string m_SystemName;
        
        private string m_TimeOfLastReset;
        
        private string m_MyPath;
        
        public Win32_NetworkAdapter()
        {
        }
        
        public string AdapterType
        {
            get
            {
                return this.m_AdapterType;
            }
            set
            {
                this.m_AdapterType = value;
            }
        }
        
        public ushort AdapterTypeId
        {
            get
            {
                return this.m_AdapterTypeId;
            }
            set
            {
                this.m_AdapterTypeId = value;
            }
        }
        
        public bool AutoSense
        {
            get
            {
                return this.m_AutoSense;
            }
            set
            {
                this.m_AutoSense = value;
            }
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
        
        public string GUID
        {
            get
            {
                return this.m_GUID;
            }
            set
            {
                this.m_GUID = value;
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
        
        public bool Installed
        {
            get
            {
                return this.m_Installed;
            }
            set
            {
                this.m_Installed = value;
            }
        }
        
        public uint InterfaceIndex
        {
            get
            {
                return this.m_InterfaceIndex;
            }
            set
            {
                this.m_InterfaceIndex = value;
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
        
        public string MACAddress
        {
            get
            {
                return this.m_MACAddress;
            }
            set
            {
                this.m_MACAddress = value;
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
        
        public ulong MaxSpeed
        {
            get
            {
                return this.m_MaxSpeed;
            }
            set
            {
                this.m_MaxSpeed = value;
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
        
        public string NetConnectionID
        {
            get
            {
                return this.m_NetConnectionID;
            }
            set
            {
                this.m_NetConnectionID = value;
            }
        }
        
        public ushort NetConnectionStatus
        {
            get
            {
                return this.m_NetConnectionStatus;
            }
            set
            {
                this.m_NetConnectionStatus = value;
            }
        }
        
        public bool NetEnabled
        {
            get
            {
                return this.m_NetEnabled;
            }
            set
            {
                this.m_NetEnabled = value;
            }
        }
        
        public string [] NetworkAddresses
        {
            get
            {
                return this.m_NetworkAddresses;
            }
            set
            {
                this.m_NetworkAddresses = value;
            }
        }
        
        public string PermanentAddress
        {
            get
            {
                return this.m_PermanentAddress;
            }
            set
            {
                this.m_PermanentAddress = value;
            }
        }
        
        public bool PhysicalAdapter
        {
            get
            {
                return this.m_PhysicalAdapter;
            }
            set
            {
                this.m_PhysicalAdapter = value;
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
        
        public string ProductName
        {
            get
            {
                return this.m_ProductName;
            }
            set
            {
                this.m_ProductName = value;
            }
        }
        
        public string ServiceName
        {
            get
            {
                return this.m_ServiceName;
            }
            set
            {
                this.m_ServiceName = value;
            }
        }
        
        public ulong Speed
        {
            get
            {
                return this.m_Speed;
            }
            set
            {
                this.m_Speed = value;
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
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapter");
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
        
        public Int32 Enable()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Enable", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Disable()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Disable", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
    }
}
