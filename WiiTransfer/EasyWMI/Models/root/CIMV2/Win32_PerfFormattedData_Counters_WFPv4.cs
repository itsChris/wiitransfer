using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfFormattedData_Counters_WFPv4 : WMIBase
    {
        
        private uint m_ActiveInboundConnections;
        
        private uint m_ActiveOutboundConnections;
        
        private uint m_AllowedClassifiesPersec;
        
        private uint m_BlockedBinds;
        
        private string m_Caption;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_InboundConnections;
        
        private uint m_InboundConnectionsAllowedPersec;
        
        private uint m_InboundConnectionsBlockedPersec;
        
        private uint m_InboundPacketsDiscardedPersec;
        
        private string m_Name;
        
        private uint m_OutboundConnections;
        
        private uint m_OutboundConnectionsAllowedPersec;
        
        private uint m_OutboundConnectionsBlockedPersec;
        
        private uint m_OutboundPacketsDiscardedPersec;
        
        private uint m_PacketsDiscardedPersec;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfFormattedData_Counters_WFPv4()
        {
        }
        
        public uint ActiveInboundConnections
        {
            get
            {
                return this.m_ActiveInboundConnections;
            }
            set
            {
                this.m_ActiveInboundConnections = value;
            }
        }
        
        public uint ActiveOutboundConnections
        {
            get
            {
                return this.m_ActiveOutboundConnections;
            }
            set
            {
                this.m_ActiveOutboundConnections = value;
            }
        }
        
        public uint AllowedClassifiesPersec
        {
            get
            {
                return this.m_AllowedClassifiesPersec;
            }
            set
            {
                this.m_AllowedClassifiesPersec = value;
            }
        }
        
        public uint BlockedBinds
        {
            get
            {
                return this.m_BlockedBinds;
            }
            set
            {
                this.m_BlockedBinds = value;
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
        
        public uint InboundConnections
        {
            get
            {
                return this.m_InboundConnections;
            }
            set
            {
                this.m_InboundConnections = value;
            }
        }
        
        public uint InboundConnectionsAllowedPersec
        {
            get
            {
                return this.m_InboundConnectionsAllowedPersec;
            }
            set
            {
                this.m_InboundConnectionsAllowedPersec = value;
            }
        }
        
        public uint InboundConnectionsBlockedPersec
        {
            get
            {
                return this.m_InboundConnectionsBlockedPersec;
            }
            set
            {
                this.m_InboundConnectionsBlockedPersec = value;
            }
        }
        
        public uint InboundPacketsDiscardedPersec
        {
            get
            {
                return this.m_InboundPacketsDiscardedPersec;
            }
            set
            {
                this.m_InboundPacketsDiscardedPersec = value;
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
        
        public uint OutboundConnections
        {
            get
            {
                return this.m_OutboundConnections;
            }
            set
            {
                this.m_OutboundConnections = value;
            }
        }
        
        public uint OutboundConnectionsAllowedPersec
        {
            get
            {
                return this.m_OutboundConnectionsAllowedPersec;
            }
            set
            {
                this.m_OutboundConnectionsAllowedPersec = value;
            }
        }
        
        public uint OutboundConnectionsBlockedPersec
        {
            get
            {
                return this.m_OutboundConnectionsBlockedPersec;
            }
            set
            {
                this.m_OutboundConnectionsBlockedPersec = value;
            }
        }
        
        public uint OutboundPacketsDiscardedPersec
        {
            get
            {
                return this.m_OutboundPacketsDiscardedPersec;
            }
            set
            {
                this.m_OutboundPacketsDiscardedPersec = value;
            }
        }
        
        public uint PacketsDiscardedPersec
        {
            get
            {
                return this.m_PacketsDiscardedPersec;
            }
            set
            {
                this.m_PacketsDiscardedPersec = value;
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
