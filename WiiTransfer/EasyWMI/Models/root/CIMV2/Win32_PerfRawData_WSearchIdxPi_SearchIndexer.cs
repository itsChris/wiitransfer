using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_WSearchIdxPi_SearchIndexer : WMIBase
    {
        
        private uint m_ActiveConnections;
        
        private string m_Caption;
        
        private uint m_CleanWidSets;
        
        private string m_Description;
        
        private uint m_DirtyWidSets;
        
        private uint m_DocumentsFiltered;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_IndexSize;
        
        private uint m_L0IndexesWordlists;
        
        private uint m_L0MergeFlushCount;
        
        private uint m_L0MergeFlushSpeedAverage;
        
        private uint m_L0MergeFlushSpeedLast;
        
        private uint m_L0MergesflushesNow;
        
        private uint m_L1MergeCount;
        
        private uint m_L1MergesNow;
        
        private uint m_L1MergeSpeedaverage;
        
        private uint m_L1MergeSpeedlast;
        
        private uint m_L2MergeCount;
        
        private uint m_L2MergesNow;
        
        private uint m_L2MergeSpeedaverage;
        
        private uint m_L2MergeSpeedlast;
        
        private uint m_L3MergeCount;
        
        private uint m_L3MergesNow;
        
        private uint m_L3MergeSpeedaverage;
        
        private uint m_L3MergeSpeedlast;
        
        private uint m_L4MergeCount;
        
        private uint m_L4MergesNow;
        
        private uint m_L4MergeSpeedaverage;
        
        private uint m_L4MergeSpeedlast;
        
        private uint m_L5MergeCount;
        
        private uint m_L5MergesNow;
        
        private uint m_L5MergeSpeedaverage;
        
        private uint m_L5MergeSpeedlast;
        
        private uint m_L6MergeCount;
        
        private uint m_L6MergesNow;
        
        private uint m_L6MergeSpeedaverage;
        
        private uint m_L6MergeSpeedlast;
        
        private uint m_L7MergeCount;
        
        private uint m_L7MergesNow;
        
        private uint m_L7MergeSpeedaverage;
        
        private uint m_L7MergeSpeedlast;
        
        private uint m_L8MergeCount;
        
        private uint m_L8MergesNow;
        
        private uint m_L8MergeSpeedaverage;
        
        private uint m_L8MergeSpeedlast;
        
        private uint m_MasterIndexLevel;
        
        private uint m_MasterMergeProgress;
        
        private uint m_MasterMergesNow;
        
        private uint m_MasterMergestoDate;
        
        private string m_Name;
        
        private uint m_PersistentIndexes;
        
        private uint m_PersistentIndexesL1;
        
        private uint m_PersistentIndexesL2;
        
        private uint m_PersistentIndexesL3;
        
        private uint m_PersistentIndexesL4;
        
        private uint m_PersistentIndexesL5;
        
        private uint m_PersistentIndexesL6;
        
        private uint m_PersistentIndexesL7;
        
        private uint m_PersistentIndexesL8;
        
        private uint m_Queries;
        
        private uint m_QueriesFailed;
        
        private uint m_QueriesSucceeded;
        
        private uint m_ShadowMergeLevels;
        
        private uint m_ShadowMergeLevelsThreshold;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private uint m_UniqueKeys;
        
        private uint m_WorkItemsCreated;
        
        private uint m_WorkItemsDeleted;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_WSearchIdxPi_SearchIndexer()
        {
        }
        
        public uint ActiveConnections
        {
            get
            {
                return this.m_ActiveConnections;
            }
            set
            {
                this.m_ActiveConnections = value;
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
        
        public uint CleanWidSets
        {
            get
            {
                return this.m_CleanWidSets;
            }
            set
            {
                this.m_CleanWidSets = value;
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
        
        public uint DirtyWidSets
        {
            get
            {
                return this.m_DirtyWidSets;
            }
            set
            {
                this.m_DirtyWidSets = value;
            }
        }
        
        public uint DocumentsFiltered
        {
            get
            {
                return this.m_DocumentsFiltered;
            }
            set
            {
                this.m_DocumentsFiltered = value;
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
        
        public uint IndexSize
        {
            get
            {
                return this.m_IndexSize;
            }
            set
            {
                this.m_IndexSize = value;
            }
        }
        
        public uint L0IndexesWordlists
        {
            get
            {
                return this.m_L0IndexesWordlists;
            }
            set
            {
                this.m_L0IndexesWordlists = value;
            }
        }
        
        public uint L0MergeFlushCount
        {
            get
            {
                return this.m_L0MergeFlushCount;
            }
            set
            {
                this.m_L0MergeFlushCount = value;
            }
        }
        
        public uint L0MergeFlushSpeedAverage
        {
            get
            {
                return this.m_L0MergeFlushSpeedAverage;
            }
            set
            {
                this.m_L0MergeFlushSpeedAverage = value;
            }
        }
        
        public uint L0MergeFlushSpeedLast
        {
            get
            {
                return this.m_L0MergeFlushSpeedLast;
            }
            set
            {
                this.m_L0MergeFlushSpeedLast = value;
            }
        }
        
        public uint L0MergesflushesNow
        {
            get
            {
                return this.m_L0MergesflushesNow;
            }
            set
            {
                this.m_L0MergesflushesNow = value;
            }
        }
        
        public uint L1MergeCount
        {
            get
            {
                return this.m_L1MergeCount;
            }
            set
            {
                this.m_L1MergeCount = value;
            }
        }
        
        public uint L1MergesNow
        {
            get
            {
                return this.m_L1MergesNow;
            }
            set
            {
                this.m_L1MergesNow = value;
            }
        }
        
        public uint L1MergeSpeedaverage
        {
            get
            {
                return this.m_L1MergeSpeedaverage;
            }
            set
            {
                this.m_L1MergeSpeedaverage = value;
            }
        }
        
        public uint L1MergeSpeedlast
        {
            get
            {
                return this.m_L1MergeSpeedlast;
            }
            set
            {
                this.m_L1MergeSpeedlast = value;
            }
        }
        
        public uint L2MergeCount
        {
            get
            {
                return this.m_L2MergeCount;
            }
            set
            {
                this.m_L2MergeCount = value;
            }
        }
        
        public uint L2MergesNow
        {
            get
            {
                return this.m_L2MergesNow;
            }
            set
            {
                this.m_L2MergesNow = value;
            }
        }
        
        public uint L2MergeSpeedaverage
        {
            get
            {
                return this.m_L2MergeSpeedaverage;
            }
            set
            {
                this.m_L2MergeSpeedaverage = value;
            }
        }
        
        public uint L2MergeSpeedlast
        {
            get
            {
                return this.m_L2MergeSpeedlast;
            }
            set
            {
                this.m_L2MergeSpeedlast = value;
            }
        }
        
        public uint L3MergeCount
        {
            get
            {
                return this.m_L3MergeCount;
            }
            set
            {
                this.m_L3MergeCount = value;
            }
        }
        
        public uint L3MergesNow
        {
            get
            {
                return this.m_L3MergesNow;
            }
            set
            {
                this.m_L3MergesNow = value;
            }
        }
        
        public uint L3MergeSpeedaverage
        {
            get
            {
                return this.m_L3MergeSpeedaverage;
            }
            set
            {
                this.m_L3MergeSpeedaverage = value;
            }
        }
        
        public uint L3MergeSpeedlast
        {
            get
            {
                return this.m_L3MergeSpeedlast;
            }
            set
            {
                this.m_L3MergeSpeedlast = value;
            }
        }
        
        public uint L4MergeCount
        {
            get
            {
                return this.m_L4MergeCount;
            }
            set
            {
                this.m_L4MergeCount = value;
            }
        }
        
        public uint L4MergesNow
        {
            get
            {
                return this.m_L4MergesNow;
            }
            set
            {
                this.m_L4MergesNow = value;
            }
        }
        
        public uint L4MergeSpeedaverage
        {
            get
            {
                return this.m_L4MergeSpeedaverage;
            }
            set
            {
                this.m_L4MergeSpeedaverage = value;
            }
        }
        
        public uint L4MergeSpeedlast
        {
            get
            {
                return this.m_L4MergeSpeedlast;
            }
            set
            {
                this.m_L4MergeSpeedlast = value;
            }
        }
        
        public uint L5MergeCount
        {
            get
            {
                return this.m_L5MergeCount;
            }
            set
            {
                this.m_L5MergeCount = value;
            }
        }
        
        public uint L5MergesNow
        {
            get
            {
                return this.m_L5MergesNow;
            }
            set
            {
                this.m_L5MergesNow = value;
            }
        }
        
        public uint L5MergeSpeedaverage
        {
            get
            {
                return this.m_L5MergeSpeedaverage;
            }
            set
            {
                this.m_L5MergeSpeedaverage = value;
            }
        }
        
        public uint L5MergeSpeedlast
        {
            get
            {
                return this.m_L5MergeSpeedlast;
            }
            set
            {
                this.m_L5MergeSpeedlast = value;
            }
        }
        
        public uint L6MergeCount
        {
            get
            {
                return this.m_L6MergeCount;
            }
            set
            {
                this.m_L6MergeCount = value;
            }
        }
        
        public uint L6MergesNow
        {
            get
            {
                return this.m_L6MergesNow;
            }
            set
            {
                this.m_L6MergesNow = value;
            }
        }
        
        public uint L6MergeSpeedaverage
        {
            get
            {
                return this.m_L6MergeSpeedaverage;
            }
            set
            {
                this.m_L6MergeSpeedaverage = value;
            }
        }
        
        public uint L6MergeSpeedlast
        {
            get
            {
                return this.m_L6MergeSpeedlast;
            }
            set
            {
                this.m_L6MergeSpeedlast = value;
            }
        }
        
        public uint L7MergeCount
        {
            get
            {
                return this.m_L7MergeCount;
            }
            set
            {
                this.m_L7MergeCount = value;
            }
        }
        
        public uint L7MergesNow
        {
            get
            {
                return this.m_L7MergesNow;
            }
            set
            {
                this.m_L7MergesNow = value;
            }
        }
        
        public uint L7MergeSpeedaverage
        {
            get
            {
                return this.m_L7MergeSpeedaverage;
            }
            set
            {
                this.m_L7MergeSpeedaverage = value;
            }
        }
        
        public uint L7MergeSpeedlast
        {
            get
            {
                return this.m_L7MergeSpeedlast;
            }
            set
            {
                this.m_L7MergeSpeedlast = value;
            }
        }
        
        public uint L8MergeCount
        {
            get
            {
                return this.m_L8MergeCount;
            }
            set
            {
                this.m_L8MergeCount = value;
            }
        }
        
        public uint L8MergesNow
        {
            get
            {
                return this.m_L8MergesNow;
            }
            set
            {
                this.m_L8MergesNow = value;
            }
        }
        
        public uint L8MergeSpeedaverage
        {
            get
            {
                return this.m_L8MergeSpeedaverage;
            }
            set
            {
                this.m_L8MergeSpeedaverage = value;
            }
        }
        
        public uint L8MergeSpeedlast
        {
            get
            {
                return this.m_L8MergeSpeedlast;
            }
            set
            {
                this.m_L8MergeSpeedlast = value;
            }
        }
        
        public uint MasterIndexLevel
        {
            get
            {
                return this.m_MasterIndexLevel;
            }
            set
            {
                this.m_MasterIndexLevel = value;
            }
        }
        
        public uint MasterMergeProgress
        {
            get
            {
                return this.m_MasterMergeProgress;
            }
            set
            {
                this.m_MasterMergeProgress = value;
            }
        }
        
        public uint MasterMergesNow
        {
            get
            {
                return this.m_MasterMergesNow;
            }
            set
            {
                this.m_MasterMergesNow = value;
            }
        }
        
        public uint MasterMergestoDate
        {
            get
            {
                return this.m_MasterMergestoDate;
            }
            set
            {
                this.m_MasterMergestoDate = value;
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
        
        public uint PersistentIndexes
        {
            get
            {
                return this.m_PersistentIndexes;
            }
            set
            {
                this.m_PersistentIndexes = value;
            }
        }
        
        public uint PersistentIndexesL1
        {
            get
            {
                return this.m_PersistentIndexesL1;
            }
            set
            {
                this.m_PersistentIndexesL1 = value;
            }
        }
        
        public uint PersistentIndexesL2
        {
            get
            {
                return this.m_PersistentIndexesL2;
            }
            set
            {
                this.m_PersistentIndexesL2 = value;
            }
        }
        
        public uint PersistentIndexesL3
        {
            get
            {
                return this.m_PersistentIndexesL3;
            }
            set
            {
                this.m_PersistentIndexesL3 = value;
            }
        }
        
        public uint PersistentIndexesL4
        {
            get
            {
                return this.m_PersistentIndexesL4;
            }
            set
            {
                this.m_PersistentIndexesL4 = value;
            }
        }
        
        public uint PersistentIndexesL5
        {
            get
            {
                return this.m_PersistentIndexesL5;
            }
            set
            {
                this.m_PersistentIndexesL5 = value;
            }
        }
        
        public uint PersistentIndexesL6
        {
            get
            {
                return this.m_PersistentIndexesL6;
            }
            set
            {
                this.m_PersistentIndexesL6 = value;
            }
        }
        
        public uint PersistentIndexesL7
        {
            get
            {
                return this.m_PersistentIndexesL7;
            }
            set
            {
                this.m_PersistentIndexesL7 = value;
            }
        }
        
        public uint PersistentIndexesL8
        {
            get
            {
                return this.m_PersistentIndexesL8;
            }
            set
            {
                this.m_PersistentIndexesL8 = value;
            }
        }
        
        public uint Queries
        {
            get
            {
                return this.m_Queries;
            }
            set
            {
                this.m_Queries = value;
            }
        }
        
        public uint QueriesFailed
        {
            get
            {
                return this.m_QueriesFailed;
            }
            set
            {
                this.m_QueriesFailed = value;
            }
        }
        
        public uint QueriesSucceeded
        {
            get
            {
                return this.m_QueriesSucceeded;
            }
            set
            {
                this.m_QueriesSucceeded = value;
            }
        }
        
        public uint ShadowMergeLevels
        {
            get
            {
                return this.m_ShadowMergeLevels;
            }
            set
            {
                this.m_ShadowMergeLevels = value;
            }
        }
        
        public uint ShadowMergeLevelsThreshold
        {
            get
            {
                return this.m_ShadowMergeLevelsThreshold;
            }
            set
            {
                this.m_ShadowMergeLevelsThreshold = value;
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
        
        public uint UniqueKeys
        {
            get
            {
                return this.m_UniqueKeys;
            }
            set
            {
                this.m_UniqueKeys = value;
            }
        }
        
        public uint WorkItemsCreated
        {
            get
            {
                return this.m_WorkItemsCreated;
            }
            set
            {
                this.m_WorkItemsCreated = value;
            }
        }
        
        public uint WorkItemsDeleted
        {
            get
            {
                return this.m_WorkItemsDeleted;
            }
            set
            {
                this.m_WorkItemsDeleted = value;
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
