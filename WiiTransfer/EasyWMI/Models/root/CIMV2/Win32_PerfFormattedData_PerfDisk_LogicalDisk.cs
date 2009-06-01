using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfFormattedData_PerfDisk_LogicalDisk : WMIBase
    {
        
        private ulong m_AvgDiskBytesPerRead;
        
        private ulong m_AvgDiskBytesPerTransfer;
        
        private ulong m_AvgDiskBytesPerWrite;
        
        private ulong m_AvgDiskQueueLength;
        
        private ulong m_AvgDiskReadQueueLength;
        
        private uint m_AvgDisksecPerRead;
        
        private uint m_AvgDisksecPerTransfer;
        
        private uint m_AvgDisksecPerWrite;
        
        private ulong m_AvgDiskWriteQueueLength;
        
        private string m_Caption;
        
        private uint m_CurrentDiskQueueLength;
        
        private string m_Description;
        
        private ulong m_DiskBytesPersec;
        
        private ulong m_DiskReadBytesPersec;
        
        private uint m_DiskReadsPersec;
        
        private uint m_DiskTransfersPersec;
        
        private ulong m_DiskWriteBytesPersec;
        
        private uint m_DiskWritesPersec;
        
        private uint m_FreeMegabytes;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private string m_Name;
        
        private ulong m_PercentDiskReadTime;
        
        private ulong m_PercentDiskTime;
        
        private ulong m_PercentDiskWriteTime;
        
        private uint m_PercentFreeSpace;
        
        private ulong m_PercentIdleTime;
        
        private uint m_SplitIOPerSec;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfFormattedData_PerfDisk_LogicalDisk()
        {
        }
        
        public ulong AvgDiskBytesPerRead
        {
            get
            {
                return this.m_AvgDiskBytesPerRead;
            }
            set
            {
                this.m_AvgDiskBytesPerRead = value;
            }
        }
        
        public ulong AvgDiskBytesPerTransfer
        {
            get
            {
                return this.m_AvgDiskBytesPerTransfer;
            }
            set
            {
                this.m_AvgDiskBytesPerTransfer = value;
            }
        }
        
        public ulong AvgDiskBytesPerWrite
        {
            get
            {
                return this.m_AvgDiskBytesPerWrite;
            }
            set
            {
                this.m_AvgDiskBytesPerWrite = value;
            }
        }
        
        public ulong AvgDiskQueueLength
        {
            get
            {
                return this.m_AvgDiskQueueLength;
            }
            set
            {
                this.m_AvgDiskQueueLength = value;
            }
        }
        
        public ulong AvgDiskReadQueueLength
        {
            get
            {
                return this.m_AvgDiskReadQueueLength;
            }
            set
            {
                this.m_AvgDiskReadQueueLength = value;
            }
        }
        
        public uint AvgDisksecPerRead
        {
            get
            {
                return this.m_AvgDisksecPerRead;
            }
            set
            {
                this.m_AvgDisksecPerRead = value;
            }
        }
        
        public uint AvgDisksecPerTransfer
        {
            get
            {
                return this.m_AvgDisksecPerTransfer;
            }
            set
            {
                this.m_AvgDisksecPerTransfer = value;
            }
        }
        
        public uint AvgDisksecPerWrite
        {
            get
            {
                return this.m_AvgDisksecPerWrite;
            }
            set
            {
                this.m_AvgDisksecPerWrite = value;
            }
        }
        
        public ulong AvgDiskWriteQueueLength
        {
            get
            {
                return this.m_AvgDiskWriteQueueLength;
            }
            set
            {
                this.m_AvgDiskWriteQueueLength = value;
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
        
        public uint CurrentDiskQueueLength
        {
            get
            {
                return this.m_CurrentDiskQueueLength;
            }
            set
            {
                this.m_CurrentDiskQueueLength = value;
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
        
        public ulong DiskBytesPersec
        {
            get
            {
                return this.m_DiskBytesPersec;
            }
            set
            {
                this.m_DiskBytesPersec = value;
            }
        }
        
        public ulong DiskReadBytesPersec
        {
            get
            {
                return this.m_DiskReadBytesPersec;
            }
            set
            {
                this.m_DiskReadBytesPersec = value;
            }
        }
        
        public uint DiskReadsPersec
        {
            get
            {
                return this.m_DiskReadsPersec;
            }
            set
            {
                this.m_DiskReadsPersec = value;
            }
        }
        
        public uint DiskTransfersPersec
        {
            get
            {
                return this.m_DiskTransfersPersec;
            }
            set
            {
                this.m_DiskTransfersPersec = value;
            }
        }
        
        public ulong DiskWriteBytesPersec
        {
            get
            {
                return this.m_DiskWriteBytesPersec;
            }
            set
            {
                this.m_DiskWriteBytesPersec = value;
            }
        }
        
        public uint DiskWritesPersec
        {
            get
            {
                return this.m_DiskWritesPersec;
            }
            set
            {
                this.m_DiskWritesPersec = value;
            }
        }
        
        public uint FreeMegabytes
        {
            get
            {
                return this.m_FreeMegabytes;
            }
            set
            {
                this.m_FreeMegabytes = value;
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
        
        public ulong PercentDiskReadTime
        {
            get
            {
                return this.m_PercentDiskReadTime;
            }
            set
            {
                this.m_PercentDiskReadTime = value;
            }
        }
        
        public ulong PercentDiskTime
        {
            get
            {
                return this.m_PercentDiskTime;
            }
            set
            {
                this.m_PercentDiskTime = value;
            }
        }
        
        public ulong PercentDiskWriteTime
        {
            get
            {
                return this.m_PercentDiskWriteTime;
            }
            set
            {
                this.m_PercentDiskWriteTime = value;
            }
        }
        
        public uint PercentFreeSpace
        {
            get
            {
                return this.m_PercentFreeSpace;
            }
            set
            {
                this.m_PercentFreeSpace = value;
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
        
        public uint SplitIOPerSec
        {
            get
            {
                return this.m_SplitIOPerSec;
            }
            set
            {
                this.m_SplitIOPerSec = value;
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
