using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_NETFramework_NETCLRLocksAndThreads : WMIBase
    {
        
        private string m_Caption;
        
        private uint m_ContentionRatePersec;
        
        private uint m_CurrentQueueLength;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private string m_Name;
        
        private uint m_NumberofcurrentlogicalThreads;
        
        private uint m_NumberofcurrentphysicalThreads;
        
        private uint m_Numberofcurrentrecognizedthreads;
        
        private uint m_Numberoftotalrecognizedthreads;
        
        private uint m_QueueLengthPeak;
        
        private uint m_QueueLengthPersec;
        
        private uint m_rateofrecognizedthreadsPersec;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private uint m_TotalNumberofContentions;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_NETFramework_NETCLRLocksAndThreads()
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
        
        public uint ContentionRatePersec
        {
            get
            {
                return this.m_ContentionRatePersec;
            }
            set
            {
                this.m_ContentionRatePersec = value;
            }
        }
        
        public uint CurrentQueueLength
        {
            get
            {
                return this.m_CurrentQueueLength;
            }
            set
            {
                this.m_CurrentQueueLength = value;
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
        
        public uint NumberofcurrentlogicalThreads
        {
            get
            {
                return this.m_NumberofcurrentlogicalThreads;
            }
            set
            {
                this.m_NumberofcurrentlogicalThreads = value;
            }
        }
        
        public uint NumberofcurrentphysicalThreads
        {
            get
            {
                return this.m_NumberofcurrentphysicalThreads;
            }
            set
            {
                this.m_NumberofcurrentphysicalThreads = value;
            }
        }
        
        public uint Numberofcurrentrecognizedthreads
        {
            get
            {
                return this.m_Numberofcurrentrecognizedthreads;
            }
            set
            {
                this.m_Numberofcurrentrecognizedthreads = value;
            }
        }
        
        public uint Numberoftotalrecognizedthreads
        {
            get
            {
                return this.m_Numberoftotalrecognizedthreads;
            }
            set
            {
                this.m_Numberoftotalrecognizedthreads = value;
            }
        }
        
        public uint QueueLengthPeak
        {
            get
            {
                return this.m_QueueLengthPeak;
            }
            set
            {
                this.m_QueueLengthPeak = value;
            }
        }
        
        public uint QueueLengthPersec
        {
            get
            {
                return this.m_QueueLengthPersec;
            }
            set
            {
                this.m_QueueLengthPersec = value;
            }
        }
        
        public uint rateofrecognizedthreadsPersec
        {
            get
            {
                return this.m_rateofrecognizedthreadsPersec;
            }
            set
            {
                this.m_rateofrecognizedthreadsPersec = value;
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
        
        public uint TotalNumberofContentions
        {
            get
            {
                return this.m_TotalNumberofContentions;
            }
            set
            {
                this.m_TotalNumberofContentions = value;
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
