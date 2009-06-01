using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_NETFramework_NETCLRMemory : WMIBase
    {
        
        private ulong m_AllocatedBytesPersec;
        
        private string m_Caption;
        
        private string m_Description;
        
        private ulong m_FinalizationSurvivors;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private ulong m_Gen0heapsize;
        
        private ulong m_Gen0PromotedBytesPerSec;
        
        private ulong m_Gen1heapsize;
        
        private ulong m_Gen1PromotedBytesPerSec;
        
        private ulong m_Gen2heapsize;
        
        private ulong m_LargeObjectHeapsize;
        
        private string m_Name;
        
        private ulong m_NumberBytesinallHeaps;
        
        private ulong m_NumberGCHandles;
        
        private ulong m_NumberGen0Collections;
        
        private ulong m_NumberGen1Collections;
        
        private ulong m_NumberGen2Collections;
        
        private ulong m_NumberInducedGC;
        
        private ulong m_NumberofPinnedObjects;
        
        private ulong m_NumberofSinkBlocksinuse;
        
        private ulong m_NumberTotalcommittedBytes;
        
        private ulong m_NumberTotalreservedBytes;
        
        private uint m_PercentTimeinGC;
        
        private uint m_PercentTimeinGC_Base;
        
        private ulong m_ProcessID;
        
        private ulong m_PromotedFinalizationMemoryfromGen0;
        
        private ulong m_PromotedMemoryfromGen0;
        
        private ulong m_PromotedMemoryfromGen1;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_NETFramework_NETCLRMemory()
        {
        }
        
        public ulong AllocatedBytesPersec
        {
            get
            {
                return this.m_AllocatedBytesPersec;
            }
            set
            {
                this.m_AllocatedBytesPersec = value;
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
        
        public ulong FinalizationSurvivors
        {
            get
            {
                return this.m_FinalizationSurvivors;
            }
            set
            {
                this.m_FinalizationSurvivors = value;
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
        
        public ulong Gen0heapsize
        {
            get
            {
                return this.m_Gen0heapsize;
            }
            set
            {
                this.m_Gen0heapsize = value;
            }
        }
        
        public ulong Gen0PromotedBytesPerSec
        {
            get
            {
                return this.m_Gen0PromotedBytesPerSec;
            }
            set
            {
                this.m_Gen0PromotedBytesPerSec = value;
            }
        }
        
        public ulong Gen1heapsize
        {
            get
            {
                return this.m_Gen1heapsize;
            }
            set
            {
                this.m_Gen1heapsize = value;
            }
        }
        
        public ulong Gen1PromotedBytesPerSec
        {
            get
            {
                return this.m_Gen1PromotedBytesPerSec;
            }
            set
            {
                this.m_Gen1PromotedBytesPerSec = value;
            }
        }
        
        public ulong Gen2heapsize
        {
            get
            {
                return this.m_Gen2heapsize;
            }
            set
            {
                this.m_Gen2heapsize = value;
            }
        }
        
        public ulong LargeObjectHeapsize
        {
            get
            {
                return this.m_LargeObjectHeapsize;
            }
            set
            {
                this.m_LargeObjectHeapsize = value;
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
        
        public ulong NumberBytesinallHeaps
        {
            get
            {
                return this.m_NumberBytesinallHeaps;
            }
            set
            {
                this.m_NumberBytesinallHeaps = value;
            }
        }
        
        public ulong NumberGCHandles
        {
            get
            {
                return this.m_NumberGCHandles;
            }
            set
            {
                this.m_NumberGCHandles = value;
            }
        }
        
        public ulong NumberGen0Collections
        {
            get
            {
                return this.m_NumberGen0Collections;
            }
            set
            {
                this.m_NumberGen0Collections = value;
            }
        }
        
        public ulong NumberGen1Collections
        {
            get
            {
                return this.m_NumberGen1Collections;
            }
            set
            {
                this.m_NumberGen1Collections = value;
            }
        }
        
        public ulong NumberGen2Collections
        {
            get
            {
                return this.m_NumberGen2Collections;
            }
            set
            {
                this.m_NumberGen2Collections = value;
            }
        }
        
        public ulong NumberInducedGC
        {
            get
            {
                return this.m_NumberInducedGC;
            }
            set
            {
                this.m_NumberInducedGC = value;
            }
        }
        
        public ulong NumberofPinnedObjects
        {
            get
            {
                return this.m_NumberofPinnedObjects;
            }
            set
            {
                this.m_NumberofPinnedObjects = value;
            }
        }
        
        public ulong NumberofSinkBlocksinuse
        {
            get
            {
                return this.m_NumberofSinkBlocksinuse;
            }
            set
            {
                this.m_NumberofSinkBlocksinuse = value;
            }
        }
        
        public ulong NumberTotalcommittedBytes
        {
            get
            {
                return this.m_NumberTotalcommittedBytes;
            }
            set
            {
                this.m_NumberTotalcommittedBytes = value;
            }
        }
        
        public ulong NumberTotalreservedBytes
        {
            get
            {
                return this.m_NumberTotalreservedBytes;
            }
            set
            {
                this.m_NumberTotalreservedBytes = value;
            }
        }
        
        public uint PercentTimeinGC
        {
            get
            {
                return this.m_PercentTimeinGC;
            }
            set
            {
                this.m_PercentTimeinGC = value;
            }
        }
        
        public uint PercentTimeinGC_Base
        {
            get
            {
                return this.m_PercentTimeinGC_Base;
            }
            set
            {
                this.m_PercentTimeinGC_Base = value;
            }
        }
        
        public ulong ProcessID
        {
            get
            {
                return this.m_ProcessID;
            }
            set
            {
                this.m_ProcessID = value;
            }
        }
        
        public ulong PromotedFinalizationMemoryfromGen0
        {
            get
            {
                return this.m_PromotedFinalizationMemoryfromGen0;
            }
            set
            {
                this.m_PromotedFinalizationMemoryfromGen0 = value;
            }
        }
        
        public ulong PromotedMemoryfromGen0
        {
            get
            {
                return this.m_PromotedMemoryfromGen0;
            }
            set
            {
                this.m_PromotedMemoryfromGen0 = value;
            }
        }
        
        public ulong PromotedMemoryfromGen1
        {
            get
            {
                return this.m_PromotedMemoryfromGen1;
            }
            set
            {
                this.m_PromotedMemoryfromGen1 = value;
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
