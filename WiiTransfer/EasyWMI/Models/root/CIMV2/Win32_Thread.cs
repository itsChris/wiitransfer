using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_Thread : WMIBase
    {
        
        private string m_Caption;
        
        private string m_CreationClassName;
        
        private string m_CSCreationClassName;
        
        private string m_CSName;
        
        private string m_Description;
        
        private ulong m_ElapsedTime;
        
        private ushort m_ExecutionState;
        
        private string m_Handle;
        
        private string m_InstallDate;
        
        private ulong m_KernelModeTime;
        
        private string m_Name;
        
        private string m_OSCreationClassName;
        
        private string m_OSName;
        
        private uint m_Priority;
        
        private uint m_PriorityBase;
        
        private string m_ProcessCreationClassName;
        
        private string m_ProcessHandle;
        
        private uint m_StartAddress;
        
        private string m_Status;
        
        private uint m_ThreadState;
        
        private uint m_ThreadWaitReason;
        
        private ulong m_UserModeTime;
        
        private string m_MyPath;
        
        public Win32_Thread()
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
        
        public ulong ElapsedTime
        {
            get
            {
                return this.m_ElapsedTime;
            }
            set
            {
                this.m_ElapsedTime = value;
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
        
        public uint PriorityBase
        {
            get
            {
                return this.m_PriorityBase;
            }
            set
            {
                this.m_PriorityBase = value;
            }
        }
        
        public string ProcessCreationClassName
        {
            get
            {
                return this.m_ProcessCreationClassName;
            }
            set
            {
                this.m_ProcessCreationClassName = value;
            }
        }
        
        public string ProcessHandle
        {
            get
            {
                return this.m_ProcessHandle;
            }
            set
            {
                this.m_ProcessHandle = value;
            }
        }
        
        public uint StartAddress
        {
            get
            {
                return this.m_StartAddress;
            }
            set
            {
                this.m_StartAddress = value;
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
        
        public uint ThreadState
        {
            get
            {
                return this.m_ThreadState;
            }
            set
            {
                this.m_ThreadState = value;
            }
        }
        
        public uint ThreadWaitReason
        {
            get
            {
                return this.m_ThreadWaitReason;
            }
            set
            {
                this.m_ThreadWaitReason = value;
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
    }
}
