using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_PerfProc_JobObject : WMIBase
    {
        
        private string m_Caption;
        
        private ulong m_CurrentPercentKernelModeTime;
        
        private ulong m_CurrentPercentProcessorTime;
        
        private ulong m_CurrentPercentUserModeTime;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private string m_Name;
        
        private uint m_PagesPerSec;
        
        private uint m_ProcessCountActive;
        
        private uint m_ProcessCountTerminated;
        
        private uint m_ProcessCountTotal;
        
        private ulong m_ThisPeriodmSecKernelMode;
        
        private ulong m_ThisPeriodmSecProcessor;
        
        private ulong m_ThisPeriodmSecUserMode;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private ulong m_TotalmSecKernelMode;
        
        private ulong m_TotalmSecProcessor;
        
        private ulong m_TotalmSecUserMode;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_PerfProc_JobObject()
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
        
        public ulong CurrentPercentKernelModeTime
        {
            get
            {
                return this.m_CurrentPercentKernelModeTime;
            }
            set
            {
                this.m_CurrentPercentKernelModeTime = value;
            }
        }
        
        public ulong CurrentPercentProcessorTime
        {
            get
            {
                return this.m_CurrentPercentProcessorTime;
            }
            set
            {
                this.m_CurrentPercentProcessorTime = value;
            }
        }
        
        public ulong CurrentPercentUserModeTime
        {
            get
            {
                return this.m_CurrentPercentUserModeTime;
            }
            set
            {
                this.m_CurrentPercentUserModeTime = value;
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
        
        public uint PagesPerSec
        {
            get
            {
                return this.m_PagesPerSec;
            }
            set
            {
                this.m_PagesPerSec = value;
            }
        }
        
        public uint ProcessCountActive
        {
            get
            {
                return this.m_ProcessCountActive;
            }
            set
            {
                this.m_ProcessCountActive = value;
            }
        }
        
        public uint ProcessCountTerminated
        {
            get
            {
                return this.m_ProcessCountTerminated;
            }
            set
            {
                this.m_ProcessCountTerminated = value;
            }
        }
        
        public uint ProcessCountTotal
        {
            get
            {
                return this.m_ProcessCountTotal;
            }
            set
            {
                this.m_ProcessCountTotal = value;
            }
        }
        
        public ulong ThisPeriodmSecKernelMode
        {
            get
            {
                return this.m_ThisPeriodmSecKernelMode;
            }
            set
            {
                this.m_ThisPeriodmSecKernelMode = value;
            }
        }
        
        public ulong ThisPeriodmSecProcessor
        {
            get
            {
                return this.m_ThisPeriodmSecProcessor;
            }
            set
            {
                this.m_ThisPeriodmSecProcessor = value;
            }
        }
        
        public ulong ThisPeriodmSecUserMode
        {
            get
            {
                return this.m_ThisPeriodmSecUserMode;
            }
            set
            {
                this.m_ThisPeriodmSecUserMode = value;
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
        
        public ulong TotalmSecKernelMode
        {
            get
            {
                return this.m_TotalmSecKernelMode;
            }
            set
            {
                this.m_TotalmSecKernelMode = value;
            }
        }
        
        public ulong TotalmSecProcessor
        {
            get
            {
                return this.m_TotalmSecProcessor;
            }
            set
            {
                this.m_TotalmSecProcessor = value;
            }
        }
        
        public ulong TotalmSecUserMode
        {
            get
            {
                return this.m_TotalmSecUserMode;
            }
            set
            {
                this.m_TotalmSecUserMode = value;
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
