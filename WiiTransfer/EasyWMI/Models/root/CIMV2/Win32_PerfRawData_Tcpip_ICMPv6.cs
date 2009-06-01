using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_Tcpip_ICMPv6 : WMIBase
    {
        
        private string m_Caption;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_MessagesOutboundErrors;
        
        private uint m_MessagesPersec;
        
        private uint m_MessagesReceivedErrors;
        
        private uint m_MessagesReceivedPersec;
        
        private uint m_MessagesSentPersec;
        
        private string m_Name;
        
        private uint m_ReceivedDestUnreachable;
        
        private uint m_ReceivedEchoPersec;
        
        private uint m_ReceivedEchoReplyPersec;
        
        private uint m_ReceivedMembershipQuery;
        
        private uint m_ReceivedMembershipReduction;
        
        private uint m_ReceivedMembershipReport;
        
        private uint m_ReceivedNeighborAdvert;
        
        private uint m_ReceivedNeighborSolicit;
        
        private uint m_ReceivedPacketTooBig;
        
        private uint m_ReceivedParameterProblem;
        
        private uint m_ReceivedRedirectPersec;
        
        private uint m_ReceivedRouterAdvert;
        
        private uint m_ReceivedRouterSolicit;
        
        private uint m_ReceivedTimeExceeded;
        
        private uint m_SentDestinationUnreachable;
        
        private uint m_SentEchoPersec;
        
        private uint m_SentEchoReplyPersec;
        
        private uint m_SentMembershipQuery;
        
        private uint m_SentMembershipReduction;
        
        private uint m_SentMembershipReport;
        
        private uint m_SentNeighborAdvert;
        
        private uint m_SentNeighborSolicit;
        
        private uint m_SentPacketTooBig;
        
        private uint m_SentParameterProblem;
        
        private uint m_SentRedirectPersec;
        
        private uint m_SentRouterAdvert;
        
        private uint m_SentRouterSolicit;
        
        private uint m_SentTimeExceeded;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_Tcpip_ICMPv6()
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
        
        public uint MessagesOutboundErrors
        {
            get
            {
                return this.m_MessagesOutboundErrors;
            }
            set
            {
                this.m_MessagesOutboundErrors = value;
            }
        }
        
        public uint MessagesPersec
        {
            get
            {
                return this.m_MessagesPersec;
            }
            set
            {
                this.m_MessagesPersec = value;
            }
        }
        
        public uint MessagesReceivedErrors
        {
            get
            {
                return this.m_MessagesReceivedErrors;
            }
            set
            {
                this.m_MessagesReceivedErrors = value;
            }
        }
        
        public uint MessagesReceivedPersec
        {
            get
            {
                return this.m_MessagesReceivedPersec;
            }
            set
            {
                this.m_MessagesReceivedPersec = value;
            }
        }
        
        public uint MessagesSentPersec
        {
            get
            {
                return this.m_MessagesSentPersec;
            }
            set
            {
                this.m_MessagesSentPersec = value;
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
        
        public uint ReceivedDestUnreachable
        {
            get
            {
                return this.m_ReceivedDestUnreachable;
            }
            set
            {
                this.m_ReceivedDestUnreachable = value;
            }
        }
        
        public uint ReceivedEchoPersec
        {
            get
            {
                return this.m_ReceivedEchoPersec;
            }
            set
            {
                this.m_ReceivedEchoPersec = value;
            }
        }
        
        public uint ReceivedEchoReplyPersec
        {
            get
            {
                return this.m_ReceivedEchoReplyPersec;
            }
            set
            {
                this.m_ReceivedEchoReplyPersec = value;
            }
        }
        
        public uint ReceivedMembershipQuery
        {
            get
            {
                return this.m_ReceivedMembershipQuery;
            }
            set
            {
                this.m_ReceivedMembershipQuery = value;
            }
        }
        
        public uint ReceivedMembershipReduction
        {
            get
            {
                return this.m_ReceivedMembershipReduction;
            }
            set
            {
                this.m_ReceivedMembershipReduction = value;
            }
        }
        
        public uint ReceivedMembershipReport
        {
            get
            {
                return this.m_ReceivedMembershipReport;
            }
            set
            {
                this.m_ReceivedMembershipReport = value;
            }
        }
        
        public uint ReceivedNeighborAdvert
        {
            get
            {
                return this.m_ReceivedNeighborAdvert;
            }
            set
            {
                this.m_ReceivedNeighborAdvert = value;
            }
        }
        
        public uint ReceivedNeighborSolicit
        {
            get
            {
                return this.m_ReceivedNeighborSolicit;
            }
            set
            {
                this.m_ReceivedNeighborSolicit = value;
            }
        }
        
        public uint ReceivedPacketTooBig
        {
            get
            {
                return this.m_ReceivedPacketTooBig;
            }
            set
            {
                this.m_ReceivedPacketTooBig = value;
            }
        }
        
        public uint ReceivedParameterProblem
        {
            get
            {
                return this.m_ReceivedParameterProblem;
            }
            set
            {
                this.m_ReceivedParameterProblem = value;
            }
        }
        
        public uint ReceivedRedirectPersec
        {
            get
            {
                return this.m_ReceivedRedirectPersec;
            }
            set
            {
                this.m_ReceivedRedirectPersec = value;
            }
        }
        
        public uint ReceivedRouterAdvert
        {
            get
            {
                return this.m_ReceivedRouterAdvert;
            }
            set
            {
                this.m_ReceivedRouterAdvert = value;
            }
        }
        
        public uint ReceivedRouterSolicit
        {
            get
            {
                return this.m_ReceivedRouterSolicit;
            }
            set
            {
                this.m_ReceivedRouterSolicit = value;
            }
        }
        
        public uint ReceivedTimeExceeded
        {
            get
            {
                return this.m_ReceivedTimeExceeded;
            }
            set
            {
                this.m_ReceivedTimeExceeded = value;
            }
        }
        
        public uint SentDestinationUnreachable
        {
            get
            {
                return this.m_SentDestinationUnreachable;
            }
            set
            {
                this.m_SentDestinationUnreachable = value;
            }
        }
        
        public uint SentEchoPersec
        {
            get
            {
                return this.m_SentEchoPersec;
            }
            set
            {
                this.m_SentEchoPersec = value;
            }
        }
        
        public uint SentEchoReplyPersec
        {
            get
            {
                return this.m_SentEchoReplyPersec;
            }
            set
            {
                this.m_SentEchoReplyPersec = value;
            }
        }
        
        public uint SentMembershipQuery
        {
            get
            {
                return this.m_SentMembershipQuery;
            }
            set
            {
                this.m_SentMembershipQuery = value;
            }
        }
        
        public uint SentMembershipReduction
        {
            get
            {
                return this.m_SentMembershipReduction;
            }
            set
            {
                this.m_SentMembershipReduction = value;
            }
        }
        
        public uint SentMembershipReport
        {
            get
            {
                return this.m_SentMembershipReport;
            }
            set
            {
                this.m_SentMembershipReport = value;
            }
        }
        
        public uint SentNeighborAdvert
        {
            get
            {
                return this.m_SentNeighborAdvert;
            }
            set
            {
                this.m_SentNeighborAdvert = value;
            }
        }
        
        public uint SentNeighborSolicit
        {
            get
            {
                return this.m_SentNeighborSolicit;
            }
            set
            {
                this.m_SentNeighborSolicit = value;
            }
        }
        
        public uint SentPacketTooBig
        {
            get
            {
                return this.m_SentPacketTooBig;
            }
            set
            {
                this.m_SentPacketTooBig = value;
            }
        }
        
        public uint SentParameterProblem
        {
            get
            {
                return this.m_SentParameterProblem;
            }
            set
            {
                this.m_SentParameterProblem = value;
            }
        }
        
        public uint SentRedirectPersec
        {
            get
            {
                return this.m_SentRedirectPersec;
            }
            set
            {
                this.m_SentRedirectPersec = value;
            }
        }
        
        public uint SentRouterAdvert
        {
            get
            {
                return this.m_SentRouterAdvert;
            }
            set
            {
                this.m_SentRouterAdvert = value;
            }
        }
        
        public uint SentRouterSolicit
        {
            get
            {
                return this.m_SentRouterSolicit;
            }
            set
            {
                this.m_SentRouterSolicit = value;
            }
        }
        
        public uint SentTimeExceeded
        {
            get
            {
                return this.m_SentTimeExceeded;
            }
            set
            {
                this.m_SentTimeExceeded = value;
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
