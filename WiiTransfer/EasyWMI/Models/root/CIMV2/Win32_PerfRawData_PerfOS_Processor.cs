using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_PerfOS_Processor : WMIBase
    {
        
        private ulong m_C1TransitionsPersec;
        
        private ulong m_C2TransitionsPersec;
        
        private ulong m_C3TransitionsPersec;
        
        private string m_Caption;
        
        private string m_Description;
        
        private uint m_DPCRate;
        
        private uint m_DPCsQueuedPersec;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_InterruptsPersec;
        
        private string m_Name;
        
        private ulong m_PercentC1Time;
        
        private ulong m_PercentC2Time;
        
        private ulong m_PercentC3Time;
        
        private ulong m_PercentDPCTime;
        
        private ulong m_PercentIdleTime;
        
        private ulong m_PercentInterruptTime;
        
        private ulong m_PercentPrivilegedTime;
        
        private ulong m_PercentProcessorTime;
        
        private ulong m_PercentUserTime;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_PerfOS_Processor()
        {
        }
        
        public ulong C1TransitionsPersec
        {
            get
            {
                return this.m_C1TransitionsPersec;
            }
            set
            {
                this.m_C1TransitionsPersec = value;
            }
        }
        
        public ulong C2TransitionsPersec
        {
            get
            {
                return this.m_C2TransitionsPersec;
            }
            set
            {
                this.m_C2TransitionsPersec = value;
            }
        }
        
        public ulong C3TransitionsPersec
        {
            get
            {
                return this.m_C3TransitionsPersec;
            }
            set
            {
                this.m_C3TransitionsPersec = value;
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
        
        public uint DPCRate
        {
            get
            {
                return this.m_DPCRate;
            }
            set
            {
                this.m_DPCRate = value;
            }
        }
        
        public uint DPCsQueuedPersec
        {
            get
            {
                return this.m_DPCsQueuedPersec;
            }
            set
            {
                this.m_DPCsQueuedPersec = value;
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
        
        public uint InterruptsPersec
        {
            get
            {
                return this.m_InterruptsPersec;
            }
            set
            {
                this.m_InterruptsPersec = value;
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
        
        public ulong PercentC1Time
        {
            get
            {
                return this.m_PercentC1Time;
            }
            set
            {
                this.m_PercentC1Time = value;
            }
        }
        
        public ulong PercentC2Time
        {
            get
            {
                return this.m_PercentC2Time;
            }
            set
            {
                this.m_PercentC2Time = value;
            }
        }
        
        public ulong PercentC3Time
        {
            get
            {
                return this.m_PercentC3Time;
            }
            set
            {
                this.m_PercentC3Time = value;
            }
        }
        
        public ulong PercentDPCTime
        {
            get
            {
                return this.m_PercentDPCTime;
            }
            set
            {
                this.m_PercentDPCTime = value;
            }
        }
        
        public ulong PercentIdleTime
        {
            get
            {
                return this.m_PercentIdleTime;
            }
            set
            {
                this.m_PercentIdleTime = value;
            }
        }
        
        public ulong PercentInterruptTime
        {
            get
            {
                return this.m_PercentInterruptTime;
            }
            set
            {
                this.m_PercentInterruptTime = value;
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
