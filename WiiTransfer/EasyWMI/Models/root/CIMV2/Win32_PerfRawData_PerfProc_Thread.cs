using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_PerfProc_Thread : WMIBase
    {
        
        private string m_Caption;
        
        private uint m_ContextSwitchesPersec;
        
        private string m_Description;
        
        private ulong m_ElapsedTime;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_IDProcess;
        
        private uint m_IDThread;
        
        private string m_Name;
        
        private ulong m_PercentPrivilegedTime;
        
        private ulong m_PercentProcessorTime;
        
        private ulong m_PercentUserTime;
        
        private uint m_PriorityBase;
        
        private uint m_PriorityCurrent;
        
        private uint m_StartAddress;
        
        private uint m_ThreadState;
        
        private uint m_ThreadWaitReason;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_PerfProc_Thread()
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
        
        public uint ContextSwitchesPersec
        {
            get
            {
                return this.m_ContextSwitchesPersec;
            }
            set
            {
                this.m_ContextSwitchesPersec = value;
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
        
        public ulong Frequency_Object
        {
            get
            {
                return this.m_Frequency_Object;
            }
            set
            {
                this.m_Frequency_Object = value;
            }
        }
        
        public ulong Frequency_PerfTime
        {
            get
            {
                return this.m_Frequency_PerfTime;
            }
            set
            {
                this.m_Frequency_PerfTime = value;
            }
        }
        
        public ulong Frequency_Sys100NS
        {
            get
            {
                return this.m_Frequency_Sys100NS;
            }
            set
            {
                this.m_Frequency_Sys100NS = value;
            }
        }
        
        public uint IDProcess
        {
            get
            {
                return this.m_IDProcess;
            }
            set
            {
                this.m_IDProcess = value;
            }
        }
        
        public uint IDThread
        {
            get
            {
                return this.m_IDThread;
            }
            set
            {
                this.m_IDThread = value;
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
        
        public ulong PercentPrivilegedTime
        {
            get
            {
                return this.m_PercentPrivilegedTime;
            }
            set
            {
                this.m_PercentPrivilegedTime = value;
            }
        }
        
        public ulong PercentProcessorTime
        {
            get
            {
                return this.m_PercentProcessorTime;
            }
            set
            {
                this.m_PercentProcessorTime = value;
            }
        }
        
        public ulong PercentUserTime
        {
            get
            {
                return this.m_PercentUserTime;
            }
            set
            {
                this.m_PercentUserTime = value;
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
        
        public uint PriorityCurrent
        {
            get
            {
                return this.m_PriorityCurrent;
            }
            set
            {
                this.m_PriorityCurrent = value;
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
        
        public ulong Timestamp_Object
        {
            get
            {
                return this.m_Timestamp_Object;
            }
            set
            {
                this.m_Timestamp_Object = value;
            }
        }
        
        public ulong Timestamp_PerfTime
        {
            get
            {
                return this.m_Timestamp_PerfTime;
            }
            set
            {
                this.m_Timestamp_PerfTime = value;
            }
        }
        
        public ulong Timestamp_Sys100NS
        {
            get
            {
                return this.m_Timestamp_Sys100NS;
            }
            set
            {
                this.m_Timestamp_Sys100NS = value;
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
