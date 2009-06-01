using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_DiskPartition : WMIBase
    {
        
        private ushort m_Access;
        
        private ushort m_Availability;
        
        private ulong m_BlockSize;
        
        private bool m_Bootable;
        
        private bool m_BootPartition;
        
        private string m_Caption;
        
        private uint m_ConfigManagerErrorCode;
        
        private bool m_ConfigManagerUserConfig;
        
        private string m_CreationClassName;
        
        private string m_Description;
        
        private string m_DeviceID;
        
        private uint m_DiskIndex;
        
        private bool m_ErrorCleared;
        
        private string m_ErrorDescription;
        
        private string m_ErrorMethodology;
        
        private uint m_HiddenSectors;
        
        private uint m_Index;
        
        private string m_InstallDate;
        
        private uint m_LastErrorCode;
        
        private string m_Name;
        
        private ulong m_NumberOfBlocks;
        
        private string m_PNPDeviceID;
        
        private ushort [] m_PowerManagementCapabilities;
        
        private bool m_PowerManagementSupported;
        
        private bool m_PrimaryPartition;
        
        private string m_Purpose;
        
        private bool m_RewritePartition;
        
        private ulong m_Size;
        
        private ulong m_StartingOffset;
        
        private string m_Status;
        
        private ushort m_StatusInfo;
        
        private string m_SystemCreationClassName;
        
        private string m_SystemName;
        
        private string m_Type;
        
        private string m_MyPath;
        
        public Win32_DiskPartition()
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
        
        public bool Bootable
        {
            get
            {
                return this.m_Bootable;
            }
            set
            {
                this.m_Bootable = value;
            }
        }
        
        public bool BootPartition
        {
            get
            {
                return this.m_BootPartition;
            }
            set
            {
                this.m_BootPartition = value;
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
        
        public uint DiskIndex
        {
            get
            {
                return this.m_DiskIndex;
            }
            set
            {
                this.m_DiskIndex = value;
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
        
        public uint HiddenSectors
        {
            get
            {
                return this.m_HiddenSectors;
            }
            set
            {
                this.m_HiddenSectors = value;
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
        
        public bool PrimaryPartition
        {
            get
            {
                return this.m_PrimaryPartition;
            }
            set
            {
                this.m_PrimaryPartition = value;
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
        
        public bool RewritePartition
        {
            get
            {
                return this.m_RewritePartition;
            }
            set
            {
                this.m_RewritePartition = value;
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
        
        public ulong StartingOffset
        {
            get
            {
                return this.m_StartingOffset;
            }
            set
            {
                this.m_StartingOffset = value;
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
        
        public string Type
        {
            get
            {
                return this.m_Type;
            }
            set
            {
                this.m_Type = value;
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
            ManagementClass WMIClass = new ManagementClass("Win32_DiskPartition");
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
