using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfFormattedData_Tcpip_ICMP : WMIBase
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
        
        private uint m_ReceivedAddressMask;
        
        private uint m_ReceivedAddressMaskReply;
        
        private uint m_ReceivedDestUnreachable;
        
        private uint m_ReceivedEchoPersec;
        
        private uint m_ReceivedEchoReplyPersec;
        
        private uint m_ReceivedParameterProblem;
        
        private uint m_ReceivedRedirectPersec;
        
        private uint m_ReceivedSourceQuench;
        
        private uint m_ReceivedTimeExceeded;
        
        private uint m_ReceivedTimestampPersec;
        
        private uint m_ReceivedTimestampReplyPersec;
        
        private uint m_SentAddressMask;
        
        private uint m_SentAddressMaskReply;
        
        private uint m_SentDestinationUnreachable;
        
        private uint m_SentEchoPersec;
        
        private uint m_SentEchoReplyPersec;
        
        private uint m_SentParameterProblem;
        
        private uint m_SentRedirectPersec;
        
        private uint m_SentSourceQuench;
        
        private uint m_SentTimeExceeded;
        
        private uint m_SentTimestampPersec;
        
        private uint m_SentTimestampReplyPersec;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfFormattedData_Tcpip_ICMP()
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
        
        public uint ReceivedAddressMask
        {
            get
            {
                return this.m_ReceivedAddressMask;
            }
            set
            {
                this.m_ReceivedAddressMask = value;
            }
        }
        
        public uint ReceivedAddressMaskReply
        {
            get
            {
                return this.m_ReceivedAddressMaskReply;
            }
            set
            {
                this.m_ReceivedAddressMaskReply = value;
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
        
        public uint ReceivedSourceQuench
        {
            get
            {
                return this.m_ReceivedSourceQuench;
            }
            set
            {
                this.m_ReceivedSourceQuench = value;
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
        
        public uint ReceivedTimestampPersec
        {
            get
            {
                return this.m_ReceivedTimestampPersec;
            }
            set
            {
                this.m_ReceivedTimestampPersec = value;
            }
        }
        
        public uint ReceivedTimestampReplyPersec
        {
            get
            {
                return this.m_ReceivedTimestampReplyPersec;
            }
            set
            {
                this.m_ReceivedTimestampReplyPersec = value;
            }
        }
        
        public uint SentAddressMask
        {
            get
            {
                return this.m_SentAddressMask;
            }
            set
            {
                this.m_SentAddressMask = value;
            }
        }
        
        public uint SentAddressMaskReply
        {
            get
            {
                return this.m_SentAddressMaskReply;
            }
            set
            {
                this.m_SentAddressMaskReply = value;
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
        
        public uint SentSourceQuench
        {
            get
            {
                return this.m_SentSourceQuench;
            }
            set
            {
                this.m_SentSourceQuench = value;
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
        
        public uint SentTimestampPersec
        {
            get
            {
                return this.m_SentTimestampPersec;
            }
            set
            {
                this.m_SentTimestampPersec = value;
            }
        }
        
        public uint SentTimestampReplyPersec
        {
            get
            {
                return this.m_SentTimestampReplyPersec;
            }
            set
            {
                this.m_SentTimestampReplyPersec = value;
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
