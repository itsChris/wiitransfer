using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfFormattedData_ESENT_Database : WMIBase
    {
        
        private string m_Caption;
        
        private uint m_DatabaseCachePercentHit;
        
        private ulong m_DatabaseCacheSize;
        
        private ulong m_DatabaseCacheSizeMB;
        
        private uint m_DatabasePageEvictionsPersec;
        
        private uint m_DatabasePageFaultsPersec;
        
        private uint m_DatabasePageFaultStallsPersec;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private ulong m_IODatabaseReadsAverageLatency;
        
        private uint m_IODatabaseReadsPersec;
        
        private ulong m_IODatabaseWritesAverageLatency;
        
        private uint m_IODatabaseWritesPersec;
        
        private uint m_IOLogReadsPersec;
        
        private ulong m_IOLogWritesAverageLatency;
        
        private uint m_IOLogWritesPersec;
        
        private uint m_LogBytesWritePersec;
        
        private uint m_LogRecordStallsPersec;
        
        private uint m_LogThreadsWaiting;
        
        private uint m_LogWritesPersec;
        
        private string m_Name;
        
        private uint m_PagesConverted;
        
        private uint m_PagesConvertedPersec;
        
        private uint m_RecordsConverted;
        
        private uint m_RecordsConvertedPersec;
        
        private uint m_SessionsInUse;
        
        private uint m_SessionsPercentUsed;
        
        private uint m_TableOpenCacheHitsPersec;
        
        private uint m_TableOpenCacheMissesPersec;
        
        private uint m_TableOpenCachePercentHit;
        
        private uint m_TableOpensPersec;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private uint m_Versionbucketsallocated;
        
        private string m_MyPath;
        
        public Win32_PerfFormattedData_ESENT_Database()
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
        
        public uint DatabaseCachePercentHit
        {
            get
            {
                return this.m_DatabaseCachePercentHit;
            }
            set
            {
                this.m_DatabaseCachePercentHit = value;
            }
        }
        
        public ulong DatabaseCacheSize
        {
            get
            {
                return this.m_DatabaseCacheSize;
            }
            set
            {
                this.m_DatabaseCacheSize = value;
            }
        }
        
        public ulong DatabaseCacheSizeMB
        {
            get
            {
                return this.m_DatabaseCacheSizeMB;
            }
            set
            {
                this.m_DatabaseCacheSizeMB = value;
            }
        }
        
        public uint DatabasePageEvictionsPersec
        {
            get
            {
                return this.m_DatabasePageEvictionsPersec;
            }
            set
            {
                this.m_DatabasePageEvictionsPersec = value;
            }
        }
        
        public uint DatabasePageFaultsPersec
        {
            get
            {
                return this.m_DatabasePageFaultsPersec;
            }
            set
            {
                this.m_DatabasePageFaultsPersec = value;
            }
        }
        
        public uint DatabasePageFaultStallsPersec
        {
            get
            {
                return this.m_DatabasePageFaultStallsPersec;
            }
            set
            {
                this.m_DatabasePageFaultStallsPersec = value;
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
        
        public ulong IODatabaseReadsAverageLatency
        {
            get
            {
                return this.m_IODatabaseReadsAverageLatency;
            }
            set
            {
                this.m_IODatabaseReadsAverageLatency = value;
            }
        }
        
        public uint IODatabaseReadsPersec
        {
            get
            {
                return this.m_IODatabaseReadsPersec;
            }
            set
            {
                this.m_IODatabaseReadsPersec = value;
            }
        }
        
        public ulong IODatabaseWritesAverageLatency
        {
            get
            {
                return this.m_IODatabaseWritesAverageLatency;
            }
            set
            {
                this.m_IODatabaseWritesAverageLatency = value;
            }
        }
        
        public uint IODatabaseWritesPersec
        {
            get
            {
                return this.m_IODatabaseWritesPersec;
            }
            set
            {
                this.m_IODatabaseWritesPersec = value;
            }
        }
        
        public uint IOLogReadsPersec
        {
            get
            {
                return this.m_IOLogReadsPersec;
            }
            set
            {
                this.m_IOLogReadsPersec = value;
            }
        }
        
        public ulong IOLogWritesAverageLatency
        {
            get
            {
                return this.m_IOLogWritesAverageLatency;
            }
            set
            {
                this.m_IOLogWritesAverageLatency = value;
            }
        }
        
        public uint IOLogWritesPersec
        {
            get
            {
                return this.m_IOLogWritesPersec;
            }
            set
            {
                this.m_IOLogWritesPersec = value;
            }
        }
        
        public uint LogBytesWritePersec
        {
            get
            {
                return this.m_LogBytesWritePersec;
            }
            set
            {
                this.m_LogBytesWritePersec = value;
            }
        }
        
        public uint LogRecordStallsPersec
        {
            get
            {
                return this.m_LogRecordStallsPersec;
            }
            set
            {
                this.m_LogRecordStallsPersec = value;
            }
        }
        
        public uint LogThreadsWaiting
        {
            get
            {
                return this.m_LogThreadsWaiting;
            }
            set
            {
                this.m_LogThreadsWaiting = value;
            }
        }
        
        public uint LogWritesPersec
        {
            get
            {
                return this.m_LogWritesPersec;
            }
            set
            {
                this.m_LogWritesPersec = value;
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
        
        public uint PagesConverted
        {
            get
            {
                return this.m_PagesConverted;
            }
            set
            {
                this.m_PagesConverted = value;
            }
        }
        
        public uint PagesConvertedPersec
        {
            get
            {
                return this.m_PagesConvertedPersec;
            }
            set
            {
                this.m_PagesConvertedPersec = value;
            }
        }
        
        public uint RecordsConverted
        {
            get
            {
                return this.m_RecordsConverted;
            }
            set
            {
                this.m_RecordsConverted = value;
            }
        }
        
        public uint RecordsConvertedPersec
        {
            get
            {
                return this.m_RecordsConvertedPersec;
            }
            set
            {
                this.m_RecordsConvertedPersec = value;
            }
        }
        
        public uint SessionsInUse
        {
            get
            {
                return this.m_SessionsInUse;
            }
            set
            {
                this.m_SessionsInUse = value;
            }
        }
        
        public uint SessionsPercentUsed
        {
            get
            {
                return this.m_SessionsPercentUsed;
            }
            set
            {
                this.m_SessionsPercentUsed = value;
            }
        }
        
        public uint TableOpenCacheHitsPersec
        {
            get
            {
                return this.m_TableOpenCacheHitsPersec;
            }
            set
            {
                this.m_TableOpenCacheHitsPersec = value;
            }
        }
        
        public uint TableOpenCacheMissesPersec
        {
            get
            {
                return this.m_TableOpenCacheMissesPersec;
            }
            set
            {
                this.m_TableOpenCacheMissesPersec = value;
            }
        }
        
        public uint TableOpenCachePercentHit
        {
            get
            {
                return this.m_TableOpenCachePercentHit;
            }
            set
            {
                this.m_TableOpenCachePercentHit = value;
            }
        }
        
        public uint TableOpensPersec
        {
            get
            {
                return this.m_TableOpensPersec;
            }
            set
            {
                this.m_TableOpensPersec = value;
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
        
        public uint Versionbucketsallocated
        {
            get
            {
                return this.m_Versionbucketsallocated;
            }
            set
            {
                this.m_Versionbucketsallocated = value;
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
