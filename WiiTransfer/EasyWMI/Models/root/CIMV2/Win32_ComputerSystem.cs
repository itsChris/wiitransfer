using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_ComputerSystem : WMIBase
    {
        
        private ushort m_AdminPasswordStatus;
        
        private bool m_AutomaticManagedPagefile;
        
        private bool m_AutomaticResetBootOption;
        
        private bool m_AutomaticResetCapability;
        
        private ushort m_BootOptionOnLimit;
        
        private ushort m_BootOptionOnWatchDog;
        
        private bool m_BootROMSupported;
        
        private string m_BootupState;
        
        private string m_Caption;
        
        private ushort m_ChassisBootupState;
        
        private string m_CreationClassName;
        
        private short m_CurrentTimeZone;
        
        private bool m_DaylightInEffect;
        
        private string m_Description;
        
        private string m_DNSHostName;
        
        private string m_Domain;
        
        private ushort m_DomainRole;
        
        private bool m_EnableDaylightSavingsTime;
        
        private ushort m_FrontPanelResetStatus;
        
        private bool m_InfraredSupported;
        
        private string [] m_InitialLoadInfo;
        
        private string m_InstallDate;
        
        private ushort m_KeyboardPasswordStatus;
        
        private string m_LastLoadInfo;
        
        private string m_Manufacturer;
        
        private string m_Model;
        
        private string m_Name;
        
        private string m_NameFormat;
        
        private bool m_NetworkServerModeEnabled;
        
        private uint m_NumberOfLogicalProcessors;
        
        private uint m_NumberOfProcessors;
        
        private ushort [] m_OEMLogoBitmap;
        
        private string [] m_OEMStringArray;
        
        private bool m_PartOfDomain;
        
        private long m_PauseAfterReset;
        
        private ushort m_PCSystemType;
        
        private ushort [] m_PowerManagementCapabilities;
        
        private bool m_PowerManagementSupported;
        
        private ushort m_PowerOnPasswordStatus;
        
        private ushort m_PowerState;
        
        private ushort m_PowerSupplyState;
        
        private string m_PrimaryOwnerContact;
        
        private string m_PrimaryOwnerName;
        
        private ushort m_ResetCapability;
        
        private short m_ResetCount;
        
        private short m_ResetLimit;
        
        private string [] m_Roles;
        
        private string m_Status;
        
        private string [] m_SupportContactDescription;
        
        private ushort m_SystemStartupDelay;
        
        private string [] m_SystemStartupOptions;
        
        private ushort m_SystemStartupSetting;
        
        private string m_SystemType;
        
        private ushort m_ThermalState;
        
        private ulong m_TotalPhysicalMemory;
        
        private string m_UserName;
        
        private ushort m_WakeUpType;
        
        private string m_Workgroup;
        
        private string m_MyPath;
        
        public Win32_ComputerSystem()
        {
        }
        
        public ushort AdminPasswordStatus
        {
            get
            {
                return this.m_AdminPasswordStatus;
            }
            set
            {
                this.m_AdminPasswordStatus = value;
            }
        }
        
        public bool AutomaticManagedPagefile
        {
            get
            {
                return this.m_AutomaticManagedPagefile;
            }
            set
            {
                this.m_AutomaticManagedPagefile = value;
            }
        }
        
        public bool AutomaticResetBootOption
        {
            get
            {
                return this.m_AutomaticResetBootOption;
            }
            set
            {
                this.m_AutomaticResetBootOption = value;
            }
        }
        
        public bool AutomaticResetCapability
        {
            get
            {
                return this.m_AutomaticResetCapability;
            }
            set
            {
                this.m_AutomaticResetCapability = value;
            }
        }
        
        public ushort BootOptionOnLimit
        {
            get
            {
                return this.m_BootOptionOnLimit;
            }
            set
            {
                this.m_BootOptionOnLimit = value;
            }
        }
        
        public ushort BootOptionOnWatchDog
        {
            get
            {
                return this.m_BootOptionOnWatchDog;
            }
            set
            {
                this.m_BootOptionOnWatchDog = value;
            }
        }
        
        public bool BootROMSupported
        {
            get
            {
                return this.m_BootROMSupported;
            }
            set
            {
                this.m_BootROMSupported = value;
            }
        }
        
        public string BootupState
        {
            get
            {
                return this.m_BootupState;
            }
            set
            {
                this.m_BootupState = value;
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
        
        public ushort ChassisBootupState
        {
            get
            {
                return this.m_ChassisBootupState;
            }
            set
            {
                this.m_ChassisBootupState = value;
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
        
        public bool DaylightInEffect
        {
            get
            {
                return this.m_DaylightInEffect;
            }
            set
            {
                this.m_DaylightInEffect = value;
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
        
        public string DNSHostName
        {
            get
            {
                return this.m_DNSHostName;
            }
            set
            {
                this.m_DNSHostName = value;
            }
        }
        
        public string Domain
        {
            get
            {
                return this.m_Domain;
            }
            set
            {
                this.m_Domain = value;
            }
        }
        
        public ushort DomainRole
        {
            get
            {
                return this.m_DomainRole;
            }
            set
            {
                this.m_DomainRole = value;
            }
        }
        
        public bool EnableDaylightSavingsTime
        {
            get
            {
                return this.m_EnableDaylightSavingsTime;
            }
            set
            {
                this.m_EnableDaylightSavingsTime = value;
            }
        }
        
        public ushort FrontPanelResetStatus
        {
            get
            {
                return this.m_FrontPanelResetStatus;
            }
            set
            {
                this.m_FrontPanelResetStatus = value;
            }
        }
        
        public bool InfraredSupported
        {
            get
            {
                return this.m_InfraredSupported;
            }
            set
            {
                this.m_InfraredSupported = value;
            }
        }
        
        public string [] InitialLoadInfo
        {
            get
            {
                return this.m_InitialLoadInfo;
            }
            set
            {
                this.m_InitialLoadInfo = value;
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
        
        public ushort KeyboardPasswordStatus
        {
            get
            {
                return this.m_KeyboardPasswordStatus;
            }
            set
            {
                this.m_KeyboardPasswordStatus = value;
            }
        }
        
        public string LastLoadInfo
        {
            get
            {
                return this.m_LastLoadInfo;
            }
            set
            {
                this.m_LastLoadInfo = value;
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
        
        public string Model
        {
            get
            {
                return this.m_Model;
            }
            set
            {
                this.m_Model = value;
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
        
        public string NameFormat
        {
            get
            {
                return this.m_NameFormat;
            }
            set
            {
                this.m_NameFormat = value;
            }
        }
        
        public bool NetworkServerModeEnabled
        {
            get
            {
                return this.m_NetworkServerModeEnabled;
            }
            set
            {
                this.m_NetworkServerModeEnabled = value;
            }
        }
        
        public uint NumberOfLogicalProcessors
        {
            get
            {
                return this.m_NumberOfLogicalProcessors;
            }
            set
            {
                this.m_NumberOfLogicalProcessors = value;
            }
        }
        
        public uint NumberOfProcessors
        {
            get
            {
                return this.m_NumberOfProcessors;
            }
            set
            {
                this.m_NumberOfProcessors = value;
            }
        }
        
        public ushort [] OEMLogoBitmap
        {
            get
            {
                return this.m_OEMLogoBitmap;
            }
            set
            {
                this.m_OEMLogoBitmap = value;
            }
        }
        
        public string [] OEMStringArray
        {
            get
            {
                return this.m_OEMStringArray;
            }
            set
            {
                this.m_OEMStringArray = value;
            }
        }
        
        public bool PartOfDomain
        {
            get
            {
                return this.m_PartOfDomain;
            }
            set
            {
                this.m_PartOfDomain = value;
            }
        }
        
        public long PauseAfterReset
        {
            get
            {
                return this.m_PauseAfterReset;
            }
            set
            {
                this.m_PauseAfterReset = value;
            }
        }
        
        public ushort PCSystemType
        {
            get
            {
                return this.m_PCSystemType;
            }
            set
            {
                this.m_PCSystemType = value;
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
        
        public ushort PowerOnPasswordStatus
        {
            get
            {
                return this.m_PowerOnPasswordStatus;
            }
            set
            {
                this.m_PowerOnPasswordStatus = value;
            }
        }
        
        public ushort PowerState
        {
            get
            {
                return this.m_PowerState;
            }
            set
            {
                this.m_PowerState = value;
            }
        }
        
        public ushort PowerSupplyState
        {
            get
            {
                return this.m_PowerSupplyState;
            }
            set
            {
                this.m_PowerSupplyState = value;
            }
        }
        
        public string PrimaryOwnerContact
        {
            get
            {
                return this.m_PrimaryOwnerContact;
            }
            set
            {
                this.m_PrimaryOwnerContact = value;
            }
        }
        
        public string PrimaryOwnerName
        {
            get
            {
                return this.m_PrimaryOwnerName;
            }
            set
            {
                this.m_PrimaryOwnerName = value;
            }
        }
        
        public ushort ResetCapability
        {
            get
            {
                return this.m_ResetCapability;
            }
            set
            {
                this.m_ResetCapability = value;
            }
        }
        
        public short ResetCount
        {
            get
            {
                return this.m_ResetCount;
            }
            set
            {
                this.m_ResetCount = value;
            }
        }
        
        public short ResetLimit
        {
            get
            {
                return this.m_ResetLimit;
            }
            set
            {
                this.m_ResetLimit = value;
            }
        }
        
        public string [] Roles
        {
            get
            {
                return this.m_Roles;
            }
            set
            {
                this.m_Roles = value;
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
        
        public string [] SupportContactDescription
        {
            get
            {
                return this.m_SupportContactDescription;
            }
            set
            {
                this.m_SupportContactDescription = value;
            }
        }
        
        public ushort SystemStartupDelay
        {
            get
            {
                return this.m_SystemStartupDelay;
            }
            set
            {
                this.m_SystemStartupDelay = value;
            }
        }
        
        public string [] SystemStartupOptions
        {
            get
            {
                return this.m_SystemStartupOptions;
            }
            set
            {
                this.m_SystemStartupOptions = value;
            }
        }
        
        public ushort SystemStartupSetting
        {
            get
            {
                return this.m_SystemStartupSetting;
            }
            set
            {
                this.m_SystemStartupSetting = value;
            }
        }
        
        public string SystemType
        {
            get
            {
                return this.m_SystemType;
            }
            set
            {
                this.m_SystemType = value;
            }
        }
        
        public ushort ThermalState
        {
            get
            {
                return this.m_ThermalState;
            }
            set
            {
                this.m_ThermalState = value;
            }
        }
        
        public ulong TotalPhysicalMemory
        {
            get
            {
                return this.m_TotalPhysicalMemory;
            }
            set
            {
                this.m_TotalPhysicalMemory = value;
            }
        }
        
        public string UserName
        {
            get
            {
                return this.m_UserName;
            }
            set
            {
                this.m_UserName = value;
            }
        }
        
        public ushort WakeUpType
        {
            get
            {
                return this.m_WakeUpType;
            }
            set
            {
                this.m_WakeUpType = value;
            }
        }
        
        public string Workgroup
        {
            get
            {
                return this.m_Workgroup;
            }
            set
            {
                this.m_Workgroup = value;
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
            ManagementClass WMIClass = new ManagementClass("Win32_ComputerSystem");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetPowerState");
            InParams["PowerState"] = PowerState;
            InParams["Time"] = Time;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetPowerState", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Rename(string Name, string Password, string UserName)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_ComputerSystem");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("Rename");
            InParams["Name"] = Name;
            InParams["Password"] = Password;
            InParams["UserName"] = UserName;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Rename", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 JoinDomainOrWorkgroup(string AccountOU, uint FJoinOptions, string Name, string Password, string UserName)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_ComputerSystem");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("JoinDomainOrWorkgroup");
            InParams["AccountOU"] = AccountOU;
            InParams["FJoinOptions"] = FJoinOptions;
            InParams["Name"] = Name;
            InParams["Password"] = Password;
            InParams["UserName"] = UserName;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "JoinDomainOrWorkgroup", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 UnjoinDomainOrWorkgroup(uint FUnjoinOptions, string Password, string UserName)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_ComputerSystem");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("UnjoinDomainOrWorkgroup");
            InParams["FUnjoinOptions"] = FUnjoinOptions;
            InParams["Password"] = Password;
            InParams["UserName"] = UserName;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "UnjoinDomainOrWorkgroup", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
    }
}
