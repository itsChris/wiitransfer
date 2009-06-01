using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_TemperatureProbe : WMIBase
    {
        
        private int m_Accuracy;
        
        private ushort m_Availability;
        
        private string m_Caption;
        
        private uint m_ConfigManagerErrorCode;
        
        private bool m_ConfigManagerUserConfig;
        
        private string m_CreationClassName;
        
        private int m_CurrentReading;
        
        private string m_Description;
        
        private string m_DeviceID;
        
        private bool m_ErrorCleared;
        
        private string m_ErrorDescription;
        
        private string m_InstallDate;
        
        private bool m_IsLinear;
        
        private uint m_LastErrorCode;
        
        private int m_LowerThresholdCritical;
        
        private int m_LowerThresholdFatal;
        
        private int m_LowerThresholdNonCritical;
        
        private int m_MaxReadable;
        
        private int m_MinReadable;
        
        private string m_Name;
        
        private int m_NominalReading;
        
        private int m_NormalMax;
        
        private int m_NormalMin;
        
        private string m_PNPDeviceID;
        
        private ushort [] m_PowerManagementCapabilities;
        
        private bool m_PowerManagementSupported;
        
        private uint m_Resolution;
        
        private string m_Status;
        
        private ushort m_StatusInfo;
        
        private string m_SystemCreationClassName;
        
        private string m_SystemName;
        
        private int m_Tolerance;
        
        private int m_UpperThresholdCritical;
        
        private int m_UpperThresholdFatal;
        
        private int m_UpperThresholdNonCritical;
        
        private string m_MyPath;
        
        public Win32_TemperatureProbe()
        {
        }
        
        public int Accuracy
        {
            get
            {
                return this.m_Accuracy;
            }
            set
            {
                this.m_Accuracy = value;
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
        
        public int CurrentReading
        {
            get
            {
                return this.m_CurrentReading;
            }
            set
            {
                this.m_CurrentReading = value;
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
        
        public bool IsLinear
        {
            get
            {
                return this.m_IsLinear;
            }
            set
            {
                this.m_IsLinear = value;
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
        
        public int LowerThresholdCritical
        {
            get
            {
                return this.m_LowerThresholdCritical;
            }
            set
            {
                this.m_LowerThresholdCritical = value;
            }
        }
        
        public int LowerThresholdFatal
        {
            get
            {
                return this.m_LowerThresholdFatal;
            }
            set
            {
                this.m_LowerThresholdFatal = value;
            }
        }
        
        public int LowerThresholdNonCritical
        {
            get
            {
                return this.m_LowerThresholdNonCritical;
            }
            set
            {
                this.m_LowerThresholdNonCritical = value;
            }
        }
        
        public int MaxReadable
        {
            get
            {
                return this.m_MaxReadable;
            }
            set
            {
                this.m_MaxReadable = value;
            }
        }
        
        public int MinReadable
        {
            get
            {
                return this.m_MinReadable;
            }
            set
            {
                this.m_MinReadable = value;
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
        
        public int NominalReading
        {
            get
            {
                return this.m_NominalReading;
            }
            set
            {
                this.m_NominalReading = value;
            }
        }
        
        public int NormalMax
        {
            get
            {
                return this.m_NormalMax;
            }
            set
            {
                this.m_NormalMax = value;
            }
        }
        
        public int NormalMin
        {
            get
            {
                return this.m_NormalMin;
            }
            set
            {
                this.m_NormalMin = value;
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
        
        public int Tolerance
        {
            get
            {
                return this.m_Tolerance;
            }
            set
            {
                this.m_Tolerance = value;
            }
        }
        
        public int UpperThresholdCritical
        {
            get
            {
                return this.m_UpperThresholdCritical;
            }
            set
            {
                this.m_UpperThresholdCritical = value;
            }
        }
        
        public int UpperThresholdFatal
        {
            get
            {
                return this.m_UpperThresholdFatal;
            }
            set
            {
                this.m_UpperThresholdFatal = value;
            }
        }
        
        public int UpperThresholdNonCritical
        {
            get
            {
                return this.m_UpperThresholdNonCritical;
            }
            set
            {
                this.m_UpperThresholdNonCritical = value;
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
            ManagementClass WMIClass = new ManagementClass("Win32_TemperatureProbe");
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
