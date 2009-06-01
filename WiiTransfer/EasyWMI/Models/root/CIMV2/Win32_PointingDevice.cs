using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PointingDevice : WMIBase
    {
        
        private ushort m_Availability;
        
        private string m_Caption;
        
        private uint m_ConfigManagerErrorCode;
        
        private bool m_ConfigManagerUserConfig;
        
        private string m_CreationClassName;
        
        private string m_Description;
        
        private string m_DeviceID;
        
        private ushort m_DeviceInterface;
        
        private uint m_DoubleSpeedThreshold;
        
        private bool m_ErrorCleared;
        
        private string m_ErrorDescription;
        
        private ushort m_Handedness;
        
        private string m_HardwareType;
        
        private string m_InfFileName;
        
        private string m_InfSection;
        
        private string m_InstallDate;
        
        private bool m_IsLocked;
        
        private uint m_LastErrorCode;
        
        private string m_Manufacturer;
        
        private string m_Name;
        
        private ushort m_NumberOfButtons;
        
        private string m_PNPDeviceID;
        
        private ushort m_PointingType;
        
        private ushort [] m_PowerManagementCapabilities;
        
        private bool m_PowerManagementSupported;
        
        private uint m_QuadSpeedThreshold;
        
        private uint m_Resolution;
        
        private uint m_SampleRate;
        
        private string m_Status;
        
        private ushort m_StatusInfo;
        
        private uint m_Synch;
        
        private string m_SystemCreationClassName;
        
        private string m_SystemName;
        
        private string m_MyPath;
        
        public Win32_PointingDevice()
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
        
        public ushort DeviceInterface
        {
            get
            {
                return this.m_DeviceInterface;
            }
            set
            {
                this.m_DeviceInterface = value;
            }
        }
        
        public uint DoubleSpeedThreshold
        {
            get
            {
                return this.m_DoubleSpeedThreshold;
            }
            set
            {
                this.m_DoubleSpeedThreshold = value;
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
        
        public ushort Handedness
        {
            get
            {
                return this.m_Handedness;
            }
            set
            {
                this.m_Handedness = value;
            }
        }
        
        public string HardwareType
        {
            get
            {
                return this.m_HardwareType;
            }
            set
            {
                this.m_HardwareType = value;
            }
        }
        
        public string InfFileName
        {
            get
            {
                return this.m_InfFileName;
            }
            set
            {
                this.m_InfFileName = value;
            }
        }
        
        public string InfSection
        {
            get
            {
                return this.m_InfSection;
            }
            set
            {
                this.m_InfSection = value;
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
        
        public bool IsLocked
        {
            get
            {
                return this.m_IsLocked;
            }
            set
            {
                this.m_IsLocked = value;
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
        
        public ushort NumberOfButtons
        {
            get
            {
                return this.m_NumberOfButtons;
            }
            set
            {
                this.m_NumberOfButtons = value;
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
        
        public ushort PointingType
        {
            get
            {
                return this.m_PointingType;
            }
            set
            {
                this.m_PointingType = value;
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
        
        public uint QuadSpeedThreshold
        {
            get
            {
                return this.m_QuadSpeedThreshold;
            }
            set
            {
                this.m_QuadSpeedThreshold = value;
            }
        }
        
        public uint Resolution
        {
            get
            {
                return this.m_Resolution;
            }
            set
            {
                this.m_Resolution = value;
            }
        }
        
        public uint SampleRate
        {
            get
            {
                return this.m_SampleRate;
            }
            set
            {
                this.m_SampleRate = value;
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
        
        public uint Synch
        {
            get
            {
                return this.m_Synch;
            }
            set
            {
                this.m_Synch = value;
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
        
        public Int32 SetPowerState(ushort PowerState, string Time)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_PointingDevice");
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
