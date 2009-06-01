using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PortableBattery : WMIBase
    {
        
        private ushort m_Availability;
        
        private ushort m_BatteryStatus;
        
        private ushort m_CapacityMultiplier;
        
        private string m_Caption;
        
        private ushort m_Chemistry;
        
        private uint m_ConfigManagerErrorCode;
        
        private bool m_ConfigManagerUserConfig;
        
        private string m_CreationClassName;
        
        private string m_Description;
        
        private uint m_DesignCapacity;
        
        private ulong m_DesignVoltage;
        
        private string m_DeviceID;
        
        private bool m_ErrorCleared;
        
        private string m_ErrorDescription;
        
        private ushort m_EstimatedChargeRemaining;
        
        private uint m_EstimatedRunTime;
        
        private uint m_ExpectedLife;
        
        private uint m_FullChargeCapacity;
        
        private string m_InstallDate;
        
        private uint m_LastErrorCode;
        
        private string m_Location;
        
        private string m_ManufactureDate;
        
        private string m_Manufacturer;
        
        private ushort m_MaxBatteryError;
        
        private uint m_MaxRechargeTime;
        
        private string m_Name;
        
        private string m_PNPDeviceID;
        
        private ushort [] m_PowerManagementCapabilities;
        
        private bool m_PowerManagementSupported;
        
        private string m_SmartBatteryVersion;
        
        private string m_Status;
        
        private ushort m_StatusInfo;
        
        private string m_SystemCreationClassName;
        
        private string m_SystemName;
        
        private uint m_TimeOnBattery;
        
        private uint m_TimeToFullCharge;
        
        private string m_MyPath;
        
        public Win32_PortableBattery()
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
        
        public ushort BatteryStatus
        {
            get
            {
                return this.m_BatteryStatus;
            }
            set
            {
                this.m_BatteryStatus = value;
            }
        }
        
        public ushort CapacityMultiplier
        {
            get
            {
                return this.m_CapacityMultiplier;
            }
            set
            {
                this.m_CapacityMultiplier = value;
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
        
        public ushort Chemistry
        {
            get
            {
                return this.m_Chemistry;
            }
            set
            {
                this.m_Chemistry = value;
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
        
        public uint DesignCapacity
        {
            get
            {
                return this.m_DesignCapacity;
            }
            set
            {
                this.m_DesignCapacity = value;
            }
        }
        
        public ulong DesignVoltage
        {
            get
            {
                return this.m_DesignVoltage;
            }
            set
            {
                this.m_DesignVoltage = value;
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
        
        public ushort EstimatedChargeRemaining
        {
            get
            {
                return this.m_EstimatedChargeRemaining;
            }
            set
            {
                this.m_EstimatedChargeRemaining = value;
            }
        }
        
        public uint EstimatedRunTime
        {
            get
            {
                return this.m_EstimatedRunTime;
            }
            set
            {
                this.m_EstimatedRunTime = value;
            }
        }
        
        public uint ExpectedLife
        {
            get
            {
                return this.m_ExpectedLife;
            }
            set
            {
                this.m_ExpectedLife = value;
            }
        }
        
        public uint FullChargeCapacity
        {
            get
            {
                return this.m_FullChargeCapacity;
            }
            set
            {
                this.m_FullChargeCapacity = value;
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
        
        public string ManufactureDate
        {
            get
            {
                return this.m_ManufactureDate;
            }
            set
            {
                this.m_ManufactureDate = value;
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
        
        public ushort MaxBatteryError
        {
            get
            {
                return this.m_MaxBatteryError;
            }
            set
            {
                this.m_MaxBatteryError = value;
            }
        }
        
        public uint MaxRechargeTime
        {
            get
            {
                return this.m_MaxRechargeTime;
            }
            set
            {
                this.m_MaxRechargeTime = value;
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
        
        public string SmartBatteryVersion
        {
            get
            {
                return this.m_SmartBatteryVersion;
            }
            set
            {
                this.m_SmartBatteryVersion = value;
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
        
        public uint TimeOnBattery
        {
            get
            {
                return this.m_TimeOnBattery;
            }
            set
            {
                this.m_TimeOnBattery = value;
            }
        }
        
        public uint TimeToFullCharge
        {
            get
            {
                return this.m_TimeToFullCharge;
            }
            set
            {
                this.m_TimeToFullCharge = value;
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
            ManagementClass WMIClass = new ManagementClass("Win32_PortableBattery");
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
