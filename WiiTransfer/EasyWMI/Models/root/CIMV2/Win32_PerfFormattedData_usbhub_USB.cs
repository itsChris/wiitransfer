using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfFormattedData_usbhub_USB : WMIBase
    {
        
        private ulong m_AvgBytesPerTransfer;
        
        private ulong m_AvgmslatencyforISOtransfers;
        
        private uint m_BulkBytesPerSec;
        
        private string m_Caption;
        
        private uint m_ControlDataBytesPerSec;
        
        private uint m_ControllerPCIInterruptsPerSec;
        
        private uint m_ControllerWorkSignalsPerSec;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_HostControllerAsyncCacheFlushCount;
        
        private uint m_HostControllerAsyncIdle;
        
        private uint m_HostControllerIdle;
        
        private uint m_HostControllerPerdiodicIdle;
        
        private uint m_HostControllerPeriodicCacheFlushCount;
        
        private uint m_InterruptBytesPerSec;
        
        private uint m_IsochronousBytesPerSec;
        
        private uint m_IsoPacketErrorsPerSec;
        
        private string m_Name;
        
        private uint m_PercentTotalBandwidthUsedforInterrupt;
        
        private uint m_PercentTotalBandwidthUsedforIso;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private uint m_TransferErrorsPerSec;
        
        private string m_MyPath;
        
        public Win32_PerfFormattedData_usbhub_USB()
        {
        }
        
        public ulong AvgBytesPerTransfer
        {
            get
            {
                return this.m_AvgBytesPerTransfer;
            }
            set
            {
                this.m_AvgBytesPerTransfer = value;
            }
        }
        
        public ulong AvgmslatencyforISOtransfers
        {
            get
            {
                return this.m_AvgmslatencyforISOtransfers;
            }
            set
            {
                this.m_AvgmslatencyforISOtransfers = value;
            }
        }
        
        public uint BulkBytesPerSec
        {
            get
            {
                return this.m_BulkBytesPerSec;
            }
            set
            {
                this.m_BulkBytesPerSec = value;
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
        
        public uint ControlDataBytesPerSec
        {
            get
            {
                return this.m_ControlDataBytesPerSec;
            }
            set
            {
                this.m_ControlDataBytesPerSec = value;
            }
        }
        
        public uint ControllerPCIInterruptsPerSec
        {
            get
            {
                return this.m_ControllerPCIInterruptsPerSec;
            }
            set
            {
                this.m_ControllerPCIInterruptsPerSec = value;
            }
        }
        
        public uint ControllerWorkSignalsPerSec
        {
            get
            {
                return this.m_ControllerWorkSignalsPerSec;
            }
            set
            {
                this.m_ControllerWorkSignalsPerSec = value;
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
        
        public uint HostControllerAsyncCacheFlushCount
        {
            get
            {
                return this.m_HostControllerAsyncCacheFlushCount;
            }
            set
            {
                this.m_HostControllerAsyncCacheFlushCount = value;
            }
        }
        
        public uint HostControllerAsyncIdle
        {
            get
            {
                return this.m_HostControllerAsyncIdle;
            }
            set
            {
                this.m_HostControllerAsyncIdle = value;
            }
        }
        
        public uint HostControllerIdle
        {
            get
            {
                return this.m_HostControllerIdle;
            }
            set
            {
                this.m_HostControllerIdle = value;
            }
        }
        
        public uint HostControllerPerdiodicIdle
        {
            get
            {
                return this.m_HostControllerPerdiodicIdle;
            }
            set
            {
                this.m_HostControllerPerdiodicIdle = value;
            }
        }
        
        public uint HostControllerPeriodicCacheFlushCount
        {
            get
            {
                return this.m_HostControllerPeriodicCacheFlushCount;
            }
            set
            {
                this.m_HostControllerPeriodicCacheFlushCount = value;
            }
        }
        
        public uint InterruptBytesPerSec
        {
            get
            {
                return this.m_InterruptBytesPerSec;
            }
            set
            {
                this.m_InterruptBytesPerSec = value;
            }
        }
        
        public uint IsochronousBytesPerSec
        {
            get
            {
                return this.m_IsochronousBytesPerSec;
            }
            set
            {
                this.m_IsochronousBytesPerSec = value;
            }
        }
        
        public uint IsoPacketErrorsPerSec
        {
            get
            {
                return this.m_IsoPacketErrorsPerSec;
            }
            set
            {
                this.m_IsoPacketErrorsPerSec = value;
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
        
        public uint PercentTotalBandwidthUsedforInterrupt
        {
            get
            {
                return this.m_PercentTotalBandwidthUsedforInterrupt;
            }
            set
            {
                this.m_PercentTotalBandwidthUsedforInterrupt = value;
            }
        }
        
        public uint PercentTotalBandwidthUsedforIso
        {
            get
            {
                return this.m_PercentTotalBandwidthUsedforIso;
            }
            set
            {
                this.m_PercentTotalBandwidthUsedforIso = value;
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
        
        public uint TransferErrorsPerSec
        {
            get
            {
                return this.m_TransferErrorsPerSec;
            }
            set
            {
                this.m_TransferErrorsPerSec = value;
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
