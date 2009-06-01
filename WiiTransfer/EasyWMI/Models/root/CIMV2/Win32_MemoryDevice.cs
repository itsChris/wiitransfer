using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_MemoryDevice : WMIBase
    {
        
        private ushort m_Access;
        
        private ushort [] m_AdditionalErrorData;
        
        private ushort m_Availability;
        
        private ulong m_BlockSize;
        
        private string m_Caption;
        
        private uint m_ConfigManagerErrorCode;
        
        private bool m_ConfigManagerUserConfig;
        
        private bool m_CorrectableError;
        
        private string m_CreationClassName;
        
        private string m_Description;
        
        private string m_DeviceID;
        
        private ulong m_EndingAddress;
        
        private ushort m_ErrorAccess;
        
        private ulong m_ErrorAddress;
        
        private bool m_ErrorCleared;
        
        private ushort [] m_ErrorData;
        
        private ushort m_ErrorDataOrder;
        
        private string m_ErrorDescription;
        
        private ushort m_ErrorGranularity;
        
        private ushort m_ErrorInfo;
        
        private string m_ErrorMethodology;
        
        private ulong m_ErrorResolution;
        
        private string m_ErrorTime;
        
        private uint m_ErrorTransferSize;
        
        private string m_InstallDate;
        
        private uint m_LastErrorCode;
        
        private string m_Name;
        
        private ulong m_NumberOfBlocks;
        
        private string m_OtherErrorDescription;
        
        private string m_PNPDeviceID;
        
        private ushort [] m_PowerManagementCapabilities;
        
        private bool m_PowerManagementSupported;
        
        private string m_Purpose;
        
        private ulong m_StartingAddress;
        
        private string m_Status;
        
        private ushort m_StatusInfo;
        
        private string m_SystemCreationClassName;
        
        private bool m_SystemLevelAddress;
        
        private string m_SystemName;
        
        private string m_MyPath;
        
        public Win32_MemoryDevice()
        {
        }
        
        public ushort Access
        {
            get
            {
                return this.m_Access;
            }
            set
            {
                this.m_Access = value;
            }
        }
        
        public ushort [] AdditionalErrorData
        {
            get
            {
                return this.m_AdditionalErrorData;
            }
            set
            {
                this.m_AdditionalErrorData = value;
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
        
        public ulong BlockSize
        {
            get
            {
                return this.m_BlockSize;
            }
            set
            {
                this.m_BlockSize = value;
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
        
        public bool CorrectableError
        {
            get
            {
                return this.m_CorrectableError;
            }
            set
            {
                this.m_CorrectableError = value;
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
        
        public ulong EndingAddress
        {
            get
            {
                return this.m_EndingAddress;
            }
            set
            {
                this.m_EndingAddress = value;
            }
        }
        
        public ushort ErrorAccess
        {
            get
            {
                return this.m_ErrorAccess;
            }
            set
            {
                this.m_ErrorAccess = value;
            }
        }
        
        public ulong ErrorAddress
        {
            get
            {
                return this.m_ErrorAddress;
            }
            set
            {
                this.m_ErrorAddress = value;
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
        
        public ushort [] ErrorData
        {
            get
            {
                return this.m_ErrorData;
            }
            set
            {
                this.m_ErrorData = value;
            }
        }
        
        public ushort ErrorDataOrder
        {
            get
            {
                return this.m_ErrorDataOrder;
            }
            set
            {
                this.m_ErrorDataOrder = value;
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
        
        public ushort ErrorGranularity
        {
            get
            {
                return this.m_ErrorGranularity;
            }
            set
            {
                this.m_ErrorGranularity = value;
            }
        }
        
        public ushort ErrorInfo
        {
            get
            {
                return this.m_ErrorInfo;
            }
            set
            {
                this.m_ErrorInfo = value;
            }
        }
        
        public string ErrorMethodology
        {
            get
            {
                return this.m_ErrorMethodology;
            }
            set
            {
                this.m_ErrorMethodology = value;
            }
        }
        
        public ulong ErrorResolution
        {
            get
            {
                return this.m_ErrorResolution;
            }
            set
            {
                this.m_ErrorResolution = value;
            }
        }
        
        public string ErrorTime
        {
            get
            {
                return this.m_ErrorTime;
            }
            set
            {
                this.m_ErrorTime = value;
            }
        }
        
        public uint ErrorTransferSize
        {
            get
            {
                return this.m_ErrorTransferSize;
            }
            set
            {
                this.m_ErrorTransferSize = value;
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
        
        public ulong NumberOfBlocks
        {
            get
            {
                return this.m_NumberOfBlocks;
            }
            set
            {
                this.m_NumberOfBlocks = value;
            }
        }
        
        public string OtherErrorDescription
        {
            get
            {
                return this.m_OtherErrorDescription;
            }
            set
            {
                this.m_OtherErrorDescription = value;
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
        
        public string Purpose
        {
            get
            {
                return this.m_Purpose;
            }
            set
            {
                this.m_Purpose = value;
            }
        }
        
        public ulong StartingAddress
        {
            get
            {
                return this.m_StartingAddress;
            }
            set
            {
                this.m_StartingAddress = value;
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
        
        public bool SystemLevelAddress
        {
            get
            {
                return this.m_SystemLevelAddress;
            }
            set
            {
                this.m_SystemLevelAddress = value;
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
            ManagementClass WMIClass = new ManagementClass("Win32_MemoryDevice");
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
