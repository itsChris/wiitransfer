using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_SerialPort : WMIBase
    {
        
        private ushort m_Availability;
        
        private bool m_Binary;
        
        private ushort [] m_Capabilities;
        
        private string [] m_CapabilityDescriptions;
        
        private string m_Caption;
        
        private uint m_ConfigManagerErrorCode;
        
        private bool m_ConfigManagerUserConfig;
        
        private string m_CreationClassName;
        
        private string m_Description;
        
        private string m_DeviceID;
        
        private bool m_ErrorCleared;
        
        private string m_ErrorDescription;
        
        private string m_InstallDate;
        
        private uint m_LastErrorCode;
        
        private uint m_MaxBaudRate;
        
        private uint m_MaximumInputBufferSize;
        
        private uint m_MaximumOutputBufferSize;
        
        private uint m_MaxNumberControlled;
        
        private string m_Name;
        
        private bool m_OSAutoDiscovered;
        
        private string m_PNPDeviceID;
        
        private ushort [] m_PowerManagementCapabilities;
        
        private bool m_PowerManagementSupported;
        
        private ushort m_ProtocolSupported;
        
        private string m_ProviderType;
        
        private bool m_SettableBaudRate;
        
        private bool m_SettableDataBits;
        
        private bool m_SettableFlowControl;
        
        private bool m_SettableParity;
        
        private bool m_SettableParityCheck;
        
        private bool m_SettableRLSD;
        
        private bool m_SettableStopBits;
        
        private string m_Status;
        
        private ushort m_StatusInfo;
        
        private bool m_Supports16BitMode;
        
        private bool m_SupportsDTRDSR;
        
        private bool m_SupportsElapsedTimeouts;
        
        private bool m_SupportsIntTimeouts;
        
        private bool m_SupportsParityCheck;
        
        private bool m_SupportsRLSD;
        
        private bool m_SupportsRTSCTS;
        
        private bool m_SupportsSpecialCharacters;
        
        private bool m_SupportsXOnXOff;
        
        private bool m_SupportsXOnXOffSet;
        
        private string m_SystemCreationClassName;
        
        private string m_SystemName;
        
        private string m_TimeOfLastReset;
        
        private string m_MyPath;
        
        public Win32_SerialPort()
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
        
        public bool Binary
        {
            get
            {
                return this.m_Binary;
            }
            set
            {
                this.m_Binary = value;
            }
        }
        
        public ushort [] Capabilities
        {
            get
            {
                return this.m_Capabilities;
            }
            set
            {
                this.m_Capabilities = value;
            }
        }
        
        public string [] CapabilityDescriptions
        {
            get
            {
                return this.m_CapabilityDescriptions;
            }
            set
            {
                this.m_CapabilityDescriptions = value;
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
        
        public uint MaxBaudRate
        {
            get
            {
                return this.m_MaxBaudRate;
            }
            set
            {
                this.m_MaxBaudRate = value;
            }
        }
        
        public uint MaximumInputBufferSize
        {
            get
            {
                return this.m_MaximumInputBufferSize;
            }
            set
            {
                this.m_MaximumInputBufferSize = value;
            }
        }
        
        public uint MaximumOutputBufferSize
        {
            get
            {
                return this.m_MaximumOutputBufferSize;
            }
            set
            {
                this.m_MaximumOutputBufferSize = value;
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
        
        public bool OSAutoDiscovered
        {
            get
            {
                return this.m_OSAutoDiscovered;
            }
            set
            {
                this.m_OSAutoDiscovered = value;
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
        
        public string ProviderType
        {
            get
            {
                return this.m_ProviderType;
            }
            set
            {
                this.m_ProviderType = value;
            }
        }
        
        public bool SettableBaudRate
        {
            get
            {
                return this.m_SettableBaudRate;
            }
            set
            {
                this.m_SettableBaudRate = value;
            }
        }
        
        public bool SettableDataBits
        {
            get
            {
                return this.m_SettableDataBits;
            }
            set
            {
                this.m_SettableDataBits = value;
            }
        }
        
        public bool SettableFlowControl
        {
            get
            {
                return this.m_SettableFlowControl;
            }
            set
            {
                this.m_SettableFlowControl = value;
            }
        }
        
        public bool SettableParity
        {
            get
            {
                return this.m_SettableParity;
            }
            set
            {
                this.m_SettableParity = value;
            }
        }
        
        public bool SettableParityCheck
        {
            get
            {
                return this.m_SettableParityCheck;
            }
            set
            {
                this.m_SettableParityCheck = value;
            }
        }
        
        public bool SettableRLSD
        {
            get
            {
                return this.m_SettableRLSD;
            }
            set
            {
                this.m_SettableRLSD = value;
            }
        }
        
        public bool SettableStopBits
        {
            get
            {
                return this.m_SettableStopBits;
            }
            set
            {
                this.m_SettableStopBits = value;
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
        
        public bool Supports16BitMode
        {
            get
            {
                return this.m_Supports16BitMode;
            }
            set
            {
                this.m_Supports16BitMode = value;
            }
        }
        
        public bool SupportsDTRDSR
        {
            get
            {
                return this.m_SupportsDTRDSR;
            }
            set
            {
                this.m_SupportsDTRDSR = value;
            }
        }
        
        public bool SupportsElapsedTimeouts
        {
            get
            {
                return this.m_SupportsElapsedTimeouts;
            }
            set
            {
                this.m_SupportsElapsedTimeouts = value;
            }
        }
        
        public bool SupportsIntTimeouts
        {
            get
            {
                return this.m_SupportsIntTimeouts;
            }
            set
            {
                this.m_SupportsIntTimeouts = value;
            }
        }
        
        public bool SupportsParityCheck
        {
            get
            {
                return this.m_SupportsParityCheck;
            }
            set
            {
                this.m_SupportsParityCheck = value;
            }
        }
        
        public bool SupportsRLSD
        {
            get
            {
                return this.m_SupportsRLSD;
            }
            set
            {
                this.m_SupportsRLSD = value;
            }
        }
        
        public bool SupportsRTSCTS
        {
            get
            {
                return this.m_SupportsRTSCTS;
            }
            set
            {
                this.m_SupportsRTSCTS = value;
            }
        }
        
        public bool SupportsSpecialCharacters
        {
            get
            {
                return this.m_SupportsSpecialCharacters;
            }
            set
            {
                this.m_SupportsSpecialCharacters = value;
            }
        }
        
        public bool SupportsXOnXOff
        {
            get
            {
                return this.m_SupportsXOnXOff;
            }
            set
            {
                this.m_SupportsXOnXOff = value;
            }
        }
        
        public bool SupportsXOnXOffSet
        {
            get
            {
                return this.m_SupportsXOnXOffSet;
            }
            set
            {
                this.m_SupportsXOnXOffSet = value;
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
            ManagementClass WMIClass = new ManagementClass("Win32_SerialPort");
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
