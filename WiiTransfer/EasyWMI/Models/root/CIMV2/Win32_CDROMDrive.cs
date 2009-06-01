using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_CDROMDrive : WMIBase
    {
        
        private ushort m_Availability;
        
        private ushort [] m_Capabilities;
        
        private string [] m_CapabilityDescriptions;
        
        private string m_Caption;
        
        private string m_CompressionMethod;
        
        private uint m_ConfigManagerErrorCode;
        
        private bool m_ConfigManagerUserConfig;
        
        private string m_CreationClassName;
        
        private ulong m_DefaultBlockSize;
        
        private string m_Description;
        
        private string m_DeviceID;
        
        private string m_Drive;
        
        private bool m_DriveIntegrity;
        
        private bool m_ErrorCleared;
        
        private string m_ErrorDescription;
        
        private string m_ErrorMethodology;
        
        private ushort m_FileSystemFlags;
        
        private uint m_FileSystemFlagsEx;
        
        private string m_Id;
        
        private string m_InstallDate;
        
        private uint m_LastErrorCode;
        
        private string m_Manufacturer;
        
        private ulong m_MaxBlockSize;
        
        private uint m_MaximumComponentLength;
        
        private ulong m_MaxMediaSize;
        
        private bool m_MediaLoaded;
        
        private string m_MediaType;
        
        private string m_MfrAssignedRevisionLevel;
        
        private ulong m_MinBlockSize;
        
        private string m_Name;
        
        private bool m_NeedsCleaning;
        
        private uint m_NumberOfMediaSupported;
        
        private string m_PNPDeviceID;
        
        private ushort [] m_PowerManagementCapabilities;
        
        private bool m_PowerManagementSupported;
        
        private string m_RevisionLevel;
        
        private uint m_SCSIBus;
        
        private ushort m_SCSILogicalUnit;
        
        private ushort m_SCSIPort;
        
        private ushort m_SCSITargetId;
        
        private string m_SerialNumber;
        
        private ulong m_Size;
        
        private string m_Status;
        
        private ushort m_StatusInfo;
        
        private string m_SystemCreationClassName;
        
        private string m_SystemName;
        
        private double m_TransferRate;
        
        private string m_VolumeName;
        
        private string m_VolumeSerialNumber;
        
        private string m_MyPath;
        
        public Win32_CDROMDrive()
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
        
        public string CompressionMethod
        {
            get
            {
                return this.m_CompressionMethod;
            }
            set
            {
                this.m_CompressionMethod = value;
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
        
        public ulong DefaultBlockSize
        {
            get
            {
                return this.m_DefaultBlockSize;
            }
            set
            {
                this.m_DefaultBlockSize = value;
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
        
        public string Drive
        {
            get
            {
                return this.m_Drive;
            }
            set
            {
                this.m_Drive = value;
            }
        }
        
        public bool DriveIntegrity
        {
            get
            {
                return this.m_DriveIntegrity;
            }
            set
            {
                this.m_DriveIntegrity = value;
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
        
        public ushort FileSystemFlags
        {
            get
            {
                return this.m_FileSystemFlags;
            }
            set
            {
                this.m_FileSystemFlags = value;
            }
        }
        
        public uint FileSystemFlagsEx
        {
            get
            {
                return this.m_FileSystemFlagsEx;
            }
            set
            {
                this.m_FileSystemFlagsEx = value;
            }
        }
        
        public string Id
        {
            get
            {
                return this.m_Id;
            }
            set
            {
                this.m_Id = value;
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
        
        public ulong MaxBlockSize
        {
            get
            {
                return this.m_MaxBlockSize;
            }
            set
            {
                this.m_MaxBlockSize = value;
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
        
        public ulong MaxMediaSize
        {
            get
            {
                return this.m_MaxMediaSize;
            }
            set
            {
                this.m_MaxMediaSize = value;
            }
        }
        
        public bool MediaLoaded
        {
            get
            {
                return this.m_MediaLoaded;
            }
            set
            {
                this.m_MediaLoaded = value;
            }
        }
        
        public string MediaType
        {
            get
            {
                return this.m_MediaType;
            }
            set
            {
                this.m_MediaType = value;
            }
        }
        
        public string MfrAssignedRevisionLevel
        {
            get
            {
                return this.m_MfrAssignedRevisionLevel;
            }
            set
            {
                this.m_MfrAssignedRevisionLevel = value;
            }
        }
        
        public ulong MinBlockSize
        {
            get
            {
                return this.m_MinBlockSize;
            }
            set
            {
                this.m_MinBlockSize = value;
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
        
        public bool NeedsCleaning
        {
            get
            {
                return this.m_NeedsCleaning;
            }
            set
            {
                this.m_NeedsCleaning = value;
            }
        }
        
        public uint NumberOfMediaSupported
        {
            get
            {
                return this.m_NumberOfMediaSupported;
            }
            set
            {
                this.m_NumberOfMediaSupported = value;
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
        
        public string RevisionLevel
        {
            get
            {
                return this.m_RevisionLevel;
            }
            set
            {
                this.m_RevisionLevel = value;
            }
        }
        
        public uint SCSIBus
        {
            get
            {
                return this.m_SCSIBus;
            }
            set
            {
                this.m_SCSIBus = value;
            }
        }
        
        public ushort SCSILogicalUnit
        {
            get
            {
                return this.m_SCSILogicalUnit;
            }
            set
            {
                this.m_SCSILogicalUnit = value;
            }
        }
        
        public ushort SCSIPort
        {
            get
            {
                return this.m_SCSIPort;
            }
            set
            {
                this.m_SCSIPort = value;
            }
        }
        
        public ushort SCSITargetId
        {
            get
            {
                return this.m_SCSITargetId;
            }
            set
            {
                this.m_SCSITargetId = value;
            }
        }
        
        public string SerialNumber
        {
            get
            {
                return this.m_SerialNumber;
            }
            set
            {
                this.m_SerialNumber = value;
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
        
        public double TransferRate
        {
            get
            {
                return this.m_TransferRate;
            }
            set
            {
                this.m_TransferRate = value;
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
            ManagementClass WMIClass = new ManagementClass("Win32_CDROMDrive");
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
