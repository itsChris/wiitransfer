using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_MappedLogicalDisk : WMIBase
    {
        
        private ushort m_Access;
        
        private ushort m_Availability;
        
        private ulong m_BlockSize;
        
        private string m_Caption;
        
        private bool m_Compressed;
        
        private uint m_ConfigManagerErrorCode;
        
        private bool m_ConfigManagerUserConfig;
        
        private string m_CreationClassName;
        
        private string m_Description;
        
        private string m_DeviceID;
        
        private bool m_ErrorCleared;
        
        private string m_ErrorDescription;
        
        private string m_ErrorMethodology;
        
        private string m_FileSystem;
        
        private ulong m_FreeSpace;
        
        private string m_InstallDate;
        
        private uint m_LastErrorCode;
        
        private uint m_MaximumComponentLength;
        
        private string m_Name;
        
        private ulong m_NumberOfBlocks;
        
        private string m_PNPDeviceID;
        
        private ushort [] m_PowerManagementCapabilities;
        
        private bool m_PowerManagementSupported;
        
        private string m_ProviderName;
        
        private string m_Purpose;
        
        private bool m_QuotasDisabled;
        
        private bool m_QuotasIncomplete;
        
        private bool m_QuotasRebuilding;
        
        private string m_SessionID;
        
        private ulong m_Size;
        
        private string m_Status;
        
        private ushort m_StatusInfo;
        
        private bool m_SupportsDiskQuotas;
        
        private bool m_SupportsFileBasedCompression;
        
        private string m_SystemCreationClassName;
        
        private string m_SystemName;
        
        private string m_VolumeName;
        
        private string m_VolumeSerialNumber;
        
        private string m_MyPath;
        
        public Win32_MappedLogicalDisk()
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
        
        public bool Compressed
        {
            get
            {
                return this.m_Compressed;
            }
            set
            {
                this.m_Compressed = value;
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
        
        public string FileSystem
        {
            get
            {
                return this.m_FileSystem;
            }
            set
            {
                this.m_FileSystem = value;
            }
        }
        
        public ulong FreeSpace
        {
            get
            {
                return this.m_FreeSpace;
            }
            set
            {
                this.m_FreeSpace = value;
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
        
        public uint MaximumComponentLength
        {
            get
            {
                return this.m_MaximumComponentLength;
            }
            set
            {
                this.m_MaximumComponentLength = value;
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
        
        public string ProviderName
        {
            get
            {
                return this.m_ProviderName;
            }
            set
            {
                this.m_ProviderName = value;
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
        
        public bool QuotasDisabled
        {
            get
            {
                return this.m_QuotasDisabled;
            }
            set
            {
                this.m_QuotasDisabled = value;
            }
        }
        
        public bool QuotasIncomplete
        {
            get
            {
                return this.m_QuotasIncomplete;
            }
            set
            {
                this.m_QuotasIncomplete = value;
            }
        }
        
        public bool QuotasRebuilding
        {
            get
            {
                return this.m_QuotasRebuilding;
            }
            set
            {
                this.m_QuotasRebuilding = value;
            }
        }
        
        public string SessionID
        {
            get
            {
                return this.m_SessionID;
            }
            set
            {
                this.m_SessionID = value;
            }
        }
        
        public ulong Size
        {
            get
            {
                return this.m_Size;
            }
            set
            {
                this.m_Size = value;
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
        
        public bool SupportsDiskQuotas
        {
            get
            {
                return this.m_SupportsDiskQuotas;
            }
            set
            {
                this.m_SupportsDiskQuotas = value;
            }
        }
        
        public bool SupportsFileBasedCompression
        {
            get
            {
                return this.m_SupportsFileBasedCompression;
            }
            set
            {
                this.m_SupportsFileBasedCompression = value;
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
        
        public string VolumeName
        {
            get
            {
                return this.m_VolumeName;
            }
            set
            {
                this.m_VolumeName = value;
            }
        }
        
        public string VolumeSerialNumber
        {
            get
            {
                return this.m_VolumeSerialNumber;
            }
            set
            {
                this.m_VolumeSerialNumber = value;
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
            ManagementClass WMIClass = new ManagementClass("Win32_MappedLogicalDisk");
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
