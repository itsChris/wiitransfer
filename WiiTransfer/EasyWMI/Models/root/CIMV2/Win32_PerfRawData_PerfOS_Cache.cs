using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_PerfOS_Cache : WMIBase
    {
        
        private uint m_AsyncCopyReadsPersec;
        
        private uint m_AsyncDataMapsPersec;
        
        private uint m_AsyncFastReadsPersec;
        
        private uint m_AsyncMDLReadsPersec;
        
        private uint m_AsyncPinReadsPersec;
        
        private string m_Caption;
        
        private uint m_CopyReadHitsPercent;
        
        private uint m_CopyReadHitsPercent_Base;
        
        private uint m_CopyReadsPersec;
        
        private uint m_DataFlushesPersec;
        
        private uint m_DataFlushPagesPersec;
        
        private uint m_DataMapHitsPercent;
        
        private uint m_DataMapHitsPercent_Base;
        
        private uint m_DataMapPinsPersec;
        
        private uint m_DataMapPinsPersec_Base;
        
        private uint m_DataMapsPersec;
        
        private string m_Description;
        
        private uint m_FastReadNotPossiblesPersec;
        
        private uint m_FastReadResourceMissesPersec;
        
        private uint m_FastReadsPersec;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_LazyWriteFlushesPersec;
        
        private uint m_LazyWritePagesPersec;
        
        private uint m_MDLReadHitsPercent;
        
        private uint m_MDLReadHitsPercent_Base;
        
        private uint m_MDLReadsPersec;
        
        private string m_Name;
        
        private uint m_PinReadHitsPercent;
        
        private uint m_PinReadHitsPercent_Base;
        
        private uint m_PinReadsPersec;
        
        private uint m_ReadAheadsPersec;
        
        private uint m_SyncCopyReadsPersec;
        
        private uint m_SyncDataMapsPersec;
        
        private uint m_SyncFastReadsPersec;
        
        private uint m_SyncMDLReadsPersec;
        
        private uint m_SyncPinReadsPersec;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_PerfOS_Cache()
        {
        }
        
        public uint AsyncCopyReadsPersec
        {
            get
            {
                return this.m_AsyncCopyReadsPersec;
            }
            set
            {
                this.m_AsyncCopyReadsPersec = value;
            }
        }
        
        public uint AsyncDataMapsPersec
        {
            get
            {
                return this.m_AsyncDataMapsPersec;
            }
            set
            {
                this.m_AsyncDataMapsPersec = value;
            }
        }
        
        public uint AsyncFastReadsPersec
        {
            get
            {
                return this.m_AsyncFastReadsPersec;
            }
            set
            {
                this.m_AsyncFastReadsPersec = value;
            }
        }
        
        public uint AsyncMDLReadsPersec
        {
            get
            {
                return this.m_AsyncMDLReadsPersec;
            }
            set
            {
                this.m_AsyncMDLReadsPersec = value;
            }
        }
        
        public uint AsyncPinReadsPersec
        {
            get
            {
                return this.m_AsyncPinReadsPersec;
            }
            set
            {
                this.m_AsyncPinReadsPersec = value;
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
        
        public uint CopyReadHitsPercent
        {
            get
            {
                return this.m_CopyReadHitsPercent;
            }
            set
            {
                this.m_CopyReadHitsPercent = value;
            }
        }
        
        public uint CopyReadHitsPercent_Base
        {
            get
            {
                return this.m_CopyReadHitsPercent_Base;
            }
            set
            {
                this.m_CopyReadHitsPercent_Base = value;
            }
        }
        
        public uint CopyReadsPersec
        {
            get
            {
                return this.m_CopyReadsPersec;
            }
            set
            {
                this.m_CopyReadsPersec = value;
            }
        }
        
        public uint DataFlushesPersec
        {
            get
            {
                return this.m_DataFlushesPersec;
            }
            set
            {
                this.m_DataFlushesPersec = value;
            }
        }
        
        public uint DataFlushPagesPersec
        {
            get
            {
                return this.m_DataFlushPagesPersec;
            }
            set
            {
                this.m_DataFlushPagesPersec = value;
            }
        }
        
        public uint DataMapHitsPercent
        {
            get
            {
                return this.m_DataMapHitsPercent;
            }
            set
            {
                this.m_DataMapHitsPercent = value;
            }
        }
        
        public uint DataMapHitsPercent_Base
        {
            get
            {
                return this.m_DataMapHitsPercent_Base;
            }
            set
            {
                this.m_DataMapHitsPercent_Base = value;
            }
        }
        
        public uint DataMapPinsPersec
        {
            get
            {
                return this.m_DataMapPinsPersec;
            }
            set
            {
                this.m_DataMapPinsPersec = value;
            }
        }
        
        public uint DataMapPinsPersec_Base
        {
            get
            {
                return this.m_DataMapPinsPersec_Base;
            }
            set
            {
                this.m_DataMapPinsPersec_Base = value;
            }
        }
        
        public uint DataMapsPersec
        {
            get
            {
                return this.m_DataMapsPersec;
            }
            set
            {
                this.m_DataMapsPersec = value;
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
        
        public uint FastReadNotPossiblesPersec
        {
            get
            {
                return this.m_FastReadNotPossiblesPersec;
            }
            set
            {
                this.m_FastReadNotPossiblesPersec = value;
            }
        }
        
        public uint FastReadResourceMissesPersec
        {
            get
            {
                return this.m_FastReadResourceMissesPersec;
            }
            set
            {
                this.m_FastReadResourceMissesPersec = value;
            }
        }
        
        public uint FastReadsPersec
        {
            get
            {
                return this.m_FastReadsPersec;
            }
            set
            {
                this.m_FastReadsPersec = value;
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
        
        public uint LazyWriteFlushesPersec
        {
            get
            {
                return this.m_LazyWriteFlushesPersec;
            }
            set
            {
                this.m_LazyWriteFlushesPersec = value;
            }
        }
        
        public uint LazyWritePagesPersec
        {
            get
            {
                return this.m_LazyWritePagesPersec;
            }
            set
            {
                this.m_LazyWritePagesPersec = value;
            }
        }
        
        public uint MDLReadHitsPercent
        {
            get
            {
                return this.m_MDLReadHitsPercent;
            }
            set
            {
                this.m_MDLReadHitsPercent = value;
            }
        }
        
        public uint MDLReadHitsPercent_Base
        {
            get
            {
                return this.m_MDLReadHitsPercent_Base;
            }
            set
            {
                this.m_MDLReadHitsPercent_Base = value;
            }
        }
        
        public uint MDLReadsPersec
        {
            get
            {
                return this.m_MDLReadsPersec;
            }
            set
            {
                this.m_MDLReadsPersec = value;
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
        
        public uint PinReadHitsPercent
        {
            get
            {
                return this.m_PinReadHitsPercent;
            }
            set
            {
                this.m_PinReadHitsPercent = value;
            }
        }
        
        public uint PinReadHitsPercent_Base
        {
            get
            {
                return this.m_PinReadHitsPercent_Base;
            }
            set
            {
                this.m_PinReadHitsPercent_Base = value;
            }
        }
        
        public uint PinReadsPersec
        {
            get
            {
                return this.m_PinReadsPersec;
            }
            set
            {
                this.m_PinReadsPersec = value;
            }
        }
        
        public uint ReadAheadsPersec
        {
            get
            {
                return this.m_ReadAheadsPersec;
            }
            set
            {
                this.m_ReadAheadsPersec = value;
            }
        }
        
        public uint SyncCopyReadsPersec
        {
            get
            {
                return this.m_SyncCopyReadsPersec;
            }
            set
            {
                this.m_SyncCopyReadsPersec = value;
            }
        }
        
        public uint SyncDataMapsPersec
        {
            get
            {
                return this.m_SyncDataMapsPersec;
            }
            set
            {
                this.m_SyncDataMapsPersec = value;
            }
        }
        
        public uint SyncFastReadsPersec
        {
            get
            {
                return this.m_SyncFastReadsPersec;
            }
            set
            {
                this.m_SyncFastReadsPersec = value;
            }
        }
        
        public uint SyncMDLReadsPersec
        {
            get
            {
                return this.m_SyncMDLReadsPersec;
            }
            set
            {
                this.m_SyncMDLReadsPersec = value;
            }
        }
        
        public uint SyncPinReadsPersec
        {
            get
            {
                return this.m_SyncPinReadsPersec;
            }
            set
            {
                this.m_SyncPinReadsPersec = value;
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
