using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_OperatingSystem : WMIBase
    {
        
        private string m_BootDevice;
        
        private string m_BuildNumber;
        
        private string m_BuildType;
        
        private string m_Caption;
        
        private string m_CodeSet;
        
        private string m_CountryCode;
        
        private string m_CreationClassName;
        
        private string m_CSCreationClassName;
        
        private string m_CSDVersion;
        
        private string m_CSName;
        
        private short m_CurrentTimeZone;
        
        private bool m_DataExecutionPrevention_32BitApplications;
        
        private bool m_DataExecutionPrevention_Available;
        
        private bool m_DataExecutionPrevention_Drivers;
        
        private ushort m_DataExecutionPrevention_SupportPolicy;
        
        private bool m_Debug;
        
        private string m_Description;
        
        private bool m_Distributed;
        
        private uint m_EncryptionLevel;
        
        private ushort m_ForegroundApplicationBoost;
        
        private ulong m_FreePhysicalMemory;
        
        private ulong m_FreeSpaceInPagingFiles;
        
        private ulong m_FreeVirtualMemory;
        
        private string m_InstallDate;
        
        private uint m_LargeSystemCache;
        
        private string m_LastBootUpTime;
        
        private string m_LocalDateTime;
        
        private string m_Locale;
        
        private string m_Manufacturer;
        
        private uint m_MaxNumberOfProcesses;
        
        private ulong m_MaxProcessMemorySize;
        
        private string [] m_MUILanguages;
        
        private string m_Name;
        
        private uint m_NumberOfLicensedUsers;
        
        private uint m_NumberOfProcesses;
        
        private uint m_NumberOfUsers;
        
        private uint m_OperatingSystemSKU;
        
        private string m_Organization;
        
        private string m_OSArchitecture;
        
        private uint m_OSLanguage;
        
        private uint m_OSProductSuite;
        
        private ushort m_OSType;
        
        private string m_OtherTypeDescription;
        
        private bool m_PAEEnabled;
        
        private string m_PlusProductID;
        
        private string m_PlusVersionNumber;
        
        private bool m_Primary;
        
        private uint m_ProductType;
        
        private ushort m_QuantumLength;
        
        private ushort m_QuantumType;
        
        private string m_RegisteredUser;
        
        private string m_SerialNumber;
        
        private ushort m_ServicePackMajorVersion;
        
        private ushort m_ServicePackMinorVersion;
        
        private ulong m_SizeStoredInPagingFiles;
        
        private string m_Status;
        
        private uint m_SuiteMask;
        
        private string m_SystemDevice;
        
        private string m_SystemDirectory;
        
        private string m_SystemDrive;
        
        private ulong m_TotalSwapSpaceSize;
        
        private ulong m_TotalVirtualMemorySize;
        
        private ulong m_TotalVisibleMemorySize;
        
        private string m_Version;
        
        private string m_WindowsDirectory;
        
        private string m_MyPath;
        
        public Win32_OperatingSystem()
        {
        }
        
        public string BootDevice
        {
            get
            {
                return this.m_BootDevice;
            }
            set
            {
                this.m_BootDevice = value;
            }
        }
        
        public string BuildNumber
        {
            get
            {
                return this.m_BuildNumber;
            }
            set
            {
                this.m_BuildNumber = value;
            }
        }
        
        public string BuildType
        {
            get
            {
                return this.m_BuildType;
            }
            set
            {
                this.m_BuildType = value;
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
        
        public string CodeSet
        {
            get
            {
                return this.m_CodeSet;
            }
            set
            {
                this.m_CodeSet = value;
            }
        }
        
        public string CountryCode
        {
            get
            {
                return this.m_CountryCode;
            }
            set
            {
                this.m_CountryCode = value;
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
        
        public string CSCreationClassName
        {
            get
            {
                return this.m_CSCreationClassName;
            }
            set
            {
                this.m_CSCreationClassName = value;
            }
        }
        
        public string CSDVersion
        {
            get
            {
                return this.m_CSDVersion;
            }
            set
            {
                this.m_CSDVersion = value;
            }
        }
        
        public string CSName
        {
            get
            {
                return this.m_CSName;
            }
            set
            {
                this.m_CSName = value;
            }
        }
        
        public short CurrentTimeZone
        {
            get
            {
                return this.m_CurrentTimeZone;
            }
            set
            {
                this.m_CurrentTimeZone = value;
            }
        }
        
        public bool DataExecutionPrevention_32BitApplications
        {
            get
            {
                return this.m_DataExecutionPrevention_32BitApplications;
            }
            set
            {
                this.m_DataExecutionPrevention_32BitApplications = value;
            }
        }
        
        public bool DataExecutionPrevention_Available
        {
            get
            {
                return this.m_DataExecutionPrevention_Available;
            }
            set
            {
                this.m_DataExecutionPrevention_Available = value;
            }
        }
        
        public bool DataExecutionPrevention_Drivers
        {
            get
            {
                return this.m_DataExecutionPrevention_Drivers;
            }
            set
            {
                this.m_DataExecutionPrevention_Drivers = value;
            }
        }
        
        public ushort DataExecutionPrevention_SupportPolicy
        {
            get
            {
                return this.m_DataExecutionPrevention_SupportPolicy;
            }
            set
            {
                this.m_DataExecutionPrevention_SupportPolicy = value;
            }
        }
        
        public bool Debug
        {
            get
            {
                return this.m_Debug;
            }
            set
            {
                this.m_Debug = value;
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
        
        public bool Distributed
        {
            get
            {
                return this.m_Distributed;
            }
            set
            {
                this.m_Distributed = value;
            }
        }
        
        public uint EncryptionLevel
        {
            get
            {
                return this.m_EncryptionLevel;
            }
            set
            {
                this.m_EncryptionLevel = value;
            }
        }
        
        public ushort ForegroundApplicationBoost
        {
            get
            {
                return this.m_ForegroundApplicationBoost;
            }
            set
            {
                this.m_ForegroundApplicationBoost = value;
            }
        }
        
        public ulong FreePhysicalMemory
        {
            get
            {
                return this.m_FreePhysicalMemory;
            }
            set
            {
                this.m_FreePhysicalMemory = value;
            }
        }
        
        public ulong FreeSpaceInPagingFiles
        {
            get
            {
                return this.m_FreeSpaceInPagingFiles;
            }
            set
            {
                this.m_FreeSpaceInPagingFiles = value;
            }
        }
        
        public ulong FreeVirtualMemory
        {
            get
            {
                return this.m_FreeVirtualMemory;
            }
            set
            {
                this.m_FreeVirtualMemory = value;
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
        
        public uint LargeSystemCache
        {
            get
            {
                return this.m_LargeSystemCache;
            }
            set
            {
                this.m_LargeSystemCache = value;
            }
        }
        
        public string LastBootUpTime
        {
            get
            {
                return this.m_LastBootUpTime;
            }
            set
            {
                this.m_LastBootUpTime = value;
            }
        }
        
        public string LocalDateTime
        {
            get
            {
                return this.m_LocalDateTime;
            }
            set
            {
                this.m_LocalDateTime = value;
            }
        }
        
        public string Locale
        {
            get
            {
                return this.m_Locale;
            }
            set
            {
                this.m_Locale = value;
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
        
        public uint MaxNumberOfProcesses
        {
            get
            {
                return this.m_MaxNumberOfProcesses;
            }
            set
            {
                this.m_MaxNumberOfProcesses = value;
            }
        }
        
        public ulong MaxProcessMemorySize
        {
            get
            {
                return this.m_MaxProcessMemorySize;
            }
            set
            {
                this.m_MaxProcessMemorySize = value;
            }
        }
        
        public string [] MUILanguages
        {
            get
            {
                return this.m_MUILanguages;
            }
            set
            {
                this.m_MUILanguages = value;
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
        
        public uint NumberOfLicensedUsers
        {
            get
            {
                return this.m_NumberOfLicensedUsers;
            }
            set
            {
                this.m_NumberOfLicensedUsers = value;
            }
        }
        
        public uint NumberOfProcesses
        {
            get
            {
                return this.m_NumberOfProcesses;
            }
            set
            {
                this.m_NumberOfProcesses = value;
            }
        }
        
        public uint NumberOfUsers
        {
            get
            {
                return this.m_NumberOfUsers;
            }
            set
            {
                this.m_NumberOfUsers = value;
            }
        }
        
        public uint OperatingSystemSKU
        {
            get
            {
                return this.m_OperatingSystemSKU;
            }
            set
            {
                this.m_OperatingSystemSKU = value;
            }
        }
        
        public string Organization
        {
            get
            {
                return this.m_Organization;
            }
            set
            {
                this.m_Organization = value;
            }
        }
        
        public string OSArchitecture
        {
            get
            {
                return this.m_OSArchitecture;
            }
            set
            {
                this.m_OSArchitecture = value;
            }
        }
        
        public uint OSLanguage
        {
            get
            {
                return this.m_OSLanguage;
            }
            set
            {
                this.m_OSLanguage = value;
            }
        }
        
        public uint OSProductSuite
        {
            get
            {
                return this.m_OSProductSuite;
            }
            set
            {
                this.m_OSProductSuite = value;
            }
        }
        
        public ushort OSType
        {
            get
            {
                return this.m_OSType;
            }
            set
            {
                this.m_OSType = value;
            }
        }
        
        public string OtherTypeDescription
        {
            get
            {
                return this.m_OtherTypeDescription;
            }
            set
            {
                this.m_OtherTypeDescription = value;
            }
        }
        
        public bool PAEEnabled
        {
            get
            {
                return this.m_PAEEnabled;
            }
            set
            {
                this.m_PAEEnabled = value;
            }
        }
        
        public string PlusProductID
        {
            get
            {
                return this.m_PlusProductID;
            }
            set
            {
                this.m_PlusProductID = value;
            }
        }
        
        public string PlusVersionNumber
        {
            get
            {
                return this.m_PlusVersionNumber;
            }
            set
            {
                this.m_PlusVersionNumber = value;
            }
        }
        
        public bool Primary
        {
            get
            {
                return this.m_Primary;
            }
            set
            {
                this.m_Primary = value;
            }
        }
        
        public uint ProductType
        {
            get
            {
                return this.m_ProductType;
            }
            set
            {
                this.m_ProductType = value;
            }
        }
        
        public ushort QuantumLength
        {
            get
            {
                return this.m_QuantumLength;
            }
            set
            {
                this.m_QuantumLength = value;
            }
        }
        
        public ushort QuantumType
        {
            get
            {
                return this.m_QuantumType;
            }
            set
            {
                this.m_QuantumType = value;
            }
        }
        
        public string RegisteredUser
        {
            get
            {
                return this.m_RegisteredUser;
            }
            set
            {
                this.m_RegisteredUser = value;
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
        
        public ushort ServicePackMajorVersion
        {
            get
            {
                return this.m_ServicePackMajorVersion;
            }
            set
            {
                this.m_ServicePackMajorVersion = value;
            }
        }
        
        public ushort ServicePackMinorVersion
        {
            get
            {
                return this.m_ServicePackMinorVersion;
            }
            set
            {
                this.m_ServicePackMinorVersion = value;
            }
        }
        
        public ulong SizeStoredInPagingFiles
        {
            get
            {
                return this.m_SizeStoredInPagingFiles;
            }
            set
            {
                this.m_SizeStoredInPagingFiles = value;
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
        
        public uint SuiteMask
        {
            get
            {
                return this.m_SuiteMask;
            }
            set
            {
                this.m_SuiteMask = value;
            }
        }
        
        public string SystemDevice
        {
            get
            {
                return this.m_SystemDevice;
            }
            set
            {
                this.m_SystemDevice = value;
            }
        }
        
        public string SystemDirectory
        {
            get
            {
                return this.m_SystemDirectory;
            }
            set
            {
                this.m_SystemDirectory = value;
            }
        }
        
        public string SystemDrive
        {
            get
            {
                return this.m_SystemDrive;
            }
            set
            {
                this.m_SystemDrive = value;
            }
        }
        
        public ulong TotalSwapSpaceSize
        {
            get
            {
                return this.m_TotalSwapSpaceSize;
            }
            set
            {
                this.m_TotalSwapSpaceSize = value;
            }
        }
        
        public ulong TotalVirtualMemorySize
        {
            get
            {
                return this.m_TotalVirtualMemorySize;
            }
            set
            {
                this.m_TotalVirtualMemorySize = value;
            }
        }
        
        public ulong TotalVisibleMemorySize
        {
            get
            {
                return this.m_TotalVisibleMemorySize;
            }
            set
            {
                this.m_TotalVisibleMemorySize = value;
            }
        }
        
        public string Version
        {
            get
            {
                return this.m_Version;
            }
            set
            {
                this.m_Version = value;
            }
        }
        
        public string WindowsDirectory
        {
            get
            {
                return this.m_WindowsDirectory;
            }
            set
            {
                this.m_WindowsDirectory = value;
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
        
        public Int32 Reboot()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Reboot", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Shutdown()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Shutdown", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Win32Shutdown(int Flags, int Reserved)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_OperatingSystem");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("Win32Shutdown");
            InParams["Flags"] = Flags;
            InParams["Reserved"] = Reserved;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Win32Shutdown", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Win32ShutdownTracker(string Comment, int Flags, uint ReasonCode, uint Timeout)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_OperatingSystem");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("Win32ShutdownTracker");
            InParams["Comment"] = Comment;
            InParams["Flags"] = Flags;
            InParams["ReasonCode"] = ReasonCode;
            InParams["Timeout"] = Timeout;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Win32ShutdownTracker", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetDateTime(string LocalDateTime)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_OperatingSystem");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetDateTime");
            InParams["LocalDateTime"] = LocalDateTime;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetDateTime", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
    }
}
