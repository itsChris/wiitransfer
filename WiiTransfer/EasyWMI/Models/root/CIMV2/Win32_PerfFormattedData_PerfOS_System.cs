using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfFormattedData_PerfOS_System : WMIBase
    {
        
        private uint m_AlignmentFixupsPersec;
        
        private string m_Caption;
        
        private uint m_ContextSwitchesPersec;
        
        private string m_Description;
        
        private uint m_ExceptionDispatchesPersec;
        
        private ulong m_FileControlBytesPersec;
        
        private uint m_FileControlOperationsPersec;
        
        private uint m_FileDataOperationsPersec;
        
        private ulong m_FileReadBytesPersec;
        
        private uint m_FileReadOperationsPersec;
        
        private ulong m_FileWriteBytesPersec;
        
        private uint m_FileWriteOperationsPersec;
        
        private uint m_FloatingEmulationsPersec;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private string m_Name;
        
        private uint m_PercentRegistryQuotaInUse;
        
        private uint m_Processes;
        
        private uint m_ProcessorQueueLength;
        
        private uint m_SystemCallsPersec;
        
        private ulong m_SystemUpTime;
        
        private uint m_Threads;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfFormattedData_PerfOS_System()
        {
        }
        
        public uint AlignmentFixupsPersec
        {
            get
            {
                return this.m_AlignmentFixupsPersec;
            }
            set
            {
                this.m_AlignmentFixupsPersec = value;
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
        
        public uint ExceptionDispatchesPersec
        {
            get
            {
                return this.m_ExceptionDispatchesPersec;
            }
            set
            {
                this.m_ExceptionDispatchesPersec = value;
            }
        }
        
        public ulong FileControlBytesPersec
        {
            get
            {
                return this.m_FileControlBytesPersec;
            }
            set
            {
                this.m_FileControlBytesPersec = value;
            }
        }
        
        public uint FileControlOperationsPersec
        {
            get
            {
                return this.m_FileControlOperationsPersec;
            }
            set
            {
                this.m_FileControlOperationsPersec = value;
            }
        }
        
        public uint FileDataOperationsPersec
        {
            get
            {
                return this.m_FileDataOperationsPersec;
            }
            set
            {
                this.m_FileDataOperationsPersec = value;
            }
        }
        
        public ulong FileReadBytesPersec
        {
            get
            {
                return this.m_FileReadBytesPersec;
            }
            set
            {
                this.m_FileReadBytesPersec = value;
            }
        }
        
        public uint FileReadOperationsPersec
        {
            get
            {
                return this.m_FileReadOperationsPersec;
            }
            set
            {
                this.m_FileReadOperationsPersec = value;
            }
        }
        
        public ulong FileWriteBytesPersec
        {
            get
            {
                return this.m_FileWriteBytesPersec;
            }
            set
            {
                this.m_FileWriteBytesPersec = value;
            }
        }
        
        public uint FileWriteOperationsPersec
        {
            get
            {
                return this.m_FileWriteOperationsPersec;
            }
            set
            {
                this.m_FileWriteOperationsPersec = value;
            }
        }
        
        public uint FloatingEmulationsPersec
        {
            get
            {
                return this.m_FloatingEmulationsPersec;
            }
            set
            {
                this.m_FloatingEmulationsPersec = value;
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
        
        public uint PercentRegistryQuotaInUse
        {
            get
            {
                return this.m_PercentRegistryQuotaInUse;
            }
            set
            {
                this.m_PercentRegistryQuotaInUse = value;
            }
        }
        
        public uint Processes
        {
            get
            {
                return this.m_Processes;
            }
            set
            {
                this.m_Processes = value;
            }
        }
        
        public uint ProcessorQueueLength
        {
            get
            {
                return this.m_ProcessorQueueLength;
            }
            set
            {
                this.m_ProcessorQueueLength = value;
            }
        }
        
        public uint SystemCallsPersec
        {
            get
            {
                return this.m_SystemCallsPersec;
            }
            set
            {
                this.m_SystemCallsPersec = value;
            }
        }
        
        public ulong SystemUpTime
        {
            get
            {
                return this.m_SystemUpTime;
            }
            set
            {
                this.m_SystemUpTime = value;
            }
        }
        
        public uint Threads
        {
            get
            {
                return this.m_Threads;
            }
            set
            {
                this.m_Threads = value;
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
