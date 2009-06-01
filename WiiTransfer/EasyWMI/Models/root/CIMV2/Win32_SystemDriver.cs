using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_SystemDriver : WMIBase
    {
        
        private bool m_AcceptPause;
        
        private bool m_AcceptStop;
        
        private string m_Caption;
        
        private string m_CreationClassName;
        
        private string m_Description;
        
        private bool m_DesktopInteract;
        
        private string m_DisplayName;
        
        private string m_ErrorControl;
        
        private uint m_ExitCode;
        
        private string m_InstallDate;
        
        private string m_Name;
        
        private string m_PathName;
        
        private uint m_ServiceSpecificExitCode;
        
        private string m_ServiceType;
        
        private bool m_Started;
        
        private string m_StartMode;
        
        private string m_StartName;
        
        private string m_State;
        
        private string m_Status;
        
        private string m_SystemCreationClassName;
        
        private string m_SystemName;
        
        private uint m_TagId;
        
        private string m_MyPath;
        
        public Win32_SystemDriver()
        {
        }
        
        public bool AcceptPause
        {
            get
            {
                return this.m_AcceptPause;
            }
            set
            {
                this.m_AcceptPause = value;
            }
        }
        
        public bool AcceptStop
        {
            get
            {
                return this.m_AcceptStop;
            }
            set
            {
                this.m_AcceptStop = value;
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
        
        public bool DesktopInteract
        {
            get
            {
                return this.m_DesktopInteract;
            }
            set
            {
                this.m_DesktopInteract = value;
            }
        }
        
        public string DisplayName
        {
            get
            {
                return this.m_DisplayName;
            }
            set
            {
                this.m_DisplayName = value;
            }
        }
        
        public string ErrorControl
        {
            get
            {
                return this.m_ErrorControl;
            }
            set
            {
                this.m_ErrorControl = value;
            }
        }
        
        public uint ExitCode
        {
            get
            {
                return this.m_ExitCode;
            }
            set
            {
                this.m_ExitCode = value;
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
        
        public string PathName
        {
            get
            {
                return this.m_PathName;
            }
            set
            {
                this.m_PathName = value;
            }
        }
        
        public uint ServiceSpecificExitCode
        {
            get
            {
                return this.m_ServiceSpecificExitCode;
            }
            set
            {
                this.m_ServiceSpecificExitCode = value;
            }
        }
        
        public string ServiceType
        {
            get
            {
                return this.m_ServiceType;
            }
            set
            {
                this.m_ServiceType = value;
            }
        }
        
        public bool Started
        {
            get
            {
                return this.m_Started;
            }
            set
            {
                this.m_Started = value;
            }
        }
        
        public string StartMode
        {
            get
            {
                return this.m_StartMode;
            }
            set
            {
                this.m_StartMode = value;
            }
        }
        
        public string StartName
        {
            get
            {
                return this.m_StartName;
            }
            set
            {
                this.m_StartName = value;
            }
        }
        
        public string State
        {
            get
            {
                return this.m_State;
            }
            set
            {
                this.m_State = value;
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
        
        public uint TagId
        {
            get
            {
                return this.m_TagId;
            }
            set
            {
                this.m_TagId = value;
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
        
        public Int32 StartService()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "StartService", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 StopService()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "StopService", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 PauseService()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "PauseService", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 ResumeService()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "ResumeService", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 InterrogateService()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "InterrogateService", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 UserControlService(UInt16 ControlCode)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_SystemDriver");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("UserControlService");
InParams["ControlCode"] = ControlCode;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "UserControlService", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Create(bool DesktopInteract, string DisplayName, UInt16 ErrorControl, string LoadOrderGroup, string [] LoadOrderGroupDependencies, string Name, string PathName, string [] ServiceDependencies, UInt16 ServiceType, string StartMode, string StartName, string StartPassword)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_SystemDriver");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("Create");
InParams["DesktopInteract"] = DesktopInteract;
InParams["DisplayName"] = DisplayName;
InParams["ErrorControl"] = ErrorControl;
InParams["LoadOrderGroup"] = LoadOrderGroup;
InParams["LoadOrderGroupDependencies"] = LoadOrderGroupDependencies;
InParams["Name"] = Name;
InParams["PathName"] = PathName;
InParams["ServiceDependencies"] = ServiceDependencies;
InParams["ServiceType"] = ServiceType;
InParams["StartMode"] = StartMode;
InParams["StartName"] = StartName;
InParams["StartPassword"] = StartPassword;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Create", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Change(bool DesktopInteract, string DisplayName, UInt16 ErrorControl, string LoadOrderGroup, string [] LoadOrderGroupDependencies, string PathName, string [] ServiceDependencies, UInt16 ServiceType, string StartMode, string StartName, string StartPassword)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_SystemDriver");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("Change");
InParams["DesktopInteract"] = DesktopInteract;
InParams["DisplayName"] = DisplayName;
InParams["ErrorControl"] = ErrorControl;
InParams["LoadOrderGroup"] = LoadOrderGroup;
InParams["LoadOrderGroupDependencies"] = LoadOrderGroupDependencies;
InParams["PathName"] = PathName;
InParams["ServiceDependencies"] = ServiceDependencies;
InParams["ServiceType"] = ServiceType;
InParams["StartMode"] = StartMode;
InParams["StartName"] = StartName;
InParams["StartPassword"] = StartPassword;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Change", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 ChangeStartMode(string StartMode)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_SystemDriver");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("ChangeStartMode");
InParams["StartMode"] = StartMode;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "ChangeStartMode", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Delete()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Delete", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
    }
}
