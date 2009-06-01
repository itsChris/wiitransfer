using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_Volume : WMIBase
    {
        
        private ushort m_Access;
        
        private bool m_Automount;
        
        private ushort m_Availability;
        
        private ulong m_BlockSize;
        
        private bool m_BootVolume;
        
        private ulong m_Capacity;
        
        private string m_Caption;
        
        private bool m_Compressed;
        
        private uint m_ConfigManagerErrorCode;
        
        private bool m_ConfigManagerUserConfig;
        
        private string m_CreationClassName;
        
        private string m_Description;
        
        private string m_DeviceID;
        
        private bool m_DirtyBitSet;
        
        private string m_DriveLetter;
        
        private uint m_DriveType;
        
        private bool m_ErrorCleared;
        
        private string m_ErrorDescription;
        
        private string m_ErrorMethodology;
        
        private string m_FileSystem;
        
        private ulong m_FreeSpace;
        
        private bool m_IndexingEnabled;
        
        private string m_InstallDate;
        
        private string m_Label;
        
        private uint m_LastErrorCode;
        
        private uint m_MaximumFileNameLength;
        
        private string m_Name;
        
        private ulong m_NumberOfBlocks;
        
        private bool m_PageFilePresent;
        
        private string m_PNPDeviceID;
        
        private ushort [] m_PowerManagementCapabilities;
        
        private bool m_PowerManagementSupported;
        
        private string m_Purpose;
        
        private bool m_QuotasEnabled;
        
        private bool m_QuotasIncomplete;
        
        private bool m_QuotasRebuilding;
        
        private uint m_SerialNumber;
        
        private string m_Status;
        
        private ushort m_StatusInfo;
        
        private bool m_SupportsDiskQuotas;
        
        private bool m_SupportsFileBasedCompression;
        
        private string m_SystemCreationClassName;
        
        private string m_SystemName;
        
        private bool m_SystemVolume;
        
        private string m_MyPath;
        
        public Win32_Volume()
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
        
        public bool Automount
        {
            get
            {
                return this.m_Automount;
            }
            set
            {
                this.m_Automount = value;
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
        
        public bool BootVolume
        {
            get
            {
                return this.m_BootVolume;
            }
            set
            {
                this.m_BootVolume = value;
            }
        }
        
        public ulong Capacity
        {
            get
            {
                return this.m_Capacity;
            }
            set
            {
                this.m_Capacity = value;
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
        
        public bool DirtyBitSet
        {
            get
            {
                return this.m_DirtyBitSet;
            }
            set
            {
                this.m_DirtyBitSet = value;
            }
        }
        
        public string DriveLetter
        {
            get
            {
                return this.m_DriveLetter;
            }
            set
            {
                this.m_DriveLetter = value;
            }
        }
        
        public uint DriveType
        {
            get
            {
                return this.m_DriveType;
            }
            set
            {
                this.m_DriveType = value;
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
        
        public bool IndexingEnabled
        {
            get
            {
                return this.m_IndexingEnabled;
            }
            set
            {
                this.m_IndexingEnabled = value;
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
        
        public string Label
        {
            get
            {
                return this.m_Label;
            }
            set
            {
                this.m_Label = value;
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
        
        public uint MaximumFileNameLength
        {
            get
            {
                return this.m_MaximumFileNameLength;
            }
            set
            {
                this.m_MaximumFileNameLength = value;
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
        
        public bool PageFilePresent
        {
            get
            {
                return this.m_PageFilePresent;
            }
            set
            {
                this.m_PageFilePresent = value;
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
        
        public bool QuotasEnabled
        {
            get
            {
                return this.m_QuotasEnabled;
            }
            set
            {
                this.m_QuotasEnabled = value;
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
        
        public uint SerialNumber
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
        
        public bool SystemVolume
        {
            get
            {
                return this.m_SystemVolume;
            }
            set
            {
                this.m_SystemVolume = value;
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
            ManagementClass WMIClass = new ManagementClass("Win32_Volume");
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
        
        public Int32 Chkdsk(bool FixErrors, bool ForceDismount, bool OkToRunAtBootUp, bool RecoverBadSectors, bool SkipFolderCycle, bool VigorousIndexCheck)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_Volume");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("Chkdsk");
InParams["FixErrors"] = FixErrors;
InParams["ForceDismount"] = ForceDismount;
InParams["OkToRunAtBootUp"] = OkToRunAtBootUp;
InParams["RecoverBadSectors"] = RecoverBadSectors;
InParams["SkipFolderCycle"] = SkipFolderCycle;
InParams["VigorousIndexCheck"] = VigorousIndexCheck;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Chkdsk", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 ScheduleAutoChk(string [] Volume)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_Volume");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("ScheduleAutoChk");
InParams["Volume"] = Volume;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "ScheduleAutoChk", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 ExcludeFromAutoChk(string [] Volume)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_Volume");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("ExcludeFromAutoChk");
InParams["Volume"] = Volume;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "ExcludeFromAutoChk", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Format(uint ClusterSize, bool EnableCompression, string FileSystem, string Label, bool QuickFormat, uint Version)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_Volume");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("Format");
InParams["ClusterSize"] = ClusterSize;
InParams["EnableCompression"] = EnableCompression;
InParams["FileSystem"] = FileSystem;
InParams["Label"] = Label;
InParams["QuickFormat"] = QuickFormat;
InParams["Version"] = Version;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Format", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Defrag(bool Force, out object DefragAnalysis)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_Volume");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("Defrag");
InParams["Force"] = Force;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Defrag", InParams, Options);
DefragAnalysis = (Object)OutParams["DefragAnalysis"];

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 DefragAnalysis(out object DefragAnalysis, out bool DefragRecommended)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "DefragAnalysis", InParams, Options);
DefragAnalysis = (Object)OutParams["DefragAnalysis"];
DefragRecommended = (Boolean)OutParams["DefragRecommended"];

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 AddMountPoint(string Directory)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_Volume");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("AddMountPoint");
InParams["Directory"] = Directory;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "AddMountPoint", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Mount()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Mount", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Dismount(bool Force, bool Permanent)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_Volume");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("Dismount");
InParams["Force"] = Force;
InParams["Permanent"] = Permanent;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Dismount", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
    }
}
