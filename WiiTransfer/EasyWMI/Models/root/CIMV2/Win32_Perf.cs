using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_Perf : WMIBase
    {
        
        private uint m_BITSDownloadBlockSizeBytes;
        
        private uint m_BITSDownloadResponseIntervalmsec;
        
        private string m_Caption;
        
        private string m_Description;
        
        private uint m_EstimatedbandwidthavailabletotheremotesystemBitsPersec;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_IGDSpeedBitsPerSec;
        
        private string m_Name;
        
        private uint m_NetcardSpeedBitsPerSec;
        
        private uint m_PercentIGDFree;
        
        private uint m_PercentNetcardFree;
        
        private uint m_RemoteServerSpeedBitsPerSec;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_Perf()
        {
        }
        
        public uint BITSDownloadBlockSizeBytes
        {
            get
            {
                return this.m_BITSDownloadBlockSizeBytes;
            }
            set
            {
                this.m_BITSDownloadBlockSizeBytes = value;
            }
        }
        
        public uint BITSDownloadResponseIntervalmsec
        {
            get
            {
                return this.m_BITSDownloadResponseIntervalmsec;
            }
            set
            {
                this.m_BITSDownloadResponseIntervalmsec = value;
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
        
        public uint EstimatedbandwidthavailabletotheremotesystemBitsPersec
        {
            get
            {
                return this.m_EstimatedbandwidthavailabletotheremotesystemBitsPersec;
            }
            set
            {
                this.m_EstimatedbandwidthavailabletotheremotesystemBitsPersec = value;
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
        
        public uint IGDSpeedBitsPerSec
        {
            get
            {
                return this.m_IGDSpeedBitsPerSec;
            }
            set
            {
                this.m_IGDSpeedBitsPerSec = value;
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
        
        public uint NetcardSpeedBitsPerSec
        {
            get
            {
                return this.m_NetcardSpeedBitsPerSec;
            }
            set
            {
                this.m_NetcardSpeedBitsPerSec = value;
            }
        }
        
        public uint PercentIGDFree
        {
            get
            {
                return this.m_PercentIGDFree;
            }
            set
            {
                this.m_PercentIGDFree = value;
            }
        }
        
        public uint PercentNetcardFree
        {
            get
            {
                return this.m_PercentNetcardFree;
            }
            set
            {
                this.m_PercentNetcardFree = value;
            }
        }
        
        public uint RemoteServerSpeedBitsPerSec
        {
            get
            {
                return this.m_RemoteServerSpeedBitsPerSec;
            }
            set
            {
                this.m_RemoteServerSpeedBitsPerSec = value;
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
