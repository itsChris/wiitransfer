using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_PSched_PacerPipe : WMIBase
    {
        
        private uint m_Averagepacketsinnetcard;
        
        private uint m_Averagepacketsinsequencer;
        
        private uint m_Averagepacketsinshaper;
        
        private string m_Caption;
        
        private string m_Description;
        
        private uint m_Flowmodsrejected;
        
        private uint m_Flowsclosed;
        
        private uint m_Flowsmodified;
        
        private uint m_Flowsopened;
        
        private uint m_Flowsrejected;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_Maxpacketsinnetcard;
        
        private uint m_Maxpacketsinsequencer;
        
        private uint m_Maxpacketsinshaper;
        
        private uint m_Maxsimultaneousflows;
        
        private string m_Name;
        
        private uint m_Nonconformingpacketsscheduled;
        
        private uint m_NonconformingpacketsscheduledPersec;
        
        private uint m_Nonconformingpacketstransmitted;
        
        private uint m_NonconformingpacketstransmittedPersec;
        
        private uint m_Outofpackets;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_PSched_PacerPipe()
        {
        }
        
        public uint Averagepacketsinnetcard
        {
            get
            {
                return this.m_Averagepacketsinnetcard;
            }
            set
            {
                this.m_Averagepacketsinnetcard = value;
            }
        }
        
        public uint Averagepacketsinsequencer
        {
            get
            {
                return this.m_Averagepacketsinsequencer;
            }
            set
            {
                this.m_Averagepacketsinsequencer = value;
            }
        }
        
        public uint Averagepacketsinshaper
        {
            get
            {
                return this.m_Averagepacketsinshaper;
            }
            set
            {
                this.m_Averagepacketsinshaper = value;
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
        
        public uint Flowmodsrejected
        {
            get
            {
                return this.m_Flowmodsrejected;
            }
            set
            {
                this.m_Flowmodsrejected = value;
            }
        }
        
        public uint Flowsclosed
        {
            get
            {
                return this.m_Flowsclosed;
            }
            set
            {
                this.m_Flowsclosed = value;
            }
        }
        
        public uint Flowsmodified
        {
            get
            {
                return this.m_Flowsmodified;
            }
            set
            {
                this.m_Flowsmodified = value;
            }
        }
        
        public uint Flowsopened
        {
            get
            {
                return this.m_Flowsopened;
            }
            set
            {
                this.m_Flowsopened = value;
            }
        }
        
        public uint Flowsrejected
        {
            get
            {
                return this.m_Flowsrejected;
            }
            set
            {
                this.m_Flowsrejected = value;
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
        
        public uint Maxpacketsinnetcard
        {
            get
            {
                return this.m_Maxpacketsinnetcard;
            }
            set
            {
                this.m_Maxpacketsinnetcard = value;
            }
        }
        
        public uint Maxpacketsinsequencer
        {
            get
            {
                return this.m_Maxpacketsinsequencer;
            }
            set
            {
                this.m_Maxpacketsinsequencer = value;
            }
        }
        
        public uint Maxpacketsinshaper
        {
            get
            {
                return this.m_Maxpacketsinshaper;
            }
            set
            {
                this.m_Maxpacketsinshaper = value;
            }
        }
        
        public uint Maxsimultaneousflows
        {
            get
            {
                return this.m_Maxsimultaneousflows;
            }
            set
            {
                this.m_Maxsimultaneousflows = value;
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
        
        public uint Nonconformingpacketsscheduled
        {
            get
            {
                return this.m_Nonconformingpacketsscheduled;
            }
            set
            {
                this.m_Nonconformingpacketsscheduled = value;
            }
        }
        
        public uint NonconformingpacketsscheduledPersec
        {
            get
            {
                return this.m_NonconformingpacketsscheduledPersec;
            }
            set
            {
                this.m_NonconformingpacketsscheduledPersec = value;
            }
        }
        
        public uint Nonconformingpacketstransmitted
        {
            get
            {
                return this.m_Nonconformingpacketstransmitted;
            }
            set
            {
                this.m_Nonconformingpacketstransmitted = value;
            }
        }
        
        public uint NonconformingpacketstransmittedPersec
        {
            get
            {
                return this.m_NonconformingpacketstransmittedPersec;
            }
            set
            {
                this.m_NonconformingpacketstransmittedPersec = value;
            }
        }
        
        public uint Outofpackets
        {
            get
            {
                return this.m_Outofpackets;
            }
            set
            {
                this.m_Outofpackets = value;
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
