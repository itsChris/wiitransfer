using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_VideoController : WMIBase
    {
        
        private ushort [] m_AcceleratorCapabilities;
        
        private string m_AdapterCompatibility;
        
        private string m_AdapterDACType;
        
        private uint m_AdapterRAM;
        
        private ushort m_Availability;
        
        private string [] m_CapabilityDescriptions;
        
        private string m_Caption;
        
        private uint m_ColorTableEntries;
        
        private uint m_ConfigManagerErrorCode;
        
        private bool m_ConfigManagerUserConfig;
        
        private string m_CreationClassName;
        
        private uint m_CurrentBitsPerPixel;
        
        private uint m_CurrentHorizontalResolution;
        
        private ulong m_CurrentNumberOfColors;
        
        private uint m_CurrentNumberOfColumns;
        
        private uint m_CurrentNumberOfRows;
        
        private uint m_CurrentRefreshRate;
        
        private ushort m_CurrentScanMode;
        
        private uint m_CurrentVerticalResolution;
        
        private string m_Description;
        
        private string m_DeviceID;
        
        private uint m_DeviceSpecificPens;
        
        private uint m_DitherType;
        
        private string m_DriverDate;
        
        private string m_DriverVersion;
        
        private bool m_ErrorCleared;
        
        private string m_ErrorDescription;
        
        private uint m_ICMIntent;
        
        private uint m_ICMMethod;
        
        private string m_InfFilename;
        
        private string m_InfSection;
        
        private string m_InstallDate;
        
        private string m_InstalledDisplayDrivers;
        
        private uint m_LastErrorCode;
        
        private uint m_MaxMemorySupported;
        
        private uint m_MaxNumberControlled;
        
        private uint m_MaxRefreshRate;
        
        private uint m_MinRefreshRate;
        
        private bool m_Monochrome;
        
        private string m_Name;
        
        private ushort m_NumberOfColorPlanes;
        
        private uint m_NumberOfVideoPages;
        
        private string m_PNPDeviceID;
        
        private ushort [] m_PowerManagementCapabilities;
        
        private bool m_PowerManagementSupported;
        
        private ushort m_ProtocolSupported;
        
        private uint m_ReservedSystemPaletteEntries;
        
        private uint m_SpecificationVersion;
        
        private string m_Status;
        
        private ushort m_StatusInfo;
        
        private string m_SystemCreationClassName;
        
        private string m_SystemName;
        
        private uint m_SystemPaletteEntries;
        
        private string m_TimeOfLastReset;
        
        private ushort m_VideoArchitecture;
        
        private ushort m_VideoMemoryType;
        
        private ushort m_VideoMode;
        
        private string m_VideoModeDescription;
        
        private string m_VideoProcessor;
        
        private string m_MyPath;
        
        public Win32_VideoController()
        {
        }
        
        public ushort [] AcceleratorCapabilities
        {
            get
            {
                return this.m_AcceleratorCapabilities;
            }
            set
            {
                this.m_AcceleratorCapabilities = value;
            }
        }
        
        public string AdapterCompatibility
        {
            get
            {
                return this.m_AdapterCompatibility;
            }
            set
            {
                this.m_AdapterCompatibility = value;
            }
        }
        
        public string AdapterDACType
        {
            get
            {
                return this.m_AdapterDACType;
            }
            set
            {
                this.m_AdapterDACType = value;
            }
        }
        
        public uint AdapterRAM
        {
            get
            {
                return this.m_AdapterRAM;
            }
            set
            {
                this.m_AdapterRAM = value;
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
        
        public uint ColorTableEntries
        {
            get
            {
                return this.m_ColorTableEntries;
            }
            set
            {
                this.m_ColorTableEntries = value;
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
        
        public uint CurrentBitsPerPixel
        {
            get
            {
                return this.m_CurrentBitsPerPixel;
            }
            set
            {
                this.m_CurrentBitsPerPixel = value;
            }
        }
        
        public uint CurrentHorizontalResolution
        {
            get
            {
                return this.m_CurrentHorizontalResolution;
            }
            set
            {
                this.m_CurrentHorizontalResolution = value;
            }
        }
        
        public ulong CurrentNumberOfColors
        {
            get
            {
                return this.m_CurrentNumberOfColors;
            }
            set
            {
                this.m_CurrentNumberOfColors = value;
            }
        }
        
        public uint CurrentNumberOfColumns
        {
            get
            {
                return this.m_CurrentNumberOfColumns;
            }
            set
            {
                this.m_CurrentNumberOfColumns = value;
            }
        }
        
        public uint CurrentNumberOfRows
        {
            get
            {
                return this.m_CurrentNumberOfRows;
            }
            set
            {
                this.m_CurrentNumberOfRows = value;
            }
        }
        
        public uint CurrentRefreshRate
        {
            get
            {
                return this.m_CurrentRefreshRate;
            }
            set
            {
                this.m_CurrentRefreshRate = value;
            }
        }
        
        public ushort CurrentScanMode
        {
            get
            {
                return this.m_CurrentScanMode;
            }
            set
            {
                this.m_CurrentScanMode = value;
            }
        }
        
        public uint CurrentVerticalResolution
        {
            get
            {
                return this.m_CurrentVerticalResolution;
            }
            set
            {
                this.m_CurrentVerticalResolution = value;
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
        
        public uint DeviceSpecificPens
        {
            get
            {
                return this.m_DeviceSpecificPens;
            }
            set
            {
                this.m_DeviceSpecificPens = value;
            }
        }
        
        public uint DitherType
        {
            get
            {
                return this.m_DitherType;
            }
            set
            {
                this.m_DitherType = value;
            }
        }
        
        public string DriverDate
        {
            get
            {
                return this.m_DriverDate;
            }
            set
            {
                this.m_DriverDate = value;
            }
        }
        
        public string DriverVersion
        {
            get
            {
                return this.m_DriverVersion;
            }
            set
            {
                this.m_DriverVersion = value;
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
        
        public uint ICMIntent
        {
            get
            {
                return this.m_ICMIntent;
            }
            set
            {
                this.m_ICMIntent = value;
            }
        }
        
        public uint ICMMethod
        {
            get
            {
                return this.m_ICMMethod;
            }
            set
            {
                this.m_ICMMethod = value;
            }
        }
        
        public string InfFilename
        {
            get
            {
                return this.m_InfFilename;
            }
            set
            {
                this.m_InfFilename = value;
            }
        }
        
        public string InfSection
        {
            get
            {
                return this.m_InfSection;
            }
            set
            {
                this.m_InfSection = value;
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
        
        public string InstalledDisplayDrivers
        {
            get
            {
                return this.m_InstalledDisplayDrivers;
            }
            set
            {
                this.m_InstalledDisplayDrivers = value;
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
        
        public uint MaxMemorySupported
        {
            get
            {
                return this.m_MaxMemorySupported;
            }
            set
            {
                this.m_MaxMemorySupported = value;
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
        
        public uint MaxRefreshRate
        {
            get
            {
                return this.m_MaxRefreshRate;
            }
            set
            {
                this.m_MaxRefreshRate = value;
            }
        }
        
        public uint MinRefreshRate
        {
            get
            {
                return this.m_MinRefreshRate;
            }
            set
            {
                this.m_MinRefreshRate = value;
            }
        }
        
        public bool Monochrome
        {
            get
            {
                return this.m_Monochrome;
            }
            set
            {
                this.m_Monochrome = value;
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
        
        public ushort NumberOfColorPlanes
        {
            get
            {
                return this.m_NumberOfColorPlanes;
            }
            set
            {
                this.m_NumberOfColorPlanes = value;
            }
        }
        
        public uint NumberOfVideoPages
        {
            get
            {
                return this.m_NumberOfVideoPages;
            }
            set
            {
                this.m_NumberOfVideoPages = value;
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
        
        public uint ReservedSystemPaletteEntries
        {
            get
            {
                return this.m_ReservedSystemPaletteEntries;
            }
            set
            {
                this.m_ReservedSystemPaletteEntries = value;
            }
        }
        
        public uint SpecificationVersion
        {
            get
            {
                return this.m_SpecificationVersion;
            }
            set
            {
                this.m_SpecificationVersion = value;
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
        
        public uint SystemPaletteEntries
        {
            get
            {
                return this.m_SystemPaletteEntries;
            }
            set
            {
                this.m_SystemPaletteEntries = value;
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
        
        public ushort VideoArchitecture
        {
            get
            {
                return this.m_VideoArchitecture;
            }
            set
            {
                this.m_VideoArchitecture = value;
            }
        }
        
        public ushort VideoMemoryType
        {
            get
            {
                return this.m_VideoMemoryType;
            }
            set
            {
                this.m_VideoMemoryType = value;
            }
        }
        
        public ushort VideoMode
        {
            get
            {
                return this.m_VideoMode;
            }
            set
            {
                this.m_VideoMode = value;
            }
        }
        
        public string VideoModeDescription
        {
            get
            {
                return this.m_VideoModeDescription;
            }
            set
            {
                this.m_VideoModeDescription = value;
            }
        }
        
        public string VideoProcessor
        {
            get
            {
                return this.m_VideoProcessor;
            }
            set
            {
                this.m_VideoProcessor = value;
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
            ManagementClass WMIClass = new ManagementClass("Win32_VideoController");
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
