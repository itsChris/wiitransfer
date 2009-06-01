using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_Tcpip_TCPv6 : WMIBase
    {
        
        private string m_Caption;
        
        private uint m_ConnectionFailures;
        
        private uint m_ConnectionsActive;
        
        private uint m_ConnectionsEstablished;
        
        private uint m_ConnectionsPassive;
        
        private uint m_ConnectionsReset;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private string m_Name;
        
        private uint m_SegmentsPersec;
        
        private uint m_SegmentsReceivedPersec;
        
        private uint m_SegmentsRetransmittedPersec;
        
        private uint m_SegmentsSentPersec;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_Tcpip_TCPv6()
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
        
        public uint ConnectionFailures
        {
            get
            {
                return this.m_ConnectionFailures;
            }
            set
            {
                this.m_ConnectionFailures = value;
            }
        }
        
        public uint ConnectionsActive
        {
            get
            {
                return this.m_ConnectionsActive;
            }
            set
            {
                this.m_ConnectionsActive = value;
            }
        }
        
        public uint ConnectionsEstablished
        {
            get
            {
                return this.m_ConnectionsEstablished;
            }
            set
            {
                this.m_ConnectionsEstablished = value;
            }
        }
        
        public uint ConnectionsPassive
        {
            get
            {
                return this.m_ConnectionsPassive;
            }
            set
            {
                this.m_ConnectionsPassive = value;
            }
        }
        
        public uint ConnectionsReset
        {
            get
            {
                return this.m_ConnectionsReset;
            }
            set
            {
                this.m_ConnectionsReset = value;
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
        
        public uint SegmentsPersec
        {
            get
            {
                return this.m_SegmentsPersec;
            }
            set
            {
                this.m_SegmentsPersec = value;
            }
        }
        
        public uint SegmentsReceivedPersec
        {
            get
            {
                return this.m_SegmentsReceivedPersec;
            }
            set
            {
                this.m_SegmentsReceivedPersec = value;
            }
        }
        
        public uint SegmentsRetransmittedPersec
        {
            get
            {
                return this.m_SegmentsRetransmittedPersec;
            }
            set
            {
                this.m_SegmentsRetransmittedPersec = value;
            }
        }
        
        public uint SegmentsSentPersec
        {
            get
            {
                return this.m_SegmentsSentPersec;
            }
            set
            {
                this.m_SegmentsSentPersec = value;
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
