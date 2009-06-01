using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_PerfOS_Memory : WMIBase
    {
        
        private ulong m_AvailableBytes;
        
        private ulong m_AvailableKBytes;
        
        private ulong m_AvailableMBytes;
        
        private ulong m_CacheBytes;
        
        private ulong m_CacheBytesPeak;
        
        private uint m_CacheFaultsPersec;
        
        private string m_Caption;
        
        private ulong m_CommitLimit;
        
        private ulong m_CommittedBytes;
        
        private uint m_DemandZeroFaultsPersec;
        
        private string m_Description;
        
        private ulong m_FreeAndZeroPageListBytes;
        
        private uint m_FreeSystemPageTableEntries;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private ulong m_ModifiedPageListBytes;
        
        private string m_Name;
        
        private uint m_PageFaultsPersec;
        
        private uint m_PageReadsPersec;
        
        private uint m_PagesInputPersec;
        
        private uint m_PagesOutputPersec;
        
        private uint m_PagesPersec;
        
        private uint m_PageWritesPersec;
        
        private uint m_PercentCommittedBytesInUse;
        
        private uint m_PercentCommittedBytesInUse_Base;
        
        private uint m_PoolNonpagedAllocs;
        
        private ulong m_PoolNonpagedBytes;
        
        private uint m_PoolPagedAllocs;
        
        private ulong m_PoolPagedBytes;
        
        private ulong m_PoolPagedResidentBytes;
        
        private ulong m_StandbyCacheCoreBytes;
        
        private ulong m_StandbyCacheNormalPriorityBytes;
        
        private ulong m_StandbyCacheReserveBytes;
        
        private ulong m_SystemCacheResidentBytes;
        
        private ulong m_SystemCodeResidentBytes;
        
        private ulong m_SystemCodeTotalBytes;
        
        private ulong m_SystemDriverResidentBytes;
        
        private ulong m_SystemDriverTotalBytes;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private uint m_TransitionFaultsPersec;
        
        private uint m_TransitionPagesRePurposedPersec;
        
        private uint m_WriteCopiesPersec;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_PerfOS_Memory()
        {
        }
        
        public ulong AvailableBytes
        {
            get
            {
                return this.m_AvailableBytes;
            }
            set
            {
                this.m_AvailableBytes = value;
            }
        }
        
        public ulong AvailableKBytes
        {
            get
            {
                return this.m_AvailableKBytes;
            }
            set
            {
                this.m_AvailableKBytes = value;
            }
        }
        
        public ulong AvailableMBytes
        {
            get
            {
                return this.m_AvailableMBytes;
            }
            set
            {
                this.m_AvailableMBytes = value;
            }
        }
        
        public ulong CacheBytes
        {
            get
            {
                return this.m_CacheBytes;
            }
            set
            {
                this.m_CacheBytes = value;
            }
        }
        
        public ulong CacheBytesPeak
        {
            get
            {
                return this.m_CacheBytesPeak;
            }
            set
            {
                this.m_CacheBytesPeak = value;
            }
        }
        
        public uint CacheFaultsPersec
        {
            get
            {
                return this.m_CacheFaultsPersec;
            }
            set
            {
                this.m_CacheFaultsPersec = value;
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
        
        public ulong CommitLimit
        {
            get
            {
                return this.m_CommitLimit;
            }
            set
            {
                this.m_CommitLimit = value;
            }
        }
        
        public ulong CommittedBytes
        {
            get
            {
                return this.m_CommittedBytes;
            }
            set
            {
                this.m_CommittedBytes = value;
            }
        }
        
        public uint DemandZeroFaultsPersec
        {
            get
            {
                return this.m_DemandZeroFaultsPersec;
            }
            set
            {
                this.m_DemandZeroFaultsPersec = value;
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
        
        public ulong FreeAndZeroPageListBytes
        {
            get
            {
                return this.m_FreeAndZeroPageListBytes;
            }
            set
            {
                this.m_FreeAndZeroPageListBytes = value;
            }
        }
        
        public uint FreeSystemPageTableEntries
        {
            get
            {
                return this.m_FreeSystemPageTableEntries;
            }
            set
            {
                this.m_FreeSystemPageTableEntries = value;
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
        
        public ulong ModifiedPageListBytes
        {
            get
            {
                return this.m_ModifiedPageListBytes;
            }
            set
            {
                this.m_ModifiedPageListBytes = value;
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
        
        public uint PageReadsPersec
        {
            get
            {
                return this.m_PageReadsPersec;
            }
            set
            {
                this.m_PageReadsPersec = value;
            }
        }
        
        public uint PagesInputPersec
        {
            get
            {
                return this.m_PagesInputPersec;
            }
            set
            {
                this.m_PagesInputPersec = value;
            }
        }
        
        public uint PagesOutputPersec
        {
            get
            {
                return this.m_PagesOutputPersec;
            }
            set
            {
                this.m_PagesOutputPersec = value;
            }
        }
        
        public uint PagesPersec
        {
            get
            {
                return this.m_PagesPersec;
            }
            set
            {
                this.m_PagesPersec = value;
            }
        }
        
        public uint PageWritesPersec
        {
            get
            {
                return this.m_PageWritesPersec;
            }
            set
            {
                this.m_PageWritesPersec = value;
            }
        }
        
        public uint PercentCommittedBytesInUse
        {
            get
            {
                return this.m_PercentCommittedBytesInUse;
            }
            set
            {
                this.m_PercentCommittedBytesInUse = value;
            }
        }
        
        public uint PercentCommittedBytesInUse_Base
        {
            get
            {
                return this.m_PercentCommittedBytesInUse_Base;
            }
            set
            {
                this.m_PercentCommittedBytesInUse_Base = value;
            }
        }
        
        public uint PoolNonpagedAllocs
        {
            get
            {
                return this.m_PoolNonpagedAllocs;
            }
            set
            {
                this.m_PoolNonpagedAllocs = value;
            }
        }
        
        public ulong PoolNonpagedBytes
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
        
        public uint PoolPagedAllocs
        {
            get
            {
                return this.m_PoolPagedAllocs;
            }
            set
            {
                this.m_PoolPagedAllocs = value;
            }
        }
        
        public ulong PoolPagedBytes
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
        
        public ulong PoolPagedResidentBytes
        {
            get
            {
                return this.m_PoolPagedResidentBytes;
            }
            set
            {
                this.m_PoolPagedResidentBytes = value;
            }
        }
        
        public ulong StandbyCacheCoreBytes
        {
            get
            {
                return this.m_StandbyCacheCoreBytes;
            }
            set
            {
                this.m_StandbyCacheCoreBytes = value;
            }
        }
        
        public ulong StandbyCacheNormalPriorityBytes
        {
            get
            {
                return this.m_StandbyCacheNormalPriorityBytes;
            }
            set
            {
                this.m_StandbyCacheNormalPriorityBytes = value;
            }
        }
        
        public ulong StandbyCacheReserveBytes
        {
            get
            {
                return this.m_StandbyCacheReserveBytes;
            }
            set
            {
                this.m_StandbyCacheReserveBytes = value;
            }
        }
        
        public ulong SystemCacheResidentBytes
        {
            get
            {
                return this.m_SystemCacheResidentBytes;
            }
            set
            {
                this.m_SystemCacheResidentBytes = value;
            }
        }
        
        public ulong SystemCodeResidentBytes
        {
            get
            {
                return this.m_SystemCodeResidentBytes;
            }
            set
            {
                this.m_SystemCodeResidentBytes = value;
            }
        }
        
        public ulong SystemCodeTotalBytes
        {
            get
            {
                return this.m_SystemCodeTotalBytes;
            }
            set
            {
                this.m_SystemCodeTotalBytes = value;
            }
        }
        
        public ulong SystemDriverResidentBytes
        {
            get
            {
                return this.m_SystemDriverResidentBytes;
            }
            set
            {
                this.m_SystemDriverResidentBytes = value;
            }
        }
        
        public ulong SystemDriverTotalBytes
        {
            get
            {
                return this.m_SystemDriverTotalBytes;
            }
            set
            {
                this.m_SystemDriverTotalBytes = value;
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
        
        public uint TransitionFaultsPersec
        {
            get
            {
                return this.m_TransitionFaultsPersec;
            }
            set
            {
                this.m_TransitionFaultsPersec = value;
            }
        }
        
        public uint TransitionPagesRePurposedPersec
        {
            get
            {
                return this.m_TransitionPagesRePurposedPersec;
            }
            set
            {
                this.m_TransitionPagesRePurposedPersec = value;
            }
        }
        
        public uint WriteCopiesPersec
        {
            get
            {
                return this.m_WriteCopiesPersec;
            }
            set
            {
                this.m_WriteCopiesPersec = value;
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
