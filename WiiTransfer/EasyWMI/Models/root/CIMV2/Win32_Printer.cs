using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_Printer : WMIBase
    {
        
        private uint m_Attributes;
        
        private ushort m_Availability;
        
        private string [] m_AvailableJobSheets;
        
        private uint m_AveragePagesPerMinute;
        
        private ushort [] m_Capabilities;
        
        private string [] m_CapabilityDescriptions;
        
        private string m_Caption;
        
        private string [] m_CharSetsSupported;
        
        private string m_Comment;
        
        private uint m_ConfigManagerErrorCode;
        
        private bool m_ConfigManagerUserConfig;
        
        private string m_CreationClassName;
        
        private ushort [] m_CurrentCapabilities;
        
        private string m_CurrentCharSet;
        
        private ushort m_CurrentLanguage;
        
        private string m_CurrentMimeType;
        
        private string m_CurrentNaturalLanguage;
        
        private string m_CurrentPaperType;
        
        private bool m_Default;
        
        private ushort [] m_DefaultCapabilities;
        
        private uint m_DefaultCopies;
        
        private ushort m_DefaultLanguage;
        
        private string m_DefaultMimeType;
        
        private uint m_DefaultNumberUp;
        
        private string m_DefaultPaperType;
        
        private uint m_DefaultPriority;
        
        private string m_Description;
        
        private ushort m_DetectedErrorState;
        
        private string m_DeviceID;
        
        private bool m_Direct;
        
        private bool m_DoCompleteFirst;
        
        private string m_DriverName;
        
        private bool m_EnableBIDI;
        
        private bool m_EnableDevQueryPrint;
        
        private bool m_ErrorCleared;
        
        private string m_ErrorDescription;
        
        private string [] m_ErrorInformation;
        
        private ushort m_ExtendedDetectedErrorState;
        
        private ushort m_ExtendedPrinterStatus;
        
        private bool m_Hidden;
        
        private uint m_HorizontalResolution;
        
        private string m_InstallDate;
        
        private uint m_JobCountSinceLastReset;
        
        private bool m_KeepPrintedJobs;
        
        private ushort [] m_LanguagesSupported;
        
        private uint m_LastErrorCode;
        
        private bool m_Local;
        
        private string m_Location;
        
        private ushort m_MarkingTechnology;
        
        private uint m_MaxCopies;
        
        private uint m_MaxNumberUp;
        
        private uint m_MaxSizeSupported;
        
        private string [] m_MimeTypesSupported;
        
        private string m_Name;
        
        private string [] m_NaturalLanguagesSupported;
        
        private bool m_Network;
        
        private ushort [] m_PaperSizesSupported;
        
        private string [] m_PaperTypesAvailable;
        
        private string m_Parameters;
        
        private string m_PNPDeviceID;
        
        private string m_PortName;
        
        private ushort [] m_PowerManagementCapabilities;
        
        private bool m_PowerManagementSupported;
        
        private string [] m_PrinterPaperNames;
        
        private uint m_PrinterState;
        
        private ushort m_PrinterStatus;
        
        private string m_PrintJobDataType;
        
        private string m_PrintProcessor;
        
        private uint m_Priority;
        
        private bool m_Published;
        
        private bool m_Queued;
        
        private bool m_RawOnly;
        
        private string m_SeparatorFile;
        
        private string m_ServerName;
        
        private bool m_Shared;
        
        private string m_ShareName;
        
        private bool m_SpoolEnabled;
        
        private string m_StartTime;
        
        private string m_Status;
        
        private ushort m_StatusInfo;
        
        private string m_SystemCreationClassName;
        
        private string m_SystemName;
        
        private string m_TimeOfLastReset;
        
        private string m_UntilTime;
        
        private uint m_VerticalResolution;
        
        private bool m_WorkOffline;
        
        private string m_MyPath;
        
        public Win32_Printer()
        {
        }
        
        public uint Attributes
        {
            get
            {
                return this.m_Attributes;
            }
            set
            {
                this.m_Attributes = value;
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
        
        public string [] AvailableJobSheets
        {
            get
            {
                return this.m_AvailableJobSheets;
            }
            set
            {
                this.m_AvailableJobSheets = value;
            }
        }
        
        public uint AveragePagesPerMinute
        {
            get
            {
                return this.m_AveragePagesPerMinute;
            }
            set
            {
                this.m_AveragePagesPerMinute = value;
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
        
        public string [] CharSetsSupported
        {
            get
            {
                return this.m_CharSetsSupported;
            }
            set
            {
                this.m_CharSetsSupported = value;
            }
        }
        
        public string Comment
        {
            get
            {
                return this.m_Comment;
            }
            set
            {
                this.m_Comment = value;
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
        
        public ushort [] CurrentCapabilities
        {
            get
            {
                return this.m_CurrentCapabilities;
            }
            set
            {
                this.m_CurrentCapabilities = value;
            }
        }
        
        public string CurrentCharSet
        {
            get
            {
                return this.m_CurrentCharSet;
            }
            set
            {
                this.m_CurrentCharSet = value;
            }
        }
        
        public ushort CurrentLanguage
        {
            get
            {
                return this.m_CurrentLanguage;
            }
            set
            {
                this.m_CurrentLanguage = value;
            }
        }
        
        public string CurrentMimeType
        {
            get
            {
                return this.m_CurrentMimeType;
            }
            set
            {
                this.m_CurrentMimeType = value;
            }
        }
        
        public string CurrentNaturalLanguage
        {
            get
            {
                return this.m_CurrentNaturalLanguage;
            }
            set
            {
                this.m_CurrentNaturalLanguage = value;
            }
        }
        
        public string CurrentPaperType
        {
            get
            {
                return this.m_CurrentPaperType;
            }
            set
            {
                this.m_CurrentPaperType = value;
            }
        }
        
        public bool Default
        {
            get
            {
                return this.m_Default;
            }
            set
            {
                this.m_Default = value;
            }
        }
        
        public ushort [] DefaultCapabilities
        {
            get
            {
                return this.m_DefaultCapabilities;
            }
            set
            {
                this.m_DefaultCapabilities = value;
            }
        }
        
        public uint DefaultCopies
        {
            get
            {
                return this.m_DefaultCopies;
            }
            set
            {
                this.m_DefaultCopies = value;
            }
        }
        
        public ushort DefaultLanguage
        {
            get
            {
                return this.m_DefaultLanguage;
            }
            set
            {
                this.m_DefaultLanguage = value;
            }
        }
        
        public string DefaultMimeType
        {
            get
            {
                return this.m_DefaultMimeType;
            }
            set
            {
                this.m_DefaultMimeType = value;
            }
        }
        
        public uint DefaultNumberUp
        {
            get
            {
                return this.m_DefaultNumberUp;
            }
            set
            {
                this.m_DefaultNumberUp = value;
            }
        }
        
        public string DefaultPaperType
        {
            get
            {
                return this.m_DefaultPaperType;
            }
            set
            {
                this.m_DefaultPaperType = value;
            }
        }
        
        public uint DefaultPriority
        {
            get
            {
                return this.m_DefaultPriority;
            }
            set
            {
                this.m_DefaultPriority = value;
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
        
        public ushort DetectedErrorState
        {
            get
            {
                return this.m_DetectedErrorState;
            }
            set
            {
                this.m_DetectedErrorState = value;
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
        
        public bool Direct
        {
            get
            {
                return this.m_Direct;
            }
            set
            {
                this.m_Direct = value;
            }
        }
        
        public bool DoCompleteFirst
        {
            get
            {
                return this.m_DoCompleteFirst;
            }
            set
            {
                this.m_DoCompleteFirst = value;
            }
        }
        
        public string DriverName
        {
            get
            {
                return this.m_DriverName;
            }
            set
            {
                this.m_DriverName = value;
            }
        }
        
        public bool EnableBIDI
        {
            get
            {
                return this.m_EnableBIDI;
            }
            set
            {
                this.m_EnableBIDI = value;
            }
        }
        
        public bool EnableDevQueryPrint
        {
            get
            {
                return this.m_EnableDevQueryPrint;
            }
            set
            {
                this.m_EnableDevQueryPrint = value;
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
        
        public string [] ErrorInformation
        {
            get
            {
                return this.m_ErrorInformation;
            }
            set
            {
                this.m_ErrorInformation = value;
            }
        }
        
        public ushort ExtendedDetectedErrorState
        {
            get
            {
                return this.m_ExtendedDetectedErrorState;
            }
            set
            {
                this.m_ExtendedDetectedErrorState = value;
            }
        }
        
        public ushort ExtendedPrinterStatus
        {
            get
            {
                return this.m_ExtendedPrinterStatus;
            }
            set
            {
                this.m_ExtendedPrinterStatus = value;
            }
        }
        
        public bool Hidden
        {
            get
            {
                return this.m_Hidden;
            }
            set
            {
                this.m_Hidden = value;
            }
        }
        
        public uint HorizontalResolution
        {
            get
            {
                return this.m_HorizontalResolution;
            }
            set
            {
                this.m_HorizontalResolution = value;
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
        
        public uint JobCountSinceLastReset
        {
            get
            {
                return this.m_JobCountSinceLastReset;
            }
            set
            {
                this.m_JobCountSinceLastReset = value;
            }
        }
        
        public bool KeepPrintedJobs
        {
            get
            {
                return this.m_KeepPrintedJobs;
            }
            set
            {
                this.m_KeepPrintedJobs = value;
            }
        }
        
        public ushort [] LanguagesSupported
        {
            get
            {
                return this.m_LanguagesSupported;
            }
            set
            {
                this.m_LanguagesSupported = value;
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
        
        public bool Local
        {
            get
            {
                return this.m_Local;
            }
            set
            {
                this.m_Local = value;
            }
        }
        
        public string Location
        {
            get
            {
                return this.m_Location;
            }
            set
            {
                this.m_Location = value;
            }
        }
        
        public ushort MarkingTechnology
        {
            get
            {
                return this.m_MarkingTechnology;
            }
            set
            {
                this.m_MarkingTechnology = value;
            }
        }
        
        public uint MaxCopies
        {
            get
            {
                return this.m_MaxCopies;
            }
            set
            {
                this.m_MaxCopies = value;
            }
        }
        
        public uint MaxNumberUp
        {
            get
            {
                return this.m_MaxNumberUp;
            }
            set
            {
                this.m_MaxNumberUp = value;
            }
        }
        
        public uint MaxSizeSupported
        {
            get
            {
                return this.m_MaxSizeSupported;
            }
            set
            {
                this.m_MaxSizeSupported = value;
            }
        }
        
        public string [] MimeTypesSupported
        {
            get
            {
                return this.m_MimeTypesSupported;
            }
            set
            {
                this.m_MimeTypesSupported = value;
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
        
        public string [] NaturalLanguagesSupported
        {
            get
            {
                return this.m_NaturalLanguagesSupported;
            }
            set
            {
                this.m_NaturalLanguagesSupported = value;
            }
        }
        
        public bool Network
        {
            get
            {
                return this.m_Network;
            }
            set
            {
                this.m_Network = value;
            }
        }
        
        public ushort [] PaperSizesSupported
        {
            get
            {
                return this.m_PaperSizesSupported;
            }
            set
            {
                this.m_PaperSizesSupported = value;
            }
        }
        
        public string [] PaperTypesAvailable
        {
            get
            {
                return this.m_PaperTypesAvailable;
            }
            set
            {
                this.m_PaperTypesAvailable = value;
            }
        }
        
        public string Parameters
        {
            get
            {
                return this.m_Parameters;
            }
            set
            {
                this.m_Parameters = value;
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
        
        public string PortName
        {
            get
            {
                return this.m_PortName;
            }
            set
            {
                this.m_PortName = value;
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
        
        public string [] PrinterPaperNames
        {
            get
            {
                return this.m_PrinterPaperNames;
            }
            set
            {
                this.m_PrinterPaperNames = value;
            }
        }
        
        public uint PrinterState
        {
            get
            {
                return this.m_PrinterState;
            }
            set
            {
                this.m_PrinterState = value;
            }
        }
        
        public ushort PrinterStatus
        {
            get
            {
                return this.m_PrinterStatus;
            }
            set
            {
                this.m_PrinterStatus = value;
            }
        }
        
        public string PrintJobDataType
        {
            get
            {
                return this.m_PrintJobDataType;
            }
            set
            {
                this.m_PrintJobDataType = value;
            }
        }
        
        public string PrintProcessor
        {
            get
            {
                return this.m_PrintProcessor;
            }
            set
            {
                this.m_PrintProcessor = value;
            }
        }
        
        public uint Priority
        {
            get
            {
                return this.m_Priority;
            }
            set
            {
                this.m_Priority = value;
            }
        }
        
        public bool Published
        {
            get
            {
                return this.m_Published;
            }
            set
            {
                this.m_Published = value;
            }
        }
        
        public bool Queued
        {
            get
            {
                return this.m_Queued;
            }
            set
            {
                this.m_Queued = value;
            }
        }
        
        public bool RawOnly
        {
            get
            {
                return this.m_RawOnly;
            }
            set
            {
                this.m_RawOnly = value;
            }
        }
        
        public string SeparatorFile
        {
            get
            {
                return this.m_SeparatorFile;
            }
            set
            {
                this.m_SeparatorFile = value;
            }
        }
        
        public string ServerName
        {
            get
            {
                return this.m_ServerName;
            }
            set
            {
                this.m_ServerName = value;
            }
        }
        
        public bool Shared
        {
            get
            {
                return this.m_Shared;
            }
            set
            {
                this.m_Shared = value;
            }
        }
        
        public string ShareName
        {
            get
            {
                return this.m_ShareName;
            }
            set
            {
                this.m_ShareName = value;
            }
        }
        
        public bool SpoolEnabled
        {
            get
            {
                return this.m_SpoolEnabled;
            }
            set
            {
                this.m_SpoolEnabled = value;
            }
        }
        
        public string StartTime
        {
            get
            {
                return this.m_StartTime;
            }
            set
            {
                this.m_StartTime = value;
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
        
        public string UntilTime
        {
            get
            {
                return this.m_UntilTime;
            }
            set
            {
                this.m_UntilTime = value;
            }
        }
        
        public uint VerticalResolution
        {
            get
            {
                return this.m_VerticalResolution;
            }
            set
            {
                this.m_VerticalResolution = value;
            }
        }
        
        public bool WorkOffline
        {
            get
            {
                return this.m_WorkOffline;
            }
            set
            {
                this.m_WorkOffline = value;
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
            ManagementClass WMIClass = new ManagementClass("Win32_Printer");
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
        
        public Int32 Pause()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Pause", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Resume()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Resume", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 CancelAllJobs()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "CancelAllJobs", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 AddPrinterConnection(string Name)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_Printer");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("AddPrinterConnection");
InParams["Name"] = Name;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "AddPrinterConnection", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 RenamePrinter(string NewPrinterName)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_Printer");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("RenamePrinter");
InParams["NewPrinterName"] = NewPrinterName;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "RenamePrinter", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 PrintTestPage()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "PrintTestPage", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetDefaultPrinter()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetDefaultPrinter", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 GetSecurityDescriptor(out object Descriptor)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "GetSecurityDescriptor", InParams, Options);
Descriptor = (Object)OutParams["Descriptor"];

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetSecurityDescriptor(object Descriptor)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_Printer");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetSecurityDescriptor");
InParams["Descriptor"] = Descriptor;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetSecurityDescriptor", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
    }
}
