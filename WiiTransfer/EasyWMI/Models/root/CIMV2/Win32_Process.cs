using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_Process : WMIBase
    {
        
        private string m_Caption;
        
        private string m_CommandLine;
        
        private string m_CreationClassName;
        
        private string m_CreationDate;
        
        private string m_CSCreationClassName;
        
        private string m_CSName;
        
        private string m_Description;
        
        private string m_ExecutablePath;
        
        private ushort m_ExecutionState;
        
        private string m_Handle;
        
        private uint m_HandleCount;
        
        private string m_InstallDate;
        
        private ulong m_KernelModeTime;
        
        private uint m_MaximumWorkingSetSize;
        
        private uint m_MinimumWorkingSetSize;
        
        private string m_Name;
        
        private string m_OSCreationClassName;
        
        private string m_OSName;
        
        private ulong m_OtherOperationCount;
        
        private ulong m_OtherTransferCount;
        
        private uint m_PageFaults;
        
        private uint m_PageFileUsage;
        
        private uint m_ParentProcessId;
        
        private uint m_PeakPageFileUsage;
        
        private ulong m_PeakVirtualSize;
        
        private uint m_PeakWorkingSetSize;
        
        private uint m_Priority;
        
        private ulong m_PrivatePageCount;
        
        private uint m_ProcessId;
        
        private uint m_QuotaNonPagedPoolUsage;
        
        private uint m_QuotaPagedPoolUsage;
        
        private uint m_QuotaPeakNonPagedPoolUsage;
        
        private uint m_QuotaPeakPagedPoolUsage;
        
        private ulong m_ReadOperationCount;
        
        private ulong m_ReadTransferCount;
        
        private uint m_SessionId;
        
        private string m_Status;
        
        private string m_TerminationDate;
        
        private uint m_ThreadCount;
        
        private ulong m_UserModeTime;
        
        private ulong m_VirtualSize;
        
        private string m_WindowsVersion;
        
        private ulong m_WorkingSetSize;
        
        private ulong m_WriteOperationCount;
        
        private ulong m_WriteTransferCount;
        
        private string m_MyPath;
        
        public Win32_Process()
        {
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
        
        public string CommandLine
        {
            get
            {
                return this.m_CommandLine;
            }
            set
            {
                this.m_CommandLine = value;
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
        
        public string CreationDate
        {
            get
            {
                return this.m_CreationDate;
            }
            set
            {
                this.m_CreationDate = value;
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
        
        public string ExecutablePath
        {
            get
            {
                return this.m_ExecutablePath;
            }
            set
            {
                this.m_ExecutablePath = value;
            }
        }
        
        public ushort ExecutionState
        {
            get
            {
                return this.m_ExecutionState;
            }
            set
            {
                this.m_ExecutionState = value;
            }
        }
        
        public string Handle
        {
            get
            {
                return this.m_Handle;
            }
            set
            {
                this.m_Handle = value;
            }
        }
        
        public uint HandleCount
        {
            get
            {
                return this.m_HandleCount;
            }
            set
            {
                this.m_HandleCount = value;
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
        
        public ulong KernelModeTime
        {
            get
            {
                return this.m_KernelModeTime;
            }
            set
            {
                this.m_KernelModeTime = value;
            }
        }
        
        public uint MaximumWorkingSetSize
        {
            get
            {
                return this.m_MaximumWorkingSetSize;
            }
            set
            {
                this.m_MaximumWorkingSetSize = value;
            }
        }
        
        public uint MinimumWorkingSetSize
        {
            get
            {
                return this.m_MinimumWorkingSetSize;
            }
            set
            {
                this.m_MinimumWorkingSetSize = value;
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
        
        public string OSCreationClassName
        {
            get
            {
                return this.m_OSCreationClassName;
            }
            set
            {
                this.m_OSCreationClassName = value;
            }
        }
        
        public string OSName
        {
            get
            {
                return this.m_OSName;
            }
            set
            {
                this.m_OSName = value;
            }
        }
        
        public ulong OtherOperationCount
        {
            get
            {
                return this.m_OtherOperationCount;
            }
            set
            {
                this.m_OtherOperationCount = value;
            }
        }
        
        public ulong OtherTransferCount
        {
            get
            {
                return this.m_OtherTransferCount;
            }
            set
            {
                this.m_OtherTransferCount = value;
            }
        }
        
        public uint PageFaults
        {
            get
            {
                return this.m_PageFaults;
            }
            set
            {
                this.m_PageFaults = value;
            }
        }
        
        public uint PageFileUsage
        {
            get
            {
                return this.m_PageFileUsage;
            }
            set
            {
                this.m_PageFileUsage = value;
            }
        }
        
        public uint ParentProcessId
        {
            get
            {
                return this.m_ParentProcessId;
            }
            set
            {
                this.m_ParentProcessId = value;
            }
        }
        
        public uint PeakPageFileUsage
        {
            get
            {
                return this.m_PeakPageFileUsage;
            }
            set
            {
                this.m_PeakPageFileUsage = value;
            }
        }
        
        public ulong PeakVirtualSize
        {
            get
            {
                return this.m_PeakVirtualSize;
            }
            set
            {
                this.m_PeakVirtualSize = value;
            }
        }
        
        public uint PeakWorkingSetSize
        {
            get
            {
                return this.m_PeakWorkingSetSize;
            }
            set
            {
                this.m_PeakWorkingSetSize = value;
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
        
        public ulong PrivatePageCount
        {
            get
            {
                return this.m_PrivatePageCount;
            }
            set
            {
                this.m_PrivatePageCount = value;
            }
        }
        
        public uint ProcessId
        {
            get
            {
                return this.m_ProcessId;
            }
            set
            {
                this.m_ProcessId = value;
            }
        }
        
        public uint QuotaNonPagedPoolUsage
        {
            get
            {
                return this.m_QuotaNonPagedPoolUsage;
            }
            set
            {
                this.m_QuotaNonPagedPoolUsage = value;
            }
        }
        
        public uint QuotaPagedPoolUsage
        {
            get
            {
                return this.m_QuotaPagedPoolUsage;
            }
            set
            {
                this.m_QuotaPagedPoolUsage = value;
            }
        }
        
        public uint QuotaPeakNonPagedPoolUsage
        {
            get
            {
                return this.m_QuotaPeakNonPagedPoolUsage;
            }
            set
            {
                this.m_QuotaPeakNonPagedPoolUsage = value;
            }
        }
        
        public uint QuotaPeakPagedPoolUsage
        {
            get
            {
                return this.m_QuotaPeakPagedPoolUsage;
            }
            set
            {
                this.m_QuotaPeakPagedPoolUsage = value;
            }
        }
        
        public ulong ReadOperationCount
        {
            get
            {
                return this.m_ReadOperationCount;
            }
            set
            {
                this.m_ReadOperationCount = value;
            }
        }
        
        public ulong ReadTransferCount
        {
            get
            {
                return this.m_ReadTransferCount;
            }
            set
            {
                this.m_ReadTransferCount = value;
            }
        }
        
        public uint SessionId
        {
            get
            {
                return this.m_SessionId;
            }
            set
            {
                this.m_SessionId = value;
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
        
        public string TerminationDate
        {
            get
            {
                return this.m_TerminationDate;
            }
            set
            {
                this.m_TerminationDate = value;
            }
        }
        
        public uint ThreadCount
        {
            get
            {
                return this.m_ThreadCount;
            }
            set
            {
                this.m_ThreadCount = value;
            }
        }
        
        public ulong UserModeTime
        {
            get
            {
                return this.m_UserModeTime;
            }
            set
            {
                this.m_UserModeTime = value;
            }
        }
        
        public ulong VirtualSize
        {
            get
            {
                return this.m_VirtualSize;
            }
            set
            {
                this.m_VirtualSize = value;
            }
        }
        
        public string WindowsVersion
        {
            get
            {
                return this.m_WindowsVersion;
            }
            set
            {
                this.m_WindowsVersion = value;
            }
        }
        
        public ulong WorkingSetSize
        {
            get
            {
                return this.m_WorkingSetSize;
            }
            set
            {
                this.m_WorkingSetSize = value;
            }
        }
        
        public ulong WriteOperationCount
        {
            get
            {
                return this.m_WriteOperationCount;
            }
            set
            {
                this.m_WriteOperationCount = value;
            }
        }
        
        public ulong WriteTransferCount
        {
            get
            {
                return this.m_WriteTransferCount;
            }
            set
            {
                this.m_WriteTransferCount = value;
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
        
        public Int32 Create(string CommandLine, string CurrentDirectory, object ProcessStartupInformation, out uint ProcessId)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_Process");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("Create");
InParams["CommandLine"] = CommandLine;
InParams["CurrentDirectory"] = CurrentDirectory;
InParams["ProcessStartupInformation"] = ProcessStartupInformation;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Create", InParams, Options);
ProcessId = (UInt32)OutParams["ProcessId"];

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Terminate(uint Reason)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_Process");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("Terminate");
InParams["Reason"] = Reason;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Terminate", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 GetOwner(out string Domain, out string User)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "GetOwner", InParams, Options);
Domain = (String)OutParams["Domain"];
User = (String)OutParams["User"];

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 GetOwnerSid(out string Sid)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "GetOwnerSid", InParams, Options);
Sid = (String)OutParams["Sid"];

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetPriority(int Priority)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_Process");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetPriority");
InParams["Priority"] = Priority;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetPriority", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 AttachDebugger()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "AttachDebugger", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
    }
}
