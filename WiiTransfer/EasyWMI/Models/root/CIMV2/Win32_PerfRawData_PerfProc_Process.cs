using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_PerfProc_Process : WMIBase
    {
        
        private string m_Caption;
        
        private uint m_CreatingProcessID;
        
        private string m_Description;
        
        private ulong m_ElapsedTime;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_HandleCount;
        
        private uint m_IDProcess;
        
        private ulong m_IODataBytesPersec;
        
        private ulong m_IODataOperationsPersec;
        
        private ulong m_IOOtherBytesPersec;
        
        private ulong m_IOOtherOperationsPersec;
        
        private ulong m_IOReadBytesPersec;
        
        private ulong m_IOReadOperationsPersec;
        
        private ulong m_IOWriteBytesPersec;
        
        private ulong m_IOWriteOperationsPersec;
        
        private string m_Name;
        
        private uint m_PageFaultsPersec;
        
        private ulong m_PageFileBytes;
        
        private ulong m_PageFileBytesPeak;
        
        private ulong m_PercentPrivilegedTime;
        
        private ulong m_PercentProcessorTime;
        
        private ulong m_PercentUserTime;
        
        private uint m_PoolNonpagedBytes;
        
        private uint m_PoolPagedBytes;
        
        private uint m_PriorityBase;
        
        private ulong m_PrivateBytes;
        
        private uint m_ThreadCount;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private ulong m_VirtualBytes;
        
        private ulong m_VirtualBytesPeak;
        
        private ulong m_WorkingSet;
        
        private ulong m_WorkingSetPeak;
        
        private ulong m_WorkingSetPrivate;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_PerfProc_Process()
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
        
        public uint CreatingProcessID
        {
            get
            {
                return this.m_CreatingProcessID;
            }
            set
            {
                this.m_CreatingProcessID = value;
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
        
        public ulong IODataBytesPersec
        {
            get
            {
                return this.m_IODataBytesPersec;
            }
            set
            {
                this.m_IODataBytesPersec = value;
            }
        }
        
        public ulong IODataOperationsPersec
        {
            get
            {
                return this.m_IODataOperationsPersec;
            }
            set
            {
                this.m_IODataOperationsPersec = value;
            }
        }
        
        public ulong IOOtherBytesPersec
        {
            get
            {
                return this.m_IOOtherBytesPersec;
            }
            set
            {
                this.m_IOOtherBytesPersec = value;
            }
        }
        
        public ulong IOOtherOperationsPersec
        {
            get
            {
                return this.m_IOOtherOperationsPersec;
            }
            set
            {
                this.m_IOOtherOperationsPersec = value;
            }
        }
        
        public ulong IOReadBytesPersec
        {
            get
            {
                return this.m_IOReadBytesPersec;
            }
            set
            {
                this.m_IOReadBytesPersec = value;
            }
        }
        
        public ulong IOReadOperationsPersec
        {
            get
            {
                return this.m_IOReadOperationsPersec;
            }
            set
            {
                this.m_IOReadOperationsPersec = value;
            }
        }
        
        public ulong IOWriteBytesPersec
        {
            get
            {
                return this.m_IOWriteBytesPersec;
            }
            set
            {
                this.m_IOWriteBytesPersec = value;
            }
        }
        
        public ulong IOWriteOperationsPersec
        {
            get
            {
                return this.m_IOWriteOperationsPersec;
            }
            set
            {
                this.m_IOWriteOperationsPersec = value;
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
        
        public uint PageFaultsPersec
        {
            get
            {
                return this.m_PageFaultsPersec;
            }
            set
            {
                this.m_PageFaultsPersec = value;
            }
        }
        
        public ulong PageFileBytes
        {
            get
            {
                return this.m_PageFileBytes;
            }
            set
            {
                this.m_PageFileBytes = value;
            }
        }
        
        public ulong PageFileBytesPeak
        {
            get
            {
                return this.m_PageFileBytesPeak;
            }
            set
            {
                this.m_PageFileBytesPeak = value;
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
        
        public uint PoolNonpagedBytes
        {
            get
            {
                return this.m_PoolNonpagedBytes;
            }
            set
            {
                this.m_PoolNonpagedBytes = value;
            }
        }
        
        public uint PoolPagedBytes
        {
            get
            {
                return this.m_PoolPagedBytes;
            }
            set
            {
                this.m_PoolPagedBytes = value;
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
        
        public ulong PrivateBytes
        {
            get
            {
                return this.m_PrivateBytes;
            }
            set
            {
                this.m_PrivateBytes = value;
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
        
        public ulong VirtualBytes
        {
            get
            {
                return this.m_VirtualBytes;
            }
            set
            {
                this.m_VirtualBytes = value;
            }
        }
        
        public ulong VirtualBytesPeak
        {
            get
            {
                return this.m_VirtualBytesPeak;
            }
            set
            {
                this.m_VirtualBytesPeak = value;
            }
        }
        
        public ulong WorkingSet
        {
            get
            {
                return this.m_WorkingSet;
            }
            set
            {
                this.m_WorkingSet = value;
            }
        }
        
        public ulong WorkingSetPeak
        {
            get
            {
                return this.m_WorkingSetPeak;
            }
            set
            {
                this.m_WorkingSetPeak = value;
            }
        }
        
        public ulong WorkingSetPrivate
        {
            get
            {
                return this.m_WorkingSetPrivate;
            }
            set
            {
                this.m_WorkingSetPrivate = value;
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
