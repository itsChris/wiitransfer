using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_Tcpip_NetworkInterface : WMIBase
    {
        
        private ulong m_BytesReceivedPersec;
        
        private ulong m_BytesSentPersec;
        
        private ulong m_BytesTotalPersec;
        
        private string m_Caption;
        
        private ulong m_CurrentBandwidth;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private string m_Name;
        
        private ulong m_OutputQueueLength;
        
        private ulong m_PacketsOutboundDiscarded;
        
        private ulong m_PacketsOutboundErrors;
        
        private ulong m_PacketsPersec;
        
        private ulong m_PacketsReceivedDiscarded;
        
        private ulong m_PacketsReceivedErrors;
        
        private ulong m_PacketsReceivedNonUnicastPersec;
        
        private ulong m_PacketsReceivedPersec;
        
        private ulong m_PacketsReceivedUnicastPersec;
        
        private ulong m_PacketsReceivedUnknown;
        
        private ulong m_PacketsSentNonUnicastPersec;
        
        private ulong m_PacketsSentPersec;
        
        private ulong m_PacketsSentUnicastPersec;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_Tcpip_NetworkInterface()
        {
        }
        
        public ulong BytesReceivedPersec
        {
            get
            {
                return this.m_BytesReceivedPersec;
            }
            set
            {
                this.m_BytesReceivedPersec = value;
            }
        }
        
        public ulong BytesSentPersec
        {
            get
            {
                return this.m_BytesSentPersec;
            }
            set
            {
                this.m_BytesSentPersec = value;
            }
        }
        
        public ulong BytesTotalPersec
        {
            get
            {
                return this.m_BytesTotalPersec;
            }
            set
            {
                this.m_BytesTotalPersec = value;
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
        
        public ulong CurrentBandwidth
        {
            get
            {
                return this.m_CurrentBandwidth;
            }
            set
            {
                this.m_CurrentBandwidth = value;
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
        
        public ulong OutputQueueLength
        {
            get
            {
                return this.m_OutputQueueLength;
            }
            set
            {
                this.m_OutputQueueLength = value;
            }
        }
        
        public ulong PacketsOutboundDiscarded
        {
            get
            {
                return this.m_PacketsOutboundDiscarded;
            }
            set
            {
                this.m_PacketsOutboundDiscarded = value;
            }
        }
        
        public ulong PacketsOutboundErrors
        {
            get
            {
                return this.m_PacketsOutboundErrors;
            }
            set
            {
                this.m_PacketsOutboundErrors = value;
            }
        }
        
        public ulong PacketsPersec
        {
            get
            {
                return this.m_PacketsPersec;
            }
            set
            {
                this.m_PacketsPersec = value;
            }
        }
        
        public ulong PacketsReceivedDiscarded
        {
            get
            {
                return this.m_PacketsReceivedDiscarded;
            }
            set
            {
                this.m_PacketsReceivedDiscarded = value;
            }
        }
        
        public ulong PacketsReceivedErrors
        {
            get
            {
                return this.m_PacketsReceivedErrors;
            }
            set
            {
                this.m_PacketsReceivedErrors = value;
            }
        }
        
        public ulong PacketsReceivedNonUnicastPersec
        {
            get
            {
                return this.m_PacketsReceivedNonUnicastPersec;
            }
            set
            {
                this.m_PacketsReceivedNonUnicastPersec = value;
            }
        }
        
        public ulong PacketsReceivedPersec
        {
            get
            {
                return this.m_PacketsReceivedPersec;
            }
            set
            {
                this.m_PacketsReceivedPersec = value;
            }
        }
        
        public ulong PacketsReceivedUnicastPersec
        {
            get
            {
                return this.m_PacketsReceivedUnicastPersec;
            }
            set
            {
                this.m_PacketsReceivedUnicastPersec = value;
            }
        }
        
        public ulong PacketsReceivedUnknown
        {
            get
            {
                return this.m_PacketsReceivedUnknown;
            }
            set
            {
                this.m_PacketsReceivedUnknown = value;
            }
        }
        
        public ulong PacketsSentNonUnicastPersec
        {
            get
            {
                return this.m_PacketsSentNonUnicastPersec;
            }
            set
            {
                this.m_PacketsSentNonUnicastPersec = value;
            }
        }
        
        public ulong PacketsSentPersec
        {
            get
            {
                return this.m_PacketsSentPersec;
            }
            set
            {
                this.m_PacketsSentPersec = value;
            }
        }
        
        public ulong PacketsSentUnicastPersec
        {
            get
            {
                return this.m_PacketsSentUnicastPersec;
            }
            set
            {
                this.m_PacketsSentUnicastPersec = value;
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
